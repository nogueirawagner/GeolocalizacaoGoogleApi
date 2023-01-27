var geocoder;
var map;
var marker;

function initialize() {

    var locations = [
        ['Bondi Beach', 'a', -33.890542, 151.274856, 4],
        ['Coogee Beach', 'a', -33.923036, 151.259052, 5],
        ['Cronulla Beach', 'a', -34.028249, 151.157507, 3],
        ['Manly Beach', 'a', -33.80010128657071, 151.28747820854187, 2],
        ['Maroubra Beach', 'a', -33.950198, 151.259302, 1]
    ];

    // Chama o serviço para pegar os dados
    fetch('/Candidato/BuscaCandidatosJson')
        .then(response => response.json())
        .then(data => {
            // Atualiza a variável locations com os dados retornados pelo serviço
            locations = data;

            // Continua com o restante do código
            var map = new google.maps.Map(document.getElementById('mapa'), {
                zoom: 12,
                center: new google.maps.LatLng(locations[0].Latitude, locations[0].Longitude),
                mapTypeId: google.maps.MapTypeId.ROADMAP
            });

            var infowindow = new google.maps.InfoWindow();

            var marker, i;

            for (i = 0; i < locations.length; i++) {
                marker = new google.maps.Marker({
                    position: new google.maps.LatLng(locations[i].Latitude, locations[i].Longitude,),
                    map: map,
                    title: locations[i].Nome
                });

                google.maps.event.addListener(marker, 'click', (function (marker, i) {
                    return function () {
                        infowindow.setContent('Telefone: ' + locations[i].Telefone + '. '+ ' Qtd Vagas: ' + locations[i].QtdVagas + '. ' + ' Veículo: ' + locations[i].TipoVeiculo + '. ' + ' Turma: ' + locations[i].Turma );
                        infowindow.open(map, marker);
                    }
                })(marker, i));
            }
        });
}


/*
function initialize() {

    var locations = [
        ['Bondi Beach', 'a', -33.890542, 151.274856, 4],
        ['Coogee Beach', 'a', -33.923036, 151.259052, 5],
        ['Cronulla Beach', 'a', -34.028249, 151.157507, 3],
        ['Manly Beach', 'a', -33.80010128657071, 151.28747820854187, 2],
        ['Maroubra Beach', 'a', -33.950198, 151.259302, 1]
    ];

    var map = new google.maps.Map(document.getElementById('mapa'), {
        zoom: 10,
        center: new google.maps.LatLng(-33.92, 151.25),
        mapTypeId: google.maps.MapTypeId.ROADMAP
    });

    var infowindow = new google.maps.InfoWindow();

    var marker, i;

    for (i = 0; i < locations.length; i++) {
        marker = new google.maps.Marker({
            position: new google.maps.LatLng(locations[i][2], locations[i][3]),
            map: map,
            title: "Teste"
        });

        google.maps.event.addListener(marker, 'click', (function (marker, i) {
            return function () {
                infowindow.setContent(locations[i][0]);
                infowindow.open(map, marker);
            }
        })(marker, i));
    }
}
*/

$(document).ready(function () {

    initialize();

    google.maps.event.addListener(marker, 'drag', function () {
        geocoder.geocode({ 'latLng': marker.getPosition() }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                if (results[0]) {
                    $('#endereco').val(results[0].formatted_address);
                    $('#latitude').val(marker.getPosition().lat());
                    $('#longitude').val(marker.getPosition().lng());
                }
            }
        });
    });

});