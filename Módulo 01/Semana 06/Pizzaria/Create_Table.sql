CREATE DATABASE Pizzaria;

CREATE TABLE Massas
(
    Id int PRIMARY KEY,
    NOME VARCHAR (20)
);

CREATE TABLE Bordas
(
    Id int PRIMARY KEY,
    NOME VARCHAR (20)
);

CREATE TABLE Sabores
(
    Id int PRIMARY KEY,
    NOME VARCHAR (20)
);

CREATE TABLE Pizza
(
    Id int PRIMARY KEY,
    Id_Massa VARCHAR (20),
    Id_Bordas VARCHAR (20)
);

CREATE TABLE Pizza_Sabores
(
    Id int PRIMARY KEY,
    Id_Pizza VARCHAR (20),
    Id_Sabores VARCHAR (20)
);

CREATE TABLE Pedido
(
    Id int PRIMARY KEY,
    Id_Pizza VARCHAR (20),
    Id_Status VARCHAR (20),
);

CREATE TABLE Status_Pizza
(
    Id int PRIMARY KEY,
    NOME VARCHAR (20)
);