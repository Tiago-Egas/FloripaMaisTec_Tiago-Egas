/* Crie as tabelas necessárias para uma pequena loja de roupas. Os requisitos da loja são: que seja possível cadastrar o nome do produto, o preço, obrigatoriamente maior que 50 reais e o tamanho da roupa. Também será necessário saber detalhes dos pedidos realizados, como os produtos comprados, a data do pedido, forma de pagamento e endereço de entrega. Faça da forma mais eficiente possível usando as boas práticas em banco de dados relacional.
 */

CREATE DATABASE lojinha

CREATE TABLE Produto
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    preco INT NOT NULL CHECK (preco >= 50),
    tamanho VARCHAR(5),
)

CREATE TABLE Pedidos
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    data_pedido DATE NOT NULL,
    forma_pagamento VARCHAR(25) NOT NULL,
    logradouro VARCHAR(60) NOT NULL,
    bairro VARCHAR(30) NOT NULL,
    numero VARCHAR(10) NOT NULL,
    complemento VARCHAR(60) NOT NULL,
    cidade VARCHAR(20) NOT NULL,
    estado VARCHAR(20) NOT NULL,
    cep VARCHAR(9) NOT NULL
)

CREATE TABLE Pedido_Produtos
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    id_produtos INT REFERENCES Produto(id),
    id_pedidos INT REFERENCES Pedidos(id)
)
