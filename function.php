<?php

$_ENV = parse_ini_file('.env');
session_start();

function img($caminho)
{
    return './assets/img/' . $caminho;
}

function css($caminho)
{
    return './assets/css/' . $caminho . '.css';
}

function js($caminho)
{
    return './assets/js/' . $caminho;
}

function libs($caminho)
{
    return './assets/libs/' . $caminho;
}

function html($caminho)
{
    return './includes/html/' . $caminho . '.html';
}