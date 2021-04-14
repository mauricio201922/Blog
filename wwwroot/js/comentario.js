$(document).ready(function(){
    $.ajax({
        method: "GET",
        url: "RetornaComentarios",
        success: function (response) {
            for(var i = 0; i < response.length; i++){
                $("#caixa").append(response[i].nome + ":\n" + response[i].comenta + "\n\n");
            }
        },
    })
})

$("#enviar").on("click", function () {

    var dados = $("#insert-form").serialize();

    $.ajax({
        method: "POST", // procura uma ação com o [HttpPost]
        url: "Salvar", // URL ou diretório para a ação, 'Home' é o Controller e o 'Salvar' é a ação
        data: dados, // passando como parâmetro o nome q for inserido no input com 'id=nome'
        success: function (r) {
            // alert(r); // Retorna um objeto do method 'Salvar', é um object string
            $("#caixa").append("Usuario: " + r.nome +"\n" + "Comentario: " + r.comenta + "\n\n")

            console.log(JSON.stringify(r))

        },
        error: function () {
            
            if ($("#nome").val() == "" && $("#comentario").val() == "") {
                alert("Informe seu Nome e seu Comentário!")
            }
            else {
                if($("#nome").val() == "") alert("Informe seu nome!")
                else if ($("#comentario").val() == "") alert("Informe seu Comentário!")
            }
        }
    });
});