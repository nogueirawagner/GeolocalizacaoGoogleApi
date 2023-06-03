var estatisticas = [
    { Nome: "Categoria 1", Valor: 10 },
    { Nome: "Categoria 2", Valor: 20 },
    { Nome: "Categoria 3", Valor: 15 },
    { Nome: "Categoria 4", Valor: 25 },
    { Nome: "Categoria 5", Valor: 18 }
];

var chartContainer = document.getElementById("chartContainer");

for (var i = 0; i < estatisticas.length; i++) {
    var linha = document.createElement("div");
    linha.className = "chart-line";
    linha.style.width = "calc(100% / " + estatisticas.length + ")";
    linha.style.left = "calc(" + (i * 100) + "% / " + estatisticas.length + ")";
    linha.style.backgroundSize = "100% " + estatisticas[i].Valor + "%";
    linha.setAttribute("data-tooltip", estatisticas[i].Nome + ": " + estatisticas[i].Valor);
    chartContainer.appendChild(linha);
}
