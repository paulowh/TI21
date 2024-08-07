<?php // composer require phpmailer/phpmailer

use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;

require 'vendor/autoload.php';
require './function.php';

$mail = new PHPMailer(true);

try {
    // Configurações do servidor
    $mail->isSMTP();
    $mail->Host       = $_ENV['SMTP']; // Servidor SMTP
    // 'smtp.gmail.com';
    // 'smtp.office365.com';
    // 'smtp.mail.yahoo.com';
    // 'mail.seudominio.com';

    $mail->SMTPAuth   = true;
    $mail->Username   = $_ENV['EMAIL']; // Usuário SMTP
    $mail->Password   = $_ENV['EMAILPASSWORD']; // Senha SMTP
    $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS;
    $mail->Port       = 587;

    // Definir charset para UTF-8
    $mail->CharSet = 'UTF-8';

    // Destinatários
    $mail->setFrom($_ENV['EMAIL'], $_ENV['NAME']);
    $mail->addAddress('paulo.whsantos@hotmail.com', 'Paulo Santos');

    // Conteúdo do e-mail
    $mail->isHTML(true);
    $mail->Subject = 'Confirmação de Inscrição';
    $mail->Body    = 'Este é o corpo do email em <b>HTML</b>.';
    $mail->AltBody = 'Este é o corpo do email em texto simples para clientes de email que não suportam HTML.';

    $mail->send();
    echo 'Email enviado com sucesso';
} catch (Exception $e) {
    echo "Falha ao enviar o email. Mailer Error: {$mail->ErrorInfo}";
}
