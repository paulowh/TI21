function botao() {
    //variavel = documento selecionado pelo ID
    corpinho = document.getElementById("corpo");
    console.log(corpinho);
    //className -> lista os nomes da classe existente 
    classe = corpinho.className;
    //split -> separa em array o texto
    classSeparado = classe.split(' ')
    console.log(classSeparado);

    //length conta a quantidade de valores dentro do array
    for (cont = 0; cont < classSeparado.length; cont++) {
        
        if (classSeparado[cont] == 'tomato') {
            corpinho.classList.remove("tomato")
            corpinho.classList.add("skyblue")
        } 

        if (classSeparado[cont] == 'skyblue') {
            corpinho.classList.remove("skyblue")
            corpinho.classList.add("tomato")
        }
    }
}