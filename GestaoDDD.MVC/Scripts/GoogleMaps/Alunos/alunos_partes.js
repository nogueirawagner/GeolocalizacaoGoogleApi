var geocoder;
var map;
var marker;

function initialize() {

    $.ajax({
        type: 'POST',
        url: '/Aluno/BuscaAlunosFiltro?pFiltro=Ampla',
        dataType: 'html',
        cache: false,
        async: true,
        success: function (data) { $('#retornoPesquisa').html(data); }
    });
}


$(document).ready(function () {

    initialize();

    var select = document.getElementById("concorrencias");

    select.addEventListener("change", function () {
        var selectedValue = select.value;

        // Verifica se alguma opção foi selecionada
        if (selectedValue !== "") {
            // Aqui você pode chamar o serviço desejado com base na opção selecionada
            BuscarAlunos(selectedValue);
        }
    });


    function BuscarAlunos() {
        var filtro = $("#concorrencias option:selected").val();
        $.ajax({
            type: 'POST',
            url: '/Aluno/BuscaAlunosFiltro?pFiltro=' + filtro,
            dataType: 'html',
            cache: false,
            async: true,
            success: function (data) { $('#retornoPesquisa').html(data); }
        });
    };
});

