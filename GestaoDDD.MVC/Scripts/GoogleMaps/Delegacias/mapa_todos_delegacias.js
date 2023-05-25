var geocoder;
var map;
var marker;

function initialize() {

    var vbLat = document.getElementById("vbLat").value;
    var vbLong = document.getElementById("vbLong").value;

    // Chama o serviço para pegar os dados
    fetch('/DepartamentoPolicia/BuscaDelegaciasJson?Latitude=' + vbLat + '&Longitude=' + vbLong)
        .then(response => response.json())
        .then(data => {
            // Atualiza a variável locations com os dados retornados pelo serviço
            var locations = data;

            var directionsRenderer = new google.maps.DirectionsRenderer();
            var tempoDuracao = "";
            var localCurso = "";

            // Continua com o restante do código
            var map = new google.maps.Map(document.getElementById('mapa'), {
                zoom: 10,
                center: new google.maps.LatLng(locations[0].Latitude, locations[0].Longitude),
                mapTypeId: google.maps.MapTypeId.ROADMAP
            });

            geocoder = new google.maps.Geocoder();

            var infowindow = new google.maps.InfoWindow();

            var marker, i;

            if (vbLat && vbLong) {
                const image =
                    "https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png";

                const endereco = {
                    url: "/Images/endereco.png", // url
                    scaledSize: new google.maps.Size(30, 30), // scaled size
                    origin: new google.maps.Point(0, 0), // origin
                    anchor: new google.maps.Point(0, 0) // anchor
                };

                // Local do cara
                marker = new google.maps.Marker({
                    position: new google.maps.LatLng(vbLat, vbLong),
                    map: map,
                    title: locations[0].DistanciaEscolas,
                    icon: endereco
                });

                google.maps.event.addListener(marker, 'click', (function (marker) {
                    return function () {
                        infowindow.setContent("Meu local está a " + tempoDuracao + " " + localCurso);
                        infowindow.open(map, marker);
                    }
                })(marker));
            }

            const postoVermelho = {
                url: "/Images/posto-vermelho.png", // url
                scaledSize: new google.maps.Size(30, 30), // scaled size
                origin: new google.maps.Point(0, 0), // origin
                anchor: new google.maps.Point(0, 0) // anchor
            };

            for (i = 0; i < locations.length; i++) {

                marker = new google.maps.Marker({
                    position: new google.maps.LatLng(locations[i].Latitude, locations[i].Longitude),
                    map: map,
                    title: locations[i].EhSede ? "CEFLAG: " + locations[i].Nome : locations[i].Nome,
                    icon: postoVermelho
                });

                google.maps.event.addListener(marker, 'click', (function (marker, i) {
                    return function () {
                        infowindow.setContent('Endereço: ' + locations[i].Endereco);
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
                    var originPoint = new google.maps.LatLng(latitude, longitude);

                    // Chama o serviço para pegar os dados
                    fetch('/DepartamentoPolicia/BuscaDelegaciasJson?Latitude=' + latitude + '&Longitude=' + longitude)
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

                            const endereco = {
                                url: "/Images/endereco.png", // url
                                scaledSize: new google.maps.Size(40, 40), // scaled size
                                origin: new google.maps.Point(0, 0), // origin
                                anchor: new google.maps.Point(0, 0) // anchor
                            };

                            // Local do cara
                            marker = new google.maps.Marker({
                                position: originPoint,
                                map: map,
                                title: "Estou aqui",
                                icon: endereco
                            });

                            const postoVermelho = {
                                url: "/Images/posto-vermelho.png", // url
                                scaledSize: new google.maps.Size(50, 50), // scaled size
                                origin: new google.maps.Point(0, 0), // origin
                                anchor: new google.maps.Point(0, 0) // anchor
                            };

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
                                    title: locations[i].DistanciaColega,
                                    icon: postoVermelho
                                });

                                google.maps.event.addListener(marker, 'click', (function (marker, i) {
                                    return function () {
                                        infowindow.setContent('Nome: ' + locations[i].Nome);
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