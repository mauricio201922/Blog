$(document).ready(function(){

    $("#logar").bind("click", function(){
        if($("#nome") != null)
            localStorage.setItem("nome", $("#nome").val())
    })
    $("#logoff").bind("click", function(){
        localStorage.removeItem("nome")
        window.location.href = "https://localhost:5001/"
    })
    if(localStorage.getItem("nome") && window.location.href != "https://localhost:5001/comentario") {
        window.location.href = "https://localhost:5001/comentario"
    }
    
})

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