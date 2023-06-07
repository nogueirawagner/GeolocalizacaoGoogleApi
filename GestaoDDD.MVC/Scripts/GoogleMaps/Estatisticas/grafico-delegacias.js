// Use o evento 'DOMContentLoaded' para aguardar o carregamento completo do documento
function carregarDelegacias() {
    fetch('/Estatisticas/EstatisticasDF', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        cache: 'no-cache',
    })
        .then(response => response.text())
        .then(data => {

            var dataTableArray = [['Delegacias', 'Qtd Vagas', 'Qtd Pessoas Escolheu']];
            data.forEach(function (item) {
                var linha = [item.Nome, item.QtdVagas, item.QtdPessoasEscolheu];
                dataTableArray.push(linha);
            });

            var options = {
                chart: {
                    title: 'Delegacias mais procuradas durante o CFP.',
                    subtitle: 'Qtd de vagas (Vagas) x Qtd de pessoas (Pessoas) que desejam trabalhar nessa unidade',
                }
            };

            var chart = new google.charts.Bar(document.getElementById('columnchart_material'));
            chart.draw(data, google.charts.Bar.convertOptions(options));

        })
        .catch(error => {
            // Se houver algum erro na requisição, ele será capturado aqui
            console.error('Erro:', error);
        });
}

document.addEventListener("DOMContentLoaded", function () {
    google.charts.load('current', { 'packages': ['bar'] });
    google.charts.setOnLoadCallback(draw_servico);

    function draw_servico() {
        fetch('/Estatisticas/PegarDelegaciasPessoas', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            cache: 'no-cache',
        })
            .then(response => response.text())
            .then(data => {

                var jsonData = JSON.parse(data);

                var dataTable = new google.visualization.DataTable();
                dataTable.addColumn('string', 'Delegacias');
                dataTable.addColumn('number', 'Qtd Vagas');
                dataTable.addColumn('number', 'Qtd Pessoas Escolheu');

                jsonData.forEach(function (item) {
                    dataTable.addRow([item.Nome, item.Vagas, item.Pessoas]);
                });

                var options = {
                    chart: {
                        title: 'Delegacias mais procuradas durante o CFP.',
                        subtitle: 'Qtd de vagas (Vagas) x Qtd de pessoas (Pessoas) que desejam trabalhar nessa unidade',
                    }
                };

                var chart = new google.charts.Bar(document.getElementById('columnchart_material'));
                chart.draw(dataTable, google.charts.Bar.convertOptions(options));

            })
            .catch(error => {
                // Se houver algum erro na requisição, ele será capturado aqui
                console.error('Erro:', error);
            });
    }


});
