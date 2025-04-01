<?php 

include './includes/header.php';
echo 'bem vindo: ' . $_SESSION['dados']['nome'];
include html('usuario');

include './includes/footer.php';