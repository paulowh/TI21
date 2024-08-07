<section id="cadastro">
    <main class="container">
        <form action="#" method="post" class="cadastro-pessoa">
            <input type="hidden"
                   value="<?= isset($_GET['cadastro']) && $_GET['cadastro'] != "" ? $_GET['cadastro'] : 'geral' ?>"
                   name="tipo"
            >
            <h2>Cadastro</h2>

            <label for="nome">Nome:</label>
            <?php
            if (isset($_GET['cadastro']) && $_GET['cadastro'] == "usuario") {
                echo '<select name="id_pessoa" id="id_pessoa">';
                $listaPessoas = (new Pessoa)->ListarPessoas();
                foreach ($listaPessoas as $pessoa) {
                    echo '<option value="' . $pessoa['id'] . '">' . $pessoa['nome'] . '</option>';
                }
                echo '</select>';
            } else {
                echo '<input type="text" name="nome" id="nome" placeholder="Nome:">';
            }
            ?>

            <div class="dados" <?= isset($_GET['cadastro']) && $_GET['cadastro'] == 'usuario' ? 'hidden' : '' ?>>
                <div class="row">
                    <div class="col-lg-9 col-sm-12">
                        <label for="cpf">CPF: </label>
                        <input type="text" maxlength="11" name="cpf" id="cpf">
                    </div>
                    <div class="col-lg-3 col-sm-12">
                        <label for="ano_nascimento">Nasc.: </label>
                        <input type="number" max="9999" name="ano_nascimento" id="nome_nascimento">
                    </div>
                </div>
            </div>
            <div class="login-cadastro my-3" <?= isset($_GET['cadastro']) && $_GET['cadastro'] == 'pessoa' ? 'hidden' : '' ?> >
                <label for="user">Usuario: </label>
                <input type="text" name="user" id="user">
                <div class="row">

                    <div class="col-lg-6 col-sm-12">

                        <label for="senha">Senha: </label>
                        <input type="password" name="senha" id="senha">
                    </div>
                    <div class="col-lg-6 col-sm-12">

                        <label for="confirma">Confirme Senha: </label>
                        <input type="password" name="confirma" id="confirma">
                    </div>
                </div>
            </div>
            <div class="telefones" <?= isset($_GET['cadastro']) && $_GET['cadastro'] == 'usuario' ? 'hidden' : '' ?>>
                <div class="row">
                    <div class="col-lg-6 col-sm-12">

                        <label for="telefone1">Telefone 1: </label>
                        <input type="text" name="telefone1" id="telefone1" maxlength="11">

                    </div>
                    <div class="col-lg-6 col-sm-12">
                        <label for="telefone2">Telefone 2: </label>
                        <input type="text" name="telefone2" id="telefone2" maxlength="11">
                    </div>
                </div>
            </div>

            <div class="logradouro" <?= isset($_GET['cadastro']) && $_GET['cadastro'] == 'usuario' ? 'hidden' : '' ?>>
                <div class="row">

                    <div class="col-lg-9 col-sm-12">
                        <label for="rua">Rua: </label>
                        <input type="text" name="rua" id="rua">
                    </div>

                    <div class="col-lg-3 col-sm-12">

                        <label for="n_casa">Nº </label>
                        <input type="number" name="n_casa" id="n_casa">
                    </div>
                </div>
            </div>
            <div class="bairro-cidade" <?= isset($_GET['cadastro']) && $_GET['cadastro'] == 'usuario' ? 'hidden' : '' ?>>

                <label for="bairro">Bairro: </label>
                <input type="text" name="bairro" id="bairro">

                <label for="cidade">Cidade: </label>
                <input type="text" name="cidade" id="cidade">
            </div>

            <input type="submit" value="Enviar" class="btn fundo-verde">

        </form>
    </main>
</section>