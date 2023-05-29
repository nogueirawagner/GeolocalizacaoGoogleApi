function initialize() {
    fetch('/Aluno/BuscaDptosPreferenciaAluno', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        cache: 'no-cache',
    })
    .then(response => response.text())
    .then(data => {
        document.getElementById('retornoDptos').innerHTML = data;
    });
}

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
