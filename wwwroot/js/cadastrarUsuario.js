function IsPasswordValid(valid) {
    var senha = $("#confirmeSenha").val()
    if(senha == valid) return true
    return false
}

// Cadastra o usuário e fala se foi cadastrado ou não
$("#cadastrar").bind("click", function(){ 
    if(IsPasswordValid($("#cadastroSenha").val())){ // Essa condição verifica se os campos confirma senha e senha, e se eles são iguais ou não
        
        var dadosCadastro = $("#insert-cadastro").serialize()

        $.ajax({
            type: "POST",
            url: "Cadastro/SalvaCadastro",
            data: dadosCadastro,
            success: function (r) {
                if(r){
                    $("#cadastroSucesso").html("Cadastrado com Sucesso!")
                }
                else{
                    $("#cadastroSucesso").html("Cadastro inválido!")
                }
            },
            error(){
                alert("Erro!")
            }
        });

    }
    else{
        alert("Senha errada!")
    }

})