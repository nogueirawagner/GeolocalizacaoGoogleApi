// Use o evento 'DOMContentLoaded' para aguardar o carregamento completo do documento
document.addEventListener("DOMContentLoaded", function () {
    google.charts.load('current', { 'packages': ['bar'] });
    google.charts.setOnLoadCallback(draw_servico);

    function draw_servico() {
        fetch('/Estatisticas/PegarPreferenciaAlunosPorBairros', {
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
                dataTable.addColumn('string', 'Escolha de delegacias por regiões adm e cargos');
                dataTable.addColumn('number', 'Qtd agentes');
                dataTable.addColumn('number', 'Qtd escrivães');

                jsonData.forEach(function (item) {
                    dataTable.addRow([item.Bairro, item.QtdAgente, item.QtdEscrivao]);
                });

                var options = {
                    chart: {
                        title: '',
                        subtitle: '',
                        
                    }
                };

                var chart = new google.charts.Bar(document.getElementById('columnchart_material_bairros'));
                chart.draw(dataTable, google.charts.Bar.convertOptions(options));

            })
            .catch(error => {
                // Se houver algum erro na requisição, ele será capturado aqui
                console.error('Erro:', error);
            });
    }


});
