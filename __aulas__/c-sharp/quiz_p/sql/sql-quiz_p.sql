CREATE DATABASE db_quiz_p;

USE db_quiz_p;

CREATE TABLE `tb_perguntas` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`questao` TEXT NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `tb_alternativa` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`respostas` TEXT NOT NULL,
	`id_pergunta` INT NOT NULL,
	PRIMARY KEY (`id`)
);

CREATE TABLE `tb_resposta` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`id_altenativa` INT NOT NULL,
	`id_pergunta` INT NOT NULL,
	PRIMARY KEY (`id`)
);