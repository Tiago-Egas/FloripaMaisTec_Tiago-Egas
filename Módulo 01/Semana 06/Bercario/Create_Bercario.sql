-- BANCO DE DADOS
-- BERCARIO CRIADO
CREATE DATABASE Bercario;

-- TABELA MAE CRIADA
CREATE TABLE Mae
(
    Id int,
    Endereco varchar(60),
    Telefone varchar(20),
    Data_Nascimento DateTime,
    Primary key (Id)
);

-- TABELA BEBE CRIADA
CREATE TABLE Bebe
(
    Data_Nascimento DateTime,
    Id int,
    Peso_Nascimento decimal(4,2),
    Altura int,
    Id_Mae int,
    Id_Parto int,
    Primary key (Id)
);

-- TABELA PARTO CRIADA
CREATE TABLE Parto
(
    Id int PRIMARY KEY,
    ---o CRM É VARCHAR
    Id_Medico int NOT NULL,
    Data_Parto DateTime NOT NULL,
    Horario_Parto TimeStamp NOT NULL
);

-- TABELA MEDICO CRIADA
CREATE TABLE Medico
(
    --o CRM É VARCHAR
    CRM varchar(15) PRIMARY KEY,
    Nome varchar(60),
    Celular int,
    Especialidade varchar(100)
);

-- IDENTIFICADO QUE A REFERENCIA DE CHAVE NA TABELA MEDICO É DIFERENTE. ATRIBUTO ID_MEDICO ALTERADO
ALTER TABLE dbo.Parto 
ALTER COLUMN Id_Medico VARCHAR(15) NOT NULL;

-- TABELA DE PARTO REMOVIDA
DROP TABLE dbo.Parto;

-- TABELA DE PARTO CRIADA - NOVAMENTE CORRIGIDO ATRIBUTO ID MEDICO
CREATE TABLE Parto
(
    Id int PRIMARY KEY,
    Id_Medico varchar(15) NOT NULL,
    Data_Parto DateTime NOT NULL,
    Horario_Parto TimeStamp NOT NULL
);

-- EXEMPLO COMANDO
-- DROP COLUMN Horario_Parto REMOVIDO
-- ALTER TABLE Parto drop column Horario_Parto;

-- EXEMPLO COMANDO
-- ADD ATRIBUTO HORARIO_PARTO ADICIONADO
-- ALTER TABLE Parto 
-- ADD Horario_Parto TimeStamp NOT NULL;