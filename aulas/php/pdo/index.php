<?php $_ENV = parse_ini_file('.env');

include_once './pages/header.html';

$conexao = new PDO("mysql:host={$_ENV['HOST']};dbname={$_ENV['DATABASE']}", $_ENV['USER'], $_ENV['PASSWORD']);
$query = "SELECT tp.*, p.id as 'id_produtinho', p.*, t.descricao FROM tb_tipo_produto as tp INNER JOIN tb_produto as p ON p.id = tp.id_produto INNER JOIN tb_tipo AS t ON t.id =  tp.id_tipo LIMIT 100";
$produtos = $conexao->query($query)->fetchAll();

include './pages/produto.php';