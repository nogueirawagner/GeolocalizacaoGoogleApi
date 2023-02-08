var geocoder;
var map;
var marker;

function initialize() {

    var vbLat = document.getElementById("vbLat").value;
    var vbLong = document.getElementById("vbLong").value;
    var vbT1 = document.getElementById("vbT1").value;
    var vbT2 = document.getElementById("vbT2").value;

    // Chama o serviço para pegar os dados
    fetch('/Candidato/BuscaCandidatosJson?Latitude=' + vbLat + '&Longitude=' + vbLong)
        .then(response => response.json())
        .then(data => {
            // Atualiza a variável locations com os dados retornados pelo serviço
            var locations = data;

            var directionsService = new google.maps.DirectionsService();
            var directionsRenderer = new google.maps.DirectionsRenderer();

            var cepomLat = -15.7994772;
            var cepomLong = -48.0607247;

            var espcLat = -15.8851054;
            var espcLong = -48.0626557;

            var cepomPoint = new google.maps.LatLng(cepomLat, cepomLong);
            var espcPoint = new google.maps.LatLng(espcLat, espcLong);
            var originPoint = new google.maps.LatLng(vbLat, vbLong);
            var tempoDuracao = "";
            var localCurso = "";

            // Continua com o restante do código
            var map = new google.maps.Map(document.getElementById('mapa'), {
                zoom: 11,
                center: new google.maps.LatLng(locations[0].Latitude, locations[0].Longitude),
                mapTypeId: google.maps.MapTypeId.ROADMAP
            });

            geocoder = new google.maps.Geocoder();

            var infowindow = new google.maps.InfoWindow();

            var marker, i;

            const imageCursos =
                "https://developers.google.com/maps/documentation/javascript/examples/full/images/parking_lot_maps.png";
            // Localização do CEPOM
            marker = new google.maps.Marker({
                position: new google.maps.LatLng(cepomLat, cepomLong),
                map: map,
                title: "CEPOM",
                icon: imageCursos
            });

            google.maps.event.addListener(marker, 'click', (function (marker) {
                return function () {
                    infowindow.setContent("CEPOM");
                    infowindow.open(map, marker);
                }
            })(marker));

            if (vbLat && vbLong) {
                const image =
                    "https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png";
                // Local do cara
                marker = new google.maps.Marker({
                    position: new google.maps.LatLng(vbLat, vbLong),
                    map: map,
                    title: locations[0].DistanciaEscolas,
                    icon: image
                });

                if (vbT1) {
                    localCurso = "da ESPC";
                    directionsService.route({
                        origin: new google.maps.LatLng(vbLat, vbLong),
                        destination: new google.maps.LatLng(espcLat, espcLong),
                        travelMode: google.maps.TravelMode.DRIVING
                    }, function (response, status) {
                        if (status === google.maps.DirectionsStatus.OK) {
                            tempoDuracao = response.routes[0].legs[0].duration.text;
                            directionsRenderer.setDirections(response);
                        }
                    });
                }
                if (vbT2) {
                    localCurso = "do CEPOM";
                    directionsService.route({
                        origin: new google.maps.LatLng(vbLat, vbLong),
                        destination: new google.maps.LatLng(cepomLat, cepomLong),
                        travelMode: google.maps.TravelMode.DRIVING
                    }, function (response, status) {
                        if (status === google.maps.DirectionsStatus.OK) {
                            tempoDuracao = response.routes[0].legs[0].duration.text;
                            directionsRenderer.setDirections(response);
                        }
                    });
                }

                google.maps.event.addListener(marker, 'click', (function (marker) {
                    return function () {
                        infowindow.setContent("Meu local está a " + tempoDuracao + " " + localCurso);
                        infowindow.open(map, marker);
                    }
                })(marker));

            }

            // Localização da ESPC
            marker = new google.maps.Marker({
                position: new google.maps.LatLng(espcLat, espcLong),
                map: map,
                title: "ESPC",
                icon: imageCursos
            });

            google.maps.event.addListener(marker, 'click', (function (marker) {
                return function () {
                    infowindow.setContent("ESPC");
                    infowindow.open(map, marker);
                }
            })(marker));

            for (i = 0; i < locations.length; i++) {
                marker = new google.maps.Marker({
                    position: new google.maps.LatLng(locations[i].Latitude, locations[i].Longitude),
                    map: map,
                    title: locations[i].Nome
                });

                google.maps.event.addListener(marker, 'click', (function (marker, i) {
                    return function () {
                        infowindow.setContent('Nome: ' + locations[i].Nome + ' ' + 'Telefone: ' + locations[i].Telefone);
                        infowindow.open(map, marker);
                    }
                })(marker, i));
            }
            directionsRenderer.setMap(map);
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
                   
                    var cepomLat = -15.7994772;
                    var cepomLong = -48.0607247;

                    var espcLat = -15.8851054;
                    var espcLong = -48.0626557;

                    var cepomPoint = new google.maps.LatLng(cepomLat, cepomLong);
                    var espcPoint = new google.maps.LatLng(espcLat, espcLong);
                    var originPoint = new google.maps.LatLng(latitude, longitude);

                    // Chama o serviço para pegar os dados
                    fetch('/Candidato/BuscaCandidatosJson?Latitude=' + latitude + '&Longitude=' + longitude)
                        .then(response => response.json())
                        .then(data => {
                            // Atualiza a variável locations com os dados retornados pelo serviço
                            var locations = data;

                            // Continua com o restante do código
                            var map = new google.maps.Map(document.getElementById('mapa'), {
                                zoom: 11,
                                center: new google.maps.LatLng(latitude, longitude),
                                mapTypeId: google.maps.MapTypeId.ROADMAP
                            });

                            var infowindow = new google.maps.InfoWindow();

                            var marker, i;

                            const image =
                                "https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png";
                            // Local do cara
                            marker = new google.maps.Marker({
                                position: originPoint,
                                map: map,
                                title: locations[0].DistanciaEscolas,
                                icon: image
                            });

                            google.maps.event.addListener(marker, 'click', (function (marker) {
                                return function () {
                                    infowindow.setContent("Meu local");
                                    infowindow.open(map, marker);
                                }
                            })(marker));

                            const imageCursos =
                                "https://developers.google.com/maps/documentation/javascript/examples/full/images/parking_lot_maps.png";
                            // Localização do CEPOM
                            marker = new google.maps.Marker({
                                position: cepomPoint,
                                map: map,
                                title: "CEPOM",
                                icon: imageCursos
                            });

                            google.maps.event.addListener(marker, 'click', (function (marker) {
                                return function () {
                                    infowindow.setContent("CEPOM");
                                    infowindow.open(map, marker);
                                }
                            })(marker));


                            // Localização da ESPC
                            marker = new google.maps.Marker({
                                position: espcPoint,
                                map: map,
                                title: "ESPC",
                                icon: imageCursos
                            });

                            google.maps.event.addListener(marker, 'click', (function (marker) {
                                return function () {
                                    infowindow.setContent("ESPC");
                                    infowindow.open(map, marker);
                                }
                            })(marker));

                            // Locais de outras pessoas
                            for (i = 0; i < locations.length; i++) {
                                marker = new google.maps.Marker({
                                    position: new google.maps.LatLng(locations[i].Latitude, locations[i].Longitude),
                                    map: map,
                                    title: locations[i].DistanciaColega
                                });

                                google.maps.event.addListener(marker, 'click', (function (marker, i) {
                                    return function () {
                                        infowindow.setContent('Nome: ' + locations[i].Nome + '. ' + 'Telefone: ' + locations[i].Telefone);
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