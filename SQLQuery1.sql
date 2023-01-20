use master
go
/*
Especificar mis archivos donde se va a alojar sin la necesidad del sistema
y la ubicacion del mismo
*/
-------------------------------------------------------BASE DE DATOS-------------------------------------------------
CREATE DATABASE DBSYSVENBOD 
on primary 
(name='prueba', filename= 'E:\UNEMI\8 semestre\INTEGRACION CURRICULAR\DB\prueba.mdf', 
size=200mb, maxsize=5000mb, filegrowth=25%) 
log on 
(name='pruebalog', filename='E:\UNEMI\8 semestre\INTEGRACION CURRICULAR\DB\pruebalog.ldf', 
size=100mb, maxsize=1000mb, filegrowth=25%)
go

use DBSYSVENBOD
go

-------------------------------------------------------TABLAS-------------------------------------------------
--CREAR LAS TABLAS NECESARIAS
--TABLA DE PRODUCTO
create table Productos
(
	ID_Producto int identity(1,1) primary key not null,
	Codigo varchar(15) not null,
	Nombre varchar(50) not null,
	Descripcion varchar(100) not null,
	Presentacion varchar(10) not null,
	Costo_Unitario decimal(10,2) not null,
	Precio_venta decimal(10,2) not null,
	Tipo_Cargo varchar(10) not null
)
go

--TABLA DE INVENTARIO
create table Inventarios
(
	ID_Inventario int not null,
	Codigo varchar(15) not null,
	Nombre varchar(50) not null,
	Cantidad int not null,
	Costo_Unitario decimal(10,2) not null,
	Precio_venta decimal(10,2) not null,
	Monto_Total decimal(10,2) not null,
	Tipo_Cargo varchar(10) not null
)
go

--TABLA DE PROVEEDORES
create table Proveedores
(
	ID_Proveedor int identity(1,1) primary key not null,
	Codigo varchar(15) not null,
	Nombre varchar(50) not null,
	RUC_Proveedor varchar(13) not null,
	Direccion varchar(150) not null,
	Telefono varchar(15) not null,
	Email varchar(50) not null,
)
go
--TABLA DE CLIENTES
create table Clientes
(
	ID_Cliente int identity(1,1) primary key not null,
	Codigo varchar(15) not null,
	Nombre varchar(50) not null,
	RUC_Cliente varchar(13) not null,
	Direccion varchar(150) not null,
	Telefono varchar(15) not null,
	Email varchar(50) not null,
	Estado varchar(10) not null,
)
go

--TABLA DE EMPRESA
create table Empresas
(
	ID_Empresa int identity(1,1) primary key not null,
	Nombre varchar(60) not null,
	RUC_Empresa varchar(13) not null,
	Direccion varchar(150) not null,
	Telefono varchar(15) not null,
	Email varchar(50) not null,
	Logo image not null,
)
go













-------------------------------------------------------PROCEDURE-------------------------------------------------
--DONDE ENCONTRAR LUEGO DE SER CREADOS, ESTAN EN LA CARPETA DE "PROGRAMMABILITY" - "STORED PROCEDURES"


--*********************************PRODUCTO******************************
--Crear Producto
create proc AgregarProducto
@Codigo varchar(15),
@Nombre varchar(50),
@Descripcion varchar(100),
@Presentacion varchar(10),
@Costo_Unitario decimal(10,2),
@Precio_venta decimal(10,2),
@Tipo_Cargo varchar(10)
as
Insert into Productos(Codigo,Nombre,Descripcion,Presentacion,Costo_Unitario,Precio_venta,Tipo_Cargo)
values(@Codigo,@Nombre,@Descripcion,@Presentacion,@Costo_Unitario,@Precio_venta,@Tipo_Cargo)
go

--editar Producto
create proc EditarProducto
@ID_Producto int,
@Codigo varchar(15),
@Nombre varchar(50),
@Descripcion varchar(100),
@Presentacion varchar(10),
@Costo_Unitario decimal(10,2),
@Precio_Venta decimal(10,2),
@Tipo_Cargo varchar(10)
as
update Productos set Codigo=@Codigo, Nombre=@Nombre,Descripcion=@Descripcion,
Presentacion=@Presentacion,Costo_Unitario=@Costo_Unitario,
Precio_venta=@Precio_venta,Tipo_Cargo=@Tipo_Cargo where ID_Producto=@ID_Producto
go

