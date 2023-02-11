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

CREATE SEQUENCE Produ AS INT START WITH 1 NO CACHE;
create table Productos
(
	ID_Producto int PRIMARY KEY DEFAULT NEXT VALUE FOR produ,
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
CREATE SEQUENCE Provee AS INT START WITH 1 NO CACHE;
create table Proveedores
(
	ID_Proveedor int PRIMARY KEY DEFAULT NEXT VALUE FOR Provee,
	Codigo varchar(15) not null,
	Nombre varchar(50) not null,
	RUC_Proveedor varchar(13) not null,
	Direccion varchar(150) not null,
	Telefono varchar(15) not null,
	Email varchar(50) not null,
)
go

--TABLA DE CLIENTES
CREATE SEQUENCE Clien AS INT START WITH 1 NO CACHE;
create table Clientes
(
	ID_Cliente int PRIMARY KEY DEFAULT NEXT VALUE FOR Clien,
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
CREATE SEQUENCE Empr AS INT START WITH 1 NO CACHE;
create table Empresas
(
	ID_Empresa int PRIMARY KEY DEFAULT NEXT VALUE FOR Empr,
	Nombre varchar(60) not null,
	RUC_Empresa varchar(13) not null,
	Direccion varchar(150) not null,
	Telefono varchar(15) not null,
	Email varchar(50) not null,
	Logo image ,
)
go

--TABLA INGRESAR PRODUCTO
CREATE SEQUENCE Ing_pro AS INT START WITH 1 NO CACHE;
create table Ingreso_Producto
(
	ID_Ingreso int PRIMARY KEY DEFAULT NEXT VALUE FOR Ing_Pro,
	No_Ingreso varchar(15) not null,
	Id_Proveedor int not null,
	Fecha_Ingreso date not null,
	Comprobante varchar(20) not null,
	Monto_Total decimal (12,2) not null,
	Estado varchar (10) not null
)
go

--DETALLE INGRESO
CREATE SEQUENCE Det_pro AS INT START WITH 1 NO CACHE;
create table Detalle_Producto
(
	ID_Detalle int PRIMARY KEY DEFAULT NEXT VALUE FOR Det_pro,
	Id_Ingreso int not null,
	Id_Producto int not null,
	Cantidad int not null,
	Fecha_caducidad date not null,
	Costo_Unitario decimal (12,2) not null,
	Sub_Total decimal (12,2) not null,
)
go

--CANTIDAD POR FECHA DE CADUCIDAD
create table Can_Detalle_Producto
(
	ID_Can_Detalle int not null,
	Nombre varchar(50) not null,
	Cantidad int not null,
	Fecha_caducidad date not null,
)
go

--TAbla tipo de comprobante
CREATE SEQUENCE Tipcom AS INT START WITH 1 NO CACHE;
create table TipoComprobante
(
	ID_Comprobante int PRIMARY KEY DEFAULT NEXT VALUE FOR Tipcom,
	Nombre_Comprobante varchar(50) not null,
	Tipo_Comprobante varchar(4) not null,
	Correlativo int not null
)
go

--Tabla ususario
CREATE SEQUENCE Acc AS INT START WITH 1 NO CACHE;
create table Acceso
(
	ID_Usuario int PRIMARY KEY DEFAULT NEXT VALUE FOR Acc,
	Nombre_Usuario varchar(50) not null,
	Apellido_Usuario varchar(50) not null,
	Usuario varchar(50) not null,
	Password varchar(max) not null
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
update Productos 
set Codigo=@Codigo, Nombre=@Nombre,Descripcion=@Descripcion,
	Presentacion=@Presentacion,Costo_Unitario=@Costo_Unitario,
	Precio_venta=@Precio_venta,Tipo_Cargo=@Tipo_Cargo 
where ID_Producto=@ID_Producto
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
update Proveedores 
set Codigo=@Codigo, Nombre=@Nombre,RUC_Proveedor=@RUC_Proveedor,
	Direccion=@Direccion,Telefono=@Telefono,Email=@Email 
where ID_Proveedor=@ID_Proveedor
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
update Clientes 
set Codigo=@Codigo, Nombre=@Nombre,RUC_Cliente=@RUC_Cliente,
	Direccion=@Direccion,Telefono=@Telefono,Email=@Email, 
	Estado=@Estado 
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
update Empresas 
set Nombre=@Nombre,RUC_Empresa=@RUC_Empresa,Direccion=@Direccion,
	Telefono=@Telefono,Email=@Email, Logo=@Logo 
where ID_Empresa=@ID_Empresa
go

--eliminar Proveedor 
create proc EliminarEmpresa
@ID_Empresa int
as
delete from Empresas where ID_Empresa=@ID_Empresa
go

---------------------------------------------------------------------------------------------------------
--****************************************Producto********************************************
---Ingreso de productos
create proc Agregar_Ing_Producto
@No_Ingreso varchar(15),
@Id_Proveedor int,
@Fecha_Ingreso date,
@Comprobante varchar(20),
@Monto_Total decimal (12,2),
@Estado varchar (10)
as
Insert into Ingreso_Producto 
	(No_Ingreso, Id_Proveedor,Fecha_Ingreso, Comprobante, Monto_Total, Estado)
Values(@No_Ingreso, @Id_Proveedor,@Fecha_Ingreso, @Comprobante, @Monto_Total, @Estado)
go

---Anular Ingreso de productos
create proc Anular_Ing_Producto
@ID_Ingreso int,
@No_Ingreso varchar(15),
@Id_Proveedor int,
@Fecha_Ingreso date,
@Comprobante varchar(20),
@Monto_Total decimal (12,2),
@Estado varchar (10)
as
Update Ingreso_Producto 
Set No_Ingreso=@No_Ingreso, Id_Proveedor=@Id_Proveedor, Fecha_Ingreso=@Fecha_Ingreso,
	Comprobante= @Comprobante, Monto_Total= @Monto_Total,
	Estado=@Estado
where ID_Ingreso=@ID_Ingreso

go

----------Agregar detalle producto
create proc Agregar_Det_Ingreso
@Id_Ingreso int,
@Id_Producto int,
--Nombre varchar(100) not null,
@Cantidad int,
@Fecha_caducidad date,
@Costo_Unitario decimal (12,2),
@Sub_Total decimal (12,2)
as
Insert into Detalle_Producto	
			(Id_Ingreso,Id_Producto,Cantidad,
			 Fecha_caducidad,Costo_Unitario,Sub_Total)
values	(@Id_Ingreso,@Id_Producto,@Cantidad,@Fecha_caducidad,
		 @Costo_Unitario,@Sub_Total)

go

----------Anular detalle producto
create proc Anular_Det_Producto
@ID_Detalle int,
@Id_Ingreso int,
@Id_Producto int,
--Nombre varchar(100) not null,
@Cantidad int,
@Fecha_caducidad date,
@Costo_Unitario decimal (12,2),
@Sub_Total decimal (12,2)
as
Update Detalle_Producto
Set Id_Ingreso=@Id_Ingreso,Id_Producto=@Id_Producto,
	Fecha_caducidad=@Fecha_caducidad,
	Costo_Unitario=@Costo_Unitario,Sub_Total=@Sub_Total
Where ID_Detalle=@ID_Detalle
go


----Mostrar detalles de los Ingreso proveedor
create proc Mostrar_Ingreso
as
select ing.ID_Ingreso, ing.Id_Proveedor, ing.No_Ingreso ,Pro.Nombre as 'Nombre Proveedor', Ing.Fecha_Ingreso, Ing.Comprobante, Ing.Monto_Total,Ing.Estado 
				  From Ingreso_Producto Ing inner join Proveedores Pro
				  on Ing.Id_Proveedor=Pro.ID_Proveedor
go


--Mostrar Detalles de ingresos
create proc MostrarDetalleIngresos
@Id_Ingreso int
as
Select DETPRO.ID_Detalle, DETPRO.Id_Ingreso, DETPRO.Id_Producto, PRO.Nombre, DETPRO.Cantidad,DETPRO.Costo_Unitario, 
(DETPRO.Cantidad * DETPRO.Costo_Unitario) as 'SUB_TOTAL', DETPRO.Fecha_caducidad
From Detalle_Producto DETPRO inner join Productos PRO on DETPRO.Id_Producto=PRO.ID_Producto
Where Id_Ingreso=@Id_Ingreso 
go

--Mostrar entrada de productos
create proc Mostrar_IngresoProducto
@Id_Ingreso int
as
Select	INGPRO.No_Ingreso, PROVEE.Nombre as 'Proveedor', INGPRO.Fecha_Ingreso, INGPRO.Comprobante, INGPRO.Monto_Total,
		INGPRO.Estado, PRO.Nombre as 'Nombre',DETPRO.Cantidad,
		DETPRO.Costo_Unitario, DETPRO.Sub_Total as 'Total', DETPRO.Fecha_caducidad,
		EMP.Nombre, EMP.RUC_Empresa, EMP.Direccion, EMP.Telefono, EMP.Email, EMP.Logo
from Ingreso_Producto INGPRO 
inner join Detalle_Producto DETPRO on INGPRO.ID_Ingreso=DETPRO.Id_Ingreso
inner join Proveedores PROVEE on INGPRO.Id_Proveedor=PROVEE.ID_Proveedor
inner join Productos PRO on DETPRO.Id_Producto=PRO.ID_Producto
cross join Empresas EMP 
where INGPRO.ID_Ingreso=@Id_Ingreso order by Fecha_caducidad
go

/****************************************************TIPO DE COMPROBANTE*****************************************************************/

--Agregar tipo de comprbante
Create proc AgregarTipoCompro
@Nombre_Comprobante varchar(50),
@Tipo_Comprobante varchar(4),
@Correlativo int
as
Insert into TipoComprobante(Nombre_Comprobante, Tipo_Comprobante, Correlativo)
values (@Nombre_Comprobante,@Tipo_Comprobante,@Correlativo)
go


--Editar tipo de comprbante
Create proc EditarTipoCompro
@ID_Comprobante int,
@Nombre_Comprobante varchar(50),
@Tipo_Comprobante varchar(4),
@Correlativo int
as
update TipoComprobante
Set Nombre_Comprobante=@Nombre_Comprobante,Tipo_Comprobante=@Tipo_Comprobante,
	Correlativo=@Correlativo
Where ID_Comprobante=@ID_Comprobante
go


/*****************************************Usuario***************************************/
----Para ingresar acceso con encriptado    45 me pase 64
Create proc IngresarAcceso
	@Nombre_Usuario varchar(50) ,
	@Apellido_Usuario varchar(50) ,
	@Usuario varchar(50) ,
	@Password varchar(max) 
as begin
set @Password =( ENCRYPTBYPASSPHRASE(@Usuario,@Password));
insert into Acceso(Nombre_Usuario,Apellido_Usuario,Usuario,Password)
values (@Nombre_Usuario,@Apellido_Usuario,@Usuario,@Password)
end
GO

-----------Para editar Acceso
Create proc EditAcceso
	@ID_Usuario int,
	@Nombre_Usuario varchar(50) ,
	@Apellido_Usuario varchar(50) ,
	@Usuario varchar(50) ,
	@Password varchar(max) 
as
update Acceso 
set @Password =( ENCRYPTBYPASSPHRASE(@Usuario,@Password)),
	Nombre_Usuario=@Nombre_Usuario,Apellido_Usuario=@Apellido_Usuario,
	Usuario=@Usuario,Password=@Password
where ID_Usuario=@ID_Usuario
GO

-----eliminar usuraio
Create proc ElimAcceso
@ID_Usuario int
as
delete from Acceso 
where ID_Usuario=@ID_Usuario
go

------Visualizar login
Create proc VisAcce
as
select * from Acceso
go



----para desencriptar constraseña
Create proc DescAcceso
@ID_Usuario int
as
select	Nombre_Usuario, Apellido_Usuario, Usuario, 
		Password=CONVERT(varchar(max), DECRYPTBYPASSPHRASE(Usuario,Password)) 
from Acceso 
where @ID_Usuario=ID_Usuario
go

----para almacenar lo encriptado
Create proc AccesoEncri
@ID_Usuario int
as
select	Nombre_Usuario, Apellido_Usuario, Usuario, 
		Password = ENCRYPTBYPASSPHRASE(Usuario,Password) 
from Acceso 
where @ID_Usuario=ID_Usuario
go

-----para desencriptar lo convertido en pocos datos
Create Proc AccesoConverEncri
@ID_Usuario int
as
select	Nombre_Usuario, Apellido_Usuario, Usuario, 
		Password= DECRYPTBYPASSPHRASE(Usuario,Password) 
from Acceso 
where @ID_Usuario=ID_Usuario
go

/*
exec DescAcceso 1
EXEC AccesoLogin 'admin', 'admin'
exec AccesoEncri 1
exec AccesoConverEncri 1
*/

/*********************************************LOGIN***********************************************************/
create proc AccesoLogin
@Usuario varchar(30),
@Password varchar(20)
as
Select * 
from Acceso 
where Usuario=@Usuario and @Password=CONVERT(varchar(max), DECRYPTBYPASSPHRASE(Usuario,Password))
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

/***********************************************BUSQUEDA POR INVENTARIO***********************************************************/
Create Proc Buscar_Inventario_Nombre
@Buscar varchar(50)
as
select * from Inventarios where Nombre like @Buscar + '%'
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


--------------------------------------------------------------------------------------------------------------------------------------
---****************************************************** BUSQUEDA DE PRODUCTOS MEDIANTE EL INGRESO********************************************
--Buscar Ingreso de los productos por proveedores
create proc Buscar_IngrProd_Proveedor
@Buscar nvarchar(100)
as
select ing.ID_Ingreso, ing.No_Ingreso, Pro.Nombre as 'Nombre Proveedor', Ing.Fecha_Ingreso, Ing.Comprobante, Ing.Monto_Total,Ing.Estado 
				  From Ingreso_Producto Ing inner join Proveedores Pro
				  on Ing.Id_Proveedor=Pro.ID_Proveedor
where Nombre like @Buscar + '%' 
go

--Buscar Ingreso de los productos por fecha
create proc Buscar_IngrProd_Fecha
@Buscar nvarchar(100)
as
select ing.ID_Ingreso, ing.No_Ingreso, Pro.Nombre as 'Nombre Proveedor', Ing.Fecha_Ingreso, Ing.Comprobante, Ing.Monto_Total,Ing.Estado 
				  From Ingreso_Producto Ing inner join Proveedores Pro
				  on Ing.Id_Proveedor=Pro.ID_Proveedor
where Fecha_Ingreso like @Buscar + '%' 
go

--Buscar Ingreso de los productos por comprobante
create proc Buscar_IngrProd_Comprobante
@Buscar nvarchar(100)
as
select ing.ID_Ingreso, ing.No_Ingreso, Pro.Nombre as 'Nombre Proveedor', Ing.Fecha_Ingreso, Ing.Comprobante, Ing.Monto_Total,Ing.Estado 
				  From Ingreso_Producto Ing inner join Proveedores Pro
				  on Ing.Id_Proveedor=Pro.ID_Proveedor
where Comprobante like @Buscar + '%' 
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

--TABLA PRODUCTOS ACTUALIZAR INVENTARIO
Create Trigger Tr_Editar_producto_inv
on Productos for Update
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
select @ID_Inventario=ID_Producto,@Codigo=Codigo, @Nombre=Nombre,@Costo_Unitario=Costo_Unitario,
		@Precio_Venta=Precio_venta,	@Tipo_Cargo=Tipo_Cargo from inserted
select @Cantidad=Cantidad from Inventarios where ID_Inventario=@ID_Inventario
update Inventarios set inventarios.Codigo=@Codigo,inventarios.Nombre=@Nombre,inventarios.Costo_Unitario=@Costo_Unitario,
inventarios.Precio_venta=@Precio_Venta,inventarios.Monto_Total=(@Cantidad-@Costo_Unitario),inventarios.Tipo_Cargo=@Tipo_Cargo
where ID_Inventario=@ID_Inventario
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


---Agregar los productos al inventario
create trigger Tr_Balan_Productos_Inv
on Detalle_Producto for insert --detalle ingreso
as
set nocount on
declare @ID_Inventario int
declare @Cantidad int
declare @Stock_Actual int
declare @Costo_Unitario decimal(12,2)
declare @Monto_Total decimal(12,2)
declare @Balance_Actual decimal(12,2) 
Select	@ID_Inventario=Id_Producto, @Cantidad=Cantidad, @Costo_Unitario =Costo_Unitario, @Monto_Total=(@Cantidad*@Costo_Unitario) From inserted
Select  @Stock_Actual=Cantidad, @Balance_Actual=Monto_Total From Inventarios where ID_Inventario=@ID_Inventario
update Inventarios set Inventarios.Cantidad=@Cantidad + @Stock_Actual, Inventarios.Monto_Total = @Monto_Total + @Balance_Actual
where Inventarios.ID_Inventario=@ID_Inventario
go


---disminuir los productos al ingreso de los inventario "cuando se anule una compra"
create trigger Reducir_Productos_Inv
on Detalle_Producto for update --detalle ingreso
as
set nocount on
declare @ID_Inventario int
declare @Cantidad int
declare @Stock_Actual int
declare @Costo_Unitario decimal(12,2)
declare @Monto_Total decimal(12,2)
declare @Balance_Actual decimal(12,2) 
Select	@ID_Inventario=Id_Producto, @Cantidad=Cantidad From inserted
Select  @Stock_Actual=Cantidad, @Costo_Unitario=Costo_Unitario, @Balance_Actual=Monto_Total From Inventarios where ID_Inventario=@ID_Inventario
update Inventarios set Inventarios.Cantidad=@Stock_Actual -@Cantidad, Inventarios.Monto_Total = @Balance_Actual - (@Cantidad*@Costo_Unitario)
where Inventarios.ID_Inventario=@ID_Inventario
go


----Agregar Tabla Contador detalle producto
CREATE Trigger Tr_Agregar_detalle_con
on Detalle_Producto for Insert
as
Set nocount on
declare @ID_Can_Detalle int
declare @Nombre varchar (50)
declare @Cantidad int
declare @max int
declare @Fecha_caducidad date
select @ID_Can_Detalle=ID_Detalle, @Nombre= (select P.Nombre from Productos P inner join Detalle_Producto DP on dp.Id_Producto=p.ID_Producto where dp.ID_Detalle= p.ID_Producto),--OJO
        @Cantidad=Cantidad,@Fecha_caducidad=Fecha_caducidad from inserted
Insert Into Can_Detalle_Producto (ID_Can_Detalle,Nombre,Cantidad,Fecha_caducidad)
values(@ID_Can_Detalle,@Nombre,@Cantidad,@Fecha_caducidad)
update Can_Detalle_Producto set Nombre = (select P.Nombre from Productos P inner join Detalle_Producto DP on dp.Id_Producto=p.ID_Producto where dp.ID_Detalle= ID_Can_Detalle)
go


/******************************************IMGRESO DE DATOS MANUALMENTE************************************************************************/

/******************************************ACCESO*************************/
INSERT INTO [dbo].[Acceso]
           ([Nombre_Usuario]
           ,[Apellido_Usuario]
           ,[Usuario]
           ,[Password])
     VALUES
	 
           ('Administrador','Administrador','admin','0x61646D696E')
GO

UPDATE [dbo].[Acceso]
   SET Password = ENCRYPTBYPASSPHRASE('admin','admin')
	where ID_Usuario=1
GO

/*****************************************PRODUCTOS*********************/
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000001','Galleta Oreo','Taco mayor','UNIDAD','0.83','0.90','Iva 12%')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000002','Pasta','Espagueti 100lb','UNIDAD','0.75','2.15','Sin IVA')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000003','Ciclon','Detergente de 500gr.','UNIDAD','1.99','2.50','Iva 12%')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000004','Deja','Detergente 1K','UNIDAD','2.80','3.50','Iva 12%')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000005','Macho','Jabon 200gr','UNIDADI','0.80','1.02','Iva 12%')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000006','ACEITE PALMA ORO','1 LITRO EN BOTELLA','UNIDAD','1.35','2.00','Sin IVA')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000007','POLLO COMPLETO MR. POLLO','SÚPER EXTRA GRANDE - PESO: 2,50 A 2,80KG','KG','1.89','2.10','Sin IVA')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000008','Galak','Galletas de 500gr','UNIDAD','1.35','2.15','Iva 12%')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000009','Mayonesa','Botella 500g','UNIDAD','2.75','3.15','Iva 12%')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000010','Salsa de Tomate','Galon','UNIDAD','8.00','9.25','Iva 12%')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000011','Mostaza','Botella 250g','UNIDAD','2.15','2.75','Iva 12%')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000012','Aliño','Sazonador 450g','UNIDAD','3.00','3.75','Iva 12%')
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo])
     VALUES('PROD00000013','Ajo','Botella 250g','UNIDAD','1.15','1.75','Iva 12%')
