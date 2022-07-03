CREATE TABLE Aluno (
	Id int identity(1,1) primary key NOT NULL,
	Nome varchar(50) NOT NULL,
	DataNascimento date NOT NULL,
	Sexo char NOT NULL,
	TurmaId int foreign key references Turma(Id) NOT NULL,
	TotalFaltas int
)

CREATE TABLE Turma (
	Id int identity(1,1) primary key NOT NULL,
	Nome varchar(20) NOT NULL,
	Ativo bit
)

SELECT * FROM Turma

DELETE FROM Aluno WHERE Id = 2

DROP TABLE Aluno

DROP TABLE Turma