--eliminar Producto
create proc EliminarProducto
@ID_Producto int
as
delete from Productos where ID_Producto=@ID_Producto
go

--************************************PROVEEDOR**************************
--Crear Proveedor
create proc AgregarProveedor
@Codigo varchar(15),
@Nombre varchar(50),
@RUC_Proveedor varchar(13),
@Direccion varchar(150) ,
@Telefono varchar(15),
@Email varchar(50)
as
Insert into Proveedores(Codigo,Nombre,RUC_Proveedor,Direccion,Telefono,Email)
values(@Codigo,@Nombre,@RUC_Proveedor,@Direccion,@Telefono,@Email)
go

--editar Proveedor
create proc EditarProveedor
@ID_Proveedor int,
@Codigo varchar(15),
@Nombre varchar(50),
@RUC_Proveedor varchar(13),
@Direccion varchar(150) ,
@Telefono varchar(15),
@Email varchar(50)
as
update Proveedores set Codigo=@Codigo, Nombre=@Nombre,RUC_Proveedor=@RUC_Proveedor,
Direccion=@Direccion,Telefono=@Telefono,Email=@Email where ID_Proveedor=@ID_Proveedor
go

--eliminar Proveedor 
create proc EliminarProveedores
@ID_Proveedor int
as
delete from Proveedores where ID_Proveedor=@ID_Proveedor
go

--************************************CLIENTE**************************
--Crear Cliente
create proc AgregarCliente
@Codigo varchar(15),
@Nombre varchar(50),
@RUC_Cliente varchar(13),
@Direccion varchar(150) ,
@Telefono varchar(15),
@Email varchar(50),
@Estado varchar(10)
as
Insert into Clientes(Codigo,Nombre,RUC_Cliente,Direccion,Telefono,Email,Estado)
values(@Codigo,@Nombre,@RUC_Cliente,@Direccion,@Telefono,@Email,@Estado)
go

--editar Cliente
create proc EditarCliente
@ID_Cliente int,
@Codigo varchar(15),
@Nombre varchar(50),
@RUC_Cliente varchar(13),
@Direccion varchar(150) ,
@Telefono varchar(15),
@Email varchar(50),
@Estado varchar(10)
as
update Clientes set Codigo=@Codigo, Nombre=@Nombre,RUC_Cliente=@RUC_Cliente,
Direccion=@Direccion,Telefono=@Telefono,Email=@Email, Estado=@Estado 
where ID_Cliente=@ID_Cliente
go

--eliminar Cliente
create proc EliminarCliente
@ID_Cliente int
as
delete from Clientes where ID_Cliente=@ID_Cliente
go

--************************************EMPRESA**************************
--Crear Empresa

create proc AgregarEmpresa
@Nombre varchar(60),
@RUC_Empresa varchar(13),
@Direccion varchar(150) ,
@Telefono varchar(15),
@Email varchar(50),
@Logo image
as
Insert into Empresas(Nombre,RUC_Empresa,Direccion,Telefono,Email,Logo)
values(@Nombre,@RUC_Empresa,@Direccion,@Telefono,@Email,@Logo)
go

--editar Proveedor
create proc EditarEmpresa
@ID_Empresa int,
@Nombre varchar(60),
@RUC_Empresa varchar(13),
@Direccion varchar(150) ,
@Telefono varchar(15),
@Email varchar(50),
@Logo image
as
update Empresas set Nombre=@Nombre,RUC_Empresa=@RUC_Empresa,
Direccion=@Direccion,Telefono=@Telefono,Email=@Email, Logo=@Logo 
where ID_Empresa=@ID_Empresa
go

--eliminar Proveedor 
create proc EliminarEmpresa
@ID_Empresa int
as
delete from Empresas where ID_Empresa=@ID_Empresa
go











--*********************************************BUSCADORES********************************************

--*****************************************BUSCADOR POR PRODUCTO*************************************************
--Buscador mediante codigo
Create Proc Buscar_Producto_Codigo
@Buscar varchar(50)
as
select * from Productos where Codigo like @Buscar + '%'
go

