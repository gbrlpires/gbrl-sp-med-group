	SELECT * FROM CLINICAS

	SELECT * FROM ESPECIALIDADES

	SELECT * FROM CONSULTAS

	SELECT * FROM PRONTUARIOS_CONSULTAS

	SELECT * FROM USUARIOS_TIPOS

	SELECT * FROM USUARIOS

	SELECT * FROM PRONTUARIOS

	SELECT * FROM PACIENTES

	SELECT * FROM MEDICOS

	SELECT * FROM PRONTUARIOS_CONSULTAS
	
	--Corrigindo e atualizando Nome de especialidade 'Otorrinolaringologia'
	UPDATE ESPECIALIDADES SET EspecialidadeNome = 'Otorrinolaringologia' WHERE EspecialidadeId = 3

	--Corrigindo e atualizando senha de administrador
	UPDATE USUARIOS SET Senha = 'admin' WHERE UsuarioId = 1