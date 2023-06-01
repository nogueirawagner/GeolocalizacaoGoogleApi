function carregarPreferencia(alunoId) {
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

function ExcluirDptoPreferencia(alunoId, dptoId) {
    fetch('/Aluno/ExcluirDptoPreferencia?pDptoId=' + dptoId + '&pAlunoID=' + alunoId)
        .then(function (response) {
            atualizarPainelPreferencias(alunoId);
            contarLinhas();
            linhaLink();
        });
}

function AtualizarPainelPreferencias(alunoId) {
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
        });
}

$(document).ready(function () {

    var alunoId = document.getElementById("vbId").value;
    carregarPreferencia(alunoId);

    linhaLink();
    contarLinhas();
});
