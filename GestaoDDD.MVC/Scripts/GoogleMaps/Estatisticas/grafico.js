// Use o evento 'DOMContentLoaded' para aguardar o carregamento completo do documento
document.addEventListener("DOMContentLoaded", function () {
    google.charts.load("current", { packages: ["corechart"] });
    google.charts.setOnLoadCallback(drawChart);

    function drawChart() {

        /*Metropolitana */
        var data_metro = google.visualization.arrayToDataTable([
            ['Task', 'Hours per Day'],
            ['C.V.L.I', 28],
            ['C.C.P', 6674],
            ['Outros Crimes', 1089],
            ['Prod. Policial', 1961]
        ]);

        /* Sul */
        var data_sul = google.visualization.arrayToDataTable([
            ['Task', 'Hours per Day'],
            ['C.V.L.I', 63],
            ['C.C.P', 4471],
            ['Outros Crimes', 551],
            ['Prod. Policial', 1840]
        ]);

        /* Leste */
        var data_leste = google.visualization.arrayToDataTable([
            ['Task', 'Hours per Day'],
            ['C.V.L.I', 85],
            ['C.C.P', 3977],
            ['Outros Crimes', 733],
            ['Prod. Policial', 2166]
        ]);

        /* Oeste */
        var data_oeste = google.visualization.arrayToDataTable([
            ['Task', 'Hours per Day'],
            ['C.V.L.I', 109],
            ['C.C.P', 12442],
            ['Outros Crimes', 1484],
            ['Prod. Policial', 4710]
        ]);

        /* Teste para graficos de linha */
        /* Sul */
        var data_sul_1 = google.visualization.arrayToDataTable([
            ['Task', 'Hours per Day'],
            ['C.V.L.I', 63],
            ['C.C.P', 4471],
            ['Outros Crimes', 551],
            ['Prod. Policial', 1840]
        ]);

        var data_sul_2 = google.visualization.arrayToDataTable([
            ['Task', 'Hours per Day'],
            ['C.V.L.I', 63],
            ['C.C.P', 4471],
            ['Outros Crimes', 551],
            ['Prod. Policial', 1840]
        ]);

        /* setando dados */
        var chartNorte = new google.visualization.PieChart(document.getElementById('piechart_norte'));
        var chartSul = new google.visualization.PieChart(document.getElementById('piechart_sul'));
        var chartLeste = new google.visualization.PieChart(document.getElementById('piechart_leste'));
        var chartOeste = new google.visualization.PieChart(document.getElementById('piechart_oeste'));

        var chartSul_1 = new google.visualization.PieChart(document.getElementById('piechart_sul_1'));
        var chartSul_2 = new google.visualization.PieChart(document.getElementById('piechart_sul_2'));

        chartNorte.draw(data_metro);
        chartSul.draw(data_sul);
        chartLeste.draw(data_leste);
        chartOeste.draw(data_oeste);
        
        chartSul_1.draw(data_sul_1);
        chartSul_2.draw(data_sul_2);
    }

});
