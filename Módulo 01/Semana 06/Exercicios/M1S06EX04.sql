/* Desenvolva o exercício de acordo com a problemática:
Uma biblioteca deseja manter informações sobre seus livros. Inicialmente, quer armazenar para os livros as seguINTes características: ISBN, título, ano editora e autores deste livro. Para os autores, deseja manter: nome e nacionalidade. Cabe salientar que um autor pode ter vários livros, assim como um livro pode ser escrito por vários autores. Cada livro da biblioteca pertence a uma categoria. A biblioteca deseja manter um cadastro de todas as categorias existentes, com informações como: código da categoria e descrição. Uma categoria pode ter vários livros associados a ela.
 */

CREATE DATABASE M1S06EX04

USE M1S06EX04

CREATE TABLE categoria
(
    id INT identity(1,1) PRIMARY KEY,
    cod_cat VARCHAR (50) NOT NULL,
    descricao VARCHAR (50) NOT NULL
);

CREATE TABLE livros
(
    id INT identity(1,1) PRIMARY KEY,
    isbn VARCHAR (50) NOT NULL,
    titulo VARCHAR (50) NOT NULL,
    editora VARCHAR (50) NOT NULL,
    autor VARCHAR (50) NOT NULL,
    id_categoria INT REFERENCES categoria(id)
);

CREATE TABLE livros
(
    id INT identity(1,1) PRIMARY KEY,
    isbn VARCHAR (50) NOT NULL,
    titulo VARCHAR (50) NOT NULL,
    editora VARCHAR (50) NOT NULL,
    autor VARCHAR (50) NOT NULL,
    id_categoria INT REFERENCES categoria(id)
);