<?php
include 'classe/Usuario.php';

echo "<pre>";
var_dump($_POST);

$user = $_POST['usuario'];
$password = $_POST['senha'];
$passwordConfirm = $_POST['confirma'];

echo "</pre>";
$usuario = new Usuario();

$resultado = $usuario->CadastroUsuario($user, $password, $passwordConfirm);

echo $resultado;

echo "</pre>";
