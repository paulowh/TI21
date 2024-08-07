<?php
include_once './includes/header.php';
include_once './classes/Produto.php';

include_once html('banner');


$produto = new Produto();
$dadosProdutos = $produto->ListarProdutos(8);

include_once './includes/produtos.php';
include_once './includes/footer.php';

?>