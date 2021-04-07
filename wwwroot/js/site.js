function nome(massage) {
    return massage
}

$("#enviar").click(function(){
    let s = nome($("#nome").val())
    $("#result").html(s)
})