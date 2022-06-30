CREATE TABLE Pessoa
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,
);

CREATE TABLE Emprego
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nome_Empresa VARCHAR(50) NOT NULL,
	Cargo VARCHAR(50) NOT NULL,
	Pessoa_Id INT FOREIGN KEY REFERENCES Pessoa(Id),
);

-- DDL - DATA DEFINITION LANGUAGE
-- DML - DATA MANIPULATION LANGUAGE

INSERT INTO Pessoa (Nome) VALUES ('Ana Carolina');
INSERT INTO Pessoa (Nome) VALUES ('Gabriela');
INSERT INTO Pessoa (Nome) VALUES ('João');

INSERT INTO Emprego (Nome_Empresa, Cargo, Pessoa_Id) VALUES ('Blue EdTech', 'Professor', 1);

SELECT * FROM Pessoa; 
-- SELECT 'O nome da pessoa é: '+ Nome FROM Pessoa;
-- SELECT Id, Nome FROM Pessoa;
-- SELECT Id, Nome, Nome FROM Pessoa:
-- SELECT Id, 'O nome da pessoa é: ' + Nome AS 'Nome Interpolado' FROM Pessoa;
-- SELECT CAST(Id AS VARCHAR) + Nome FROM Pessoa;

SELECT * FROM Emprego;

-- OPERADORES LÓGICOS >> "AND" E "OR"
-- C#: "&&" OU "||"

SELECT * FROM Pessoa WHERE Id = 1 OR Id = 2;
SELECT * FROM Pessoa WHERE Id > 1;
SELECT * FROM Pessoa WHERE Nome = 'João';
SELECT * FROM Pessoa WHERE Nome LIKE '%Ana%';

-- %a retorna os nomes que terminam com A
-- a% retorna os nomes que começam com A

SELECT * FROM Pessoa WHERE Id BETWEEN 1 AND 4;
SELECT * FROM Pessoa WHERE Nome NOT LIKE '%a%';

-- ORDENAR DE FORMA ASCENDENTE
SELECT * FROM Pessoa ORDER BY Nome ASC;

-- ORDENAR DE FORMA DESCENDENTE 
SELECT * FROM Pessoa ORDER BY Nome DESC;
SELECT * FROM Pessoa WHERE Id >= 1 ORDER BY Nome DESC;

-- FUNÇÕES DE AGREGAÇÃO
SELECT COUNT(*) FROM Pessoa;
SELECT SUM(Id) FROM Pessoa;

UPDATE Pessoa SET Nome = 'Lucas' WHERE Id = 4;
UPDATE Emprego SET Nome_Empresa = 'RDI', Cargo = 'Desenvolvedora' WHERE Id = 1;

DELETE FROM Pessoa WHERE Id = 5 OR Id = 6;

-- EXERCÍCIO

-- INSERIR 3 PRODUTOS
-- NOME= Chaveiro, VALOR= 10, QUANTIDADE= 100
-- NOME= Chinelo, VALOR= 50.99, QUANTIDADE= 14
-- NOME= Travesseiro, VALOR= 99.99, QUANTIDADE= 50

-- DEPOIS

-- GERAR O COMANDO PARA 
-- SIMULAR UMA VENDA DE UM TRAVESSEIRO ENTÃO, DEVE DIMINUIR EM 1
-- A QUANTIDADE TOTAL DO TRAVESSEIRO
-- Quantidade=Quantidade-1
-- não esquecer do WHERE

CREATE TABLE Produto
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Descricao VARCHAR(50) NOT NULL,
	Valor DECIMAL(10,2) NOT NULL,
	Quantidade INT NOT NULL
);

INSERT INTO Produto (Descricao, Valor, Quantidade) VALUES ('Chaveiro', 10, 100);
INSERT INTO Produto (Descricao, Valor, Quantidade) VALUES ('Chinelo', 50.99, 14);
INSERT INTO Produto (Descricao, Valor, Quantidade) VALUES ('Travesseiro', 99.99, 50);

SELECT * FROM Produto

UPDATE Produto SET Quantidade = Quantidade - 1 WHERE Id = 3 AND Descricao = 'Travesseiro';

-- INNER JOIN PARA UNIFICAR 2 TABELAS

SELECT * FROM Pessoa INNER JOIN Emprego ON Emprego.Pessoa_Id = Pessoa.Id;