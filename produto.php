<?php
include_once './includes/header.php';
include './classes/Produto.php';

$produto = new Produto();
$dados = $produto->ConsultarProduto($_GET['id']);
$tipos = $produto->ConsultarTipo($_GET['id']);
$cores = [
    "#FF7733",
    "#4EADA7",
    "#ED2FD1"
];
?>

    <section id="detalhes">
        <main class="container">
            <div class="row">
                <div class="col-lg-6 col-md-6 col-sm-12 my-4">
                    <img src="<?= img('poster/' . $dados['imagem']) ?>" alt="poster Jedi Survivor" class="foto ">
                </div>
                <div class="col-lg-6 col-md-6 col-sm-12 detalhe-produto py-5">
                    <h1 class="titulo-jogo"><?= $dados['titulo'] ?></h1>

                    <span class="avaliacao">
                    <?php for ($i = 1; $i <= 5; $i++) {
                        if ($i <= $dados['avaliacao']) {
                            echo '<i class="bi bi-star-fill"></i>';
                        } else {
                            echo '<i class="bi bi-star"></i>';
                        }
                    } ?>
                </span>

                    <div class="genero">
                        <?php foreach ($tipos as $key => $tipo) { ?>
                            <span style="background-color: <?= $cores[$key] ?>;"><?= $tipo['descricao'] ?></span>
                        <?php } ?>
                    </div>

                    <h3 class="preco">R$ <?= number_format($dados['preco'], 2, ',', '.') ?></h3>

                    <div class="versao-jogo m-3 ">
                        <button checked>STANDARD</button>
                        <button>DELUX</button>
                        <button>ULTIMATE</button>
                    </div>

                    <button class="btn btn-success "><i class="bi bi-bag"></i> COMPRAR</button>
                    <div class="sobre-jogo">
                        <h4>Descrição</h4>
                        <?php
                        $descricao = explode('. ', $dados['descricao']);

                        foreach ($descricao as $value) {
                            echo '<p>' . $value . '.</p>';
                        }
                        ?>
                    </div>

                </div>
            </div>
        </main>
    </section>

<?php
include_once './includes/footer.php'

?>