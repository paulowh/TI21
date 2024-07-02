<!doctype html>
<html lang="pt-br">

<head>

	<meta charset="utf-8">

	<title>Login</title>

	<link href="./assets/css/style.css" rel="stylesheet">
</head>

<?php
if (isset($_POST) && !empty($_POST)) {

	$user = $_POST['usuario'];
	$password = $_POST['senha'];
	// new PDO cria a conexão com o banco de dados
	$conn = new PDO("mysql:host=localhost;dbname=db_login", "root", "");
	// $script guarda um script para a consulta do banco, nesse caso verifica se a senha e usuario é igual
	$script = "SELECT * FROM tb_usuario WHERE usuario = '{$user}' AND senha = '{$password}'";
	// -> query executa o scritp e o -> fetch retorna o resultado do script
	// $resultado guarda o resultado da consulta
	$resultado = $conn->query($script)->fetch();
	// verifico se a variavel resultado tem algum valor
	if (!empty($resultado)) {
		echo 'Usuario Validado com sucesso!!!';
		// ele redireciona a pagina
		header('location:valido.php');
	} else {
		echo 'Usuario não encontrado.';
	}
}
?>

<body class="d-flex align-items-center py-4 bg-body-tertiary login">

	<main class="form-signin w-100 m-auto">
		<form action="#" method="POST">
			<h1 class="h3 mb-3 fw-normal">Por Favor Faça o Login</h1>

			<div class="form-floating">
				<input type="text" class="form-control usuario" id="usuario" name="usuario" placeholder="Usuario">
				<label for="usuario">Usuario</label>
			</div>

			<div class="form-floating">
				<input type="text" class="form-control senha" id="senha" name="senha" placeholder="Senha">
				<label for="senha">Senha</label>
			</div>

			<div class="form-check text-end my-3">
				<label class="form-check-label">
					Problema ao fazer o login?
					<a href="./cadastro.php">
						Cadastre Aqui...
					</a>
				</label>
			</div>

			<input class="btn btn-primary w-100 py-2" type="submit">

			<p class="mt-5 mb-3 text-body-secondary">&copy; Aqui estamos mais um dia</p>
		</form>
	</main>

</body>

</html>