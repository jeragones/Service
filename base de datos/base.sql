create database services
go
use services

IF object_id('Usuario', 'U') IS NULL
BEGIN  
CREATE TABLE Usuario(
	Nombre varchar(50)not null,
	Usuario varchar(50)not null,
	Contraseña varchar(50)not null,
	Grupo int
	)
end
go

IF object_id('Grupo', 'U') IS NULL
BEGIN  
CREATE TABLE Grupo(
	Id int identity(1,1) not null,
	Nombre varchar(50) not null
	)
end
go


IF object_id('Rol', 'U') IS NULL
BEGIN  
CREATE TABLE Rol(
	Id int identity(1,1) not null,
	Nombre varchar(50) not null
	)
end
go

IF object_id('Usuario_Rol', 'U') IS NULL
BEGIN  
CREATE TABLE Usuario_Rol(
	Id_Rol int not null,
	Nombre_Usuario varchar(50) not null
	)
end


go
alter table Usuario ADD CONSTRAINT PK_Usuario PRIMARY KEY (Usuario) 
go
alter table Grupo ADD CONSTRAINT PK_Grupo PRIMARY KEY (Id)
go 
alter table Rol ADD CONSTRAINT PK_Rol PRIMARY KEY (Id)
go 
alter table Usuario_Rol ADD CONSTRAINT PK_Usuario_Rol PRIMARY KEY (Id_Rol,Nombre_Usuario)
go
go		
ALTER TABLE Usuario_Rol	ADD CONSTRAINT FK_Usuario_Rol FOREIGN KEY (Id_Rol) REFERENCES Rol (Id) ON DELETE CASCADE
go
ALTER TABLE Usuario_Rol	ADD CONSTRAINT FK_Rol_Usuario FOREIGN KEY (Nombre_Usuario) REFERENCES Usuario (Usuario) ON DELETE CASCADE
go
ALTER TABLE Usuario	ADD CONSTRAINT FK_Grupo_Usuario FOREIGN KEY (Grupo) REFERENCES Grupo (Id) ON DELETE CASCADE


