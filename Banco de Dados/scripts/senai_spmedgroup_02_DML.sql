USE SP_MEDICAL
GO


-- INSERÇÃO DE DADOS (DML)

-- TABELA CLINICA
INSERT INTO CLINICA (nomeFantasia, cnpj, razaoSocial, endereco, telefone, email)
VALUES	('Clinica Porssale','86.400.902/0001-30','SP Medical Group','Av. Barão Limeira, 532, São Paulo, SP','11-25871230','clinicPorssale@spmedicalgroup.com.br');
GO

-- TABELA ESPECIALIDADE
INSERT INTO ESPECIALIDADE (nomeEspecialidade)
VALUES	('Acupuntura'),('Anestesiologia'),
		('Angiologia'),('Cardiologia'),
		('Cirurgia Cardiovascular'),('Cirurgia da Mão'),
		('Cirurgia do Aparelho Digestivo'),('Cirurgia Geral'),
		('Cirurgia Pediátrica'),('Cirurgia Plástica'),
		('Cirurgia Torácica'),('Cirurgia Vascular'),
		('Dermatologia'),('Radioterapia'),
		('Urologia'),('Pediatria'),
		('Psiquiatria')
GO
-- TABELA TIPOUSUARIO
INSERT INTO TIPOUSUARIO (nomeTipoUsuario)
VALUES ('paciente'),('administrador'),('médico')
GO

-- TABELA SITUACAO
INSERT INTO SITUACAO (nomeSituacao)
VALUES ('REALIZADA'),('CANCELADA'),('AGENDADA')
GO

-- TABELA USUARIO
INSERT INTO USUARIO (idTipoUsuario, senha, email, nomeUsuario)
VALUES	(2,'adm12345','adm@email.com','adm'),
		(3,'lemos1234','ricardo.lemos@spmedicalgroup.com.br','lemos'),
		(3,'motivacao123','roberto.possarle@spmedicalgroup.com.br','motivadorporsalle'),
		(3,'helena987','helena.souza@spmedicalgroup.com.br','helena'),
		(1,'ligia1324','ligia@gmail.com','liginha'),
		(1,'alexandre1324','alexandre@gmail.com','alexbrabo'),
		(1,'fernando1324','fernando@gmail.com','ferl2'),
		(1,'henrique1324','henrique@gmail.com','henriq9'),
		(1,'joao1324','joao@hotmail.com','joaobrabo'),
		(1,'bruno1324','bruno@gmail.com','bruninhogamer'),
		(1,'mariana1324','mariana@outlook.com','marianauser')
GO
-- TABELA MEDICO IMPORTADA DO EXCEL

-- TABELA PACIENTE IMPORTADA DO EXCEL

-- TABELA CONSULTA IMPORTADA DO EXCEL

-- RESETAR A CONTAGEM DOS IDS DE UMA TABELA --
--DBCC CHECKIDENT ('[TestTable]', RESEED, 0);
--GO
