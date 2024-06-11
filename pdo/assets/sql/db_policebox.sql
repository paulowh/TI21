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


