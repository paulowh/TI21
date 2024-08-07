<section id="produtos">
    <h2 class="titulo">Produtos</h2>
    <main class="container produtos">
        <div class="row">
            <?php foreach ($dadosProdutos as $dados) { ?>
                <div class="col-lg-3 col-md-6 col-sm-12">
                    <figure>
                        <a href="./produto.php?id=<?= $dados['id'] ?> ">
                            <img src="<?= img('poster/' . $dados['imagem']) ?>"
                                 alt="Poste do jogo <?= $dados['titulo'] ?>" class="foto-produto">
                            <figcaption>
                                <h4 class="mt-1"><?= $dados['titulo'] ?></h4>
                                <span class="preco">R$ <?= number_format($dados['preco'], 2, ',', '.') ?></span>
                                <span class="avaliacao">
                                    <?php for ($i = 1; $i <= 5; $i++) {
                                        if ($i <= $dados['avaliacao']) {
                                            echo '<i class="bi bi-star-fill"></i>';
                                        } else {
                                            echo '<i class="bi bi-star"></i>';
                                        }
                                    } ?>
                                </span>
                            </figcaption>
                        </a>
                    </figure>
                </div>
            <?php } ?>
        </div>
    </main>
</section>