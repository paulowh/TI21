# UC15-HMTL

Repositório criado durante a trajetoria da turma da TI21
projetos dos alunos:
- [Doces Lunares](https://doceslunares.paulowh.com/) / [Renon](https://github.com/RenonHG), [Erick](https://github.com/erickgusson)
- [Vent'Qui](https://ventqui.paulowh.com/) / [Edilson](https://github.com/Arrowaaa)
- [BuildsBurgues](https://doceslunares.paulowh.com/) / [Guilherme](https://github.com/Guilhlm)
- [iDrink](https://idrink.paulowh.com/adega-idrink/) / [Gustavo](#), [Lucas](#)
- [PC Prevenido](#) / [Richard](#)


## Como clonar através do GIT

1. Baixe e instale o [GIT](https://git-scm.com/)
2. Configure através do CMD o usuario e o e-mail
    ```git
    git config --global user.email "seu@email.com"
    git config --global user.name "seu nome"
    ```
3. Copie o link do repositorio requerido
4. Clone o repositorio pelo CMD
    ```git
    git clone link-repositorio
    ```
5. Após a clonagem abra o repositorio no [VsCode](https://code.visualstudio.com/)

## Como instalar o projeto inicial

1. Crie um banco de dados e configure o arquivo `.env`
    ```env
    HOST=host_banco
    DATABASE=banco
    USER=usuario
    PASSWORD=senha

    SMTP=
    EMAIL=
    EMAILPASSWORD=
    NAME=
    ```
2. Execute o script `./assets/sql/table.sql`
    ```sql
    CREATE TABLE tb_produto (
        id INT AUTO_INCREMENT PRIMARY KEY,
        titulo VARCHAR(150),
        preco DECIMAL(10, 2),
        avaliacao INT,
        imagem VARCHAR(200)
    );

    INSERT INTO tb_produto (titulo, preco, avaliacao, imagem) 
    VALUES 
        ('Star Wars Jedi Survivor', 139.00, 5, 'jedi-survivor.png'),
        ('Baldurs Gate 3', 236.50, 3, 'baldurs-gate-3.jpg'),
        ('Death Stranding', 188.25, 4, 'death-stranding.png'),
        ('Devil May Cry5', 275.80, 2, 'devil-may-cry5.png'),
        ('Ghost of Tshushima', 217.90, 5, 'ghost-of-tshushima.jpg'),
        ('Mirage', 146.70, 1, 'mirage.png'),
        ('Requiem', 194.10, 3, 'requiem.png'),
        ('Valhalla', 163.40, 5, 'valhalla.jpg'),
        ('Wukong', 220.80, 4, 'wukong.png'),
        ('Cult of The Lamb',64.95,5,'cult-of-the-lamb.png'),
        ('Deus Ex: Mankind Divided',124.99,3,'deus-ex-mankind-divided.png'),
        ('Far Cry 6',249.99,4,'far-cry-6.png'),
        ('Hades 2',88.99,4,'hades-2.png'),
        ('Hades',75.45,5,'hades.png'),
        ('Lies of P',249.90,5,'lies-of-p.png'),
        ('The Last of US part I',249.0,3,'the-last-of-us-part-i.png');

    CREATE TABLE tb_tipo (
        id INT PRIMARY KEY AUTO_INCREMENT,
        descricao VARCHAR(255)
    );
    INSERT INTO tb_tipo (descricao) VALUES ('Ação'), ('Aventura'), ('Estratégia'), ('RPG'), ('Ficção');

    CREATE TABLE tb_tipo_produto (
        id INT PRIMARY KEY AUTO_INCREMENT,
        id_produto INT,
        id_tipo INT,
        FOREIGN KEY (id_produto) REFERENCES tb_produto(id),
        FOREIGN KEY (id_tipo) REFERENCES tb_tipo(id)
    );

    -- Star Wars Jedi Survivor
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 1);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (2, 1);

    -- Baldurs Gate 3
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (3, 2);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (4, 2);

    -- Death Stranding
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (2, 3);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (5, 3);

    -- Devil May Cry 5
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 4);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (2, 4);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (4, 4);

    -- Ghost of Tsushima
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 5);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (2, 5);

    -- Mirage
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 6);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (2, 6);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (5, 6);

    -- Requiem
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (2, 7);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (3, 7);

    -- Valhalla
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 8);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (4, 8);

    -- Wukong
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 9);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (5, 9);

    -- Cult of The Lamb
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (3, 10);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (5, 10);

    -- Deus Ex: Mankind Divided
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 11);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (5, 11);

    -- Far Cry 6
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 12);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (2, 12);

    -- Hades 2
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 13);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (2, 13);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (4, 13);

    -- Hades
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 14);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (2, 14);

    -- Lies of P
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 15);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (4, 15);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (5, 15);

    -- The Last of Us Part I
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (1, 16);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (2, 16);
    INSERT INTO tb_tipo_produto (id_tipo, id_produto) VALUE (5, 16);

    CREATE TABLE tb_pessoa (
        id INT PRIMARY KEY AUTO_INCREMENT,
        nome VARCHAR(100),
        ano_nascimento YEAR(4),
        cpf VARCHAR(11),
        telefone_1 VARCHAR(11),
        telefone_2 VARCHAR(11),
        logradouro VARCHAR(150),
        n_casa INT(5),
        bairro VARCHAR(100),
        cidade VARCHAR(100)
    );

    CREATE TABLE tb_usuario (
        id INT PRIMARY KEY AUTO_INCREMENT,
        usuario VARCHAR(100),
        senha VARCHAR(100),
        id_pessoa INT NOT NULL,
        FOREIGN KEY (id_pessoa) REFERENCES tb_pessoa(id)
    );

    INSERT INTO tb_pessoa (nome, ano_nascimento, cpf, telefone_1, telefone_2, logradouro, n_casa, bairro, cidade)
    VALUES
        ('Tony Stark', 1970, '12345678900', '999887766', '998877665', 'Malibu Point, CA', 10880, 'Malibu', 'Los Angeles'),
        ('Peter Parker', 1995, '98765432100', '111222333', NULL, 'Rua Ingram, 20', 3, 'Forest Hills', 'Nova York'),
        ('Steve Rogers', 1918, '45678912300', '444555666', NULL, 'Rua Leaman, 569', 1, 'Brooklyn', 'Nova York'),
        ('Natasha Romanoff', 1984, '65432198700', '777888999', '770077007', 'Rua 48, 4A', 12, 'Brooklyn Heights', 'Nova York');

    INSERT INTO tb_usuario (usuario, senha, id_pessoa)
    VALUES
        ('homemDeFerro', 'jarvis123', 1),
        ('homemAranha', 'teia123', 2),
        ('capitaoAmerica', 'euvouLutar', 3),
        ('viuvaNegra', 'assassinaVermelha', 4);


    INSERT INTO tb_pessoa (nome, ano_nascimento, cpf, telefone_1, telefone_2, logradouro, n_casa, bairro, cidade)
    VALUES
        ('Thor Odinson', 1972, '11122233344', '555666777', NULL, 'Asgard Palace', 1, 'Asgard', 'Asgard'),
        ('Bruce Banner', 1972, '99988877766', '333444555', NULL, '123 Gamma Avenue', 7, 'Culver City', 'Los Angeles');

    INSERT INTO tb_usuario (usuario, senha, id_pessoa)
    VALUES
        ('deusDoTrovao', 'mjolnir123', 5),
        ('hulk', 'smash123', 6);
    ```

3. Baixe e instale o [Composer](https://getcomposer.org/)
4. Instale o pacote do compose
    ```composer
    composer install
    ```
