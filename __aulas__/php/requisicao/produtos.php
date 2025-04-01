<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<?php
if (isset($_GET['nome'])) {
    $busca = $_GET['nome'];

    $conexao = new PDO('mysql:host=localhost;dbname=db_requisicao',  'root', '');
    $query = "SELECT * FROM tb_produto WHERE titulo LIKE '%{$busca}%' ";
    $resultado = $conexao->query($query)->fetchAll();
}

?>

<body>
    <form action="#" method="GET">
        <input type="text" name="nome" placeholder="nome do produto">
        <input type="submit" value="Enviar">
    </form>
    
    <table border="1">
        <thead>
            <tr>
                <th>ID</th>
                <th>Nome</th>
                <th>Valor</th>
            </tr>
        </thead>
        <tbody>
            <?php
            if (!empty($resultado)) {
                foreach ($resultado as $value) {
            ?>
                    <tr>
                        <td><?= $value['id'] ?></td>
                        <td><?= $value['titulo'] ?></td>
                        <td><?= $value['preco'] ?></td>
                    </tr>

            <?php
                }
            }
            ?>


        </tbody>
    </table>
</body>

</html>