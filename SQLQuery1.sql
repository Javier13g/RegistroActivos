CREATE DATABASE RegistroActivos
USE RegistroActivos
USE master

DROP DATABASE RegistroActivos

CREATE TABLE EMPLEADOS (
ID_Empleado INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Nombre_Empleado VARCHAR(40) NOT NULL,
Apellido_Empleado VARCHAR(40) NOT NULL,
Cedula VARCHAR(40) NOT NULL,
Direccion VARCHAR (40) NOT NULL,
ID_Usuario INT FOREIGN KEY(ID_Usuario) REFERENCES USUARIOS(ID_Usuario)
);

CREATE TABLE USUARIOS (
ID_Usuario INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Nombre_Usuario VARCHAR(20) NOT NULL,
Contraseña VARCHAR(20) NOT NULL,
Correo VARCHAR(50) NOT NULL,
Cargo VARCHAR(40) NOT NULL,
);

CREATE PROC AgregaUsuarios
@nombre varchar(20),
@password varchar(20),
@correo varchar(50),
@cargo varchar(40)
as
insert into USUARIOS values (@nombre,@password,@correo,@cargo)
go

CREATE PROC EditarUsuarios
@nombre varchar(20),
@password varchar(20),
@correo varchar(50),
@cargo varchar(40),
@id int
as
update USUARIOS set  Nombre_Usuario=@nombre, Contraseña=@password, Correo=@correo,Cargo=@cargo
where ID_Usuario=@id
go

CREATE PROC EliminarUsuarios

@id int
as
delete from USUARIOS where ID_Usuario=@id
go

CREATE PROC MostrarUsuario
as
select * from USUARIOS
go
exec MostrarUsuario


insert into USUARIOS values ('Javier13g','lospepe15','cuevasjavier52@gmail.com','Administrador')
insert into USUARIOS values ('YariOC','lospepe15','ferrerasmyari@gmail.com','Administrador')

insert into USUARIOS values ('Javixo','lospepe15','cuevasjavier53@gmail.com','Empleado')

select * from USUARIOS


select *from USUARIOS where Nombre_Usuario='Javier13g' and Contraseña='lospepe15'

declare @usuario VARCHAR(20) ='Javier13g'
declare @contraseña VARCHAR(20) ='lospepe15'
select * from USUARIOS where Nombre_Usuario=@user or Correo=@email
select *from USUARIOS where Nombre_Usuario=@usuario and Contrase�a=@contrase�a


CREATE TABLE ACTIVOS (
ID_Activo INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
ID_Terreno INT FOREIGN KEY(ID_Terreno) REFERENCES TERRENOS(ID_Terreno) ,
ID_Vehiculo INT FOREIGN KEY(ID_Vehiculo) REFERENCES VEHICULOS(ID_Vehiculo) ,
ID_Edificacion INT FOREIGN KEY(ID_Edificacion) REFERENCES EDIFICACIONES(ID_Edificacion) ,
ID_Maquinaria INT FOREIGN KEY(ID_Maquinaria) REFERENCES MAQUINARIA(ID_Maquinaria) ,
ID_Patente INT FOREIGN KEY(ID_Patente) REFERENCES PATENTE(ID_Patente) 
);

SELECT * FROM ACTIVOS

CREATE TABLE TERRENOS (
ID_Terreno INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Tamaño DECIMAL (20,2) NOT NULL,
Matricula_Titulo  VARCHAR(13) NOT NULL,
Designacion_catastral VARCHAR(13) NOT NULL,
Latitud DOUBLE PRECISION not null,
Longitud DOUBLE PRECISION not null,
Provincia VARCHAR (25) NOT NULL,
Valor DECIMAL (38,2) NOT NULL,
Tipo_Activo VARCHAR(12) NOT NULL
);

insert into TERRENOS values (100.15,'13g4sfd4','123acFjv', 19.20561, -69.33685, 'Samana', 155.52,'Tangible')
insert into TERRENOS values (100.15,'13g4sfd4','123acFjv', 19.84826, -71.64597, 'Monte Cristi', 155.52,'Tangible')
 drop table TERRENOS
SELECT SUM(Valor) AS ValorTerrenos FROM TERRENOS;
SELECT * from TERRENOS

