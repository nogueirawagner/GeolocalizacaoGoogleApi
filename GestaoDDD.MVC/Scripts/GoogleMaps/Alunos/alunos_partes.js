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

    
});

