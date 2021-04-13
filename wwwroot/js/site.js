$("#enviar").bind("click", function () {

    var dados = $("#insert-form").serialize();

    $.ajax({
        method: "POST", // procura uma ação com o [HttpPost]
        url: "Home/Salvar", // URL ou diretório para a ação, 'Home' é o Controller e o 'Salvar' é a ação
        data: dados, // passando como parâmetro o nome q for inserido no input com 'id=nome'
        success: function (r) {
            alert(r) // Retorna um objeto do method 'Salvar', é um object string

            /*if ($("#nome").val() != "" && $("#comentario").val() != "")
                $("#caixa").append($("#nome").val() + ":\n" + $("#comentario").val() + "\n\n")
            else if ($("#nome").val() == "" && $("#comentario").val() == "") {
                alert("Informe seu Nome e seu Comentário!")
            }
            else {
                if($("#nome").val() == "") alert("Informe seu nome!")
                else if ($("#comentario").val() == "") alert("Informe seu Comentário!")
            }*/
        },
        error: function () {
            alert("erro")
        }
    });
});