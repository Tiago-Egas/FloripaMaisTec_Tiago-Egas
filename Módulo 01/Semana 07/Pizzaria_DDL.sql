-- CREATE DATABASE Pizzaria; >> já criado através do SQLCMD

USE Pizzaria;

CREATE TABLE Massas
(
    id INT identity(1,1) PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE Bordas
(
    id INT identity(1,1),
    nome VARCHAR(50) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE Status
(
    id INT identity(1,1),
    nome VARCHAR(50) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE Pizza
(
    id INT identity(1,1) PRIMARY KEY,
    id_massas INT NOT NULL REFERENCES Massas(id),
    id_Bordas INT NOT NULL REFERENCES Bordas(id)
)
