$(document).ready(function () {

    var vbId = document.getElementById("vbId").value;

    var escolher = document.getElementById("escolher");
    escolher.addEventListener("click", function () {
        var dpId = escolher.getAttribute('value');
        EscolherLotacao(dpId);
    });

    function EscolherLotacao(pId) {
        fetch('/Aluno/EscolherLotacao?pLotacaoID=' + pId + '&pAlunoID=' + vbId)
            .then(response => response.json());
    }

  

    var totalRows = $("#mytable tr").length;
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
});
