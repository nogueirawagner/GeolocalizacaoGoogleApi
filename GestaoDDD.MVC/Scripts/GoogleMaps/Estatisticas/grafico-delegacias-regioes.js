// Use o evento 'DOMContentLoaded' para aguardar o carregamento completo do documento
document.addEventListener("DOMContentLoaded", function () {
    google.charts.load('current', { 'packages': ['bar'] });
    google.charts.setOnLoadCallback(draw_servico);

    function draw_servico() {
        fetch('/Estatisticas/PegarPreferenciaAlunosPorRegioes', {
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
                dataTable.addColumn('string', 'Regiões Integradas de Segurança Pública - RISP');
                dataTable.addColumn('number', 'Qtd pessoas');

                jsonData.forEach(function (item) {
                    dataTable.addRow([item.Nome, item.QtdPessoas]);
                });

                var options = {
                    chart: {
                        title: '',
                        subtitle: '',
                        
                    }
                };

                var chart = new google.charts.Bar(document.getElementById('columnchart_material_regioes'));
                chart.draw(dataTable, google.charts.Bar.convertOptions(options));

            })
            .catch(error => {
                // Se houver algum erro na requisição, ele será capturado aqui
                console.error('Erro:', error);
            });
    }


});
