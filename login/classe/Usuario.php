<?php
class Usuario
{
    public function CadastroUsuario($user, $password, $passwordConfirm)
    {
        try {

            if (empty($user) || $user == null) {
                return "<br>Usuário não informado";
            }

            if (empty($password) || $password == null) {
                return "<br>Senha não informada";
            }

            if ($password != $passwordConfirm) {
                return "<br>Senhas não são iguias";
            }

            $conn = new PDO("mysql:host=localhost; dbname=db_login", "root", "");
            $script = "INSERT INTO tb_usuario (usuario, senha) VALUE (:usuario, :senha)";
            $preparo = $conn->prepare($script);
            $var = [
                ':usuario' => $user,
                ':senha' => $password
            ];
            $preparo->execute($var);
            return "Usuário cadastrado com sucesso id: " . $conn->lastInsertId();
        } catch (PDOException $erro) {
            echo "Seguinte, deu erro no negocio do treco <br>" . $erro->getMessage();
        }
    }
}
