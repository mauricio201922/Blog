$("#enviar").bind("click", function () {
    $.ajax({
        method: "POST",
        url: "Home/Salvar",
        data: $("#nome"),
        success: function (r) {
            if ($("#nome").val() != "" && $("#comentario").val() != "")
                $("#caixa").append($("#nome").val() + ":\n" + $("#comentario").val() + "\n\n")
            else if ($("#nome").val() == "" && $("#comentario").val() == "") {
                alert("Informe seu Nome e seu Comentário!")
            }
            else {
                if($("#nome").val() == "") alert("Informe seu nome!")
                else if ($("#comentario").val() == "") alert("Informe seu Comentário!")
            }
        },
        error: function () {
            alert("erro")
        }
    })
});