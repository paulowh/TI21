
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
    id_pessoa INT NOT NULL
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
