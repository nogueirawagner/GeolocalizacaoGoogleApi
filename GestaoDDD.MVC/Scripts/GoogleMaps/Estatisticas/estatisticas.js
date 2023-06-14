$(document).ready(function () {

    });

    function PegarEstatisticasDF() {
        var filtro = $("#concorrencias option:selected").val();

        fetch('/Estatisticas/EstatisticasDF', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            cache: 'no-cache',
        })
            .then(response => response.text())
            .then(data => {
                document.getElementById('retornoEstatistica').innerHTML = data;

                const script = document.createElement('script');
                script.src = '/Scripts/GoogleMaps/Estatisticas/grafico-delegacias.js';
                document.body.appendChild(script);

                const script_df = document.createElement('script');
                script_df.src = '/Scripts/GoogleMaps/Estatisticas/grafico-df.js';
                document.body.appendChild(script_df);

                const script_api = document.createElement('script');
                script_api.src = 'https://www.gstatic.com/charts/loader.js';
                document.body.appendChild(script_api);
            })
            .catch(error => {
                // Se houver algum erro na requisição, ele será capturado aqui
                console.error('Erro:', error);
            });
    }

    function PegarEstatisticasDelegacias() {
        var filtro = $("#concorrencias option:selected").val();

        fetch('/Estatisticas/EstatisticasDeptos', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            cache: 'no-cache',
        })
            .then(response => response.text())
            .then(data => {

                document.getElementById('retornoEstatistica').innerHTML = data;

                const script = document.createElement('script');
                script.src = '/Scripts/GoogleMaps/Estatisticas/grafico-delegacias.js';
                document.body.appendChild(script);

                const script_df = document.createElement('script');
                script_df.src = '/Scripts/GoogleMaps/Estatisticas/grafico-df.js';
                document.body.appendChild(script_df);

                const script_api = document.createElement('script');
                script_api.src = 'https://www.gstatic.com/charts/loader.js';
                document.body.appendChild(script_api);

            })
            .catch(error => {
                // Se houver algum erro na requisição, ele será capturado aqui
                console.error('Erro:', error);
            });
    }


});