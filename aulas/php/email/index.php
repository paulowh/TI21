<?php
// composer require phpmailer/phpmailer
// Importando Classes do PHPMailer
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;

//Carregando arquivo do composer
require 'vendor/autoload.php';

//Criando instancia do PHPMailer 
$mail = new PHPMailer(true);

try {
    //Configuração do servidor
    $mail->isSMTP();                                    //Usando o SMTP
    $mail->Host       = 'smtp-mail.outlook.com';        //O servidor responsavel pelo envio
    $mail->SMTPAuth   = true;                           //Enable SMTP authentication
    $mail->Username   = 'policebox2@hotmail.com';       //SMTP username
    $mail->Password   = '@luno123';                     //SMTP password
    $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS; //Enable implicit TLS encryption
    $mail->Port       = 587;                            //TCP port to connect to; use 587 if you have set `SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS`
    $mail->CharSet    = 'UTF-8';

    //Destinatarios
    $mail->setFrom('policebox2@hotmail.com', 'PoliceBox');
    $mail->addAddress('doceslunaticos@outlook.com', 'Doces Lunaticos');     //Add a recipient

    //Conteudo do email
    $mail->isHTML(true);                                  //Set email format to HTML
    $mail->Subject = 'Confirmação de cadastro';
    $mail->Body    = 'Venho confirmar que o seu cadastro foi efetuado com <strong>sucesso</strong>!!!';
    $mail->AltBody = 'Aqui tenho o texto alternativo do meu email.';

    $mail->send();
    echo "até agora, tudo certo...";
} catch (Exception $e) {
    echo "Erro ao enviar o e-mail: {$mail->ErrorInfo}";
}
