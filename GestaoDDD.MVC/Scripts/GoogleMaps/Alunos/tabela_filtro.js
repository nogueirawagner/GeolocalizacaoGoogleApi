﻿function RegraBuscarPorPalavras(value) {
    if (value.length >= 4) {
        PesquisarAlunosPorPalavras(value);
    }
    if (value.length == 0) {
        BuscarAlunosFetch();
    }
}

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

        RegraBuscarPorPalavras(value);

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

function BuscarAlunosFetch() {
    var concorrencia = $("#concorrencias option:selected").val();
    var cargo = $("#cargo-select option:selected").val();

    fetch('/Aluno/BuscaAlunosFiltro?pCargo=' + cargo + '&pConcorrencia=' + concorrencia,  {
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

                RegraBuscarPorPalavras(value);
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

function PesquisarAlunosPorPalavras(pTermo) {
    var concorrencia = document.getElementById("concorrencias").value;
    var cargo = document.getElementById("cargo-select").value;

    fetch('/Aluno/PesquisarAlunosPorPalavras?pTermo=' + pTermo + '&pConcorrencia=' + concorrencia + "&pCargo=" + cargo, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        cache: 'no-cache',
    })
        .then(response => response.text())
        .then(data => {
            const parsedData = JSON.parse(data);
            var tableBody = $("#tableBody"); // Obter a referência do elemento tbody da tabela

            var totalRows = parsedData.length;
            $("#totalRows").text("Total de linhas: " + totalRows);

            // Limpar a tabela atual
            tableBody.empty();

            // Criar linhas da tabela com base nos dados recebidos
            parsedData.forEach(function (item) {
                var newRow = $("<tr class='table-row'>")
                    .attr("data-url", "/Aluno/PainelAluno?pAlunoId=" + item.ID)
                    .append($("<td>").text(item.Posicao))
                    .append($("<td>").text(item.Inscricao))
                    .append($("<td>").text(item.Nome))
                    .append($("<td>").text(item.NotaEtapa1))
                    .append($("<td>").text(item.NotaEtapa2))
                    .append($("<td>").text(item.NotaFinal));

                tableBody.append(newRow);
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

        RegraBuscarPorPalavras(value);

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

