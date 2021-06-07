--Funciones para LabTec
USE LabTec

--Creamos una funcion para verficar si la contraseña y usuario son los mismos
CREATE FUNCTION fn_VerificacionUsuario
(
--Va ha recibir la contraseña y el usuario 
	@ID_usuario INT,
	@Clave VARCHAR(10)
)
--Va ha devolver un resultado en cadana de texto
RETURNS VARCHAR(50)
AS 
BEGIN
	DECLARE @Mensaje VARCHAR(50)
	IF EXISTS((SELECT ID_Rol FROM Usuario WHERE ID_Usuario = @ID_usuario AND Clave = @Clave)) 
		BEGIN
			SELECT @Mensaje = ID_Rol FROM Usuario WHERE ID_Usuario = @ID_usuario AND Clave = @Clave
		END
	ELSE
		BEGIN
			SET @Mensaje = 'No'
		END
	RETURN @Mensaje
END
--Creamos una Funcion para verifica si existe algun laboratorio
CREATE FUNCTION fn_VerificacionLaboratorio
(
--Va ha recibir el Numero del Laboratorio
	@ID_Laboratorio INT
)
--Va ha devolver un resultado en cadana de texto
RETURNS VARCHAR(50)
AS 
BEGIN
	DECLARE @Mensaje VARCHAR(50)
	IF EXISTS((SELECT ID_Lap FROM Laboratorios WHERE ID_Lap = @ID_Laboratorio)) 
		BEGIN
			SET @Mensaje = 'Si'
		END
	ELSE
		BEGIN
			SET @Mensaje = 'No'
		END
	RETURN @Mensaje
END

--Creamos una Funcion para verifica si existe algun laboratorio
CREATE FUNCTION fn_PrestamoVerificacionLaboratorio
(
--Va ha recibir el Numero del Laboratorio
	@ID_Laboratorio INT
)
--Va ha devolver un resultado en cadana de texto
RETURNS VARCHAR(50)
AS 
BEGIN
	DECLARE @Mensaje VARCHAR(50)
	IF EXISTS((SELECT ID_Lap FROM Prestamo_Lab WHERE ID_Lap = @ID_Laboratorio)) 
		BEGIN
			SET @Mensaje = 'Si'
		END
	ELSE
		BEGIN
			SET @Mensaje = 'No'
		END
	RETURN @Mensaje
END

SELECT dbo.fn_PrestamoVerificacionLaboratorio(1000)

SELECT dbo.fn_VerificacionUsuario(17210550,'1234')

CREATE FUNCTION fn_VerificacionCorreo
(
--Va ha recibir la contraseña y el usuario 
	@Correo VARCHAR(50)
)
--Va ha devolver un resultado en cadana de texto
RETURNS VARCHAR(50)
AS 
BEGIN
	DECLARE @Mensaje VARCHAR(50)
	IF EXISTS((SELECT Correo FROM Usuario WHERE Correo = @Correo)) 
		BEGIN
			SET @Mensaje = 'Si'
		END
	ELSE
		BEGIN
			SET @Mensaje = 'No'
		END
	RETURN @Mensaje
END

SELECT dbo.fn_VerificacionCorreo('joel.ortega17@tectijuana.edu.mx')


SELECT dbo.fn_VerificacionUsuario(17210550,123)

CREATE FUNCTION fn_RecuperarClave
(
	@Correo VARCHAR(50)
)
RETURNS INT
AS
BEGIN 
	DECLARE @Clave VARCHAR(50)
	IF EXISTS((SELECT Clave FROM Usuario WHERE Correo = @Correo)) 
		BEGIN
			SELECT @Clave = Clave FROM Usuario WHERE Correo = @Correo
		END
	ELSE
		BEGIN
			SET @Clave = 'No'
		END
	RETURN @Clave
END

CREATE FUNCTION fn_Comentarios
(
	@I_seq INT 
)
RETURNS VARCHAR(50)
AS
BEGIN 
	DECLARE @Mensaje VARCHAR(50)
	IF EXISTS((SELECT * FROM Comentarios WHERE I_seq = @I_seq)) 
		BEGIN
			SET @Mensaje = 'Si'
		END
	ELSE
		BEGIN
			SET @Mensaje = 'No'
		END
	RETURN @Mensaje
END


SELECT dbo.fn_RecuperarClave('joel.ortega17@tectijuana.edu.mx')

SELECT Clave FROM Usuario WHERE Correo = 'joel.ortega17@tectijuana.edu.mx'
SELECT Correo FROM Usuario WHERE ID_Usuario = 17210550
