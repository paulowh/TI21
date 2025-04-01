<?php
include './classes/Tipo.php';
include './classes/Produto.php';

include './includes/header.php';

$tipo = new Tipo();
$dadosTipo = $tipo->ListarTipo();

$produto = new Produto();
$dadosProdutos = [];

if (!empty($_GET)) {
    $dadosProdutos = $produto->ConsultarFiltro($_GET);
} else {
    $dadosProdutos = $produto->ListarProdutos();
}

include './includes/filtroProdutos.php';

include_once './includes/footer.php';
