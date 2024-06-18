<?php

if (!empty($_GET)) {
    echo 'estamos recebendo valores do tipo GET';
    $usuario = $_GET['user'];
    $senha = $_GET['senha'];
}

if (!empty($_POST)) {
    echo 'estamos recebendo valores do tipo POST';
    $usuario = $_POST['user'];
    $senha = $_POST['senha'];
}

echo '<br>';
echo '<br>';
echo '<br>';

echo $usuario;
echo '<br>';
echo $senha;

