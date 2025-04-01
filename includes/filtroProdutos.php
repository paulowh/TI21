<section id="filtroProdutos">
    <main class="container">
        <div class="row">
            <div class="col-2 col-lg-2 col-xs-12">
                <form action="#" method="get" class="filtro">
                    <?php foreach ($dadosTipo as $value) { ?>
                        <label for="<?= $value['descricao'] ?>" class="label">
                            <input
                                    id="<?= $value['descricao'] ?>"
                                    name="<?= $value['descricao'] ?>"
                                    type="checkbox" <?= isset($_GET[$value['descricao']]) ? 'checked' : '' ?>
                            >
                            <div class="checkmark"></div>
                            <?= $value['descricao'] ?>
                        </label>
                    <?php } ?>
                    <input type="submit" value="Filtrar" class="btn">
                </form>

            </div>
            <div class="col-10 col-lg-10 col-xs-12">
                <?php include './includes/produtos.php'; ?>
            </div>
        </div>
    </main>
</section>