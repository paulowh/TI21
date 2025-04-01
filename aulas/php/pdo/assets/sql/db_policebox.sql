-- Active: 1718106765918@@127.0.0.1@3306@db_policebox
CREATE TABLE tb_produto (
    id INT AUTO_INCREMENT PRIMARY KEY,
    titulo VARCHAR(150),
    preco DECIMAL(10, 2),
    avaliacao INT,
    imagem VARCHAR(200)
);
 
INSERT INTO tb_produto (titulo, preco, avaliacao, imagem) VALUE ('Star Wars Jedi Survivor', 139.00, 5, 'jedi-survivor.png');
INSERT INTO tb_produto (titulo, preco, avaliacao, imagem) VALUE ('Baldurs Gate 3', 236.50, 3, 'baldurs-gate-3.jpg');
INSERT INTO tb_produto (titulo, preco, avaliacao, imagem) VALUE ('Death Stranding', 188.25, 4, 'death-stranding.png');
INSERT INTO tb_produto (titulo, preco, avaliacao, imagem) VALUE ('Devil May Cry5', 275.80, 2, 'devil-may-cry5.png');
INSERT INTO tb_produto (titulo, preco, avaliacao, imagem) VALUE ('Ghost of Tshushima', 217.90, 5, 'ghost-of-tshushima.jpg');
INSERT INTO tb_produto (titulo, preco, avaliacao, imagem) VALUE ('Mirage', 146.70, 1, 'mirage.png');
INSERT INTO tb_produto (titulo, preco, avaliacao, imagem) VALUE ('Requiem', 194.10, 3, 'requiem.png');
INSERT INTO tb_produto (titulo, preco, avaliacao, imagem) VALUE ('Valhalla', 163.40, 5, 'valhalla.jpg');
INSERT INTO tb_produto (titulo, preco, avaliacao, imagem) VALUE ('Wukong', 220.80, 4, 'wukong.png');

SELECT * FROM tb_produto;

CREATE TABLE tb_tipo (
    id INT PRIMARY KEY AUTO_INCREMENT,
    descricao VARCHAR(255)
);
INSERT INTO tb_tipo (descricao) VALUE ('Ação');
INSERT INTO tb_tipo (descricao) VALUE ('Aventura');
INSERT INTO tb_tipo (descricao) VALUE ('Estratégia');
INSERT INTO tb_tipo (descricao) VALUE ('RPG');
INSERT INTO tb_tipo (descricao) VALUE ('Esportes');

SELECT * FROM tb_tipo;

CREATE TABLE tb_tipo_produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_produto INT,
    id_tipo INT,
    FOREIGN KEY (id_produto) REFERENCES tb_produto(id),
    FOREIGN KEY (id_tipo) REFERENCES tb_tipo(id)
);

SELECT * FROM tb_tipo_produto;


SELECT tp.*, p.id as "id_produtinho", p.*, t.descricao 
FROM tb_tipo_produto as tp 
INNER JOIN tb_produto as p ON p.id = tp.id_produto 
INNER JOIN tb_tipo AS t ON t.id =  tp.id_tipo;