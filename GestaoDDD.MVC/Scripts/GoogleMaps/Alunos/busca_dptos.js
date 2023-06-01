function atualizarPainelPreferencias(alunoId) {
    fetch('/Aluno/BuscaDptosPreferenciaAluno?pAlunoID=' + alunoId, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        cache: 'no-cache',
    })
        .then(response => response.text())
        .then(data => {
            document.getElementById('retornoPreferencias').innerHTML = data;

            contarLinhas();
            linhaLink();

            var removerButton = document.querySelectorAll(".excluir-dpto");
            removerButton.forEach(function (button) {
                button.addEventListener("click", function () {
                    var dpId = button.getAttribute("data-value");
                    ExcluirDptoPreferencia(alunoId, dpId);
                });
            });
        });
}

function carregadorDepartamentosPolicia(alunoId) {
    fetch('/Aluno/BuscaDptosPolicia', {
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

    var escolherButton = document.querySelectorAll(".escolher-dpto");
    escolherButton.forEach(function (button) {
        button.addEventListener("click", function () {
            var dpId = button.getAttribute("data-value");
            EscolherLotacao(dpId);
        });
    });

    function EscolherLotacao(pId) {
        fetch('/Aluno/EscolherLotacao?pLotacaoID=' + pId + '&pAlunoID=' + vbId)
            .then(function (response) {
                atualizarPainelPreferencias(vbId);
            });
    }
});
