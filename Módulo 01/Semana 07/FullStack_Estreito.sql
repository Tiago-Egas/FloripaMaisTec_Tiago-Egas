CREATE DATABASE fullstack

USE fullstack

CREATE TABLE estreito
(
    id INT IDENTITY(1,1) CONSTRAINT pk_estreito PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL CHECK (idade >= 18),
    cidade VARCHAR(100),
    ocupacao VARCHAR(100) DEFAULT 'estudante'
)

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Rodrigo Rodrigues', 26, 'Florianópolis', 'Estagiário');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Luis Zielke', 33, 'Florianópolis', 'Analista Fiscal');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Rogério Mattos', 45, 'Gravataí', 'Tecnólogo em Eletrônica');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Djamille Vieira', 38, 'São José', 'Estudante dev Back-
End e FullStack');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Diego Alegre', 26, 'Florianópolis', 'Psicólogo');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Soraia Cunha', 30, 'Florianópolis', 'Analista de Marketing');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Anna Oliveira', 23, 'Florianópolis', 'CX');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Tiago Egas', 32, 'Criciúma', 'Help Desk');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Rafael da Silva Pereira', 31, 'Florianópolis', 'Estagiário Java');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Marcio Oliveira', 42, 'Uruguaiana', 'Eletricista');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Milene Moraes', 22, 'São José', 'Assistente de Remuneração');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Victoria Prado', 26, 'Florianópolis', 'Especialista de Produto');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Guilherme da Costa Alves', 22, 'Florianópolis', 'Estudante');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Fernando Aurelio', 39, 'Florianópolis', 'Empreendedor');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Cesar Telski', 28, 'Florianópolis', 'Produto');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Leonardo Machado', 20, 'São José', 'Aluno do FloripaMaisTec');

INSERT INTO estreito
    (nome, idade, cidade, ocupacao)
values
    ('Bruno Bestetti', 31, 'Florianópolis', 'Estudante');

SELECT *
FROM estreito

INSERT INTO estreito
    (nome, idade, cidade)
VALUES
    ('User', 99, 'Null');