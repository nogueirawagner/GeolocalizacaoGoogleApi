﻿function contarLinhas() {
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

        // Verificar se a palavra digitada é múltipla de 4
        if (value.length > 0 && value.length % 4 === 0) {
            // Chamar o serviço aqui
            PesquisarPorPalavras();
        }

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

function PesquisarAlunosPorPalavras(pTermo) {
    var concorrencia = document.getElementById("concorrencias").value;
    console.log("chamando serviço passando a concorrencia: ", concorrencia, "e termo: " + pTermo);

    fetch('/Aluno/PesquisarAlunosPorPalavras?pTermo=' + pTermo + '&pConcorrencia=' + concorrencia, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        cache: 'no-cache',
    })
        .then(response => response.text())
        .then(data => {
            document.getElementById('retornoPesquisa').innerHTML = data;

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

                // Verificar se a palavra digitada é múltipla de 4
                if (value.length > 0 && value.length % 4 === 0) {
                    // Chamar o serviço aqui
                    PesquisarPorPalavras(value);
                }


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


        })
        .catch(error => {
            // Se houver algum erro na requisição, ele será capturado aqui
            console.error('Erro:', error);
        });






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

        // Verificar se a palavra digitada é múltipla de 4
        if (value.length > 0 && value.length % 4 === 0) {
            // Chamar o serviço aqui
            PesquisarAlunosPorPalavras(value);
        }

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

