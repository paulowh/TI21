<?php

class Tipo
{
    public function ListarTipo()
    {
        $conexao = new PDO("mysql:host={$_ENV['HOST']}; dbname={$_ENV['DATABASE']}", $_ENV['USER'], $_ENV['PASSWORD']);

        $query = "SELECT * FROM tb_tipo";

        $resultado = $conexao->query($query);
        $lista = $resultado->fetchAll();

        return $lista;
    }
}