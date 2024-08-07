<?php

class Produto
{

    public function ListarProdutos($limite = '')
    {
        $conexao = new PDO("mysql:host={$_ENV['HOST']}; dbname={$_ENV['DATABASE']}", $_ENV['USER'], $_ENV['PASSWORD']);

        $query = "SELECT id, titulo, preco, avaliacao, imagem FROM tb_produto";

        !empty($limite) ? $query = "SELECT id, titulo, preco, avaliacao, imagem FROM tb_produto ORDER BY RAND() LIMIT " . $limite : '';


        $resultado = $conexao->query($query);
        $lista = $resultado->fetchAll();

        return $lista;
    }

    public function ConsultarProduto($id_consulta)
    {
        $conexao = new PDO("mysql:host={$_ENV['HOST']}; dbname={$_ENV['DATABASE']}", $_ENV['USER'], $_ENV['PASSWORD']);
        $query = "SELECT * FROM tb_produto WHERE id = " . $id_consulta;

        $resultado = $conexao->query($query);
        $lista = $resultado->fetch();

        return $lista;
    }

    public function ConsultarTipo($id_produto)
    {

        $conexao = new PDO("mysql:host={$_ENV['HOST']}; dbname={$_ENV['DATABASE']}", $_ENV['USER'], $_ENV['PASSWORD']);

        $query = " SELECT t.* FROM tb_tipo_produto tp
        INNER JOIN tb_tipo t ON t.id = tp.id_tipo
        WHERE tp.id_produto = {$id_produto}";

        $resultado = $conexao->query($query);
        $lista = $resultado->fetchAll();

        return $lista;
    }

    public function ConsultarFiltro($filtro)
    {
        $conexao = new PDO("mysql:host={$_ENV['HOST']}; dbname={$_ENV['DATABASE']}", $_ENV['USER'], $_ENV['PASSWORD']);

        $params = '';
        $query = " SELECT p.id, p.titulo, p.preco, p.avaliacao, p.imagem FROM tb_tipo_produto tp
        INNER JOIN tb_tipo t ON t.id = tp.id_tipo
        INNER JOIN tb_produto p ON p.id = tp.id_produto WHERE";

        $cont = 1;

        foreach ($filtro as $key => $value) {
            $cont != count($filtro)
                ? $params .= ' t.descricao = "' . $key . '" OR'
                : $params .= ' t.descricao = "' . $key . '"';

            $cont++;
        }

        $query .= $params . 'GROUP BY p.titulo';

        $resultado = $conexao->query($query);
        $lista = $resultado->fetchAll();

        return $lista;
    }
}
