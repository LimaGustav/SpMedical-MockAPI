USE SP_MEDICAL
GO
-- Mostrar a quantidade de usu�rios ap�s realizar a importa��o do banco de dados
SELECT COUNT(*) 'N�mero de usu�rios cadastrados' FROM USUARIO
GO

-- Converter a data de nascimento do usu�rio para o formato (mm-dd-yyyy) na exibi��o
SELECT nomePaciente Paciente, Convert(varchar,dataNascimento, 105) 'Data de Nascimento' FROM PACIENTE
GO

-- Calcular a idade do usu�rio a partir da data de nascimento
SELECT nomePaciente Paciente, DATEDIFF(YEAR,dataNascimento,GETDATE()) Idade FROM PACIENTE
GO

SELECT	idConsulta,
		dataConsulta [Data da Consulta],
		nomePaciente Paciente,
		nomeUsuario [Nome de Usu�rio do Paciente],
		nomeMedico [M�dico],
		nomeEspecialidade [Especialidade],
		CLINICA.nomeFantasia [Cl�nica],
		nomeSituacao [Situa��o da Consulta],
		CONSULTA.descricao [Descr��o da Consulta]
FROM CONSULTA
LEFT JOIN SITUACAO
ON CONSULTA.idSituacao = SITUACAO.idSituacao
LEFT JOIN PACIENTE
ON CONSULTA.idPaciente = PACIENTE.idPaciente
LEFT JOIN MEDICO
ON CONSULTA.idMedico = MEDICO.idMedico
LEFT JOIN ESPECIALIDADE
ON MEDICO.idEspecialidade = ESPECIALIDADE.idEspecialidade
LEFT JOIN CLINICA
ON MEDICO.idClinica = CLINICA.idClinica
INNER JOIN USUARIO
ON PACIENTE.idUsuario = USUARIO.idUsuario
GO
