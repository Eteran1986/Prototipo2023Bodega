/******************************************ACCESO*************************/

INSERT INTO [dbo].[Acceso]
           ([Nombre_Usuario],[Apellido_Usuario],[Usuario],[Password],[Administrador])
     VALUES
           ('Administrador','Administrador','admin','0x61646D696E',1)
GO
UPDATE [dbo].[Acceso]
   SET Password = ENCRYPTBYPASSPHRASE('admin','admin')
	where ID_Usuario=1
GO

/*******************************************CATEGORIA***********************/
INSERT INTO [dbo].[Categoria]
           ([Categoria])
     VALUES
           ('GOLOSINAS'),
		   ('COMESTIBLE'),
		   ('LIMPIEZA DE HOGAR'),
		   ('AGUAS Y BEBIDAS'),
		   ('INSECTICIDAS'),
		   ('LACTEOS'),
		   ('BEBIDAS ALCOHOLICAS')
GO



/*****************************************PRODUCTOS*********************/

INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000001','Galleta Oreo','Taco mayor','UNIDAD','0.83','0.90','IVA',1)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000002','Pasta','Espagueti 100lb','UNIDAD','0.75','2.15','SIN IVA',2)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000003','Ciclon','Detergente de 500gr.','UNIDAD','1.99','2.50','IVA',3)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000004','Deja','Detergente 1K','UNIDAD','2.80','3.50','IVA',3)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000005','Macho','Jabon 200gr','UNIDAD','0.80','1.02','IVA',3)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000006','ACEITE PALMA ORO','1 LITRO EN BOTELLA','UNIDAD','1.35','2.00','SIN IVA',2)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000007','POLLO COMPLETO MR. POLLO','SÚPER EXTRA GRANDE - PESO: 2,50 A 2,80KG','KG','1.89','2.10','SIN IVA',2)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000008','Galak','Galletas de 500gr','UNIDAD','1.35','2.15','IVA',1)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000009','Mayonesa','Botella 500g','UNIDAD','2.75','3.15','IVA',2)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000010','Salsa de Tomate','Galon','UNIDAD','8.00','9.25','IVA',2)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000011','Mostaza','Botella 250g','UNIDAD','2.15','2.75','IVA',2)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000012','Aliño','Sazonador 450g','UNIDAD','3.00','3.75','IVA',2)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000013','Ajo','Botella 250g','UNIDAD','1.15','1.75','IVA',2)
INSERT INTO [dbo].[Productos]
           ([Codigo],[Nombre],[Descripcion],[Presentacion],[Costo_Unitario],[Precio_venta],[Tipo_Cargo],[ID_Categoria])
     VALUES('PROD00000014','COCACOLA','3 LITROS RETONABLE','UNIDAD','2.05','2.75','IVA',4)

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

           --('Comercial Adrianita','0921845162001','Parroquia Virgen de fatima Yaguachi Viejo, Ecuador','0985622007','adrianitacomercialvf@hotmail.es',NULL)
		   --MODIFICAR EL LOGO DE LA EMPRESA

