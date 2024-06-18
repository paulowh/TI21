<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Requisição</title>
</head>
<style>
    form{
        display: flex;
        flex-direction: column;
        gap: 15px;
        width: 200px;
    }
</style>
<body>
    <h1>Requisição</h1>
    
    <form action="auxindex.php" method="POST">
        <input type="text" name="user" placeholder="user">
        <input type="text" name="senha" placeholder="senha">
        <input type="submit">
    </form>

</body>
</html>