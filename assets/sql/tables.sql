-- Active: 1718968678357@@127.0.0.1@3306@db_policebox

DROP DATABASE db_policebox;
CREATE DATABASE db_policebox;
USE db_policebox;

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

ALTER TABLE tb_produto ADD COLUMN descricao BLOB;
UPDATE tb_produto SET descricao = "A história de Cal Kestis continua em Star Wars Jedi: Survivor™, uma aventura em terceira pessoa na galáxia da Respawn Entertainment, desenvolvida em colaboração com a Lucasfilm Games. Este título de jogo solo guiado pela narrativa começa 5 anos após os eventos de Star Wars Jedi: Fallen Order™, acompanhando a luta cada vez mais desesperada de Cal enquanto a galáxia se torna ainda mais sombria. Empurrado para os limites da galáxia pelo Império, Cal se verá cercado por ameaças novas e conhecidas. Como um dos últimos Cavaleiros Jedi sobreviventes, Cal precisa mostrar seu valor durante o momento mais sombrio da galáxia, mas até onde ele está disposto a ir para proteger a si, sua equipe e o legado da Ordem Jedi?" WHERE id =1;
UPDATE tb_produto SET descricao = "Reúna seu grupo e volte aos Reinos Esquecidos em uma história de amizade e traição, sacrifício e sobrevivência, e tentação pelo poder absoluto. Habilidades misteriosas despertam em você, semeadas por um parasita devorador de mentes no seu cérebro. Resista e faça a escuridão ruir a si mesma, ou aceite a corrupção e torne-se o mal supremo. Dos criadores de Divinity: Original Sin 2, este é um RPG da nova geração situado no mundo de Dungeons and Dragons. Escolha dentre diversas raças e classes de D&D ou assuma o papel de um personagem original com um histórico detalhado. Aventure-se, saqueie, lute e envolva-se em romances ao longo da sua jornada pelos Reinos Esquecidos e além. Jogue solo e escolha seus companheiros com cuidado, ou jogue em grupo com até quatro amigos no multijogador." WHERE id =2;
UPDATE tb_produto SET descricao = "Do lendário diretor Hideo Kojima, surge uma experiência que desafia gêneros, ainda maior em DIRECTOR’S CUT. No futuro, um evento misterioso conhecido como Death Stranding abriu uma passagem entre os vivos e os mortos, resultando em criaturas grotescas do pós-vida andando pelo mundo arruinado, marcado por uma sociedade desolada. Jogando como Sam Bridges, sua missão é entregar esperança à humanidade ao conectar os sobreviventes de uma América devastada. Você conseguirá reunir este mundo destruído, um passo de cada vez? DEATH STRANDING DIRECTOR’S CUT no PC inclui ALTA TAXA DE QUADROS, MODO FOTO e SUPORTE A MONITORES ULTRAWIDE. Também inclui conteúdo crossover da série HALF-LIFE, da Valve Corporation; e de Cyberpunk 2077, da CD Projekt Red. Esteja conectado a jogadores no mundo todo com o Social Strand System™." WHERE id =3;
UPDATE tb_produto SET descricao = "O melhor caçador de demônios está de volta com estilo, no jogo que os fãs de ação estavam esperando. Agora inclui o conteúdo baixável Personagem Jogável: Vergil (também disponível separadamente). Um novo episódio na lendária série de ação, Devil May Cry 5 traz junto sua clássica mistura de ação turbinada com personagens originais de outro mundo e a mais nova tecnologia de jogos Capcom para trazer uma obra de arte de ação e aventura visualmente inovadora" WHERE id =4;
UPDATE tb_produto SET descricao = "Experimente a jornada de Jin Sakai pela primeira vez no PC e desfrute da experiência completa de Ghost of Tsushima na Versão do Diretor. No final do século XIII, o império mongol devastou nações em sua campanha para conquistar o Oriente. A Ilha de Tsushima é tudo que resta entre a ilha principal do Japão e a imensa frota invasora dos mongóis liderada por um general ardiloso e implacável, Khotun Khan. Enquanto a ilha é devastada pela primeira onda de ataques mongóis, surge Jin Sakai, um corajoso guerreiro samurai que é um dos últimos sobreviventes de seu clã. Ele está decidido a fazer o que for preciso, custe o que custar, para proteger seu povo e recuperar seu lar. Para isso, será necessário deixar de lado as tradições que o moldaram como guerreiro e forjar um novo caminho, o do Fantasma, travando uma guerra atípica pela liberdade de Tsushima." WHERE id =5;
UPDATE tb_produto SET descricao = "Descubra uma experiência narrativa de ação-aventura que acompanha a transformação de um jovem rebelde em um Mestre Assassino de destino conflituoso. Conheça um elenco inspirador de personagens que darão forma ao destino de Basim e que talvez sejam mais do que pareçam..." WHERE id =6;
UPDATE tb_produto SET descricao = "No mar distante, uma ilha chama você... Embarque em uma comovente jornada por um cativante mundo brutal distorcido por forças sobrenaturais. Depois que seu lar foi devastado, Amicia e Hugo viajam para o sul, para novas regiões e cidades cheias de vida. Eles tentam começar uma vida nova e controlar a maldição de Hugo. Mas, quando os poderes dele retornam, morte e destruição voltam com uma enxurrada de ratos famintos. Forçados a fugir mais uma vez, os irmãos depositam suas esperanças em uma ilha das profecias que pode conter a chave para salvar Hugo. Descubra o preço pago para salvar aqueles que você ama nesta desesperada luta pela sobrevivência. Ataque nas sombras ou use uma variedade de armas, ferramentas e poderes místicos para superar inimigos e desafios." WHERE id =7;
UPDATE tb_produto SET descricao = "Em Assassin’s Creed® Valhalla, você é Eivor, um guerreiro Viking temível que cresceu em meio a histórias de batalhas e glória. Explore um mundo aberto misterioso e belo que tem como cenário a brutal Idade das Trevas da Inglaterra. Em Assassin’s Creed Valhalla: Dawn of Ragnarök, a expansão mais ambiciosa na história da franquia, Eivor precisa encarar seu destino como Odin, o deus nórdico da batalha e da sabedoria. Use novos poderes divinos e embarque em uma jornada desesperada por um mundo impressionante. Conclua uma saga Viking lendária e salve seu filho do castigo dos deuses. Inclui Forgotten Saga, um novo modo de jogo rogue-lite GRÁTIS para todas as pessoas que jogam Assassin's Creed Valhalla" WHERE id =8;
UPDATE tb_produto SET descricao = "Black Myth: Wukong é um RPG de ação inspirado na mitologia chinesa. A história é baseada em 'Jornada para o Oeste', um dos Quatro Grandes Romances Clássicos da literatura do país. Você assume o papel do Predestinado e tem a responsabilidade de encarar os desafios e as maravilhas do mundo para desvendar a verdade obscura por trás de uma lenda gloriosa do passado.Entre em um reino fascinante repleto de maravilhas e descobertas da antiga mitologia chinesa! No papel principal de Predestinado, você verá cenários de tirar o fôlego do romance clássico 'Jornada para o Oeste' e criará um novo conto épico enquanto se aventura." WHERE id =9;
UPDATE tb_produto SET descricao = "Cult of the Lamb coloca o jogador no papel de um cordeiro possuído, que é salvo da aniquilação por um estranho sinistro e precisa quitar sua dívida recrutando seguidores leais em nome dele. Crie seu próprio culto em uma terra de falsos profetas, aventurando-se por regiões misteriosas e diversas para criar uma comunidade fiel de Seguidores da floresta e para propagar sua Palavra e se tornar o único culto verdadeiro." WHERE id =10;
UPDATE tb_produto SET descricao = "O Ano é 2029, e humanos mecanicamente aprimorados são considerados exilados, vivendo totalmente segregados do resto da sociedade. Agora, o experiente agente disfarçado Adam Jensen é forçado a agir em um mundo intolerante. Armado com um novo arsenal de modernas armas e aprimoramentos, ele deve prosseguir com cautela, escolhendo com cuidado os seus aliados, para desvendar uma enorme conspiração mundial." WHERE id =11;
UPDATE tb_produto SET descricao = "Boas-vindas a Yara, um paraíso tropical que parou no tempo. Antón Castillo, o ditador de Yara, pretende resgatar a glória do seu país a qualquer custo, junto com seu filho, Diego, que é tão sanguinário quanto o pai. Seu governo opressor desencadeou uma revolução. - Jogue como Dani Rojas, que nasceu em Yara e luta na guerrilha revolucionária atual para libertar sua nação. Aproveite o jogo completo, sozinho ou com um amigo no modo cooperativo. - Explore selvas, praias e cidades a pé, a cavalo, ou em uma enorme variedade de veículos incluindo barcos e jet skis enquanto luta contra o regime de Castillo no Far Cry mais extenso já criado. - Sinta a adrenalina do combate com um arsenal de centenas de armas contando com a ajuda de amigos como Chorizo, o cachorro, e Guapo, o jacaré. - Aproveite conteúdos novos e recursos adicionados desde o lançamento, incluindo quatro novas operações especiais, missões de crossover com blockbusters gratuitas, e atualizações pedidas pelos fãs como o Novo Jogo +, Auxílio ao Completista, um modo de dificuldade extra difícil, e quatro novos espaços de carregamento." WHERE id =12;
UPDATE tb_produto SET descricao = "A primeira sequência já desenvolvida pela Supergiant Games aprimora os aspectos mais divinos do roguelike de exploração de masmorras original em uma experiência frenética, totalmente nova e infinitamente rejogável que se baseia no Submundo da mitologia grega, no surgimento da bruxaria e na profunda relação entre eles." WHERE id =13;
UPDATE tb_produto SET descricao = "Hades é um jogo roguelike que combina os melhores aspectos dos títulos da Supergiant aclamados pela crítica, incluindo a ação rápida de Bastion, a rica atmosfera e profundidade de Transistor e a narrativa baseada em personagens de Pyre." WHERE id =14;
UPDATE tb_produto SET descricao = "Você é um títere criado por Geppetto, preso numa teia de mentiras com monstros inimagináveis e figuras pouco confiáveis que ficarão entre você e os eventos no mundo de Lies of P. Uma voz misteriosa desperta você e guia seus passos pela atormentada cidade de Krat — um lugar outrora animado que foi envenenado pela loucura e sede de sangue. Em nosso soulslike, você deve adaptar suas armas e seu personagem para enfrentar horrores incalculáveis, desvendar os segredos insondáveis das elites da cidade e escolher entre confrontar as dificuldades com a verdade ou tecer mentiras para superá-las na jornada para encontrar a si mesmo." WHERE id =15;
UPDATE tb_produto SET descricao = "Para se defender de Infectados e outros sobreviventes humanos, os jogadores usam armas como pistolas, rifles e explosivos caseiros, assim como ataques corpo a corpo com chaves de braço, bastões e canos de metal. Os jogadores também podem entrar em sequências de combate furtivo que incluem perspectiva de câmera em close. Ataques explosivos e com armas podem resultar em decapitação e/ou desmembramento. As cenas exibem atos intensos de violência, incluindo temáticas de suicídio e tortura. Durante o jogo, um personagem faz comentários de tom sexual sobre uma revista adulta, e um personagem jovem ingere bebida alcoólica. Linguagem chula é usada frequentemente nos diálogos." WHERE id =16;


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