--Buscador mediante Nombre
Create Proc Buscar_Producto_Nombre
@Buscar varchar(50)
as
select * from Productos where Nombre like @Buscar + '%'
go

--Buscador mediante Descripcion
Create Proc Buscar_Producto_Descripcion
@Buscar varchar(50)
as
select * from Productos where Descripcion like @Buscar + '%'
go


--*****************************************BUSCADOR POR PROVEEDOR************************************************
--Buscador mediante codigo
Create Proc Buscar_Proveedor_Codigo
@Buscar varchar(50)
as
select * from Proveedores where Codigo like @Buscar + '%'
go

--Buscador mediante Nombre
Create Proc Buscar_Proveedor_Nombre
@Buscar varchar(50)
as
select * from Proveedores where Nombre like @Buscar + '%'
go

--Buscador mediante RUC
Create Proc Buscar_Proveedor_RUC
@Buscar varchar(50)
as
select * from Proveedores where RUC_Proveedor like @Buscar + '%'
go

--*****************************************BUSCADOR POR CLIENTE************************************************
--Buscador mediante codigo
Create Proc Buscar_Cliente_Codigo
@Buscar varchar(50)
as
select * from Clientes where Codigo like @Buscar + '%'
go

--Buscador mediante Nombre
Create Proc Buscar_Cliente_Nombre
@Buscar varchar(50)
as
select * from Clientes where Nombre like @Buscar + '%'
go

--Buscador mediante RUC
Create Proc Buscar_Cliente_RUC
@Buscar varchar(50)
as
select * from Clientes where RUC_Cliente like @Buscar + '%'
go


--*****************************************BUSCADOR POR EMPRESAS************************************************

--Buscador mediante Nombre
Create Proc Buscar_Empresa_Nombre
@Buscar varchar(50)
as
select * from Empresas where Nombre like @Buscar + '%'
go

--Buscador mediante RUC
Create Proc Buscar_Empresa_RUC
@Buscar varchar(50)
as
select * from Empresas where RUC_Empresa like @Buscar + '%'
go















-------------------------------------------------------TRIGGER-------------------------------------------------
--LUEGO DE CREAR SE ENCUENTRAN DENTRO DE LA TABLA EN LA CARPETA "TRIGGERS"
--Trigger para agregar productos al inventario
--TABLA PRODUCTOS

Create Trigger Tr_Agregar_producto_inv
on Productos for Insert
as
Set nocount on
declare @ID_Inventario int
declare @Codigo varchar (15)
declare @Nombre varchar (50)
declare @Cantidad int
declare @Costo_Unitario decimal(10,2)
declare @Precio_Venta decimal(10,2)
declare @Monto_Total decimal(10,2)
declare @Tipo_Cargo varchar (10)
select @ID_Inventario=ID_Producto,@Codigo=Codigo, @Nombre=Nombre, @Cantidad=0,@Costo_Unitario=Costo_Unitario,
		@Precio_Venta=Precio_venta,@Monto_Total=(@Cantidad*@Costo_Unitario), 
		@Tipo_Cargo=Tipo_Cargo from inserted
Insert Into Inventarios (ID_Inventario,Codigo,Nombre,Cantidad,Costo_Unitario,Precio_venta, 
Monto_Total,Tipo_Cargo)
values(@ID_Inventario,@Codigo, @Nombre, @Cantidad,@Costo_Unitario, @Precio_Venta, @Monto_Total, 
@Tipo_Cargo)
go

--Trigger para eliminar productos en la tabla inventario
Create Trigger Tr_Eliminar_producto_inv
on Productos for delete
as
Set nocount on
declare @ID_Inventario int
declare @Cantidad int
Select @ID_Inventario=ID_Producto From deleted
Delete from Inventarios where ID_Inventario=@ID_Inventario
go




-------------------------------------------------------CONSULTA DE LAS TABLAS-------------------------------------------------
--CONSULTAR
USE DBSYSVENBOD

SELECT * FROM Inventarios
SELECT * FROM Productos
SELECT * FROM Proveedores
SELECT * FROM Clientes