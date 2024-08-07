<?php

class Pessoa
{
    private $nome;
    private $cpf;
    private $data_nascimento;
    private $telefone1;
    private $telefone2;
    private $rua;
    private $numero;
    private $bairro;
    private $cidade;

    public function getDados($nome, $cpf, $data_nascimento, $telefone1)
    {
        $this->nome = $nome;
        $this->cpf = $cpf;
        $this->data_nascimento = $data_nascimento;
        $this->telefone1 = $telefone1;
    }

    public function ListarPessoas()
    {
        $conexao = new PDO("mysql:host={$_ENV['HOST']}; dbname={$_ENV['DATABASE']}", $_ENV['USER'], $_ENV['PASSWORD']);

        $query = "SELECT id, nome FROM tb_pessoa";

        $resultado = $conexao->query($query);
        $lista = $resultado->fetchAll();

        return $lista;
    }

    public function CadastrarPessoa()
    {
        try {
            $conexao = new PDO("mysql:host={$_ENV['HOST']}; dbname={$_ENV['DATABASE']}", $_ENV['USER'], $_ENV['PASSWORD']);

            $stmt = $conexao->prepare('INSERT INTO tb_pessoa (nome, ano_nascimento, cpf, telefone_1) 
                                            VALUES(:nome, :nome_nascimento, :cpf, :telefone1)'
            );

            $stmt->execute([
                ':nome' => $this->nome,
                ':nome_nascimento' => $this->cpf,
                ':cpf' => $this->data_nascimento,
                ':telefone1' => $this->telefone1,
            ]);

            return $conexao->lastInsertId();
        } catch (PDOException $e) {
            echo 'Error: ' . $e->getMessage();
        }

    }
}
