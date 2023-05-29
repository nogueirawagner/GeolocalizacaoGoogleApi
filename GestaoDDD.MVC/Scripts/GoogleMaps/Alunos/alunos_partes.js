$(document).ready(function () {
    var select = document.getElementById("concorrencias");

    select.addEventListener("change", function () {
        var selectedValue = select.value;

        // Verifica se alguma opção foi selecionada
        if (selectedValue !== "") {
            // Aqui você pode chamar o serviço desejado com base na opção selecionada
            BuscarAlunosFetch(selectedValue);
        }
    });

    function BuscarAlunosFetch() {
        var filtro = $("#concorrencias option:selected").val();

        fetch('/Aluno/BuscaAlunosFiltro?pFiltro=' + filtro, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            cache: 'no-cache',
        })
            .then(response => response.text())
            .then(data => {
                document.getElementById('retornoPesquisa').innerHTML = data;



                var totalRows = $("#mytable tr").length - 1;
                $("#totalRows").text("Total de linhas: " + totalRows);

                $("#searchInput").on("keyup", function () {
                    var value = $(this).val().toLowerCase().normalize('NFD').replace(/[\u0300-\u036f]/g, "");
                    $("#mytable tr:not(:first)").filter(function () {
                        var rowValue = $(this).text().toLowerCase().normalize('NFD').replace(/[\u0300-\u036f]/g, "");
                        $(this).toggle(rowValue.indexOf(value) > -1);
                    });
                    var filteredRows = $("#mytable tr:visible").length - 1;
                    $("#totalRows").text("Linhas encontradas: " + filteredRows);
                });


            })
            .catch(error => {
                // Se houver algum erro na requisição, ele será capturado aqui
                console.error('Erro:', error);
            });
    }
});

