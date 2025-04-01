<?php

if (!empty($_GET)) {
    $busca = $_GET['nome'];
}

$conexao = new PDO('mysql:host=localhost;dbname=db_requisicao',  'root', '');
$query = "SELECT * FROM tb_produto WHERE titulo LIKE '%{$busca}%' ";
$resultado = $conexao->query($query)->fetchAll();
