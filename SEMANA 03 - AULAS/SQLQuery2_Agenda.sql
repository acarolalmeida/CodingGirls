CREATE TABLE Contato (
	id int identity(1,1) primary key,
	nome varchar(100),
	email_principal varchar(100),
	apelido varchar(100),
	sexo char
)

CREATE TABLE Usu�rio (
	id int identity(1,1) primary key,
	nome varchar(100),
	idade int
)