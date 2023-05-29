var geocoder;
var map;
var marker;

$(document).ready(function () {

    var totalRows = $("#mytable tr").length - 1;
    $("#totalRows").text("Total de linhas: " + totalRows);

    $("#searchInput").on("keyup", function () {
        var value = $(this).val().toLowerCase().normalize('NFD').replace(/[\u0300-\u036f]/g, "");
        $("#mytable tr:not(:first)").filter(function () {
            var rowValue = $(this).text().toLowerCase().normalize('NFD').replace(/[\u0300-\u036f]/g, "");
            $(this).toggle(rowValue.indexOf(value) > -1);
        });
        var filteredRows = $("#mytable tr:visible").length - 1;
        $("#totalRows").text("Linhas encontradas: " + filteredRows);
    });
});

