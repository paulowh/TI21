<?php include_once './pages/header.html';
/**
 * include_once -> carrega apenas uma vez o arquivo
 * include -> carrega quantas nescessarias
 */
/** Objetivo
 * criar um array com as info dos produtos 
 * laço que vai passar pelo array e criar os produtos 
 */
// poster, titulo, preço, avaliação
$produtos = [
    [
        'titulo' => 'Baldur\'s Gate 3',
        'preco' => 290.00,
        'avaliacao' => 3,
        'poster' => 'baldurs-gate-3.jpg'
    ],
    [
        'titulo' => 'Death Stranding',
        'preco' => 139.00,
        'avaliacao' => 2,
        'poster' => 'death-stranding.png'
    ],
    [
        'titulo' => 'Jedi Survivor',
        'preco' => 139.00,
        'avaliacao' => 5,
        'poster' => 'jedi-survivor.png'
    ],
    [
        'titulo' => 'Baldur\'s Gate 3',
        'preco' => 290.00,
        'avaliacao' => 3,
        'poster' => 'baldurs-gate-3.jpg'
    ],
    [
        'titulo' => 'Death Stranding',
        'preco' => 139.00,
        'avaliacao' => 2,
        'poster' => 'death-stranding.png'
    ],
    [
        'titulo' => 'Jedi Survivor',
        'preco' => 139.00,
        'avaliacao' => 5,
        'poster' => 'jedi-survivor.png'
    ],
    [
        'titulo' => 'Baldur\'s Gate 3',
        'preco' => 290.00,
        'avaliacao' => 3,
        'poster' => 'baldurs-gate-3.jpg'
    ],
    [
        'titulo' => 'Death Stranding',
        'preco' => 139.00,
        'avaliacao' => 2,
        'poster' => 'death-stranding.png'
    ]
];

/** Acordo de cavaleiros
 * $snake_case -> variaveis
 * $camelCase -> variaveis
 * $kebab-case -> img
 * $PascalCase -> funções, classes
 * 
 * palavra singular -> variaveis, classes, objetos  
 * palavra plural -> arrays, json,
 * 
 */

include './pages/produto.php';