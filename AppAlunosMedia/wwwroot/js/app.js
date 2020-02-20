$(document).ready(function () {
    CarregarDados();
});


function CarregarDados() {
    $.ajax({
        type: "GET",
        url: '/api/v1/list',
        data: {},
        dataType: "json",
        success: function (data) {
            //alert()
            //var d = JSON.parse(data);
            if (data.length > 0) {
                var comecoTabela = "<table class='table table-bordered table-hover'><tr><td>RA</td><td>Name</td><td>Period</td><td>Course</td><td>Note</td><td>Status</td></tr><tbody>";
                var meioTabela = "";
                for (var x = 0; x < data.length; x++) {
                    meioTabela = meioTabela + "<tr><td style='text-align: center'></td><td>" + d[x].RA + "</td><td>" + data[x].Name + "</td><td>" + d[x].Period + "</td><td>" + d[x].Course + "</td><td>" + d[x].Note + "</td><td>" + d[x].Status + "</td>";
                }
                var finalTabela = "</tboby></table>";
                $("#tabelaPrincipal").html(comecoTabela + meioTabela + finalTabela);
            } else {
                $("#mensagemFinalPrincipal").append("<span>Nenhuma assinatura no período</span>");
            }
        }
    }