$(document).ready(function () {
    var concorrenciasValue = document.getElementById("concorrencias");
    var cargoValue = document.getElementById("cargo-select");

    cargoValue.addEventListener("change", function () {
        var concorrencia = concorrenciasValue.value;
        var cargo = cargoValue.value;

        // Verifica se alguma opção foi selecionada
        if (concorrencia !== "" || cargo !== "") {
            // Aqui você pode chamar o serviço desejado com base na opção selecionada
            BuscarAlunosFetch();
        }
    });

    concorrenciasValue.addEventListener("change", function () {
        var concorrencia = concorrenciasValue.value;
        var cargo = cargoValue.value;

        // Verifica se alguma opção foi selecionada
        if (concorrencia !== "" || cargo !== "") {
            // Aqui você pode chamar o serviço desejado com base na opção selecionada
            BuscarAlunosFetch();
        }
    });


});

