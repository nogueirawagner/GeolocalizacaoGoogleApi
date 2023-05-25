var geocoder;
var map;
var marker;

function initialize() {

}

$(document).ready(function () {

    geocoder = new google.maps.Geocoder();
    var vbLat = document.getElementById("vbLat").value;
    var vbLong = document.getElementById("vbLong").value;
    var vbID = document.getElementById("vbId").value;
    var vbEndereco = document.getElementById("vbEndereco").value;
    var vbNome = document.getElementById("vbNome").value;

    //initialize();
    geocoder.geocode({ 'address': vbEndereco + ', Brasil', 'region': 'BR' }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                if (results[0]) {
                    var latitude = results[0].geometry.location.lat();
                    var longitude = results[0].geometry.location.lng();
                    var originPoint = new google.maps.LatLng(vbLat, vbLong);

                    // Chama o serviço para pegar os dados
                    fetch('/DepartamentoPolicia/BuscaDelegaciasProximasJson?Latitude=' + vbLat + '&Longitude=' + vbLong + '&Id=' + vbID)
                        .then(response => response.json())
                        .then(data => {
                            // Atualiza a variável locations com os dados retornados pelo serviço
                            var locations = data;

                            // Continua com o restante do código
                            var map = new google.maps.Map(document.getElementById('mapa'), {
                                zoom: 12    ,
                                center: new google.maps.LatLng(vbLat, vbLong),
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
                                    infowindow.setContent(vbNome);
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

    //carregarNoMapa(vbEndereco);


    //$("#endereco").blur(function () {
    //    if ($(this).val() != "")
    //        carregarNoMapa($(this).val());
    //})

    //$('#endereco').keypress(function (event) {
    //    var keycode = (event.keyCode ? event.keyCode : event.which);
    //    if (keycode == '13') {
    //        if ($(this).val() != "")
    //            carregarNoMapa($(this).val());
    //    }
    //});

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

    //$("#endereco").autoComplete({
    //    source: function (request, response) {
    //        geocoder.geocode({ 'address': request.term + ', Brasil', 'region': 'Distrito Federal' }, function (results, status) {
    //            response($.map(results, function (item) {
    //                return {
    //                    label: item.formatted_address,
    //                    value: item.formatted_address,
    //                    latitude: item.geometry.location.lat(),
    //                    longitude: item.geometry.location.lng()
    //                }
    //            }));
    //        })
    //    },
    //    select: function (event, ui) {
    //        $("#latitude").val(ui.item.latitude);
    //        $("#longitude").val(ui.item.longitude);
    //        var location = new google.maps.LatLng(ui.item.latitude, ui.item.longitude);
    //        marker.setPosition(location);
    //        map.setCenter(location);
    //        map.setZoom(16);
    //    }
    //});
});