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
});