GO

/******************************************PROVEEDORES*******************/
INSERT INTO [dbo].[Proveedores]
           ([Codigo],[Nombre],[RUC_Proveedor],[Direccion],[Telefono],[Email])
	VALUES
           ('PROV00000001','Nestle','0922281621001','santa teresita y carlos viteri 1050','098-241-7171','gusteran1@gmail.com'),
		   ('PROV00000002','Pronaca','1208769541002','bucay','094-123-5647','Pronac_proveedor@gmail.com'),
		   ('PROV00000003',	'Arca Continental','2308972654001','Milagro','152-755-4122','arcamilagro@continental.com'),
		   ('PROV00000004','DEVIES CORP S.A.','0992231092001','Av. 17 de Septiembre 1105, Milagro','042-716-7000','devcorpmilagro@gmail.com')
GO

/*******************************************CLIENTES*********************/
INSERT INTO [dbo].[Clientes]
           ([Codigo],[Nombre],[RUC_Cliente],[Direccion],[Telefono],[Email],[Estado])
     VALUES
           ('CLI00000001','Eloisa Teran Baque','0941347840','cdla x marcos','042-977-3570','eteranb2@gmail.com','Activo'),
		   ('CLI00000002','Arthur Teran','0941256522','amazonas y la huerta','125-415-4154','gusteran1@gmail.com','Activo')
