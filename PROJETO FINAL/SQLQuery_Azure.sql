CREATE TABLE Turma (
	Id int identity(1,1) primary key,
	Nome varchar(20) NOT NULL,
	Ativo bit 
)

CREATE TABLE Aluno (
	Id int identity(1,1) primary key,
	Nome varchar(50) NOT NULL,
	DataNascimento date NOT NULL,
	Sexo char NOT NULL,
	TurmaId int foreign key references Turma(Id) NOT NULL,
	TotalFaltas int
)

SELECT * FROM Turma

SELECT * FROM Aluno

DROP TABLE Turma