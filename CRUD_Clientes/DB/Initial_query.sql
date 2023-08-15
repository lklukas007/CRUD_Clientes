-- Usar a master para validar se o banco de dados já existe:
USE master
GO
-- Valida se banco dados já existe, caso não exista, ele cria:
IF NOT EXISTS(
SELECT name  
FROM sys.databases
WHERE name = 'CRUD_CLIENTES'
)
BEGIN
CREATE DATABASE CRUD_CLIENTES
END

GO
-- Mudar para o banco de dados criado:
USE CRUD_CLIENTES

-- Criar tabela de Gêneros:
CREATE TABLE Genero(
 Codigo INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
 Descricao VARCHAR(255) NOT NULL
)

GO

-- Criar tabela de Clientes:
CREATE TABLE Clientes(
 Codigo INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
 Nome VARCHAR(255) NOT NULL,
 Sobrenome VARCHAR(255),
 Datanascimento DATE,
 Endereco VARCHAR(255),
 Numero_Endereco VARCHAR(50),
 Codigo_Genero INT FOREIGN KEY REFERENCES Genero(Codigo)
)

-- Inserção dos gêneros na tabela Genero:
INSERT INTO Genero (Descricao) VALUES ('Feminino');
INSERT INTO Genero (Descricao) VALUES ('Masculino');
INSERT INTO Genero (Descricao) VALUES ('Outro');