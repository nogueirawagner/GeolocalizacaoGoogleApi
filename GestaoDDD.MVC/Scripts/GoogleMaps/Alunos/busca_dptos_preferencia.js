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


            var removerButton = document.querySelectorAll(".excluir-dpto");
            removerButton.forEach(function (button) {
                button.addEventListener("click", function () {
                    var dpId = button.getAttribute("data-value");
                    ExcluirLotacao(dpId);
                });
            });

            function ExcluirLotacao(pId) {
                console.log("passou pelo excluir: " + pId)
            }
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

    var vbId = document.getElementById("vbId").value;
    carregarPreferencia(vbId);

    var removerButton = document.querySelectorAll(".excluir-dpto");
    removerButton.forEach(function (button) {
        button.addEventListener("click", function () {
            var dpId = button.getAttribute("data-value");
            ExcluirLotacao(dpId);
        });
    });

    function ExcluirLotacao(pId) {
        console.log("passou pelo excluir: " + pId)
    }


});