CREATE PROC AgregarTerreno
@tamaño decimal(20,2),
@matricula varchar(13),
@catastral varchar(13),
@latitud double PRECISION,
@longitud DOUBLE PRECISION,
@provincia varchar(25),
@valor decimal(38,2),
@tipo varchar(23)
as
insert into TERRENOS values (@tamaño,@matricula,@catastral,@latitud,@longitud,@provincia,@valor,@tipo)
go

drop PROCEDURE EditarTerreno
CREATE PROC EditarTerreno
@tamaño decimal(20,2),
@matricula varchar(13),
@catastral varchar(13),
@latitud double PRECISION,
@longitud DOUBLE PRECISION,
@provincia varchar(25),
@valor decimal(38,2),
@tipo varchar(23),
@id int
as
update TERRENOS set Tamaño=@tamaño, Matricula_Titulo=@matricula, 
Designacion_catastral=@catastral, Latitud=@latitud, Longitud=@longitud,
Provincia=@provincia,Valor=@valor, Tipo_Activo=@tipo
where ID_Terreno=@id
go

CREATE PROC EliminarTerreno

@id int
as
delete from TERRENOS where ID_Terreno=@id
go
exec AgregarTerrenos 157.35,'ab52F45rt','AFk135MVN', 73598.57, 'Tangible'
exec EditarTerreno 157.35,'ab52F45rt','123jajaja', 73598.57, 'Tangible',1
DROP TABLE TERRENOS
DROP TABLE ACTIVOS

insert into TERRENOS values (100.15,'13g4sfd4','123acFjv', 15000, 'Tangible')
select * from TERRENOS

select count(*) as Cantidad_Terrenos
  from TERRENOS



CREATE PROC MostrarTerrenos
as
select * from TERRENOS
go
exec MostrarTerrenos


CREATE TABLE VEHICULOS (
ID_Vehiculo INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Marca  VARCHAR(20) NOT NULL,
Modelo VARCHAR(13) NOT NULL,
Año VARCHAR(5) NOT NULL,
Matricula varchar(15) NOT NULL,
Tipo  VARCHAR(13) NOT NULL,
Tipo2 VARCHAR(13) NOT NULL,
Color VARCHAR(13) NOT NULL,
Combustible  VARCHAR(12) NOT NULL,
Valor float NOT NULL,
Tipo_Activo VARCHAR(12) NOT NULL
);

drop TABLE VEHICULOS
drop PROCEDURE EditarVehiculos
CREATE PROC AgregarVehiculos
@marca varchar(20),
@modelo varchar(13),
@year varchar(13),
@matricula varchar(15),
@tipo varchar(23),
@tipo2 varchar(13),
@color varchar(13),
@combustible varchar(12),
@valor float,
@tipoActivo varchar(12)
as
insert into VEHICULOS values (@marca,@modelo,@year,@matricula,@tipo,@tipo2,@color,@combustible,@valor,@tipoActivo)
go

drop PROCEDURE EditarVehiculos
CREATE PROC EditarVehiculos
@marca varchar(20),
@modelo varchar(13),
@year varchar(13),
@matricula varchar(15),
@tipo varchar(23),
@tipo2 varchar(13),
@color varchar(13),
@combustible varchar(12),
@valor float,
@tipoActivo varchar(12),
@id int
as
update VEHICULOS set Marca=@marca, Modelo=@modelo,Año=@year,Matricula=@matricula, Tipo=@tipo,
Tipo2=@tipo2,Color=@color, Combustible=@combustible, Valor=@valor, Tipo_Activo=@tipoActivo
where ID_Vehiculo=@id
go

CREATE PROC EliminarVehiculo

@id int
as
delete from VEHICULOS where ID_Vehiculo=@id
go
DROP TABLE VEHICULOS
DROP TABLE ACTIVOS

insert into VEHICULOS values ('Honda','Civic','2001','Automatico', 'Gasolina',1500,'Tangible')

CREATE PROC MostrarVehiculos
as
select * from VEHICULOS
go
exec MostrarVehiculos
select count(*) as Cantidad_Vehiculos from VEHICULOS

