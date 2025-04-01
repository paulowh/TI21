<?php

var_dump($_GET);
$selecionados = $_GET;
$total = count($selecionados);
$cont = 1;
echo '<br>você selecionou as opções ....';

foreach ($selecionados as $key => $value) {
    if ($cont < $total){
        echo $key . ', ';
    } else {
        echo $key;
    }
    $cont = $cont + 1;

};

$separado = implode(' , ', $selecionados);
echo $separado;