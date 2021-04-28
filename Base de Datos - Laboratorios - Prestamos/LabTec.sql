--Creacion de la base de datos LabTec
CREATE DATABASE LabTec
--Borrar la base de datos
DROP DATABASE LabTec
--Usar la base de datos Labtec
USE LabTec
--Creacion de la base de datos
--Creacion del la tabla de Usuario
CREATE TABLE Usuario
(
	ID_Usuario INT NOT NULL PRIMARY KEY,
	Nombre VARCHAR(100),
	Ape_P VARCHAR(20),
	Ape_M VARCHAR(20),
	--Usar la letra M para masculino y F para Femenino
	Genero CHAR NOT NULL, 
	Correo VARCHAR(200),
	--La contraseña no debe pasar los 8 caracteres.
	Clave VARCHAR(10),
	ID_Rol INT NOT NULL,
	--Usar la letra T para indicar que se encuentra activo.
	--Usar la letra F para indicar que se encuentra inactivo
	Estado CHAR NOT NULL,
	--Esta campo sera utilizado para limitar las solicitudes que pueden ser realizadas por el usuario
	--Por default siempre se encontrar en cero
	--El limite de intentos es de 3 veces. Se modifica de forma manual este campo
	ContadorRegistro INT,
	ID_Dep INT NOT NULL,
	FOREIGN KEY(ID_Rol) REFERENCES Rol(ID_Rol),
	FOREIGN KEY(ID_Dep) REFERENCES Departamento(ID_Dep)
);
--Creacion de la tabla Proyector
CREATE TABLE Proyectores
(
	ID_Proyector INT NOT NULL PRIMARY KEY,
	Nombre VARCHAR(30),
	Descripcion VARCHAR(500),
	ID_EstadoProyector INT NOT NULL,
	FOREIGN KEY(ID_EstadoProyector) REFERENCES Estado_Proyector(ID_EstadoProyector)
)
--Creacion de la tabla Laboratorios
CREATE TABLE Laboratorios
(
	ID_Lap INT NOT NULL PRIMARY KEY,
	Nombre VARCHAR(20),
	ID_EstLab INT NOT NULL,
	FOREIGN KEY (ID_EstLab) REFERENCES Estado_Lab(ID_EstLab)
);
--Creacion de la tabla de Prestamos de Laboratorio
CREATE TABLE Prestamo_Lab
(
	ID_PL INT NOT NULL PRIMARY KEY,
	ID_Usuario INT NOT NULL,
	ID_Lap INT NOT NULL,
	Fecha DATE,
	Hora_Entrada TIME,
	Hora_Salida TIME,
	Codigo_Verificacion VARCHAR(20),
	FOREIGN KEY(ID_Usuario) REFERENCES Usuario(ID_Usuario),
	FOREIGN KEY(ID_Lap) REFERENCES Laboratorios(ID_Lap)
);
--Creacion de la tabla de prestamos de proyectores
CREATE TABLE Prestamo_Proyectores
(
	ID_PP INT NOT NULL PRIMARY KEY,
	ID_Usuario INT NOT NULL,
	ID_Proyector INT NOT NULL,
	Fecha DATE,
	Hora_Entrada TIME,
	Hora_Salida TIME,
	Codigo_Verificacion VARCHAR(20),
	FOREIGN KEY(ID_Usuario) REFERENCES Usuario(ID_Usuario),
	FOREIGN KEY(ID_Proyector) REFERENCES Proyectores(ID_Proyector)
);
--Creacion de la tabla de Comentarios
CREATE TABLE Comentarios
(
	I_seq					INT IDENTITY (1,1) NOT NULL,
	ID_Usuario				INT NOT NULL,
	Fecha					DATE,
	FOREIGN KEY(ID_Usuario) REFERENCES Usuario(ID_Usuario),
);

--Creacion de la tabla Rol
CREATE TABLE Rol
(
	ID_Rol INT NOT NULL PRIMARY KEY,
	Nombre VARCHAR(20),
);
--Creacion de la tabla Departamento
CREATE TABLE Departamento
(
	ID_Dep INT NOT NULL PRIMARY KEY,
	Nombre VARCHAR(50),
);
--Creacion de la tabla de Estado de los Proyectores
CREATE TABLE Estado_Proyector
(
	ID_EstadoProyector INT NOT NULL PRIMARY KEY,
	Nombre VARCHAR(20)
);
--Creacion de la tabla de Estado de los Laboratorios
CREATE TABLE Estado_Lab
(
	ID_EstLab INT NOT NULL PRIMARY KEY,
	Nombre VARCHAR(20)
);