GO

/*******************************************EMPRESA**************************/
INSERT INTO [dbo].[Empresas]
           ([Nombre],[RUC_Empresa],[Direccion],[Telefono],[Email],[Logo])
     VALUES
           ('Comercial Adrianita','0921845162001','Parroquia Virgen de fatima Yaguachi Viejo, Ecuador','098-562-2007','adrianitacomercialvf@hotmail.es',NULL)
		   --MODIFICAR EL LOGO DE LA EMPRESA
GO

-------------------------------------------------------CONSULTA DE LAS TABLAS-------------------------------------------------
--CONSULTAR
USE DBSYSVENBOD

SELECT * FROM Inventarios
SELECT * FROM Productos
SELECT * FROM Proveedores
SELECT * FROM Clientes
SELECT * FROM Empresas
SELECT * FROM Detalle_Producto 
SELECT * FROM Can_Detalle_Producto
SELECT * FROM Ingreso_Producto
SELECT * FROM Acceso
SELECT * FROM TipoComprobante

SELECT PRO.Nombre, PROVEE.Nombre, DETPRO.Fecha_caducidad
FROM Detalle_Producto DETPRO, Productos PRO, Ingreso_Producto ING, Proveedores PROVEE  
where DETPRO.Id_Producto=pro.ID_Producto AND ING.Id_Proveedor=PROVEE.ID_Proveedor 



