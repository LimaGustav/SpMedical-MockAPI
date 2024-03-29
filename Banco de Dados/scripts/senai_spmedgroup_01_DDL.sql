CREATE DATABASE SP_MEDICAL
GO

USE SP_MEDICAL
GO

-- TABELA CLINICA 
CREATE TABLE CLINICA (
	idClinica SMALLINT PRIMARY KEY IDENTITY,
	nomeFantasia VARCHAR (55) DEFAULT 'NOME FANTASIA N�O CADASTRADO',
	cnpj VARCHAR (18) NOT NULL UNIQUE,
	razaoSocial VARCHAR (200) NOT NULL,
	endereco VARCHAR (250) NOT NULL,
	telefone VARCHAR (15) UNIQUE,
	email VARCHAR (255) NOT NULL UNIQUE,
);
GO

-- TABELA ESPECIALIDADE
CREATE TABLE ESPECIALIDADE (
	idEspecialidade TINYINT PRIMARY KEY IDENTITY,
	nomeEspecialidade VARCHAR (100) NOT NULL UNIQUE
);
GO

-- TABELA TIPOUSUARIO
CREATE TABLE TIPOUSUARIO (
	idTipoUsuario TINYINT PRIMARY KEY IDENTITY,
	nomeTipoUsuario VARCHAR (50) NOT NULL UNIQUE,
);
GO

-- TABELA SITUACAO
CREATE TABLE SITUACAO (
	idSituacao TINYINT PRIMARY KEY IDENTITY,
	nomeSituacao VARCHAR (40) NOT NULL UNIQUE
);
GO

-- TABELA USUARIO
CREATE TABLE USUARIO (
	idUsuario INT PRIMARY KEY IDENTITY,
	idTipoUsuario TINYINT FOREIGN KEY REFERENCES TIPOUSUARIO (idTipoUsuario),
	nomeUsuario VARCHAR (200),
	email VARCHAR (255) NOT NULL UNIQUE,
	senha VARCHAR (100) CHECK(len(senha) >= 8) NOT NULL,
);
GO


-- TABELA MEDICO
CREATE TABLE MEDICO (
	idMedico SMALLINT PRIMARY KEY IDENTITY,
	idUsuario INT FOREIGN KEY REFERENCES USUARIO (idUsuario),
	idClinica SMALLINT FOREIGN KEY REFERENCES CLINICA (idClinica),
	idEspecialidade	TINYINT FOREIGN KEY REFERENCES ESPECIALIDADE (idEspecialidade),
	crm VARCHAR (10) NOT NULL UNIQUE,
	nomeMedico VARCHAR(100) DEFAULT 'DR N�O CADASTRADO',
);
GO

-- TABELA PACIENTE
CREATE TABLE PACIENTE (
	idPaciente INT PRIMARY KEY IDENTITY,
	idUsuario INT FOREIGN KEY REFERENCES USUARIO (idUsuario),
	dataNascimento SMALLDATETIME NOT NULL,
	nomePaciente VARCHAR(100) DEFAULT 'NOME N�O DECLARADO',
	telefone VARCHAR(30) DEFAULT 'TELEFONE N�O CADASTRADO',
	rg CHAR(10) NOT NULL UNIQUE,
	cpf CHAR(11) NOT NULL UNIQUE,
	endereco VARCHAR(250) NOT NULL
);
GO

-- TABELA CONSULTA
CREATE TABLE CONSULTA (
	idConsulta BIGINT PRIMARY KEY IDENTITY,
	idSituacao TINYINT FOREIGN KEY REFERENCES SITUACAO (idSituacao),
	idPaciente INT FOREIGN KEY REFERENCES PACIENTE (idPaciente),
	idMedico SMALLINT FOREIGN KEY REFERENCES MEDICO (idMedico),
	dataConsulta DATETIME NOT NULL,
	descricao VARCHAR(300) DEFAULT 'Consulta sem descri��o'
);
GO


-- TABELA FOTOPERFIL
CREATE TABLE FOTOPERFIL (
	idFotoPerfil INT PRIMARY KEY IDENTITY,
	idUsuario INT FOREIGN KEY REFERENCES USUARIO(idUsuario),
	nomeArquivo VARCHAR(150) UNIQUE 
);
GO