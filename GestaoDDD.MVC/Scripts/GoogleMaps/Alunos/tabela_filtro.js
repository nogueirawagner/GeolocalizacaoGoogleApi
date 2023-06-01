function contarLinhas() {
    // novo
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

        // Adicionar eventos de clique novamente após cada filtro
        var filteredTableRows = document.getElementsByClassName("table-row");
        for (var i = 0; i < filteredTableRows.length; i++) {
            filteredTableRows[i].addEventListener("click", function () {
                var url = this.getAttribute("data-url");
                window.location.href = url;
            });
        }
    });
}

function linhaLink() {
    var tableRows = document.getElementsByClassName("table-row");
    for (var i = 0; i < tableRows.length; i++) {
        tableRows[i].addEventListener("click", function () {
            var url = this.getAttribute("data-url");
            window.location.href = url;
        });
    }
}

$(document).ready(function () {

    // novo
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

        // Adicionar eventos de clique novamente após cada filtro
        var filteredTableRows = document.getElementsByClassName("table-row");
        for (var i = 0; i < filteredTableRows.length; i++) {
            filteredTableRows[i].addEventListener("click", function () {
                var url = this.getAttribute("data-url");
                window.location.href = url;
            });
        }
    });


    var tableRows = document.getElementsByClassName("table-row");
    for (var i = 0; i < tableRows.length; i++) {
        tableRows[i].addEventListener("click", function () {
            var url = this.getAttribute("data-url");
            window.location.href = url;
        });
    }




});

