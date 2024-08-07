<?php

class Usuario
{
    private $id;
    private $user;
    private $password;
    private $id_pessoa;

    public function CadastrarUsuario($user, $password, $id_pessoa)
    {
        if ($id_pessoa == "" || empty($id_pessoa)) {
            return false;
        }

        try {
            $conexao = new PDO("mysql:host={$_ENV['HOST']}; dbname={$_ENV['DATABASE']}", $_ENV['USER'], $_ENV['PASSWORD']);

            $stmt = $conexao->prepare('INSERT INTO tb_usuario (
                                                usuario,
                                                senha,
                                                id_pessoa
                                            ) VALUES(
                                                   :usuario,
                                                   :senha,
                                                   :id_pessoa
                                            )'
            );

            $stmt->execute([
                ':usuario' => $user,
                ':senha' => $password,
                ':id_pessoa' => $id_pessoa,
            ]);

            return $conexao->lastInsertId();
        } catch (PDOException $e) {
            echo 'Error: ' . $e->getMessage();
        }
    }

    public function ValidarUsuario($user, $senha)
    {
        try {

            $conn = new PDO("mysql:host={$_ENV['HOST']}; dbname={$_ENV['DATABASE']}", $_ENV['USER'], $_ENV['PASSWORD']);
            $query = "SELECT * FROM tb_usuario WHERE usuario = '{$user}' AND senha = '{$senha}'";

            $dados = $conn->query($query)->fetch();

            if (!empty($dados)) {

                $query = "SELECT * FROM tb_pessoa WHERE id = '{$dados['id_pessoa']}'";
                $dadosUsuario = $conn->query($query)->fetch();

                $_SESSION['user'] = $dados['usuario'];
                $_SESSION['id_user'] = $dados['id'];
                $_SESSION['dados']['nome'] = $dadosUsuario['nome'];
                $_SESSION['dados']['data_nascimento'] = $dadosUsuario['ano_nascimento'];
                $_SESSION['dados']['cpf'] = $dadosUsuario['cpf'];

                return true;
            }
        } catch (PDOException $e) {
            echo "Error " . $e->getMessage();
            return false;
        }
    }


}
