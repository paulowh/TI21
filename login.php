<?php

include './includes/header.php';
include './classes/Usuario.php';

if (isset($_POST['usuario']) && isset($_POST['senha'])) {
    $usuario = new Usuario();
    $valido = $usuario->ValidarUsuario($_POST['usuario'], $_POST['senha']);

    if (isset($valido) && !empty($valido)) {
        header('location:usuario.php');
    }

}

if (isset($_GET['sair']) && $_GET['sair'] == 'true') {
    session_destroy();
    header('location:index.php');
}

include html('login');

include_once './includes/footer.php';