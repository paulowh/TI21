
-- Consulta multipla tb_tipo_produto
SELECT tp.*, p.*, t.descricao 
FROM tb_tipo_produto as tp 
INNER JOIN tb_produto as p ON p.id = tp.id_produto 
INNER JOIN tb_tipo AS t ON t.id =  tp.id_tipo
ORDER BY p.titulo
;

SELECT tp.*, p.id as "id_produto_p", p.*, t.descricao 
FROM tb_tipo_produto as tp 
INNER JOIN tb_produto as p ON p.id = tp.id_produto 
INNER JOIN tb_tipo AS t ON t.id =  tp.id_tipo
ORDER BY p.titulo
;

--Consulta tipo atravez do id do produto
SELECT t.* FROM tb_tipo_produto tp
INNER JOIN tb_tipo t ON t.id = tp.id_tipo
WHERE tp.id_produto = 8
;

--Consulta tipo atravez do id do produto
SELECT p.id, p.titulo, p.preco, p.avaliacao, p.imagem FROM tb_tipo_produto tp
INNER JOIN tb_tipo t ON t.id = tp.id_tipo
INNER JOIN tb_produto p ON p.id = tp.id_produto
WHERE t.descricao = 'Aventura' OR t.descricao = 'Ação'
;
