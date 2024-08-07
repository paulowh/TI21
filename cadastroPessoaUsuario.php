<?php
include_once './includes/header.php';
include './classes/Pessoa.php';
include './classes/Usuario.php';


if (isset($_POST) && !empty($_POST) && $_POST['tipo'] != 'usuario') {
    $pessoa = new Pessoa();
    $pessoa->getDados(
        $_POST['nome'],
        $_POST['cpf'],
        $_POST['ano_nascimento'],
        $_POST['telefone1']
    );

    $id_newPessoa = $pessoa->CadastrarPessoa();

}

if (isset($_POST) && !empty($_POST) && $_POST['tipo'] != 'pessoa') {

    $id_pessoa = isset($id_newPessoa) ? $id_newPessoa : $_POST['id_pessoa'];

    $usuario = new Usuario();

    $usuario->CadastrarUsuario(
        $_POST['user'],
        $_POST['senha'],
        $id_pessoa
    );
}


include_once './includes/cadastro.php';

include_once './includes/footer.php';