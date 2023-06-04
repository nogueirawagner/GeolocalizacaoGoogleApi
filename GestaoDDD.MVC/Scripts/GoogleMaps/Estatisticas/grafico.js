// Use o evento 'DOMContentLoaded' para aguardar o carregamento completo do documento
document.addEventListener("DOMContentLoaded", function () {
    google.charts.load("current", { packages: ["corechart"] });
    //google.charts.load('current', { packages: ['corechart', 'bar'] });

    google.charts.setOnLoadCallback(drawChart);
    //google.charts.setOnLoadCallback(drawAxisTickColors);

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

    //function drawAxisTickColors() {
    //    var data = new google.visualization.DataTable();
    //    data.addColumn('timeofday', 'Time of Day');
    //    data.addColumn('number', 'Motivation Level');
    //    data.addColumn('number', 'Energy Level');

    //    data.addRows([
    //        [{ v: [8, 0, 0], f: '8 am' }, 1, .25],
    //        [{ v: [9, 0, 0], f: '9 am' }, 2, .5],
    //        [{ v: [10, 0, 0], f: '10 am' }, 3, 1],
    //        [{ v: [11, 0, 0], f: '11 am' }, 4, 2.25],
    //        [{ v: [12, 0, 0], f: '12 pm' }, 5, 2.25],
    //        [{ v: [13, 0, 0], f: '1 pm' }, 6, 3],
    //        [{ v: [14, 0, 0], f: '2 pm' }, 7, 4],
    //        [{ v: [15, 0, 0], f: '3 pm' }, 8, 5.25],
    //        [{ v: [16, 0, 0], f: '4 pm' }, 9, 7.5],
    //        [{ v: [17, 0, 0], f: '5 pm' }, 10, 10],
    //    ]);

    //    var options = {
    //        title: 'Motivation and Energy Level Throughout the Day',
    //        focusTarget: 'category',
    //        hAxis: {
    //            title: 'Time of Day',
    //            format: 'h:mm a',
    //            viewWindow: {
    //                min: [7, 30, 0],
    //                max: [17, 30, 0]
    //            },
    //            textStyle: {
    //                fontSize: 14,
    //                color: '#053061',
    //                bold: true,
    //                italic: false
    //            },
    //            titleTextStyle: {
    //                fontSize: 18,
    //                color: '#053061',
    //                bold: true,
    //                italic: false
    //            }
    //        },
    //        vAxis: {
    //            title: 'Rating (scale of 1-10)',
    //            textStyle: {
    //                fontSize: 18,
    //                color: '#67001f',
    //                bold: false,
    //                italic: false
    //            },
    //            titleTextStyle: {
    //                fontSize: 18,
    //                color: '#67001f',
    //                bold: true,
    //                italic: false
    //            }
    //        }
    //    };

    //    var chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));
    //    chart.draw(data, options);
    //}

});
