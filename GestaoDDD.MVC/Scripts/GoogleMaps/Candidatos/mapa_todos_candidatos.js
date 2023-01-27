var geocoder;
var map;
var marker;

function initialize() {

    // Chama o serviço para pegar os dados
    fetch('/Candidato/BuscaCandidatosJson')
        .then(response => response.json())
        .then(data => {
            // Atualiza a variável locations com os dados retornados pelo serviço
            var locations = data;

            // Continua com o restante do código
            var map = new google.maps.Map(document.getElementById('mapa'), {
                zoom: 12,
                center: new google.maps.LatLng(locations[0].Latitude, locations[0].Longitude),
                mapTypeId: google.maps.MapTypeId.ROADMAP
            });

            geocoder = new google.maps.Geocoder();

            var infowindow = new google.maps.InfoWindow();

            var marker, i;

            for (i = 0; i < locations.length; i++) {
                marker = new google.maps.Marker({
                    position: new google.maps.LatLng(locations[i].Latitude, locations[i].Longitude),
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

$(document).ready(function () {

    initialize();

    function carregarNoMapa(endereco) {
        geocoder.geocode({ 'address': endereco + ', Brasil', 'region': 'BR' }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                if (results[0]) {
                    var latitude = results[0].geometry.location.lat();
                    var longitude = results[0].geometry.location.lng();














                    // Chama o serviço para pegar os dados
                    fetch('/Candidato/BuscaCandidatosJson')
                        .then(response => response.json())
                        .then(data => {
                            // Atualiza a variável locations com os dados retornados pelo serviço
                            var locations = data;

                            // Continua com o restante do código
                            var map = new google.maps.Map(document.getElementById('mapa'), {
                                zoom: 12,
                                center: new google.maps.LatLng(locations[0].Latitude, locations[0].Longitude),
                                mapTypeId: google.maps.MapTypeId.ROADMAP
                            });

                            var infowindow = new google.maps.InfoWindow();

                            var marker, i;

                            // Local do cara
                            marker = new google.maps.Marker({
                                position: new google.maps.LatLng(latitude, longitude),
                                map: map,
                                title: "Eu estou hospedado aqui"
                            });

                            google.maps.event.addListener(marker, 'click', (function (marker) {
                                return function () {
                                    infowindow.setContent("Meu local");
                                    infowindow.open(map, marker);
                                }
                            })(marker));

                            // Locais de outras pessoas
                            for (i = 0; i < locations.length; i++) {
                                marker = new google.maps.Marker({
                                    position: new google.maps.LatLng(locations[i].Latitude, locations[i].Longitude),
                                    map: map,
                                    title: locations[i].Nome
                                });

                                google.maps.event.addListener(marker, 'click', (function (marker, i) {
                                    return function () {
                                        infowindow.setContent('Telefone: ' + locations[i].Telefone + '. ' + ' Qtd Vagas: ' + locations[i].QtdVagas + '. ' + ' Veículo: ' + locations[i].TipoVeiculo + '. ' + ' Turma: ' + locations[i].Turma);
                                        infowindow.open(map, marker);
                                    }
                                })(marker, i));
                            }
                        });
                }
            }
        })
    }

    $("#endereco").blur(function () {
        if ($(this).val() != "")
            carregarNoMapa($(this).val());
    })

    $('#endereco').keypress(function (event) {
        var keycode = (event.keyCode ? event.keyCode : event.which);
        if (keycode == '13') {
            if ($(this).val() != "")
                carregarNoMapa($(this).val());
        }
    });

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

    $("#endereco").autoComplete({
        source: function (request, response) {
            geocoder.geocode({ 'address': request.term + ', Brasil', 'region': 'Distrito Federal' }, function (results, status) {
                response($.map(results, function (item) {
                    return {
                        label: item.formatted_address,
                        value: item.formatted_address,
                        latitude: item.geometry.location.lat(),
                        longitude: item.geometry.location.lng()
                    }
                }));
            })
        },
        select: function (event, ui) {
            $("#latitude").val(ui.item.latitude);
            $("#longitude").val(ui.item.longitude);
            var location = new google.maps.LatLng(ui.item.latitude, ui.item.longitude);
            marker.setPosition(location);
            map.setCenter(location);
            map.setZoom(16);
        }
    });
});