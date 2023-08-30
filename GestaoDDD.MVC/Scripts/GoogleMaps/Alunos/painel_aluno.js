function SalvarNotaCFP(alunoId, notaCfp) {
    var nota = parseFloat(notaCfp.replace(',', '.'));
    var notaDividida = (nota / 2);
    //if (parseFloat(price) > 100)

    fetch('/Aluno/AtualizarNotaCFP?pAlunoId=' + alunoId + '&pNota=' + notaDividida, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        cache: 'no-cache',
    })
        .then(response => response.text())
        .then(data => {
            var notaFinal = document.getElementById("vbNotaFinal").value;
            var notaFinal = parseFloat(notaFinal.replace(',', '.'));
            var notaAtualizada = nota + notaDividida;
            notaAtualizada = parseFloat(notaAtualizada.toFixed(4)).toFixed(2).replace('.', ',');

            document.getElementById('nota-etapa-2').value = nota;
            document.getElementById('nota-atualizada').value = notaAtualizada;
        });
}

function inicializarNotas() {
    var notaEtapa1 = document.getElementById("vbNotaEtapa1").value;
    document.getElementById('nota-etapa-1').value = notaEtapa1;

    var notaEtapa2 = document.getElementById("vbNotaEtapa2").value;
    document.getElementById('nota-etapa-2').value = notaEtapa2;

    var notaFinal = document.getElementById("vbNotaFinal").value;
    document.getElementById('nota-atualizada').value = notaFinal;
}


$(document).ready(function () {
    var alunoId = document.getElementById("vbId").value;
    inicializarNotas();

    document.getElementById('botao-cfp').addEventListener('click', function () {
        var notaCfp = document.getElementById('nota-etapa-2').value;
        if (notaCfp.length > 3)
            SalvarNotaCFP(alunoId, notaCfp);
        else
            alert("Sua nota deve estar no formato 80,40 ou 80,00. Não precisa digitar a vírgula, apenas coloque 8000 que a vírgula entra sozinha.");

        var nota = parseFloat(notaCfp.replace(',', '.'));

        if (nota <= 50)
            alert("Não coloque a nota dividida! Se vc tirou 80,00 na prova, coloque 80,00 e não 40.");

    });

    var input = document.getElementById('nota-etapa-2');

    input.addEventListener('input', function (e) {
        var value = e.target.value;
        if (value.length > 3) {
            var formattedValue = formatNumber(value);
            e.target.value = formattedValue;
        }
    });

    function formatNumber(value) {
        // Remove tudo que não for dígito
        var numericValue = value.replace(/\D/g, '');

        // Divide o valor em duas partes: parte inteira e parte decimal
        var integerPart = numericValue.slice(0, -2);
        var decimalPart = numericValue.slice(-2);

        // Adiciona a vírgula
        var formattedValue = integerPart + ',' + decimalPart;

        return formattedValue;
    }
});
