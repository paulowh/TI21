<!DOCTYPE html>
<html lang="pt-br">
<?php

include './function.php';
?>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Police Public Call Box</title>
    <link rel="stylesheet" href="assets/libs/bootstrap.min.css">
    <link rel="stylesheet" href="assets/libs/bootstrap-icons.min.css">
    <link rel="shortcut icon" href="assets/img/logo.ico" type="image/x-icon">
    <link rel="stylesheet" href="<?= css('style') ?>">
    <link rel="stylesheet" href="<?= css('carrossel') ?>">
    <link rel="stylesheet" href="<?= css('footer') ?>">
    <link rel="stylesheet" href="<?= css('login') ?>">
    <link rel="stylesheet" href="<?= css('detalhes') ?>">
    <link rel="stylesheet" href="<?= css('filtro') ?>">
    <link rel="stylesheet" href="<?= css('cadastro') ?>">


</head>

<body>
<header>
    <nav class="menu-perfil">

        <a href="index.php" class="logo">
            <p>POLICE BOX</p>
        </a>

        <ul class="menu">
            <li><a href="index.php">Inicio</a></li>
            <li><a href="todosprodutos.php">Produto</a></li>
            <li><a href="sobre.php">Sobre</a></li>
        </ul>

        <ul class="menu-compra">
            <li><a href="#" class="selecionado"><i class="bi bi-search"></i></a></li>
            <li><a href="#" class=""><i class="bi bi-heart"></i></a></li>
            <li><a href="#" class=""><i class="bi bi-cart"></i></a></li>

            <li class="dropdown">
                <a href="#" class="" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                    <i class="bi bi-person"></i>
                </a>
                <ul class="dropdown-menu">
                    <li class="drop">
                        <a class="dropdown-item" href="./login.php">
                            Login
                        </a>
                    </li>
                    <li class="drop">
                        <a class="dropdown-item" href="./cadastroPessoaUsuario.php">
                            Cadastrar Usuario
                        </a>
                    </li>
                    <li class="drop">
                        <a class="dropdown-item <?= !empty($_SESSION['user']) && isset($_SESSION) ? '' : 'disabled' ?>"
                           href="./usuario.php">
                            Menu
                        </a>
                    </li>
                    <li class="drop">
                        <a class="dropdown-item <?= !empty($_SESSION['user']) && isset($_SESSION) ? '' : 'disabled' ?>"
                           href="#">
                            Editar Usuario
                        </a>
                    </li>

                    <li class="drop">
                        <a class="dropdown-item <?= !empty($_SESSION['user']) && isset($_SESSION) ? '' : 'disabled' ?>"
                           href="#">
                            Cadastrar Produto
                        </a>
                    </li>

                    <li class="drop">
                        <a class="dropdown-item <?= !empty($_SESSION['user']) && isset($_SESSION) ? '' : 'disabled' ?>"
                           href="./login.php?sair=true">
                            Sair
                        </a>
                    </li>

                </ul>
            </li>
        </ul>

    </nav>

</header>