-- Início da criação da database 'M01S07EX01'
-- Conectar na database MASTER para o teste abaixo
-- USE master
-- GO

-- -- Criação da database caso não exista
-- IF NOT EXISTS
-- (
--     SELECT name
-- FROM sys.databases
-- WHERE name = N'M01S07EX01'
-- )
-- CREATE DATABASE M01S07EX01
-- GO

-- -- Sempre lembrar de utilizar o database correto
USE M01S07EX01;
GO

-- -- Criação das tabelas necessárias para a Select do exercício proposto
-- CREATE TABLE Tabela_A
-- (
--     nome VARCHAR(50) PRIMARY KEY,
-- )

-- CREATE TABLE Tabela_B
-- (
--     nome VARCHAR(50) PRIMARY KEY,
-- )
-- GO

-- Inserir valores que serão utilizados no exercício
-- INSERT INTO Tabela_A
--     (nome)
-- VALUES
--     ('Fernanda'),
--     ('Josefa'),
--     ('Luiz'),
--     ('Fernando');

-- INSERT INTO Tabela_B
--     (nome)
-- VALUES
--     ('Carlos'),
--     ('Manoel'),
--     ('Luiz'),
--     ('Fernando');
-- GO

-- TODO
-- Select para exibir em ordem alfabética e sem repetir os nomes
SELECT *
FROM
    Tabela_A, Tabela_B
GROUP BY
    Tabela_A.nome, Tabela_B.nome
GO
