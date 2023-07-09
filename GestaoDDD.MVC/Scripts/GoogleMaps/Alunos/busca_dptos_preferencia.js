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
            // iniciar tabela 
            const parsedData = JSON.parse(data);

            const tableBody = document.getElementById('tabela-dptos-preferencia');
            tableBody.innerHTML = ""; // Limpa o conteúdo anterior da tabela

            parsedData.forEach(item => {
                const row = document.createElement('tr');

                const nomeCell = document.createElement('td');
                nomeCell.textContent = item.Nome;
                row.appendChild(nomeCell);

                const ehSedeCell = document.createElement('td');
                ehSedeCell.textContent = item.EhSede;
                row.appendChild(ehSedeCell);

                const bairroCell = document.createElement('td');
                bairroCell.textContent = item.Bairro;
                row.appendChild(bairroCell);

                //const contempladaCell = document.createElement('td');
                //contempladaCell.textContent = item.Contemplada;
                //row.appendChild(contempladaCell);

                const excluirCell = document.createElement('td');
                const excluirLink = document.createElement('a');
                excluirLink.setAttribute('data-value', item.DepartamentoId);
                excluirLink.classList.add('excluir-dpto', 'btn', 'btn-remover');
                excluirLink.innerHTML = '<span class="glyphicon glyphicon-remove"></span>';
                excluirLink.addEventListener('click', function () {
                    var dpId = excluirLink.getAttribute("data-value");
                    ExcluirDptoPreferencia(alunoId, dpId);
                });
                excluirCell.appendChild(excluirLink);
                row.appendChild(excluirCell);

                tableBody.appendChild(row);
            });

            // fim tabela
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