DROP TABLE EDIFICACIONES
CREATE TABLE EDIFICACIONES (
ID_Edificacion INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Tamaño DECIMAL (20,2) NOT NULL,
Latitud DOUBLE PRECISION NOT NULL,
Longitud DOUBLE PRECISION NOT NULL,
Valor float NOT NULL,
Tipo_Activo VARCHAR(12) NOT NULL
)

 CREATE PROC AgregarEdificacion
@tamaño decimal(20,2),
@latitud DOUBLE PRECISION,
@longitud DOUBLE PRECISION,
@valor float,
@tipo varchar(12)
as
insert into EDIFICACIONES values (@tamaño,@latitud,@longitud,@valor,@tipo)
go

CREATE PROC EditarEdificios
@tamaño decimal(20,2),
@latitud DOUBLE PRECISION,
@longitud DOUBLE PRECISION,
@valor float,
@tipo varchar(12),
@id int
as
update EDIFICACIONES set Tamaño=@tamaño,Latitud=@latitud,Longitud=@longitud, Valor=@valor,Tipo_Activo=@tipo
where ID_Edificacion=@id
go

CREATE PROC EliminarEdificacion

@id int
as
delete from EDIFICACIONES where ID_Edificacion=@id
go
DROP TABLE EDIFICACIONES
DROP TABLE ACTIVOS

insert into EDIFICACIONES values (1580.84, 489586,'Tangible')

CREATE PROC MostrarEdificacion
as
select * from EDIFICACIONES
go
exec MostrarEdificacion



CREATE TABLE MAQUINARIA (
ID_Maquinaria INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Tipo_Maquinaria VARCHAR(20) NOT NULL,
Valor float NOT NULL,
Tipo_Activo VARCHAR(12) NOT NULL,
Matricula VARCHAR(12) NOT NULL,
Descripcion VARCHAR(100)
)
SELECT * FROM MAQUINARIA
DROP TABLE ACTIVOS

drop PROCEDURE EditarMaquinaria
CREATE PROC EditarMaquinaria
@tipoM varchar(20),
@valor float,
@tipo varchar(12),
@id int,
@matricula VARCHAR(12),
@descripcion VARCHAR(100)
as
update MAQUINARIA set Tipo_Maquinaria=@tipoM, Valor=@valor,Tipo_Activo=@tipo,Matricula=@matricula,Descripcion=@descripcion
where ID_Maquinaria=@id
go

CREATE PROC EliminarMaquinaria

@id int
as
delete from MAQUINARIA where ID_Maquinaria=@id
go
insert into MAQUINARIA values ('Trituradora',1580,'Tangible')

CREATE PROC MostrarMaquinaria
as
select * from MAQUINARIA
go
exec MostrarMaquinaria

drop PROCEDURE AgregarMaquinaria
CREATE PROC AgregaMaquinaria
@tipoM varchar(20),
@valor float,
@tipo varchar(12),
@matricula VARCHAR(12),
@descripcion VARCHAR(100)
as
insert into MAQUINARIA values (@tipoM,@valor,@tipo,@matricula,@descripcion)
go


CREATE TABLE PATENTE (
ID_Patente INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Nombre VARCHAR(20) NOT NULL,
Descripcion VARCHAR(100) NOT NULL,
Valor FLOAT NOT NULL,
Tipo_Activo VARCHAR(12) NOT NULL
)
DROP TABLE PATENTE
DROP TABLE ACTIVOS

insert into PATENTE values ('Rayos X','Patente capaz de ver a traves del cuerpo humano'
,8750,'intangible')

CREATE PROC MostrarPatente
as
select * from PATENTE
go
exec MostrarMaquinaria

CREATE PROC AgregaPantentes
@nombre varchar(20),
@descripcion varchar(100),
@valor float,
@tipo varchar(12)
as
insert into PATENTE values (@nombre,@descripcion,@valor,@tipo)
go

CREATE PROC EditarPatentes
@nombre varchar(20),
@descripcion varchar(100),
@valor float,
@tipo varchar(12),
@id int
as
update PATENTE set  Nombre=@nombre, Descripción=@descripcion, Valor=@valor,Tipo_Activo=@tipo
where ID_Patente=@id
go

CREATE PROC EliminarPatente

@id int
as
delete from PATENTE where ID_Patente=@id
go