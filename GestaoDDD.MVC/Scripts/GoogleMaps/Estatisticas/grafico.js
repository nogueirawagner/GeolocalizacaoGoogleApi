// Use o evento 'DOMContentLoaded' para aguardar o carregamento completo do documento
document.addEventListener("DOMContentLoaded", function () {
    google.charts.load("current", { packages: ["corechart"] });
    google.charts.setOnLoadCallback(drawChart);
    function drawChart() {

        /*Metropolitana */
        var data_metro = google.visualization.arrayToDataTable([
            ['Task', 'Hours per Day'],
            ['Crimes Violentos Letais Intencionais', 28],
            ['Crimes Contra o Patrimônio', 6674],
            ['Outros Crimes', 1089],
            ['Produtividade Policial', 1961]
        ]);

        var options_metro = {
            title: 'BALANÇO CRIMINAL \nCOMPARATIVO MENSAL 2022 - POR NATUREZA',
            is3D: true,
        };

        /* Sul */
        var data_sul = google.visualization.arrayToDataTable([
            ['Task', 'Hours per Day'],
            ['Crimes Violentos Letais Intencionais', 63],
            ['Crimes Contra o Patrimônio', 4471],
            ['Outros Crimes', 551],
            ['Produtividade Policial', 1840]
        ]);

        var options_sul = {
            title: 'BALANÇO CRIMINAL \nCOMPARATIVO MENSAL 2022 - POR NATUREZA',
            is3D: true,
        };

        /* Leste */
        var data_leste = google.visualization.arrayToDataTable([
            ['Task', 'Hours per Day'],
            ['Crimes Violentos Letais Intencionais', 85],
            ['Crimes Contra o Patrimônio', 3977],
            ['Outros Crimes', 733],
            ['Produtividade Policial', 2166]
        ]);

        var options_leste = {
            title: 'BALANÇO CRIMINAL \nCOMPARATIVO MENSAL 2022 - POR NATUREZA',
            is3D: true,
        };

        /* Oeste */
        var data_oeste = google.visualization.arrayToDataTable([
            ['Task', 'Hours per Day'],
            ['Crimes Violentos Letais Intencionais', 109],
            ['Crimes Contra o Patrimônio', 12442],
            ['Outros Crimes', 1484],
            ['Produtividade Policial', 4710]
        ]);

        var options_oeste = {
            title: 'BALANÇO CRIMINAL \nCOMPARATIVO MENSAL 2022 - POR NATUREZA',
            is3D: true,
        };

        /* setando dados */
        var chartNorte = new google.visualization.PieChart(document.getElementById('piechart_norte'));
        var chartSul = new google.visualization.PieChart(document.getElementById('piechart_sul'));
        var chartLeste = new google.visualization.PieChart(document.getElementById('piechart_leste'));
        var chartOeste = new google.visualization.PieChart(document.getElementById('piechart_oeste'));

        chartNorte.draw(data_metro, options_metro);
        chartSul.draw(data_sul, options_sul);
        chartLeste.draw(data_leste, options_leste);
        chartOeste.draw(data_oeste, options_oeste);
    }
});
