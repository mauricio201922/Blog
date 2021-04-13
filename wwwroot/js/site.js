$("#logar").bind("click", function(){

    var dadosLogin = $("#insert-login").serialize()

    $.ajax({
        type: "POST",
        url: "Login/Login",
        data: dadosLogin,
        success: function (response) {
            console.log(response)
        },
        error: function(){
            alert("Error!")
        }
    });
})