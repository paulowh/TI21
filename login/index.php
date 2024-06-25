<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<style>
    body {
        display: flex;
        align-items: center;
        height: 100%;
        justify-content: center;
        flex-direction: column;
    }

    form {
        display: flex;
        flex-direction: column;
        width: 200px;

    }

    input[type="text"] {
        width: 200px;
        height: 30px;
        background-color: #f4f4f4;
        border: 1px solid black;
        border-radius: 15px;
        padding: 5px 5px;
        margin: 10px;
    }

    input[type="submit"] {
        width: 150px;
        height: 30px;
        justify-content: center;
        align-self: end;
    }
</style>

<pre>
<?php
if (isset($_POST) && !empty($_POST)) {
    
    $user = $_POST['usuario'];
    $password = $_POST['senha'];
    // new PDO cria a conexão com o banco de dados
    $conn = new PDO("mysql:host=localhost;dbname=bd_login", "root", "");
    // $script guarda um script para a consulta do banco, nesse caso verifica se a senha e usuario é igual
    $script = "SELECT * FROM tb_usuario WHERE usuario = '{$user}' AND senha = '{$password}'";
    // -> query executa o scritp e o -> fetch retorna o resultado do script
    // $resultado guarda o resultado da consulta
    $resultado = $conn->query($script)->fetch();
    // verifico se a variavel resultado tem algum valor
    if (!empty($resultado)){
        echo 'Usuario Validado com sucesso!!!';
        // ele redireciona a pagina
        header('location:valido.php');
    } else {
        echo 'Usuario não encontrado.';
    }
}

?>
</pre>

<body>
    <form action="#" method="POST">
        <input type="text" name="usuario" placeholder="Login">
        <input type="text" name="senha" placeholder="Digite sua senha">
        <input type="submit" value="Enviar">
    </form>
</body>

</html>