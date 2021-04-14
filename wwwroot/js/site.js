$("#logar").bind("click", function(){

    var dadosLogin = $("#insert-login").serialize();

    $.ajax({
        type: "POST",
        url: "Home/Logar",
        data: dadosLogin,
        success: function (r) {
            if(r) window.location.href = "https://localhost:5001/comentario"
            else alert("Este login não existe!")
        },
        error: function(){
            alert("Error!")
        }
    });
})