<h1>Olá Mundo</h1>
<?php //TAG para trabalhar com PHP

echo "<h1>Olá PHP em H1</h1>";
// Similaridades entre o PHP e C#
// O comentario é feito da mesma forma // ou /* */

//Variaveis
$texto = "Renon Gusson";

// Concatenação "."
echo "Bom dia Usuario: " . $texto . "<br>";

// Serve para verificar o tipo e conteudo da variavel
var_dump($texto);
echo "<br>";
//Condições
if (1 != 1) {
    echo "O IF deu certo!!!";
} else if (2 == 2) {
    echo "O ELSE IF deu certo!!!";
} else {
    echo "O IF NÃO deu certo!!!";
}
// condição ? verdadeiro : falso
echo "<br>";
$texto == "" ? "Ternario deu certo" : "Não deu certo";

for ($cont = 1; $cont <= 5; $cont++) {
    echo $cont . "<br>";
}

$contador = 0;
while ($contador < 10) {
    echo "Estou em tela!!! <br>";
    $contador = $contador + 1;
}

function Gui()
{
    echo "Oie, eu sou uma função";
}

$condicao = "Olá";

Gui();
?>  