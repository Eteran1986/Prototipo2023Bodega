--INSERT [dbo].[Empresas] ([ID_Empresa], [Nombre], [RUC_Empresa], [Direccion], [Telefono], [Email], [Logo]) VALUES (0, N'Comercial Adrianita', N'0921845162001', N'Parroquia Virgen de fatima Yaguachi Viejo, Ecuador', N'098-562-2007', N'adrianitacomercialvf@hotmail.es')

USE [DBSYSVENBOD]
GO
INSERT [dbo].[Acceso] ([ID_Usuario], [Nombre_Usuario], [Apellido_Usuario], [Usuario], [Password], [Administrador]) VALUES (1, N'Administrador', N'Administrador', N'admin', N'   xÕ+š>I‰v''­oüŒ ½.Õêô—Ä`¨,x', 1)
GO
INSERT [dbo].[Acceso] ([ID_Usuario], [Nombre_Usuario], [Apellido_Usuario], [Usuario], [Password], [Administrador]) VALUES (6, N'elo', N'elo', N'eloisa', N'   >½LÙÞÓ7üWå%#w/—s}Ãÿm ›ºER(¹ªÎ', 0)
GO
INSERT [dbo].[Acceso] ([ID_Usuario], [Nombre_Usuario], [Apellido_Usuario], [Usuario], [Password], [Administrador]) VALUES (7, N'Bodega', N'Bodega', N'bodega', N'   ú·Tè Ånù²ïf,þoù©‰-¢îägC*ƒ(ž±uƒ', 2)
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (1, N'GALLETA OREO TACO', 19, CAST(N'2023-08-19' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (2, N'GALAK 500GR', 40, CAST(N'2023-10-21' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (3, N'AJO CONDIMENSA 470GR', 20, CAST(N'2023-08-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (5, N'DEJA LIMON 1K', 30, CAST(N'2023-12-09' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (6, N'CICLON 400GR', 18, CAST(N'2023-10-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (7, N'MOSTAZA MAGGI 330GR', 30, CAST(N'2023-12-30' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (8, N'COCACOLA 3L ORIGINAL', 60, CAST(N'2024-07-03' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (9, N'POLLO COMPLETO MR. POLLO', 35, CAST(N'2023-06-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (11, N'POLLO COMPLETO MR. POLLO', 60, CAST(N'2023-10-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (12, N'SALSA DE TOMATE MARCELLOS GALON', 20, CAST(N'2023-05-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (13, N'COCACOLA 3L ORIGINAL', 0, CAST(N'2023-09-02' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (14, N'GALAK 500GR', 20, CAST(N'2023-10-14' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (15, N'MACHO 200GR', 28, CAST(N'2023-11-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (19, N'MAYONESA GUSTADINA 330 G', 50, CAST(N'2023-05-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (20, N'LECHE PARMALAC LITRO', 0, CAST(N'2023-03-03' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (21, N'GALLETA OREO TACO', 20, CAST(N'2023-11-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (22, N'ACEITE PALMA ORO', 50, CAST(N'2023-09-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (23, N'SUMESA PASTA 400G', 20, CAST(N'2024-03-09' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (24, N'MACHO 200GR', 15, CAST(N'2023-12-05' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (25, N'TONI CHOCOLATE 1L', 0, CAST(N'2023-04-01' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (26, N'LECHE PARMALAC LITRO', 0, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (27, N'GALLETAS SALTICAS 378 G', 10, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (28, N'LONCHYS POLLO 65G', 20, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (29, N'RUFFLES 245G NATURAL', 10, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (30, N'AMOR WAFFER 130G FRESA', 20, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (31, N'FERRERO NUTELA 350G', 10, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (32, N'DEJA BRISA PRIMAVERA 2KG', 40, CAST(N'2024-02-10' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (33, N'AXION ALOE 450G', 30, CAST(N'2023-12-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (34, N'PAPEL HIGIÉNICO FAMILIA X6 ROLLOS', 50, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (35, N'SUAVITEL DOYPACK 360ML ORQUÍDEA', 20, CAST(N'2023-07-14' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (36, N'FUNDA MAYIK 58X71 10U', 55, CAST(N'2024-03-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (37, N'KALIPTO DESINFECTANTE 1 GL', 10, CAST(N'2024-02-21' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (38, N'COCA COLA PACK', 15, CAST(N'2023-12-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (39, N'GATORADE APPLE ICE 750 ML', 60, CAST(N'2023-10-11' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (40, N'PEPSI 3L ORIGINAL', 20, CAST(N'2023-10-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (41, N'POWERADE MORA AZUL 500 ML', 50, CAST(N'2023-11-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (42, N'COLA TROPICAL 1L', 10, CAST(N'2023-08-18' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (43, N'ESPIRAL EUCALIPTO MAYIK 10U', 15, CAST(N'2023-10-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (51, N'TONI CHOCOLATE 1L', 10, CAST(N'2023-09-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (52, N'RAID INSECTICIDA 400CC', 30, CAST(N'2023-12-23' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (53, N'CERVEZA WIERQUER 330 ML 24U', 10, CAST(N'2024-05-18' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (54, N'CERVEZA PILSENER SIXPACK 355ML', 20, CAST(N'2024-03-28' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (55, N'CERVEZA CORONA SIXPACK 355ML', 30, CAST(N'2024-02-14' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (56, N'CERVEZA BIELA SIXPACK 355ML', 30, CAST(N'2023-12-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (57, N'CERVEZA HEINEKEN 355ML 12U', 15, CAST(N'2024-05-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (58, N'SOMETHING SPECIAL 750ML', 3, CAST(N'2024-04-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (59, N'LICOR MR ALLEN 1L', 22, CAST(N'2024-02-06' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (60, N'VINO TINTO MERLOT 750ML', 48, CAST(N'2024-11-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (61, N'ATUN VAN CAMP''S 142 G', 17, CAST(N'2024-03-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (62, N'LECHE PARMALAC LITRO', 0, CAST(N'2023-10-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (63, N'VITA DESCREMADA 1L TETRAPACK', 15, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (64, N'TONI CHOCOLATE 1L', 15, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (65, N'ANDINA SEMIDESCREMADA 900 ML FUNDA', 10, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (66, N'NESTLE SVELTY 1L TETRA-BRIK', 10, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (67, N'VITA DESLACTOSADA 1L TETRABRIK', 12, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (68, N'REYLECHE FRUTILLA 200 ML', 5, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (69, N'DULCE DE LECHE KIOSKO 250G', 20, CAST(N'2024-03-02' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (70, N'LECHE POLVO LA VAQUITA 190G', 30, CAST(N'2024-02-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (71, N'LECHE NUTRI ENTERA CARTÓN 200ML', 10, CAST(N'2023-08-23' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (72, N'LECHE REYLECHE ENTERA 900ML', 20, CAST(N'2023-04-30' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (73, N'LECHE MILO CHOCOLATADA 185ML', 40, CAST(N'2023-07-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (74, N'LECHE LENUTRIT CHOCOLATE 900ML', 10, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (75, N'GALLETA OREO TACO', 0, CAST(N'2023-07-21' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (76, N'MACHO 200GR', 20, CAST(N'2024-05-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (77, N'DEJA BRISA PRIMAVERA 2KG', 20, CAST(N'2024-03-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (78, N'PONY MALTA 1L', 30, CAST(N'2023-10-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (79, N'AJO CONDIMENSA 470GR', 20, CAST(N'2024-07-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (80, N'ALIÑO CONDIMENSA 380GR', 10, CAST(N'2024-04-10' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (81, N'PAPEL HIGIÉNICO FAMILIA X6 ROLLOS', 80, CAST(N'2024-03-07' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (82, N'MOSTAZA MAGGI 330GR', 15, CAST(N'2024-02-07' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (83, N'MAYONESA GUSTADINA 330 G', 15, CAST(N'2024-02-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (84, N'FERRERO NUTELA 350G', 30, CAST(N'2024-01-03' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (85, N'LONCHYS POLLO 65G', 20, CAST(N'2024-04-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (86, N'RUFFLES 245G NATURAL', 10, CAST(N'2024-02-21' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (87, N'AGUA ALL NATURAL 10L', 50, CAST(N'2024-07-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (88, N'DRAGON INSECTICIDA 475 ML', 13, CAST(N'2024-02-06' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (89, N'BUENDIA 170G', 20, CAST(N'2023-12-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (90, N'DEL VALLE 1.75L NARANJA', 40, CAST(N'2024-02-17' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (91, N'AGUA SIN GAS DASANI 600ML', 60, CAST(N'2024-05-11' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (92, N'FRUTARIS MANZANA 1L', 50, CAST(N'2024-02-06' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (93, N'MONSTER ULTRA ENERGIZANTE 473ML', 12, CAST(N'2024-01-27' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (94, N'GATORADE APPLE ICE 750 ML', 20, CAST(N'2024-06-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (95, N'FACUNDO MERMELADA 300G MORA', 10, CAST(N'2024-05-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (96, N'WHISKY CHIVAS REGAL 700ML', 20, CAST(N'2024-05-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (129, N'MARGARINA NATURELLA ALES 500G', 15, CAST(N'2024-01-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (130, N'MARGARINA GIRASOL 240G', 15, CAST(N'2023-11-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (131, N'MARGARINA BONELLA 3KG', 5, CAST(N'2024-02-17' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (132, N'DIFUSOR GLADE LAVANDA 100ML', 20, CAST(N'2024-05-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (133, N'MATAMOSCAS SURTIDO HAIXING', 30, CAST(N'2024-11-23' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (134, N'CLOROX LÍQUIDO BOTELLA 1L', 30, CAST(N'2024-06-19' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (135, N'LYSOL LAVANDA 3785ML', 30, CAST(N'2024-05-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (136, N'SUAVITEL DOYPACK 360ML ORQUÍDEA', 15, CAST(N'2024-04-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (137, N'SUAVIZANTE AROMATEL COCO 550ML', 15, CAST(N'2024-05-18' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (138, N'ESTROPAJO DE ALUMINIO SOLEX', 50, CAST(N'2024-09-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (139, N'GALLETA CLUB SOCIAL X9 234G', 25, CAST(N'2023-12-23' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (140, N'JUGO PULP NÉCTAR DURAZNO 1L', 24, CAST(N'2024-01-05' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (141, N'JUGO CIFRUT CITRUS PUNCH 3L', 12, CAST(N'2023-11-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (142, N'LECHE PARMALAC LITRO', 20, CAST(N'2023-07-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (143, N'LECHE PARMALAT DESLACTOSADA ZYMIL 1L', 30, CAST(N'2023-06-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (144, N'BOMBONES THE BELGIAN CHOCOLATE 200G', 20, CAST(N'2024-06-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (145, N'PAPAS RUFFLES CRE-CEB 400G', 30, CAST(N'2023-09-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (146, N'CHOCOLATES SNICKERS MINIS 275G', 30, CAST(N'2024-02-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (147, N'CHOCOLATE PACARI 200G PACK4', 10, CAST(N'2023-08-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (148, N'CHOCOLATE SCHOGETTEN ORIGINALS 100G', 10, CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (149, N'BOMBÓN DARK NOGGY 82G', 20, CAST(N'2023-11-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (150, N'GALLETA OREO ORIGINAL 432G PACK12', 15, CAST(N'2023-12-22' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (151, N'KINDER JOY 20G', 40, CAST(N'2024-02-10' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (152, N'GALLETA FESTIVAL VAINILLA 50G', 40, CAST(N'2024-01-02' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (153, N'CARAMELO HALLS STRONG LYPTUS 151.2G', 30, CAST(N'2023-11-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (154, N'MILLOWS MASMELO DE CREMA 250G', 20, CAST(N'2023-10-11' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (155, N'GALLETAS SALTICAS MINI 30G', 50, CAST(N'2023-12-23' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (156, N'ACEITE DE OLIVA MUELOLIVA 500ML', 20, CAST(N'2024-03-23' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (157, N'ACEITE GIRASOL 2L', 20, CAST(N'2024-02-21' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (158, N'ACEITE DE OLIVA EXTRA BETIS 250 ML', 40, CAST(N'2024-05-18' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (159, N'ACEITE ALESOL 500ML', 40, CAST(N'2023-12-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (160, N'ACEITE PALMA DE ORO 750 ML', 48, CAST(N'2023-11-22' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (161, N'CHOCOLATE VIZZIO 131G', 20, CAST(N'2024-05-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (163, N'ACHIOTE PALMA DE ORO 0.5L', 30, CAST(N'2024-05-01' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (164, N'FIDEO INSTANTÁNEO RAPIDITO POLLO 100G', 30, CAST(N'2023-11-10' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (165, N'MACARRÓN EKONO 350G', 20, CAST(N'2023-11-14' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (166, N'TORNILLO EKONO 350G', 10, CAST(N'2023-11-30' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (167, N'FRÉJOL DON CHICHO AMARILLO 500G', 25, CAST(N'2024-03-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (168, N'LENTEJON LA PRADERA 500G', 50, CAST(N'2024-02-14' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (169, N'FIDEO SPAGHETTI TOMADINI 500G', 30, CAST(N'2024-01-01' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (170, N'FIDEO CAYAMBE DINO 400G', 30, CAST(N'2024-05-07' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (171, N'CANGUIL EL AGRICULTOR 250G', 20, CAST(N'2024-03-05' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (172, N'LASAGNA TOSCANA 400G', 40, CAST(N'2024-07-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (173, N'DETERGENTE DEJA SUPERIOR 1800G', 30, CAST(N'2024-04-09' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (174, N'DETERGENTE CICLÓN FLORAL 5 KG', 30, CAST(N'2024-02-06' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (175, N'DETERGENTE LÍQUIDO DEJA FLORAL 500ML', 40, CAST(N'2024-01-09' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (176, N'BOMBONES FERRERO ROCHER PACK 8', 30, CAST(N'2023-12-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (177, N'MANTECA LOS 3 CHANCHITOS 175G', 30, CAST(N'2024-02-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (178, N'JABÓN LAVATODO FLORAL 960G PACK4', 40, CAST(N'2024-07-19' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (179, N'DETERGENTE LÍQUIDO WOOLITE 1800 ML', 30, CAST(N'2024-05-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (180, N'SUAVIZANTE PERLA LAV Y ORQ DOYPACK 1300ML', 30, CAST(N'2023-11-17' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (181, N'DETERGENTE GOL LIMÓN 480G', 40, CAST(N'2023-09-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (182, N'LIMPIA INODORO SAPOLIO 500ML', 20, CAST(N'2024-03-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (183, N'DESINFECTANTE TIPS 240ML', 50, CAST(N'2024-05-11' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (184, N'DESINFECTANTE OLIMPIA MANZANA 900ML', 30, CAST(N'2024-04-02' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (185, N'DESINFECTANTE FABULOSO FLORAL 2L', 50, CAST(N'2024-06-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (186, N'SELLO ROJO 375G', 30, CAST(N'2023-11-18' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (187, N'CLOROX LÍQUIDO ORIGINAL 160G', 60, CAST(N'2023-12-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (188, N'CLORO SAPOLIO 4000G', 24, CAST(N'2024-02-03' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (189, N'REPUESTO AMBIENTAL GLADE AUTO 7ML', 5, CAST(N'2024-03-09' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (190, N'REPELENTE LÍQUIDO RAID ELÉCTRICO', 20, CAST(N'2023-11-17' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (191, N'Q-KARACTION GEL CUCARACHA 10G', 10, CAST(N'2024-01-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (192, N'TRAMPA ENGOMADA ROEDORES', 15, CAST(N'2024-03-09' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (193, N'INSECTICIDA LÍQUIDO BAYGON 510ML', 18, CAST(N'2024-05-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (194, N'TRAMPA BIG CHEESE PARA RATÓN', 40, CAST(N'2025-07-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (195, N'INSECTICIDA TORVI 1000ML', 12, CAST(N'2024-10-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (196, N'EL SECRETO DE LA ABUELITA 225G', 24, CAST(N'2024-06-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (197, N'NAFTALINA TRIPLE ACCIÓN 24 UDS', 20, CAST(N'2024-05-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (198, N'RATICIDA CAMPEX 50G', 40, CAST(N'2024-07-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (199, N'INSECTICIDA AGUILA REAL LIMÓN 400ML', 12, CAST(N'2024-04-10' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (200, N'INSECTICIDA ZAP VOLADORES 360ML', 20, CAST(N'2024-02-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (201, N'AGUA SIN GAS DASANI 1200ML PACK6', 40, CAST(N'2023-12-22' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (202, N'AGUA SIN GAS SPLENDOR 5L', 25, CAST(N'2024-04-26' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (203, N'AGUA SIN GAS PURE WATER 6L', 30, CAST(N'2024-04-26' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (204, N'AGUA PURE WATER 625 ML', 80, CAST(N'2024-01-10' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (16, N'SALSA DE TOMATE MARCELLOS GALON', 50, CAST(N'2023-10-21' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (17, N'COCACOLA 3L ORIGINAL', 31, CAST(N'2023-10-21' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (18, N'ALIÑO CONDIMENSA 380GR', 52, CAST(N'2023-12-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (162, N'BOMBONES THE BELGIAN CHOCOLATE 200G', 30, CAST(N'2024-05-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (205, N'LECHE REYLECHE SURTIDO 200ML PACK6', 20, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (206, N'YOGU YOGU DE MORA 750ML', 12, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (207, N'LECHE TONI FRUTILLA 1L', 5, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (208, N'LECHE ENTERA FUNDA ANDINA 900ML PACK6', 10, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (209, N'LECHE SEMIDESCREMADA FUNDA ANDINA 900ML PACK6', 10, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (210, N'TONI CHOCOLATE 1L', 10, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (211, N'AMOR WAFFER 130G FRESA', 20, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (212, N'COLA TROPICAL 3.8 L', 20, CAST(N'2023-11-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (213, N'COLA MANZANA 3.8L', 20, CAST(N'2023-12-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (214, N'COLA KOLA GALLITO 3.78L', 20, CAST(N'2023-10-05' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (215, N'COLACOCA SIN AZÚCAR 1 LITRO', 10, CAST(N'2023-12-22' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (216, N'COLA BIG PET 300ML', 96, CAST(N'2023-11-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (217, N'COLA FANTA 1L', 60, CAST(N'2023-12-30' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (218, N'COLA MÁS SABOR NARANJA 3780ML', 30, CAST(N'2023-10-18' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (219, N'COLA INCA KOLA 3L', 30, CAST(N'2023-10-04' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (220, N'COLA SPRITE 1.75L', 25, CAST(N'2023-10-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (221, N'JUGO NATURA DURAZNO 1L', 30, CAST(N'2024-01-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (222, N'JUGO DEL VALLE NARANJA PACK2', 40, CAST(N'2024-01-28' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (242, N'LECHE TONI CHOCOLATADA 135ML PACK6', 30, CAST(N'2023-07-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (243, N'LECHE TONI DE FRUTILLA 200ML PACK6', 20, CAST(N'2023-08-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (244, N'LECHE TONI DE CHOCOLATADA 200ML PACK6', 20, CAST(N'2023-07-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (245, N'LECHE PARMALAT DESLACTOSADA ZYMIL 1L', 20, CAST(N'2023-07-18' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (246, N'LECHE NESQUIK CHOCOLATE 200ML', 30, CAST(N'2023-06-14' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (247, N'LECHE NESQUIK 200ML FRUTILLA', 20, CAST(N'2023-06-06' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (248, N'LECHE EN POLVO NUTRI 100G', 20, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (249, N'BEBIDA VEGETAL NOTMILK 1L', 20, CAST(N'2023-08-27' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (250, N'LECHE DE SOYA ORIENTAL 900G', 30, CAST(N'2023-09-22' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (251, N'LECHE PARMALAC LITRO', 30, CAST(N'2023-07-14' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (252, N'LECHE POLVO LA VAQUITA 190G', 20, CAST(N'2023-09-17' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (253, N'LECHE MILO CHOCOLATADA 185ML', 20, CAST(N'2023-07-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (44, N'DRAGON INSECTICIDA 475 ML', 10, CAST(N'2024-03-30' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (45, N'SAPOLIO AEROSOL 360 ML', 20, CAST(N'2023-12-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (46, N'CAFFE LATO MOCACCINO 285 ML PACK', 10, CAST(N'2023-10-17' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (47, N'VITA DESCREMADA 1L TETRAPACK', 20, CAST(N'2023-08-23' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (48, N'ANDINA SEMIDESCREMADA 900 ML FUNDA', 50, CAST(N'2023-10-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (49, N'NESTLE SVELTY 1L TETRA-BRIK', 50, CAST(N'2023-08-25' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (50, N'VITA DESLACTOSADA 1L TETRABRIK', 20, CAST(N'2023-10-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (97, N'COCA COLA PACK', 20, CAST(N'2023-12-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (98, N'FRUTARIS MANZANA 1L', 30, CAST(N'2024-04-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (99, N'SPRITE 300ML', 30, CAST(N'2023-12-05' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (100, N'COLA TROPICAL 1L', 50, CAST(N'2024-04-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (101, N'GÜITIG 1.5L', 40, CAST(N'2024-03-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (102, N'CERVEZA PILSENER SIXPACK 355ML', 20, CAST(N'2023-11-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (103, N'WHISKY JOHN MORRIS 750ML', 20, CAST(N'2024-01-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (104, N'WHISKY OLD TIMES 745ML RED', 20, CAST(N'2024-01-28' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (105, N'WHISKY GRANTS 750ML', 10, CAST(N'2024-03-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (106, N'CERVEZA BIELA SIXPACK 355ML', 20, CAST(N'2024-01-09' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (107, N'VINO SAUVIGNON 750 ML', 30, CAST(N'2025-08-30' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (108, N'VODKA RUSSKAYA 750CC', 20, CAST(N'2024-06-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (109, N'GALAK 500GR', 20, CAST(N'2024-02-07' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (110, N'BOMBONES FERRERO 50G', 20, CAST(N'2023-12-21' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (111, N'DORITOS 275G MEGA QUESO', 15, CAST(N'2024-02-23' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (112, N'TABLETA M&M 113.4G CHOCOLATE', 32, CAST(N'2024-03-08' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (113, N'HUEVITOS LA UNIVERSAL 265G CEREZA', 18, CAST(N'2023-11-24' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (114, N'BARRA DE CHOCOLATE LA UNIVERSAL 100G', 25, CAST(N'2024-01-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (115, N'KITKAT CHOCOLATE BLANCO 41.5G', 30, CAST(N'2024-01-20' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (116, N'FERRERO NUTELA 350G', 10, CAST(N'2024-01-17' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (117, N'DON CAFE 50G SOBRE', 20, CAST(N'2023-11-14' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (118, N'BUENDIA 170G', 14, CAST(N'2024-03-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (119, N'HELADO PINGÜINO 900ML MANICHO', 8, CAST(N'2024-01-10' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (120, N'JABON PALMOLIVE FRUTAS 120 X3', 24, CAST(N'2024-01-26' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (121, N'GELATINA 200G CHICLE', 15, CAST(N'2023-11-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (122, N'GALLETAS NESTLÉ MARIA 172G', 23, CAST(N'2023-10-12' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (123, N'BOMBA METALICO DRAGON 350CC', 4, CAST(N'2029-07-05' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (124, N'RAQUETA RECARGABLE MAYIK', 20, CAST(N'2029-07-05' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (125, N'RATICIDA KLERAT 50G', 15, CAST(N'2024-11-21' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (126, N'RAID INSECTICIDA 400CC', 15, CAST(N'2024-11-05' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (127, N'INSECTICIDA BAYGON 360ML', 35, CAST(N'2024-09-04' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (128, N'DRAGON INSECTICIDA 475 ML', 14, CAST(N'2024-05-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (236, N'LECHE TONI CHOCOLATE 200ML', 24, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (237, N'LECHE NUTRI SEMIDESCREMADA CARTÓN 1L PACK4', 10, CAST(N'2023-04-29' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (238, N'LECHE INDULAC SEMIDESCREMADA 1L', 10, CAST(N'2023-04-30' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (239, N'POLLO COMPLETO MR. POLLO', 80, CAST(N'2023-07-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (240, N'ACEITE PALMA ORO', 20, CAST(N'2024-01-13' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (241, N'AJO CONDIMENSA 470GR', 20, CAST(N'2024-03-16' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (223, N'RON CASTILLO AÑEJO 750ML', 15, CAST(N'2024-05-17' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (224, N'RON ABUELO AÑEJO 7 AÑOS - 750ML', 15, CAST(N'2024-04-09' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (225, N'RON DIPLOMÁTICO AÑEJO 750ML', 30, CAST(N'2024-08-11' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (226, N'TEQUILA EL CHARRO SILVER 750 ML', 20, CAST(N'2024-06-04' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (227, N'TEQUILA SOMBRERO NEGRO GOLD 750ML', 25, CAST(N'2024-04-10' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (228, N'RON ESTELAR SILVER 750ML', 20, CAST(N'2024-06-15' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (229, N'CRISTAL SECO 750ML', 40, CAST(N'2024-04-30' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (230, N'TRÓPICO SECO 750ML', 40, CAST(N'2024-06-01' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (231, N'RON HAVANA CLUB 750ML', 20, CAST(N'2023-12-30' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (232, N'AGUARDIENTE NORTEÑO ESPECIAL 750ML', 50, CAST(N'2024-02-17' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (233, N'VODKA SKY 750ML', 30, CAST(N'2024-01-02' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (234, N'VODKA LIOVA 750ML', 40, CAST(N'2024-04-06' AS Date))
GO
INSERT [dbo].[Can_Detalle_Producto] ([ID_Can_Detalle], [Nombre], [Cantidad], [Fecha_caducidad]) VALUES (235, N'VINO BLANCO LA VIEILLE FERME 750ML', 30, CAST(N'2024-02-13' AS Date))
GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Categoria]) VALUES (1, N'GOLOSINAS')
GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Categoria]) VALUES (2, N'COMESTIBLE')
GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Categoria]) VALUES (3, N'LIMPIEZA DE HOGAR')
GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Categoria]) VALUES (4, N'AGUAS Y BEBIDAS')
GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Categoria]) VALUES (5, N'INSECTICIDAS')
GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Categoria]) VALUES (6, N'LACTEOS')
GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Categoria]) VALUES (7, N'BEBIDAS ALCOHOLICAS')
GO
INSERT [dbo].[Clientes] ([ID_Cliente], [Codigo], [Nombre], [RUC_Cliente], [Direccion], [Telefono], [Email], [Estado]) VALUES (1, N'CLI00000001', N'Eloisa Teran Baque', N'0941347840', N'cdla x marcos', N'042-977-3570', N'eteranb2@gmail.com', N'Activo')
GO
INSERT [dbo].[Clientes] ([ID_Cliente], [Codigo], [Nombre], [RUC_Cliente], [Direccion], [Telefono], [Email], [Estado]) VALUES (2, N'CLI00000002', N'Arthur Teran', N'0941256522', N'amazonas y la huerta', N'125-415-4154', N'gusteran1@gmail.com', N'Activo')
GO
INSERT [dbo].[Clientes] ([ID_Cliente], [Codigo], [Nombre], [RUC_Cliente], [Direccion], [Telefono], [Email], [Estado]) VALUES (3, N'CLI00000003', N'Consumidor_Final', N'0999999999', N'Consumidor_Final', N'000-000-0000', N'Consumidor_Final', N'Activo')
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (1, 1, 1, 50, CAST(N'2023-08-19' AS Date), CAST(0.83 AS Decimal(12, 2)), CAST(41.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (2, 1, 8, 40, CAST(N'2023-10-21' AS Date), CAST(1.35 AS Decimal(12, 2)), CAST(54.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (3, 1, 13, 20, CAST(N'2023-08-24' AS Date), CAST(1.15 AS Decimal(12, 2)), CAST(23.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (5, 2, 4, 30, CAST(N'2023-12-09' AS Date), CAST(2.80 AS Decimal(12, 2)), CAST(84.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (6, 2, 3, 20, CAST(N'2023-10-12' AS Date), CAST(1.99 AS Decimal(12, 2)), CAST(39.80 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (7, 2, 11, 30, CAST(N'2023-12-30' AS Date), CAST(2.15 AS Decimal(12, 2)), CAST(64.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (8, 3, 14, 30, CAST(N'2024-07-03' AS Date), CAST(2.05 AS Decimal(12, 2)), CAST(61.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (9, 4, 7, 60, CAST(N'2023-06-25' AS Date), CAST(1.89 AS Decimal(12, 2)), CAST(113.40 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (11, 4, 7, 60, CAST(N'2023-10-25' AS Date), CAST(1.89 AS Decimal(12, 2)), CAST(113.40 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (12, 4, 10, 20, CAST(N'2023-05-12' AS Date), CAST(8.00 AS Decimal(12, 2)), CAST(160.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (13, 5, 14, 80, CAST(N'2023-09-02' AS Date), CAST(2.05 AS Decimal(12, 2)), CAST(164.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (14, 5, 8, 20, CAST(N'2023-10-14' AS Date), CAST(1.35 AS Decimal(12, 2)), CAST(27.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (15, 5, 5, 30, CAST(N'2023-11-25' AS Date), CAST(0.80 AS Decimal(12, 2)), CAST(24.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (16, 6, 10, 50, CAST(N'2023-10-21' AS Date), CAST(8.00 AS Decimal(12, 2)), CAST(400.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (17, 6, 14, 82, CAST(N'2023-10-21' AS Date), CAST(2.05 AS Decimal(12, 2)), CAST(168.10 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (18, 6, 12, 52, CAST(N'2023-12-15' AS Date), CAST(3.00 AS Decimal(12, 2)), CAST(156.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (19, 7, 9, 50, CAST(N'2023-05-12' AS Date), CAST(2.75 AS Decimal(12, 2)), CAST(137.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (20, 8, 15, 50, CAST(N'2023-03-03' AS Date), CAST(0.75 AS Decimal(12, 2)), CAST(37.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (21, 9, 1, 20, CAST(N'2023-11-25' AS Date), CAST(0.83 AS Decimal(12, 2)), CAST(16.60 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (22, 9, 6, 60, CAST(N'2023-09-20' AS Date), CAST(1.35 AS Decimal(12, 2)), CAST(81.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (23, 10, 2, 30, CAST(N'2024-03-09' AS Date), CAST(0.75 AS Decimal(12, 2)), CAST(22.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (24, 10, 5, 15, CAST(N'2023-12-05' AS Date), CAST(0.80 AS Decimal(12, 2)), CAST(12.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (25, 11, 16, 10, CAST(N'2023-04-01' AS Date), CAST(2.80 AS Decimal(12, 2)), CAST(28.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (26, 12, 15, 10, CAST(N'2023-04-29' AS Date), CAST(0.75 AS Decimal(12, 2)), CAST(7.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (27, 12, 17, 10, CAST(N'2023-04-29' AS Date), CAST(1.70 AS Decimal(12, 2)), CAST(17.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (28, 12, 18, 20, CAST(N'2023-04-29' AS Date), CAST(0.87 AS Decimal(12, 2)), CAST(17.40 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (29, 13, 19, 10, CAST(N'2023-04-29' AS Date), CAST(2.45 AS Decimal(12, 2)), CAST(24.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (30, 13, 20, 20, CAST(N'2023-04-29' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (31, 13, 21, 10, CAST(N'2023-04-29' AS Date), CAST(6.20 AS Decimal(12, 2)), CAST(62.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (32, 13, 22, 40, CAST(N'2024-02-10' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(200.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (33, 13, 23, 30, CAST(N'2023-12-20' AS Date), CAST(1.80 AS Decimal(12, 2)), CAST(54.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (34, 13, 24, 50, CAST(N'2023-04-29' AS Date), CAST(4.00 AS Decimal(12, 2)), CAST(200.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (35, 13, 25, 20, CAST(N'2023-07-14' AS Date), CAST(2.10 AS Decimal(12, 2)), CAST(42.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (36, 13, 26, 60, CAST(N'2024-03-29' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(30.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (37, 13, 27, 10, CAST(N'2024-02-21' AS Date), CAST(4.00 AS Decimal(12, 2)), CAST(40.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (38, 13, 28, 15, CAST(N'2023-12-12' AS Date), CAST(4.70 AS Decimal(12, 2)), CAST(70.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (39, 13, 29, 60, CAST(N'2023-10-11' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(30.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (40, 13, 30, 20, CAST(N'2023-10-29' AS Date), CAST(1.95 AS Decimal(12, 2)), CAST(39.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (41, 13, 31, 60, CAST(N'2023-11-24' AS Date), CAST(0.35 AS Decimal(12, 2)), CAST(21.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (42, 14, 32, 10, CAST(N'2023-08-18' AS Date), CAST(0.38 AS Decimal(12, 2)), CAST(3.80 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (43, 14, 34, 15, CAST(N'2023-10-20' AS Date), CAST(0.89 AS Decimal(12, 2)), CAST(13.35 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (44, 14, 35, 10, CAST(N'2024-03-30' AS Date), CAST(2.41 AS Decimal(12, 2)), CAST(24.10 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (45, 14, 36, 20, CAST(N'2023-12-29' AS Date), CAST(3.00 AS Decimal(12, 2)), CAST(60.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (46, 14, 37, 10, CAST(N'2023-10-17' AS Date), CAST(2.30 AS Decimal(12, 2)), CAST(23.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (47, 14, 38, 20, CAST(N'2023-08-23' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (48, 15, 39, 50, CAST(N'2023-10-20' AS Date), CAST(0.85 AS Decimal(12, 2)), CAST(42.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (49, 16, 40, 50, CAST(N'2023-08-25' AS Date), CAST(1.90 AS Decimal(12, 2)), CAST(95.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (50, 16, 41, 20, CAST(N'2023-10-13' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (51, 17, 16, 10, CAST(N'2023-09-29' AS Date), CAST(2.80 AS Decimal(12, 2)), CAST(28.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (52, 17, 33, 30, CAST(N'2023-12-23' AS Date), CAST(3.20 AS Decimal(12, 2)), CAST(96.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (53, 17, 42, 10, CAST(N'2024-05-18' AS Date), CAST(10.00 AS Decimal(12, 2)), CAST(100.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (54, 17, 44, 20, CAST(N'2024-03-28' AS Date), CAST(4.20 AS Decimal(12, 2)), CAST(84.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (55, 17, 43, 30, CAST(N'2024-02-14' AS Date), CAST(8.50 AS Decimal(12, 2)), CAST(255.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (56, 17, 45, 30, CAST(N'2023-12-13' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(150.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (57, 17, 46, 20, CAST(N'2024-05-24' AS Date), CAST(13.00 AS Decimal(12, 2)), CAST(260.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (58, 17, 47, 3, CAST(N'2024-04-16' AS Date), CAST(19.70 AS Decimal(12, 2)), CAST(59.10 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (59, 17, 48, 24, CAST(N'2024-02-06' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(120.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (60, 17, 49, 48, CAST(N'2024-11-29' AS Date), CAST(3.00 AS Decimal(12, 2)), CAST(144.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (61, 17, 50, 20, CAST(N'2024-03-20' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (62, 18, 15, 10, CAST(N'2023-10-29' AS Date), CAST(0.75 AS Decimal(12, 2)), CAST(7.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (63, 18, 38, 15, CAST(N'2023-04-29' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(15.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (64, 18, 16, 15, CAST(N'2023-04-29' AS Date), CAST(2.80 AS Decimal(12, 2)), CAST(42.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (65, 18, 39, 10, CAST(N'2023-04-29' AS Date), CAST(0.85 AS Decimal(12, 2)), CAST(8.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (66, 18, 40, 10, CAST(N'2023-04-29' AS Date), CAST(1.90 AS Decimal(12, 2)), CAST(19.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (67, 18, 41, 12, CAST(N'2023-04-29' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(12.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (68, 18, 57, 5, CAST(N'2023-04-29' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(2.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (69, 18, 62, 20, CAST(N'2024-03-02' AS Date), CAST(1.10 AS Decimal(12, 2)), CAST(22.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (70, 18, 85, 30, CAST(N'2024-02-13' AS Date), CAST(1.20 AS Decimal(12, 2)), CAST(36.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (71, 18, 87, 10, CAST(N'2023-08-23' AS Date), CAST(0.20 AS Decimal(12, 2)), CAST(2.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (72, 18, 88, 20, CAST(N'2023-04-30' AS Date), CAST(0.90 AS Decimal(12, 2)), CAST(18.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (73, 18, 89, 40, CAST(N'2023-07-15' AS Date), CAST(0.65 AS Decimal(12, 2)), CAST(26.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (74, 18, 91, 10, CAST(N'2023-04-29' AS Date), CAST(0.85 AS Decimal(12, 2)), CAST(8.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (75, 19, 1, 20, CAST(N'2023-07-21' AS Date), CAST(0.83 AS Decimal(12, 2)), CAST(16.60 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (76, 19, 5, 20, CAST(N'2024-05-24' AS Date), CAST(0.80 AS Decimal(12, 2)), CAST(16.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (77, 19, 22, 20, CAST(N'2024-03-13' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(100.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (78, 19, 51, 30, CAST(N'2023-10-12' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(15.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (79, 19, 13, 20, CAST(N'2024-07-12' AS Date), CAST(1.15 AS Decimal(12, 2)), CAST(23.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (80, 19, 12, 10, CAST(N'2024-04-10' AS Date), CAST(3.00 AS Decimal(12, 2)), CAST(30.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (81, 19, 24, 80, CAST(N'2024-03-07' AS Date), CAST(4.00 AS Decimal(12, 2)), CAST(320.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (82, 19, 11, 15, CAST(N'2024-02-07' AS Date), CAST(2.15 AS Decimal(12, 2)), CAST(32.25 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (83, 19, 9, 15, CAST(N'2024-02-24' AS Date), CAST(2.75 AS Decimal(12, 2)), CAST(41.25 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (84, 19, 21, 30, CAST(N'2024-01-03' AS Date), CAST(6.20 AS Decimal(12, 2)), CAST(186.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (85, 19, 18, 20, CAST(N'2024-04-20' AS Date), CAST(0.87 AS Decimal(12, 2)), CAST(17.40 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (86, 19, 19, 10, CAST(N'2024-02-21' AS Date), CAST(2.45 AS Decimal(12, 2)), CAST(24.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (87, 19, 64, 50, CAST(N'2024-07-20' AS Date), CAST(2.00 AS Decimal(12, 2)), CAST(100.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (88, 19, 35, 13, CAST(N'2024-02-06' AS Date), CAST(2.41 AS Decimal(12, 2)), CAST(31.33 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (89, 19, 56, 20, CAST(N'2023-12-13' AS Date), CAST(10.00 AS Decimal(12, 2)), CAST(200.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (90, 19, 65, 40, CAST(N'2024-02-17' AS Date), CAST(0.80 AS Decimal(12, 2)), CAST(32.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (91, 19, 63, 60, CAST(N'2024-05-11' AS Date), CAST(0.35 AS Decimal(12, 2)), CAST(21.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (92, 19, 52, 50, CAST(N'2024-02-06' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (93, 19, 53, 12, CAST(N'2024-01-27' AS Date), CAST(2.40 AS Decimal(12, 2)), CAST(28.80 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (94, 19, 29, 20, CAST(N'2024-06-15' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(10.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (95, 19, 61, 10, CAST(N'2024-05-15' AS Date), CAST(1.20 AS Decimal(12, 2)), CAST(12.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (96, 19, 68, 20, CAST(N'2024-05-25' AS Date), CAST(40.00 AS Decimal(12, 2)), CAST(800.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (97, 20, 28, 20, CAST(N'2023-12-29' AS Date), CAST(4.70 AS Decimal(12, 2)), CAST(94.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (98, 20, 52, 30, CAST(N'2024-04-13' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(15.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (99, 20, 66, 30, CAST(N'2023-12-05' AS Date), CAST(0.20 AS Decimal(12, 2)), CAST(6.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (100, 20, 32, 50, CAST(N'2024-04-13' AS Date), CAST(0.38 AS Decimal(12, 2)), CAST(19.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (101, 20, 54, 40, CAST(N'2024-03-13' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (102, 21, 44, 20, CAST(N'2023-11-16' AS Date), CAST(4.20 AS Decimal(12, 2)), CAST(84.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (103, 21, 69, 20, CAST(N'2024-01-20' AS Date), CAST(9.00 AS Decimal(12, 2)), CAST(180.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (104, 21, 70, 20, CAST(N'2024-01-28' AS Date), CAST(8.00 AS Decimal(12, 2)), CAST(160.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (105, 21, 72, 10, CAST(N'2024-03-16' AS Date), CAST(17.00 AS Decimal(12, 2)), CAST(170.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (106, 21, 45, 20, CAST(N'2024-01-09' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(100.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (107, 21, 71, 30, CAST(N'2025-08-30' AS Date), CAST(10.00 AS Decimal(12, 2)), CAST(300.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (108, 21, 67, 20, CAST(N'2024-06-12' AS Date), CAST(9.70 AS Decimal(12, 2)), CAST(194.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (109, 22, 8, 20, CAST(N'2024-02-07' AS Date), CAST(1.35 AS Decimal(12, 2)), CAST(27.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (110, 22, 73, 20, CAST(N'2023-12-21' AS Date), CAST(2.75 AS Decimal(12, 2)), CAST(55.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (111, 22, 74, 15, CAST(N'2024-02-23' AS Date), CAST(2.00 AS Decimal(12, 2)), CAST(30.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (112, 22, 75, 32, CAST(N'2024-03-08' AS Date), CAST(3.00 AS Decimal(12, 2)), CAST(96.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (113, 22, 76, 18, CAST(N'2023-11-24' AS Date), CAST(2.00 AS Decimal(12, 2)), CAST(36.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (114, 22, 98, 25, CAST(N'2024-01-20' AS Date), CAST(0.80 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (115, 22, 77, 30, CAST(N'2024-01-20' AS Date), CAST(0.60 AS Decimal(12, 2)), CAST(18.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (116, 22, 21, 10, CAST(N'2024-01-17' AS Date), CAST(6.20 AS Decimal(12, 2)), CAST(62.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (117, 23, 55, 20, CAST(N'2023-11-14' AS Date), CAST(1.15 AS Decimal(12, 2)), CAST(23.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (118, 23, 56, 14, CAST(N'2024-03-29' AS Date), CAST(10.00 AS Decimal(12, 2)), CAST(140.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (119, 23, 58, 8, CAST(N'2024-01-10' AS Date), CAST(4.00 AS Decimal(12, 2)), CAST(32.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (120, 23, 59, 24, CAST(N'2024-01-26' AS Date), CAST(1.40 AS Decimal(12, 2)), CAST(33.60 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (121, 23, 60, 15, CAST(N'2023-11-15' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(7.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (122, 23, 78, 23, CAST(N'2023-10-12' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(11.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (123, 23, 79, 4, CAST(N'2029-07-05' AS Date), CAST(2.20 AS Decimal(12, 2)), CAST(8.80 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (124, 23, 80, 20, CAST(N'2029-07-05' AS Date), CAST(4.50 AS Decimal(12, 2)), CAST(90.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (125, 23, 81, 15, CAST(N'2024-11-21' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(15.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (126, 23, 33, 15, CAST(N'2024-11-05' AS Date), CAST(3.20 AS Decimal(12, 2)), CAST(48.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (127, 23, 82, 35, CAST(N'2024-09-04' AS Date), CAST(2.80 AS Decimal(12, 2)), CAST(98.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (128, 23, 35, 14, CAST(N'2024-05-15' AS Date), CAST(2.41 AS Decimal(12, 2)), CAST(33.74 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (129, 24, 83, 15, CAST(N'2024-01-20' AS Date), CAST(1.20 AS Decimal(12, 2)), CAST(18.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (130, 24, 84, 15, CAST(N'2023-11-15' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(15.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (131, 24, 90, 5, CAST(N'2024-02-17' AS Date), CAST(10.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (132, 24, 92, 20, CAST(N'2024-05-25' AS Date), CAST(5.80 AS Decimal(12, 2)), CAST(116.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (133, 24, 86, 30, CAST(N'2024-11-23' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(30.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (134, 24, 93, 30, CAST(N'2024-06-19' AS Date), CAST(0.70 AS Decimal(12, 2)), CAST(21.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (135, 24, 94, 30, CAST(N'2024-05-15' AS Date), CAST(7.00 AS Decimal(12, 2)), CAST(210.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (136, 24, 25, 15, CAST(N'2024-04-24' AS Date), CAST(2.10 AS Decimal(12, 2)), CAST(31.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (137, 24, 95, 15, CAST(N'2024-05-18' AS Date), CAST(1.30 AS Decimal(12, 2)), CAST(19.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (138, 24, 96, 50, CAST(N'2024-09-20' AS Date), CAST(0.25 AS Decimal(12, 2)), CAST(12.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (139, 24, 97, 25, CAST(N'2023-12-23' AS Date), CAST(1.50 AS Decimal(12, 2)), CAST(37.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (140, 24, 99, 24, CAST(N'2024-01-05' AS Date), CAST(0.90 AS Decimal(12, 2)), CAST(21.60 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (141, 24, 100, 12, CAST(N'2023-11-16' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(12.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (142, 25, 15, 20, CAST(N'2023-07-15' AS Date), CAST(0.75 AS Decimal(12, 2)), CAST(15.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (143, 25, 184, 30, CAST(N'2023-06-20' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(30.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (144, 25, 104, 20, CAST(N'2024-06-13' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(100.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (145, 25, 105, 30, CAST(N'2023-09-12' AS Date), CAST(2.99 AS Decimal(12, 2)), CAST(89.70 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (146, 25, 106, 30, CAST(N'2024-02-24' AS Date), CAST(7.00 AS Decimal(12, 2)), CAST(210.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (147, 25, 107, 10, CAST(N'2023-08-16' AS Date), CAST(7.70 AS Decimal(12, 2)), CAST(77.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (148, 25, 108, 10, CAST(N'2023-06-07' AS Date), CAST(1.40 AS Decimal(12, 2)), CAST(14.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (149, 25, 109, 20, CAST(N'2023-11-24' AS Date), CAST(1.70 AS Decimal(12, 2)), CAST(34.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (150, 25, 110, 15, CAST(N'2023-12-22' AS Date), CAST(3.00 AS Decimal(12, 2)), CAST(45.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (151, 25, 111, 40, CAST(N'2024-02-10' AS Date), CAST(0.80 AS Decimal(12, 2)), CAST(32.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (152, 25, 112, 40, CAST(N'2024-01-02' AS Date), CAST(0.10 AS Decimal(12, 2)), CAST(4.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (153, 25, 113, 30, CAST(N'2023-11-15' AS Date), CAST(2.00 AS Decimal(12, 2)), CAST(60.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (154, 25, 114, 20, CAST(N'2023-10-11' AS Date), CAST(1.50 AS Decimal(12, 2)), CAST(30.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (155, 25, 115, 50, CAST(N'2023-12-23' AS Date), CAST(0.12 AS Decimal(12, 2)), CAST(6.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (156, 25, 117, 20, CAST(N'2024-03-23' AS Date), CAST(4.70 AS Decimal(12, 2)), CAST(94.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (157, 25, 116, 20, CAST(N'2024-02-21' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(100.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (158, 25, 118, 40, CAST(N'2024-05-18' AS Date), CAST(3.00 AS Decimal(12, 2)), CAST(120.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (159, 25, 119, 40, CAST(N'2023-12-13' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(40.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (160, 25, 120, 48, CAST(N'2023-11-22' AS Date), CAST(1.40 AS Decimal(12, 2)), CAST(67.20 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (161, 26, 103, 20, CAST(N'2024-05-25' AS Date), CAST(2.50 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (162, 26, 104, 30, CAST(N'2024-05-15' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(150.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (163, 26, 122, 30, CAST(N'2024-05-01' AS Date), CAST(1.50 AS Decimal(12, 2)), CAST(45.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (164, 26, 123, 30, CAST(N'2023-11-10' AS Date), CAST(0.40 AS Decimal(12, 2)), CAST(12.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (165, 26, 124, 20, CAST(N'2023-11-14' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(10.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (166, 26, 125, 10, CAST(N'2023-11-30' AS Date), CAST(0.60 AS Decimal(12, 2)), CAST(6.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (167, 26, 126, 25, CAST(N'2024-03-16' AS Date), CAST(1.70 AS Decimal(12, 2)), CAST(42.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (168, 26, 128, 50, CAST(N'2024-02-14' AS Date), CAST(1.20 AS Decimal(12, 2)), CAST(60.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (169, 26, 127, 30, CAST(N'2024-01-01' AS Date), CAST(1.05 AS Decimal(12, 2)), CAST(31.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (170, 26, 129, 30, CAST(N'2024-05-07' AS Date), CAST(0.80 AS Decimal(12, 2)), CAST(24.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (171, 26, 130, 20, CAST(N'2024-03-05' AS Date), CAST(0.40 AS Decimal(12, 2)), CAST(8.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (172, 26, 131, 40, CAST(N'2024-07-12' AS Date), CAST(3.70 AS Decimal(12, 2)), CAST(148.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (173, 26, 132, 30, CAST(N'2024-04-09' AS Date), CAST(3.50 AS Decimal(12, 2)), CAST(105.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (174, 26, 133, 30, CAST(N'2024-02-06' AS Date), CAST(9.75 AS Decimal(12, 2)), CAST(292.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (175, 26, 134, 40, CAST(N'2024-01-09' AS Date), CAST(4.00 AS Decimal(12, 2)), CAST(160.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (176, 27, 102, 30, CAST(N'2023-12-16' AS Date), CAST(6.50 AS Decimal(12, 2)), CAST(195.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (177, 27, 121, 30, CAST(N'2024-02-25' AS Date), CAST(0.25 AS Decimal(12, 2)), CAST(7.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (178, 27, 135, 40, CAST(N'2024-07-19' AS Date), CAST(1.90 AS Decimal(12, 2)), CAST(76.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (179, 27, 136, 30, CAST(N'2024-05-15' AS Date), CAST(4.80 AS Decimal(12, 2)), CAST(144.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (180, 27, 137, 30, CAST(N'2023-11-17' AS Date), CAST(2.70 AS Decimal(12, 2)), CAST(81.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (181, 27, 138, 40, CAST(N'2023-09-13' AS Date), CAST(0.40 AS Decimal(12, 2)), CAST(16.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (182, 27, 139, 20, CAST(N'2024-03-29' AS Date), CAST(1.50 AS Decimal(12, 2)), CAST(30.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (183, 27, 141, 50, CAST(N'2024-05-11' AS Date), CAST(0.29 AS Decimal(12, 2)), CAST(14.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (184, 27, 142, 30, CAST(N'2024-04-02' AS Date), CAST(1.38 AS Decimal(12, 2)), CAST(41.40 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (185, 27, 143, 50, CAST(N'2024-06-15' AS Date), CAST(3.20 AS Decimal(12, 2)), CAST(160.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (186, 28, 140, 30, CAST(N'2023-11-18' AS Date), CAST(1.70 AS Decimal(12, 2)), CAST(51.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (187, 28, 144, 60, CAST(N'2023-12-15' AS Date), CAST(0.10 AS Decimal(12, 2)), CAST(6.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (188, 28, 145, 24, CAST(N'2024-02-03' AS Date), CAST(2.00 AS Decimal(12, 2)), CAST(48.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (189, 28, 146, 5, CAST(N'2024-03-09' AS Date), CAST(7.00 AS Decimal(12, 2)), CAST(35.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (190, 28, 147, 20, CAST(N'2023-11-17' AS Date), CAST(9.15 AS Decimal(12, 2)), CAST(183.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (191, 28, 148, 10, CAST(N'2024-01-13' AS Date), CAST(9.70 AS Decimal(12, 2)), CAST(97.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (192, 28, 149, 15, CAST(N'2024-03-09' AS Date), CAST(6.00 AS Decimal(12, 2)), CAST(90.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (193, 28, 150, 18, CAST(N'2024-05-12' AS Date), CAST(3.00 AS Decimal(12, 2)), CAST(54.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (194, 28, 151, 40, CAST(N'2025-07-24' AS Date), CAST(1.20 AS Decimal(12, 2)), CAST(48.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (195, 28, 152, 12, CAST(N'2024-10-24' AS Date), CAST(3.75 AS Decimal(12, 2)), CAST(45.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (196, 28, 153, 24, CAST(N'2024-06-12' AS Date), CAST(1.40 AS Decimal(12, 2)), CAST(33.60 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (197, 28, 154, 20, CAST(N'2024-05-15' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (198, 28, 155, 40, CAST(N'2024-07-12' AS Date), CAST(0.70 AS Decimal(12, 2)), CAST(28.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (199, 28, 156, 12, CAST(N'2024-04-10' AS Date), CAST(2.90 AS Decimal(12, 2)), CAST(34.80 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (200, 28, 157, 20, CAST(N'2024-02-15' AS Date), CAST(1.50 AS Decimal(12, 2)), CAST(30.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (201, 28, 158, 40, CAST(N'2023-12-22' AS Date), CAST(2.20 AS Decimal(12, 2)), CAST(88.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (202, 28, 159, 25, CAST(N'2024-04-26' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (203, 28, 160, 30, CAST(N'2024-04-26' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(30.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (204, 28, 161, 80, CAST(N'2024-01-10' AS Date), CAST(0.15 AS Decimal(12, 2)), CAST(12.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (205, 28, 173, 20, CAST(N'2023-04-29' AS Date), CAST(2.80 AS Decimal(12, 2)), CAST(56.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (206, 28, 174, 12, CAST(N'2023-04-29' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(12.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (207, 28, 175, 5, CAST(N'2023-04-29' AS Date), CAST(1.70 AS Decimal(12, 2)), CAST(8.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (208, 28, 177, 10, CAST(N'2023-04-29' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (209, 28, 178, 10, CAST(N'2023-04-29' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (210, 28, 16, 10, CAST(N'2023-04-29' AS Date), CAST(2.80 AS Decimal(12, 2)), CAST(28.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (211, 29, 20, 20, CAST(N'2023-04-29' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (212, 29, 162, 20, CAST(N'2023-11-25' AS Date), CAST(1.80 AS Decimal(12, 2)), CAST(36.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (213, 29, 163, 20, CAST(N'2023-12-16' AS Date), CAST(1.75 AS Decimal(12, 2)), CAST(35.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (214, 29, 164, 20, CAST(N'2023-10-05' AS Date), CAST(1.70 AS Decimal(12, 2)), CAST(34.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (215, 29, 165, 10, CAST(N'2023-12-22' AS Date), CAST(0.40 AS Decimal(12, 2)), CAST(4.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (216, 29, 166, 96, CAST(N'2023-11-16' AS Date), CAST(0.15 AS Decimal(12, 2)), CAST(14.40 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (217, 29, 167, 60, CAST(N'2023-12-30' AS Date), CAST(0.40 AS Decimal(12, 2)), CAST(24.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (218, 29, 168, 30, CAST(N'2023-10-18' AS Date), CAST(1.50 AS Decimal(12, 2)), CAST(45.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (219, 29, 169, 30, CAST(N'2023-10-04' AS Date), CAST(2.00 AS Decimal(12, 2)), CAST(60.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (220, 29, 170, 25, CAST(N'2023-10-29' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(25.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (221, 29, 171, 30, CAST(N'2024-01-12' AS Date), CAST(1.10 AS Decimal(12, 2)), CAST(33.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (222, 29, 172, 40, CAST(N'2024-01-28' AS Date), CAST(1.70 AS Decimal(12, 2)), CAST(68.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (223, 30, 191, 15, CAST(N'2024-05-17' AS Date), CAST(9.00 AS Decimal(12, 2)), CAST(135.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (224, 30, 193, 15, CAST(N'2024-04-09' AS Date), CAST(14.00 AS Decimal(12, 2)), CAST(210.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (225, 30, 194, 30, CAST(N'2024-08-11' AS Date), CAST(22.00 AS Decimal(12, 2)), CAST(660.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (226, 30, 195, 20, CAST(N'2024-06-04' AS Date), CAST(11.00 AS Decimal(12, 2)), CAST(220.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (227, 30, 196, 25, CAST(N'2024-04-10' AS Date), CAST(22.00 AS Decimal(12, 2)), CAST(550.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (228, 30, 192, 20, CAST(N'2024-06-15' AS Date), CAST(6.50 AS Decimal(12, 2)), CAST(130.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (229, 30, 197, 40, CAST(N'2024-04-30' AS Date), CAST(4.00 AS Decimal(12, 2)), CAST(160.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (230, 30, 198, 40, CAST(N'2024-06-01' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(200.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (231, 30, 190, 20, CAST(N'2023-12-30' AS Date), CAST(18.00 AS Decimal(12, 2)), CAST(360.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (232, 30, 199, 50, CAST(N'2024-02-17' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(250.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (233, 30, 200, 30, CAST(N'2024-01-02' AS Date), CAST(12.00 AS Decimal(12, 2)), CAST(360.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (234, 30, 201, 40, CAST(N'2024-04-06' AS Date), CAST(5.00 AS Decimal(12, 2)), CAST(200.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (235, 30, 202, 30, CAST(N'2024-02-13' AS Date), CAST(7.00 AS Decimal(12, 2)), CAST(210.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (236, 31, 176, 24, CAST(N'2023-04-29' AS Date), CAST(0.50 AS Decimal(12, 2)), CAST(12.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (237, 31, 179, 10, CAST(N'2023-04-29' AS Date), CAST(4.00 AS Decimal(12, 2)), CAST(40.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (238, 31, 180, 10, CAST(N'2023-04-30' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(10.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (239, 32, 7, 80, CAST(N'2023-07-16' AS Date), CAST(1.89 AS Decimal(12, 2)), CAST(151.20 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (240, 32, 6, 20, CAST(N'2024-01-13' AS Date), CAST(1.35 AS Decimal(12, 2)), CAST(27.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (241, 32, 13, 20, CAST(N'2024-03-16' AS Date), CAST(1.15 AS Decimal(12, 2)), CAST(23.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (242, 33, 181, 30, CAST(N'2023-07-15' AS Date), CAST(2.00 AS Decimal(12, 2)), CAST(60.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (243, 33, 182, 20, CAST(N'2023-08-25' AS Date), CAST(3.70 AS Decimal(12, 2)), CAST(74.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (244, 33, 183, 20, CAST(N'2023-07-20' AS Date), CAST(3.70 AS Decimal(12, 2)), CAST(74.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (245, 33, 184, 20, CAST(N'2023-07-18' AS Date), CAST(1.00 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (246, 33, 185, 30, CAST(N'2023-06-14' AS Date), CAST(0.40 AS Decimal(12, 2)), CAST(12.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (247, 33, 186, 20, CAST(N'2023-06-06' AS Date), CAST(0.40 AS Decimal(12, 2)), CAST(8.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (248, 33, 187, 20, CAST(N'2023-04-29' AS Date), CAST(0.70 AS Decimal(12, 2)), CAST(14.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (249, 33, 188, 20, CAST(N'2023-08-27' AS Date), CAST(3.00 AS Decimal(12, 2)), CAST(60.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (250, 33, 189, 30, CAST(N'2023-09-22' AS Date), CAST(11.00 AS Decimal(12, 2)), CAST(330.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (251, 33, 15, 30, CAST(N'2023-07-14' AS Date), CAST(0.75 AS Decimal(12, 2)), CAST(22.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (252, 33, 85, 20, CAST(N'2023-09-17' AS Date), CAST(1.20 AS Decimal(12, 2)), CAST(24.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Producto] ([ID_Detalle], [Id_Ingreso], [Id_Producto], [Cantidad], [Fecha_caducidad], [Costo_Unitario], [Sub_Total]) VALUES (253, 33, 89, 20, CAST(N'2023-07-12' AS Date), CAST(0.65 AS Decimal(12, 2)), CAST(13.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (1, 1, 5, N'UNIDAD', 2, CAST(1.02 AS Decimal(12, 2)), CAST(2.04 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.24 AS Decimal(12, 2)), CAST(2.28 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (2, 1, 15, N'UNIDAD', 2, CAST(0.97 AS Decimal(12, 2)), CAST(1.94 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.94 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (3, 2, 15, N'UNIDAD', 30, CAST(0.97 AS Decimal(12, 2)), CAST(29.10 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(29.10 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (7, 3, 14, N'UNIDAD', 10, CAST(2.75 AS Decimal(12, 2)), CAST(27.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.30 AS Decimal(12, 2)), CAST(30.80 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (8, 4, 15, N'UNIDAD', 2, CAST(0.97 AS Decimal(12, 2)), CAST(1.94 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.94 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (9, 5, 14, N'UNIDAD', 10, CAST(2.75 AS Decimal(12, 2)), CAST(27.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.30 AS Decimal(12, 2)), CAST(30.80 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (10, 6, 14, N'UNIDAD', 10, CAST(2.75 AS Decimal(12, 2)), CAST(27.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.30 AS Decimal(12, 2)), CAST(30.80 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (14, 7, 14, N'UNIDAD', 10, CAST(2.75 AS Decimal(12, 2)), CAST(27.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.30 AS Decimal(12, 2)), CAST(30.80 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (15, 8, 7, N'KG', 20, CAST(2.10 AS Decimal(12, 2)), CAST(42.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(42.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (16, 9, 1, N'UNIDAD', 10, CAST(0.90 AS Decimal(12, 2)), CAST(9.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.08 AS Decimal(12, 2)), CAST(10.08 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (17, 9, 15, N'UNIDAD', 16, CAST(0.97 AS Decimal(12, 2)), CAST(15.52 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(15.52 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (18, 10, 6, N'UNIDAD', 10, CAST(2.00 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (19, 11, 7, N'KG', 5, CAST(2.10 AS Decimal(12, 2)), CAST(10.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(10.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (20, 11, 14, N'UNIDAD', 2, CAST(2.75 AS Decimal(12, 2)), CAST(5.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.66 AS Decimal(12, 2)), CAST(6.16 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (21, 12, 16, N'UNIDAD', 10, CAST(3.10 AS Decimal(12, 2)), CAST(31.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.72 AS Decimal(12, 2)), CAST(34.72 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (22, 13, 1, N'UNIDAD', 1, CAST(0.90 AS Decimal(12, 2)), CAST(0.90 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.11 AS Decimal(12, 2)), CAST(1.01 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (23, 14, 1, N'UNIDAD', 3, CAST(0.90 AS Decimal(12, 2)), CAST(2.70 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.32 AS Decimal(12, 2)), CAST(3.02 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (24, 14, 3, N'UNIDAD', 2, CAST(2.50 AS Decimal(12, 2)), CAST(5.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.60 AS Decimal(12, 2)), CAST(5.60 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (25, 15, 46, N'CAJA', 5, CAST(14.50 AS Decimal(12, 2)), CAST(72.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(8.70 AS Decimal(12, 2)), CAST(81.20 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (26, 15, 48, N'UNIDAD', 2, CAST(6.12 AS Decimal(12, 2)), CAST(12.24 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.47 AS Decimal(12, 2)), CAST(13.71 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (27, 15, 50, N'UNIDAD', 3, CAST(1.35 AS Decimal(12, 2)), CAST(3.97 AS Decimal(12, 2)), CAST(0.08 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.97 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (28, 15, 14, N'UNIDAD', 3, CAST(2.75 AS Decimal(12, 2)), CAST(8.25 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.99 AS Decimal(12, 2)), CAST(9.24 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (29, 15, 26, N'UNIDAD', 5, CAST(0.60 AS Decimal(12, 2)), CAST(3.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.36 AS Decimal(12, 2)), CAST(3.36 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (30, 15, 31, N'UNIDAD', 10, CAST(0.43 AS Decimal(12, 2)), CAST(4.30 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.52 AS Decimal(12, 2)), CAST(4.82 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (31, 15, 2, N'UNIDAD', 10, CAST(2.15 AS Decimal(12, 2)), CAST(21.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(21.50 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (32, 16, 15, N'UNIDAD', 20, CAST(0.97 AS Decimal(12, 2)), CAST(19.40 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(19.40 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (33, 17, 1, N'UNIDAD', 37, CAST(0.90 AS Decimal(12, 2)), CAST(33.30 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(4.00 AS Decimal(12, 2)), CAST(37.30 AS Decimal(12, 2)))
GO
INSERT [dbo].[Detalle_Ventas] ([ID_DetalleVentas], [ID_Venta], [ID_Producto], [Presentacion], [Cantidad], [Precio_Venta], [Sub_Total], [Descuento], [IVA], [Monto_Total]) VALUES (34, 18, 14, N'UNIDAD', 56, CAST(2.75 AS Decimal(12, 2)), CAST(154.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(18.48 AS Decimal(12, 2)), CAST(172.48 AS Decimal(12, 2)))
GO

INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (1, N'ING00000001', 1, CAST(N'2023-02-15' AS Date), N'NP000015242', CAST(118.50 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (2, N'ING00000002', 4, CAST(N'2023-02-16' AS Date), N'CB1521001251', CAST(188.30 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (3, N'ING00000003', 3, CAST(N'2023-02-17' AS Date), N'AC1222052121', CAST(61.50 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (4, N'ING00000004', 2, CAST(N'2023-02-17' AS Date), N'PR0000121512', CAST(273.40 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (5, N'ING00000005', 3, CAST(N'2023-02-18' AS Date), N'CB121512021', CAST(215.00 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (6, N'ING00000006', 3, CAST(N'2023-02-18' AS Date), N'AC00001221512', CAST(724.10 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (7, N'ING00000007', 1, CAST(N'2023-02-19' AS Date), N'NP012121200', CAST(137.50 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (8, N'ING00000008', 4, CAST(N'2023-02-19' AS Date), N'DC0001215141', CAST(37.50 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (9, N'ING00000009', 1, CAST(N'2023-02-20' AS Date), N'NT000012512', CAST(97.60 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (10, N'ING00000010', 4, CAST(N'2023-02-21' AS Date), N'DV0000124564', CAST(34.50 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (11, N'ING00000011', 1, CAST(N'2023-02-22' AS Date), N'NS000000152', CAST(28.00 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (12, N'ING00000012', 4, CAST(N'2023-02-23' AS Date), N'DV00012552', CAST(41.90 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (13, N'ING00000013', 1, CAST(N'2023-02-27' AS Date), N'NV00012151212', CAST(833.00 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (14, N'ING00000014', 3, CAST(N'2023-03-01' AS Date), N'AC0000012151', CAST(144.25 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (15, N'ING00000015', 2, CAST(N'2023-03-01' AS Date), N'PR0000001521', CAST(42.50 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (16, N'ING00000016', 1, CAST(N'2023-03-02' AS Date), N'NR0000125812', CAST(115.00 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (17, N'ING00000017', 4, CAST(N'2023-03-03' AS Date), N'DV0001254214', CAST(1316.10 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (18, N'ING00000018', 5, CAST(N'2023-03-04' AS Date), N'LT0000012452', CAST(219.00 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (19, N'ING00000019', 4, CAST(N'2023-03-05' AS Date), N'DV0001254228', CAST(2082.13 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (20, N'ING00000020', 6, CAST(N'2023-03-06' AS Date), N'TSC000125421', CAST(154.00 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (21, N'ING00000021', 7, CAST(N'2023-03-07' AS Date), N'CN0000125411', CAST(1188.00 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (22, N'ING00000022', 8, CAST(N'2023-03-08' AS Date), N'CF00001224215', CAST(344.00 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (23, N'ING00000023', 4, CAST(N'2023-03-09' AS Date), N'DC00125489941', CAST(541.14 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (24, N'ING00000024', 4, CAST(N'2023-03-10' AS Date), N'DC0015241224', CAST(594.60 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (25, N'ING00000025', 6, CAST(N'2023-03-11' AS Date), N'TS0000154211', CAST(1167.90 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (26, N'ING00000026', 8, CAST(N'2023-03-12' AS Date), N'CF000125421', CAST(1144.50 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (27, N'ING00000027', 1, CAST(N'2023-03-13' AS Date), N'NA0000125512', CAST(765.40 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (28, N'ING00000028', 4, CAST(N'2023-03-14' AS Date), N'DC000014121512', CAST(1162.90 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (29, N'ING00000029', 3, CAST(N'2023-03-15' AS Date), N'AC00001554121', CAST(398.40 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (30, N'ING00000030', 9, CAST(N'2023-03-18' AS Date), N'DL0000015242', CAST(3645.00 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (31, N'ING00000031', 5, CAST(N'2023-03-19' AS Date), N'LT000145218522', CAST(62.00 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (32, N'ING00000032', 2, CAST(N'2023-03-21' AS Date), N'PR000001425152', CAST(201.20 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Ingreso_Producto] ([ID_Ingreso], [No_Ingreso], [Id_Proveedor], [Fecha_Ingreso], [Comprobante], [Monto_Total], [Estado]) VALUES (33, N'ING00000033', 5, CAST(N'2023-03-23' AS Date), N'LT00001452152', CAST(711.50 AS Decimal(12, 2)), N'Emitir')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (1, 1, N'PROD00000001', N'GALLETA OREO TACO', 39, CAST(0.83 AS Decimal(10, 2)), CAST(0.90 AS Decimal(10, 2)), CAST(32.37 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (2, 2, N'PROD00000002', N'SUMESA PASTA 400G', 20, CAST(0.75 AS Decimal(10, 2)), CAST(2.15 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (3, 3, N'PROD00000003', N'CICLON 400GR', 18, CAST(1.99 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)), CAST(35.82 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (4, 3, N'PROD00000004', N'DEJA LIMON 1K', 30, CAST(2.80 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)), CAST(84.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (5, 3, N'PROD00000005', N'MACHO 200GR', 63, CAST(0.80 AS Decimal(10, 2)), CAST(1.02 AS Decimal(10, 2)), CAST(50.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (6, 2, N'PROD00000006', N'ACEITE PALMA ORO', 70, CAST(1.35 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(94.50 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (7, 2, N'PROD00000007', N'POLLO COMPLETO MR. POLLO', 175, CAST(1.89 AS Decimal(10, 2)), CAST(2.10 AS Decimal(10, 2)), CAST(330.75 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (8, 1, N'PROD00000008', N'GALAK 500GR', 80, CAST(1.35 AS Decimal(10, 2)), CAST(2.15 AS Decimal(10, 2)), CAST(108.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (9, 2, N'PROD00000009', N'MAYONESA GUSTADINA 330 G', 65, CAST(2.75 AS Decimal(10, 2)), CAST(3.15 AS Decimal(10, 2)), CAST(178.75 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (10, 2, N'PROD00000010', N'SALSA DE TOMATE MARCELLOS GALON', 70, CAST(8.00 AS Decimal(10, 2)), CAST(9.25 AS Decimal(10, 2)), CAST(560.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (11, 2, N'PROD00000011', N'MOSTAZA MAGGI 330GR', 45, CAST(2.15 AS Decimal(10, 2)), CAST(2.75 AS Decimal(10, 2)), CAST(96.75 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (12, 2, N'PROD00000012', N'ALIÑO CONDIMENSA 380GR', 62, CAST(3.00 AS Decimal(10, 2)), CAST(3.75 AS Decimal(10, 2)), CAST(186.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (13, 2, N'PROD00000013', N'AJO CONDIMENSA 470GR', 60, CAST(1.15 AS Decimal(10, 2)), CAST(1.75 AS Decimal(10, 2)), CAST(69.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (14, 4, N'PROD00000014', N'COCACOLA 3L ORIGINAL', 91, CAST(2.05 AS Decimal(10, 2)), CAST(2.75 AS Decimal(10, 2)), CAST(186.55 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (15, 6, N'PROD00000015', N'LECHE PARMALAC LITRO', 50, CAST(0.75 AS Decimal(10, 2)), CAST(0.97 AS Decimal(10, 2)), CAST(37.50 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (16, 1, N'PROD00000016', N'TONI CHOCOLATE 1L', 35, CAST(2.80 AS Decimal(10, 2)), CAST(3.10 AS Decimal(10, 2)), CAST(98.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (17, 1, N'PROD00000017', N'GALLETAS SALTICAS 378 G', 10, CAST(1.70 AS Decimal(10, 2)), CAST(1.99 AS Decimal(10, 2)), CAST(17.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (18, 1, N'PROD00000018', N'LONCHYS POLLO 65G', 40, CAST(0.87 AS Decimal(10, 2)), CAST(0.95 AS Decimal(10, 2)), CAST(34.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (19, 1, N'PROD00000019', N'RUFFLES 245G NATURAL', 20, CAST(2.45 AS Decimal(10, 2)), CAST(2.80 AS Decimal(10, 2)), CAST(49.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (20, 1, N'PROD00000020', N'AMOR WAFFER 130G FRESA', 40, CAST(1.00 AS Decimal(10, 2)), CAST(1.10 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (21, 1, N'PROD00000021', N'FERRERO NUTELA 350G', 50, CAST(6.20 AS Decimal(10, 2)), CAST(7.00 AS Decimal(10, 2)), CAST(310.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (22, 3, N'PROD00000022', N'DEJA BRISA PRIMAVERA 2KG', 60, CAST(5.00 AS Decimal(10, 2)), CAST(5.45 AS Decimal(10, 2)), CAST(300.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (23, 3, N'PROD00000023', N'AXION ALOE 450G', 30, CAST(1.80 AS Decimal(10, 2)), CAST(2.10 AS Decimal(10, 2)), CAST(54.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (24, 3, N'PROD00000024', N'PAPEL HIGIÉNICO FAMILIA X6 ROLLOS', 130, CAST(4.00 AS Decimal(10, 2)), CAST(4.40 AS Decimal(10, 2)), CAST(520.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (28, 4, N'PROD00000028', N'COCA COLA PACK', 35, CAST(4.70 AS Decimal(10, 2)), CAST(5.20 AS Decimal(10, 2)), CAST(164.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (29, 4, N'PROD00000029', N'GATORADE APPLE ICE 750 ML', 80, CAST(0.50 AS Decimal(10, 2)), CAST(0.65 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (30, 4, N'PROD00000030', N'PEPSI 3L ORIGINAL', 20, CAST(1.95 AS Decimal(10, 2)), CAST(2.20 AS Decimal(10, 2)), CAST(39.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (31, 4, N'PROD00000031', N'POWERADE MORA AZUL 500 ML', 50, CAST(0.35 AS Decimal(10, 2)), CAST(0.43 AS Decimal(10, 2)), CAST(17.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (32, 4, N'PROD00000032', N'COLA TROPICAL 1L', 60, CAST(0.38 AS Decimal(10, 2)), CAST(0.40 AS Decimal(10, 2)), CAST(22.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (33, 5, N'PROD00000033', N'RAID INSECTICIDA 400CC', 45, CAST(3.20 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)), CAST(144.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (34, 5, N'PROD00000034', N'ESPIRAL EUCALIPTO MAYIK 10U', 15, CAST(0.89 AS Decimal(10, 2)), CAST(1.02 AS Decimal(10, 2)), CAST(13.35 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (35, 5, N'PROD00000035', N'DRAGON INSECTICIDA 475 ML', 37, CAST(2.41 AS Decimal(10, 2)), CAST(2.70 AS Decimal(10, 2)), CAST(89.17 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (36, 5, N'PROD00000036', N'SAPOLIO AEROSOL 360 ML', 20, CAST(3.00 AS Decimal(10, 2)), CAST(3.40 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (37, 6, N'PROD00000037', N'CAFFE LATO MOCACCINO 285 ML PACK', 10, CAST(2.30 AS Decimal(10, 2)), CAST(2.65 AS Decimal(10, 2)), CAST(23.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (38, 6, N'PROD00000038', N'VITA DESCREMADA 1L TETRAPACK', 35, CAST(1.00 AS Decimal(10, 2)), CAST(1.25 AS Decimal(10, 2)), CAST(35.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (39, 6, N'PROD00000039', N'ANDINA SEMIDESCREMADA 900 ML FUNDA', 60, CAST(0.85 AS Decimal(10, 2)), CAST(0.90 AS Decimal(10, 2)), CAST(51.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (40, 6, N'PROD00000040', N'NESTLE SVELTY 1L TETRA-BRIK', 60, CAST(1.90 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(114.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (41, 6, N'PROD00000041', N'VITA DESLACTOSADA 1L TETRABRIK', 32, CAST(1.00 AS Decimal(10, 2)), CAST(1.23 AS Decimal(10, 2)), CAST(32.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (42, 7, N'PROD00000042', N'CERVEZA WIERQUER 330 ML 24U', 10, CAST(10.00 AS Decimal(10, 2)), CAST(12.80 AS Decimal(10, 2)), CAST(100.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (43, 7, N'PROD00000043', N'CERVEZA CORONA SIXPACK 355ML', 30, CAST(8.50 AS Decimal(10, 2)), CAST(9.35 AS Decimal(10, 2)), CAST(255.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (44, 7, N'PROD00000044', N'CERVEZA PILSENER SIXPACK 355ML', 40, CAST(4.20 AS Decimal(10, 2)), CAST(4.82 AS Decimal(10, 2)), CAST(168.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (45, 7, N'PROD00000045', N'CERVEZA BIELA SIXPACK 355ML', 50, CAST(5.00 AS Decimal(10, 2)), CAST(5.60 AS Decimal(10, 2)), CAST(250.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (46, 7, N'PROD00000046', N'CERVEZA HEINEKEN 355ML 12U', 15, CAST(13.00 AS Decimal(10, 2)), CAST(14.50 AS Decimal(10, 2)), CAST(195.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (47, 7, N'PROD00000047', N'SOMETHING SPECIAL 750ML', 3, CAST(19.70 AS Decimal(10, 2)), CAST(21.20 AS Decimal(10, 2)), CAST(59.10 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (48, 7, N'PROD00000048', N'LICOR MR ALLEN 1L', 22, CAST(5.00 AS Decimal(10, 2)), CAST(6.12 AS Decimal(10, 2)), CAST(110.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (49, 7, N'PROD00000049', N'VINO TINTO MERLOT 750ML', 48, CAST(3.00 AS Decimal(10, 2)), CAST(4.30 AS Decimal(10, 2)), CAST(144.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (79, 5, N'PROD00000079', N'BOMBA METALICO DRAGON 350CC', 4, CAST(2.20 AS Decimal(10, 2)), CAST(2.70 AS Decimal(10, 2)), CAST(8.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (80, 5, N'PROD00000080', N'RAQUETA RECARGABLE MAYIK', 20, CAST(4.50 AS Decimal(10, 2)), CAST(5.30 AS Decimal(10, 2)), CAST(90.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (81, 5, N'PROD00000081', N'RATICIDA KLERAT 50G', 15, CAST(1.00 AS Decimal(10, 2)), CAST(1.40 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (82, 5, N'PROD00000082', N'INSECTICIDA BAYGON 360ML', 35, CAST(2.80 AS Decimal(10, 2)), CAST(3.10 AS Decimal(10, 2)), CAST(98.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (102, 1, N'PROD00000101', N'BOMBONES FERRERO ROCHER PACK 8', 30, CAST(6.50 AS Decimal(10, 2)), CAST(7.00 AS Decimal(10, 2)), CAST(195.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (103, 1, N'PROD00000102', N'CHOCOLATE VIZZIO 131G', 20, CAST(2.50 AS Decimal(10, 2)), CAST(2.90 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (104, 1, N'PROD00000103', N'BOMBONES THE BELGIAN CHOCOLATE 200G', 50, CAST(5.00 AS Decimal(10, 2)), CAST(5.90 AS Decimal(10, 2)), CAST(250.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (105, 1, N'PROD00000104', N'PAPAS RUFFLES CRE-CEB 400G', 30, CAST(2.99 AS Decimal(10, 2)), CAST(3.70 AS Decimal(10, 2)), CAST(89.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (106, 1, N'PROD00000105', N'CHOCOLATES SNICKERS MINIS 275G', 30, CAST(7.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)), CAST(210.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (107, 1, N'PROD00000106', N'CHOCOLATE PACARI 200G PACK4', 10, CAST(7.70 AS Decimal(10, 2)), CAST(8.20 AS Decimal(10, 2)), CAST(77.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (108, 1, N'PROD00000107', N'CHOCOLATE SCHOGETTEN ORIGINALS 100G', 10, CAST(1.40 AS Decimal(10, 2)), CAST(1.90 AS Decimal(10, 2)), CAST(14.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (109, 1, N'PROD00000108', N'BOMBÓN DARK NOGGY 82G', 20, CAST(1.70 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(34.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (110, 1, N'PROD00000109', N'GALLETA OREO ORIGINAL 432G PACK12', 15, CAST(3.00 AS Decimal(10, 2)), CAST(3.60 AS Decimal(10, 2)), CAST(45.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (111, 1, N'PROD00000110', N'KINDER JOY 20G', 40, CAST(0.80 AS Decimal(10, 2)), CAST(1.05 AS Decimal(10, 2)), CAST(32.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (112, 1, N'PROD00000111', N'GALLETA FESTIVAL VAINILLA 50G', 40, CAST(0.10 AS Decimal(10, 2)), CAST(0.20 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (113, 1, N'PROD00000112', N'CARAMELO HALLS STRONG LYPTUS 151.2G', 30, CAST(2.00 AS Decimal(10, 2)), CAST(2.30 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (114, 1, N'PROD00000113', N'MILLOWS MASMELO DE CREMA 250G', 20, CAST(1.50 AS Decimal(10, 2)), CAST(1.90 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (115, 1, N'PROD00000114', N'GALLETAS SALTICAS MINI 30G', 50, CAST(0.12 AS Decimal(10, 2)), CAST(0.19 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (116, 2, N'PROD00000115', N'ACEITE GIRASOL 2L', 20, CAST(5.00 AS Decimal(10, 2)), CAST(5.90 AS Decimal(10, 2)), CAST(100.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (117, 2, N'PROD00000116', N'ACEITE DE OLIVA MUELOLIVA 500ML', 20, CAST(4.70 AS Decimal(10, 2)), CAST(5.10 AS Decimal(10, 2)), CAST(94.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (118, 2, N'PROD00000117', N'ACEITE DE OLIVA EXTRA BETIS 250 ML', 40, CAST(3.00 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (119, 2, N'PROD00000118', N'ACEITE ALESOL 500ML', 40, CAST(1.00 AS Decimal(10, 2)), CAST(1.35 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (120, 2, N'PROD00000119', N'ACEITE PALMA DE ORO 750 ML', 48, CAST(1.40 AS Decimal(10, 2)), CAST(1.70 AS Decimal(10, 2)), CAST(67.20 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (121, 2, N'PROD00000120', N'MANTECA LOS 3 CHANCHITOS 175G', 30, CAST(0.25 AS Decimal(10, 2)), CAST(0.32 AS Decimal(10, 2)), CAST(7.50 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (122, 2, N'PROD00000121', N'ACHIOTE PALMA DE ORO 0.5L', 30, CAST(1.50 AS Decimal(10, 2)), CAST(1.70 AS Decimal(10, 2)), CAST(45.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (123, 2, N'PROD00000122', N'FIDEO INSTANTÁNEO RAPIDITO POLLO 100G', 30, CAST(0.40 AS Decimal(10, 2)), CAST(0.55 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (124, 2, N'PROD00000123', N'MACARRÓN EKONO 350G', 20, CAST(0.50 AS Decimal(10, 2)), CAST(0.70 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (125, 2, N'PROD00000124', N'TORNILLO EKONO 350G', 10, CAST(0.60 AS Decimal(10, 2)), CAST(0.70 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (126, 2, N'PROD00000125', N'FRÉJOL DON CHICHO AMARILLO 500G', 25, CAST(1.70 AS Decimal(10, 2)), CAST(2.15 AS Decimal(10, 2)), CAST(42.50 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (127, 2, N'PROD00000126', N'FIDEO SPAGHETTI TOMADINI 500G', 30, CAST(1.05 AS Decimal(10, 2)), CAST(1.30 AS Decimal(10, 2)), CAST(31.50 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (128, 2, N'PROD00000127', N'LENTEJON LA PRADERA 500G', 50, CAST(1.20 AS Decimal(10, 2)), CAST(1.35 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (129, 2, N'PROD00000128', N'FIDEO CAYAMBE DINO 400G', 30, CAST(0.80 AS Decimal(10, 2)), CAST(1.05 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (130, 2, N'PROD00000129', N'CANGUIL EL AGRICULTOR 250G', 20, CAST(0.40 AS Decimal(10, 2)), CAST(0.55 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (131, 2, N'PROD00000130', N'LASAGNA TOSCANA 400G', 40, CAST(3.70 AS Decimal(10, 2)), CAST(4.20 AS Decimal(10, 2)), CAST(148.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (25, 3, N'PROD00000025', N'SUAVITEL DOYPACK 360ML ORQUÍDEA', 35, CAST(2.10 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)), CAST(73.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (26, 3, N'PROD00000026', N'FUNDA MAYIK 58X71 10U', 55, CAST(0.50 AS Decimal(10, 2)), CAST(0.60 AS Decimal(10, 2)), CAST(27.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (27, 3, N'PROD00000027', N'KALIPTO DESINFECTANTE 1 GL', 10, CAST(4.00 AS Decimal(10, 2)), CAST(4.50 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (50, 2, N'PROD00000050', N'ATUN VAN CAMP''S 142 G', 17, CAST(1.00 AS Decimal(10, 2)), CAST(1.35 AS Decimal(10, 2)), CAST(17.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (51, 4, N'PROD00000051', N'PONY MALTA 1L', 30, CAST(0.50 AS Decimal(10, 2)), CAST(0.75 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (52, 4, N'PROD00000052', N'FRUTARIS MANZANA 1L', 80, CAST(0.50 AS Decimal(10, 2)), CAST(0.75 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (53, 4, N'PROD00000053', N'MONSTER ULTRA ENERGIZANTE 473ML', 12, CAST(2.40 AS Decimal(10, 2)), CAST(2.60 AS Decimal(10, 2)), CAST(28.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (54, 4, N'PROD00000054', N'GÜITIG 1.5L', 40, CAST(0.50 AS Decimal(10, 2)), CAST(0.80 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (55, 2, N'PROD00000055', N'DON CAFE 50G SOBRE', 20, CAST(1.15 AS Decimal(10, 2)), CAST(1.50 AS Decimal(10, 2)), CAST(23.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (56, 2, N'PROD00000056', N'BUENDIA 170G', 34, CAST(10.00 AS Decimal(10, 2)), CAST(10.50 AS Decimal(10, 2)), CAST(340.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (57, 6, N'PROD00000057', N'REYLECHE FRUTILLA 200 ML', 5, CAST(0.50 AS Decimal(10, 2)), CAST(0.55 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (58, 6, N'PROD00000058', N'HELADO PINGÜINO 900ML MANICHO', 8, CAST(4.00 AS Decimal(10, 2)), CAST(4.30 AS Decimal(10, 2)), CAST(32.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (59, 3, N'PROD00000059', N'JABON PALMOLIVE FRUTAS 120 X3', 24, CAST(1.40 AS Decimal(10, 2)), CAST(1.80 AS Decimal(10, 2)), CAST(33.60 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (60, 2, N'PROD00000060', N'GELATINA 200G CHICLE', 15, CAST(0.50 AS Decimal(10, 2)), CAST(0.63 AS Decimal(10, 2)), CAST(7.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (61, 2, N'PROD00000061', N'FACUNDO MERMELADA 300G MORA', 10, CAST(1.20 AS Decimal(10, 2)), CAST(1.33 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (62, 2, N'PROD00000062', N'DULCE DE LECHE KIOSKO 250G', 20, CAST(1.10 AS Decimal(10, 2)), CAST(1.40 AS Decimal(10, 2)), CAST(22.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (63, 4, N'PROD00000063', N'AGUA SIN GAS DASANI 600ML', 60, CAST(0.35 AS Decimal(10, 2)), CAST(0.50 AS Decimal(10, 2)), CAST(21.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (64, 4, N'PROD00000064', N'AGUA ALL NATURAL 10L', 50, CAST(2.00 AS Decimal(10, 2)), CAST(2.30 AS Decimal(10, 2)), CAST(100.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (65, 4, N'PROD00000065', N'DEL VALLE 1.75L NARANJA', 40, CAST(0.80 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)), CAST(32.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (66, 4, N'PROD00000066', N'SPRITE 300ML', 30, CAST(0.20 AS Decimal(10, 2)), CAST(0.28 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (67, 7, N'PROD00000067', N'VODKA RUSSKAYA 750CC', 20, CAST(9.70 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(194.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (68, 7, N'PROD00000068', N'WHISKY CHIVAS REGAL 700ML', 20, CAST(40.00 AS Decimal(10, 2)), CAST(44.00 AS Decimal(10, 2)), CAST(800.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (69, 7, N'PROD00000069', N'WHISKY JOHN MORRIS 750ML', 20, CAST(9.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(180.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (70, 7, N'PROD00000070', N'WHISKY OLD TIMES 745ML RED', 20, CAST(8.00 AS Decimal(10, 2)), CAST(8.70 AS Decimal(10, 2)), CAST(160.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (71, 7, N'PROD00000071', N'VINO SAUVIGNON 750 ML', 30, CAST(10.00 AS Decimal(10, 2)), CAST(11.50 AS Decimal(10, 2)), CAST(300.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (72, 7, N'PROD00000072', N'WHISKY GRANTS 750ML', 10, CAST(17.00 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), CAST(170.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (73, 1, N'PROD00000073', N'BOMBONES FERRERO 50G', 20, CAST(2.75 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)), CAST(55.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (74, 1, N'PROD00000074', N'DORITOS 275G MEGA QUESO', 15, CAST(2.00 AS Decimal(10, 2)), CAST(2.30 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (75, 1, N'PROD00000075', N'TABLETA M&M 113.4G CHOCOLATE', 32, CAST(3.00 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)), CAST(96.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (76, 1, N'PROD00000076', N'HUEVITOS LA UNIVERSAL 265G CEREZA', 18, CAST(2.00 AS Decimal(10, 2)), CAST(2.60 AS Decimal(10, 2)), CAST(36.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (77, 1, N'PROD00000077', N'KITKAT CHOCOLATE BLANCO 41.5G', 30, CAST(0.60 AS Decimal(10, 2)), CAST(0.80 AS Decimal(10, 2)), CAST(18.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (78, 1, N'PROD00000078', N'GALLETAS NESTLÉ MARIA 172G', 23, CAST(0.50 AS Decimal(10, 2)), CAST(0.87 AS Decimal(10, 2)), CAST(11.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (83, 6, N'PROD00000083', N'MARGARINA NATURELLA ALES 500G', 15, CAST(1.20 AS Decimal(10, 2)), CAST(1.60 AS Decimal(10, 2)), CAST(18.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (84, 6, N'PROD00000084', N'MARGARINA GIRASOL 240G', 15, CAST(1.00 AS Decimal(10, 2)), CAST(1.10 AS Decimal(10, 2)), CAST(15.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (85, 6, N'PROD00000085', N'LECHE POLVO LA VAQUITA 190G', 50, CAST(1.20 AS Decimal(10, 2)), CAST(1.50 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (86, 5, N'PROD00000086', N'MATAMOSCAS SURTIDO HAIXING', 30, CAST(1.00 AS Decimal(10, 2)), CAST(1.20 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (87, 6, N'PROD00000087', N'LECHE NUTRI ENTERA CARTÓN 200ML', 10, CAST(0.20 AS Decimal(10, 2)), CAST(0.25 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (88, 6, N'PROD00000088', N'LECHE REYLECHE ENTERA 900ML', 20, CAST(0.90 AS Decimal(10, 2)), CAST(0.95 AS Decimal(10, 2)), CAST(18.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (89, 6, N'PROD00000089', N'LECHE MILO CHOCOLATADA 185ML', 60, CAST(0.65 AS Decimal(10, 2)), CAST(0.70 AS Decimal(10, 2)), CAST(39.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (90, 6, N'PROD00000090', N'MARGARINA BONELLA 3KG', 5, CAST(10.00 AS Decimal(10, 2)), CAST(11.50 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (91, 6, N'PROD00000091', N'LECHE LENUTRIT CHOCOLATE 900ML', 10, CAST(0.85 AS Decimal(10, 2)), CAST(0.93 AS Decimal(10, 2)), CAST(8.50 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (92, 3, N'PROD00000092', N'DIFUSOR GLADE LAVANDA 100ML', 20, CAST(5.80 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), CAST(116.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (93, 3, N'PROD00000093', N'CLOROX LÍQUIDO BOTELLA 1L', 30, CAST(0.70 AS Decimal(10, 2)), CAST(0.80 AS Decimal(10, 2)), CAST(21.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (94, 3, N'PROD00000094', N'LYSOL LAVANDA 3785ML', 30, CAST(7.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)), CAST(210.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (95, 3, N'PROD00000095', N'SUAVIZANTE AROMATEL COCO 550ML', 15, CAST(1.30 AS Decimal(10, 2)), CAST(1.50 AS Decimal(10, 2)), CAST(19.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (96, 3, N'PROD00000096', N'ESTROPAJO DE ALUMINIO SOLEX', 50, CAST(0.25 AS Decimal(10, 2)), CAST(0.38 AS Decimal(10, 2)), CAST(12.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (97, 1, N'PROD00000097', N'GALLETA CLUB SOCIAL X9 234G', 25, CAST(1.50 AS Decimal(10, 2)), CAST(1.70 AS Decimal(10, 2)), CAST(37.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (98, 1, N'PROD00000098', N'BARRA DE CHOCOLATE LA UNIVERSAL 100G', 25, CAST(0.80 AS Decimal(10, 2)), CAST(0.95 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (99, 4, N'PROD00000099', N'JUGO PULP NÉCTAR DURAZNO 1L', 24, CAST(0.90 AS Decimal(10, 2)), CAST(0.95 AS Decimal(10, 2)), CAST(21.60 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (100, 4, N'PROD00000100', N'JUGO CIFRUT CITRUS PUNCH 3L', 12, CAST(1.00 AS Decimal(10, 2)), CAST(1.30 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (132, 3, N'PROD00000131', N'DETERGENTE DEJA SUPERIOR 1800G', 30, CAST(3.50 AS Decimal(10, 2)), CAST(41.00 AS Decimal(10, 2)), CAST(105.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (133, 3, N'PROD00000132', N'DETERGENTE CICLÓN FLORAL 5 KG', 30, CAST(9.75 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(292.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (134, 3, N'PROD00000133', N'DETERGENTE LÍQUIDO DEJA FLORAL 500ML', 40, CAST(4.00 AS Decimal(10, 2)), CAST(4.70 AS Decimal(10, 2)), CAST(160.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (135, 3, N'PROD00000134', N'JABÓN LAVATODO FLORAL 960G PACK4', 40, CAST(1.90 AS Decimal(10, 2)), CAST(2.40 AS Decimal(10, 2)), CAST(76.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (136, 3, N'PROD00000135', N'DETERGENTE LÍQUIDO WOOLITE 1800 ML', 30, CAST(4.80 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)), CAST(144.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (137, 3, N'PROD00000136', N'SUAVIZANTE PERLA LAV Y ORQ DOYPACK 1300ML', 30, CAST(2.70 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)), CAST(81.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (138, 3, N'PROD00000137', N'DETERGENTE GOL LIMÓN 480G', 40, CAST(0.40 AS Decimal(10, 2)), CAST(0.79 AS Decimal(10, 2)), CAST(16.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (139, 3, N'PROD00000138', N'LIMPIA INODORO SAPOLIO 500ML', 20, CAST(1.50 AS Decimal(10, 2)), CAST(1.89 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (140, 3, N'PROD00000139', N'SELLO ROJO 375G', 30, CAST(1.70 AS Decimal(10, 2)), CAST(1.90 AS Decimal(10, 2)), CAST(51.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (141, 3, N'PROD00000140', N'DESINFECTANTE TIPS 240ML', 50, CAST(0.29 AS Decimal(10, 2)), CAST(0.38 AS Decimal(10, 2)), CAST(14.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (142, 3, N'PROD00000141', N'DESINFECTANTE OLIMPIA MANZANA 900ML', 30, CAST(1.38 AS Decimal(10, 2)), CAST(1.67 AS Decimal(10, 2)), CAST(41.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (143, 3, N'PROD00000142', N'DESINFECTANTE FABULOSO FLORAL 2L', 50, CAST(3.20 AS Decimal(10, 2)), CAST(3.70 AS Decimal(10, 2)), CAST(160.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (144, 3, N'PROD00000143', N'CLOROX LÍQUIDO ORIGINAL 160G', 60, CAST(0.10 AS Decimal(10, 2)), CAST(0.13 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (145, 3, N'PROD00000144', N'CLORO SAPOLIO 4000G', 24, CAST(2.00 AS Decimal(10, 2)), CAST(2.40 AS Decimal(10, 2)), CAST(48.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (146, 3, N'PROD00000145', N'REPUESTO AMBIENTAL GLADE AUTO 7ML', 5, CAST(7.00 AS Decimal(10, 2)), CAST(7.60 AS Decimal(10, 2)), CAST(35.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (147, 5, N'PROD00000146', N'REPELENTE LÍQUIDO RAID ELÉCTRICO', 20, CAST(9.15 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(183.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (148, 5, N'PROD00000147', N'Q-KARACTION GEL CUCARACHA 10G', 10, CAST(9.70 AS Decimal(10, 2)), CAST(10.10 AS Decimal(10, 2)), CAST(97.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (149, 5, N'PROD00000148', N'TRAMPA ENGOMADA ROEDORES', 15, CAST(6.00 AS Decimal(10, 2)), CAST(7.00 AS Decimal(10, 2)), CAST(90.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (150, 5, N'PROD00000149', N'INSECTICIDA LÍQUIDO BAYGON 510ML', 18, CAST(3.00 AS Decimal(10, 2)), CAST(3.80 AS Decimal(10, 2)), CAST(54.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (151, 5, N'PROD00000150', N'TRAMPA BIG CHEESE PARA RATÓN', 40, CAST(1.20 AS Decimal(10, 2)), CAST(1.40 AS Decimal(10, 2)), CAST(48.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (152, 5, N'PROD00000151', N'INSECTICIDA TORVI 1000ML', 12, CAST(3.75 AS Decimal(10, 2)), CAST(4.30 AS Decimal(10, 2)), CAST(45.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (153, 5, N'PROD00000152', N'EL SECRETO DE LA ABUELITA 225G', 24, CAST(1.40 AS Decimal(10, 2)), CAST(1.70 AS Decimal(10, 2)), CAST(33.60 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (154, 5, N'PROD00000153', N'NAFTALINA TRIPLE ACCIÓN 24 UDS', 20, CAST(1.00 AS Decimal(10, 2)), CAST(1.25 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (155, 5, N'PROD00000154', N'RATICIDA CAMPEX 50G', 40, CAST(0.70 AS Decimal(10, 2)), CAST(0.90 AS Decimal(10, 2)), CAST(28.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (156, 5, N'PROD00000155', N'INSECTICIDA AGUILA REAL LIMÓN 400ML', 12, CAST(2.90 AS Decimal(10, 2)), CAST(3.30 AS Decimal(10, 2)), CAST(34.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (157, 5, N'PROD00000156', N'INSECTICIDA ZAP VOLADORES 360ML', 20, CAST(1.50 AS Decimal(10, 2)), CAST(2.20 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (158, 4, N'PROD00000157', N'AGUA SIN GAS DASANI 1200ML PACK6', 40, CAST(2.20 AS Decimal(10, 2)), CAST(2.80 AS Decimal(10, 2)), CAST(88.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (159, 4, N'PROD00000158', N'AGUA SIN GAS SPLENDOR 5L', 25, CAST(1.00 AS Decimal(10, 2)), CAST(1.60 AS Decimal(10, 2)), CAST(25.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (160, 4, N'PROD00000159', N'AGUA SIN GAS PURE WATER 6L', 30, CAST(1.00 AS Decimal(10, 2)), CAST(1.40 AS Decimal(10, 2)), CAST(30.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (161, 4, N'PROD00000160', N'AGUA PURE WATER 625 ML', 80, CAST(0.15 AS Decimal(10, 2)), CAST(0.22 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (162, 4, N'PROD00000161', N'COLA TROPICAL 3.8 L', 20, CAST(1.80 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(36.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (163, 4, N'PROD00000162', N'COLA MANZANA 3.8L', 20, CAST(1.75 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(35.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (164, 4, N'PROD00000163', N'COLA KOLA GALLITO 3.78L', 20, CAST(1.70 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), CAST(34.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (165, 4, N'PROD00000164', N'COLACOCA SIN AZÚCAR 1 LITRO', 10, CAST(0.40 AS Decimal(10, 2)), CAST(0.50 AS Decimal(10, 2)), CAST(4.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (166, 4, N'PROD00000165', N'COLA BIG PET 300ML', 96, CAST(0.15 AS Decimal(10, 2)), CAST(0.19 AS Decimal(10, 2)), CAST(14.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (167, 4, N'PROD00000166', N'COLA FANTA 1L', 60, CAST(0.40 AS Decimal(10, 2)), CAST(0.66 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (168, 4, N'PROD00000167', N'COLA MÁS SABOR NARANJA 3780ML', 30, CAST(1.50 AS Decimal(10, 2)), CAST(1.80 AS Decimal(10, 2)), CAST(45.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (169, 4, N'PROD00000168', N'COLA INCA KOLA 3L', 30, CAST(2.00 AS Decimal(10, 2)), CAST(2.30 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (170, 4, N'PROD00000169', N'COLA SPRITE 1.75L', 25, CAST(1.00 AS Decimal(10, 2)), CAST(1.21 AS Decimal(10, 2)), CAST(25.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (171, 4, N'PROD00000170', N'JUGO NATURA DURAZNO 1L', 30, CAST(1.10 AS Decimal(10, 2)), CAST(1.40 AS Decimal(10, 2)), CAST(33.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (172, 4, N'PROD00000171', N'JUGO DEL VALLE NARANJA PACK2', 40, CAST(1.70 AS Decimal(10, 2)), CAST(1.90 AS Decimal(10, 2)), CAST(68.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (173, 6, N'PROD00000172', N'LECHE REYLECHE SURTIDO 200ML PACK6', 20, CAST(2.80 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)), CAST(56.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (174, 6, N'PROD00000173', N'YOGU YOGU DE MORA 750ML', 12, CAST(1.00 AS Decimal(10, 2)), CAST(1.49 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (175, 6, N'PROD00000174', N'LECHE TONI FRUTILLA 1L', 5, CAST(1.70 AS Decimal(10, 2)), CAST(1.90 AS Decimal(10, 2)), CAST(8.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (176, 6, N'PROD00000175', N'LECHE TONI CHOCOLATE 200ML', 24, CAST(0.50 AS Decimal(10, 2)), CAST(0.70 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (177, 6, N'PROD00000176', N'LECHE ENTERA FUNDA ANDINA 900ML PACK6', 10, CAST(5.00 AS Decimal(10, 2)), CAST(5.30 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (178, 6, N'PROD00000177', N'LECHE SEMIDESCREMADA FUNDA ANDINA 900ML PACK6', 10, CAST(5.00 AS Decimal(10, 2)), CAST(5.30 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (179, 6, N'PROD00000178', N'LECHE NUTRI SEMIDESCREMADA CARTÓN 1L PACK4', 10, CAST(4.00 AS Decimal(10, 2)), CAST(4.35 AS Decimal(10, 2)), CAST(40.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (180, 6, N'PROD00000179', N'LECHE INDULAC SEMIDESCREMADA 1L', 10, CAST(1.00 AS Decimal(10, 2)), CAST(1.28 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (181, 6, N'PROD00000180', N'LECHE TONI CHOCOLATADA 135ML PACK6', 30, CAST(2.00 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (182, 6, N'PROD00000181', N'LECHE TONI DE FRUTILLA 200ML PACK6', 20, CAST(3.70 AS Decimal(10, 2)), CAST(4.10 AS Decimal(10, 2)), CAST(74.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (183, 6, N'PROD00000182', N'LECHE TONI DE CHOCOLATADA 200ML PACK6', 20, CAST(3.70 AS Decimal(10, 2)), CAST(4.10 AS Decimal(10, 2)), CAST(74.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (184, 6, N'PROD00000183', N'LECHE PARMALAT DESLACTOSADA ZYMIL 1L', 50, CAST(1.00 AS Decimal(10, 2)), CAST(1.35 AS Decimal(10, 2)), CAST(50.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (191, 7, N'PROD00000190', N'RON CASTILLO AÑEJO 750ML', 15, CAST(9.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), CAST(135.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (192, 7, N'PROD00000191', N'RON ESTELAR SILVER 750ML', 20, CAST(6.50 AS Decimal(10, 2)), CAST(7.30 AS Decimal(10, 2)), CAST(130.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (193, 7, N'PROD00000192', N'RON ABUELO AÑEJO 7 AÑOS - 750ML', 15, CAST(14.00 AS Decimal(10, 2)), CAST(16.00 AS Decimal(10, 2)), CAST(210.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (194, 7, N'PROD00000193', N'RON DIPLOMÁTICO AÑEJO 750ML', 30, CAST(22.00 AS Decimal(10, 2)), CAST(24.50 AS Decimal(10, 2)), CAST(660.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (195, 7, N'PROD00000194', N'TEQUILA EL CHARRO SILVER 750 ML', 20, CAST(11.00 AS Decimal(10, 2)), CAST(13.00 AS Decimal(10, 2)), CAST(220.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (196, 7, N'PROD00000195', N'TEQUILA SOMBRERO NEGRO GOLD 750ML', 25, CAST(22.00 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), CAST(550.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (197, 7, N'PROD00000196', N'CRISTAL SECO 750ML', 40, CAST(4.00 AS Decimal(10, 2)), CAST(4.50 AS Decimal(10, 2)), CAST(160.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (198, 7, N'PROD00000197', N'TRÓPICO SECO 750ML', 40, CAST(5.00 AS Decimal(10, 2)), CAST(5.80 AS Decimal(10, 2)), CAST(200.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (199, 7, N'PROD00000198', N'AGUARDIENTE NORTEÑO ESPECIAL 750ML', 50, CAST(5.00 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), CAST(250.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (200, 7, N'PROD00000199', N'VODKA SKY 750ML', 30, CAST(12.00 AS Decimal(10, 2)), CAST(13.50 AS Decimal(10, 2)), CAST(360.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (201, 7, N'PROD00000200', N'VODKA LIOVA 750ML', 40, CAST(5.00 AS Decimal(10, 2)), CAST(6.40 AS Decimal(10, 2)), CAST(200.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (202, 7, N'PROD00000201', N'VINO BLANCO LA VIEILLE FERME 750ML', 30, CAST(7.00 AS Decimal(10, 2)), CAST(8.50 AS Decimal(10, 2)), CAST(210.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (185, 6, N'PROD00000184', N'LECHE NESQUIK CHOCOLATE 200ML', 30, CAST(0.40 AS Decimal(10, 2)), CAST(0.65 AS Decimal(10, 2)), CAST(12.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (186, 6, N'PROD00000185', N'LECHE NESQUIK 200ML FRUTILLA', 20, CAST(0.40 AS Decimal(10, 2)), CAST(0.65 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (187, 6, N'PROD00000186', N'LECHE EN POLVO NUTRI 100G', 20, CAST(0.70 AS Decimal(10, 2)), CAST(0.75 AS Decimal(10, 2)), CAST(14.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (188, 6, N'PROD00000187', N'BEBIDA VEGETAL NOTMILK 1L', 20, CAST(3.00 AS Decimal(10, 2)), CAST(3.20 AS Decimal(10, 2)), CAST(60.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (189, 6, N'PROD00000188', N'LECHE DE SOYA ORIENTAL 900G', 30, CAST(11.00 AS Decimal(10, 2)), CAST(12.20 AS Decimal(10, 2)), CAST(330.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Inventarios] ([ID_Inventario], [ID_Categoria], [Codigo], [Nombre], [Cantidad], [Costo_Unitario], [Precio_venta], [Monto_Total], [Tipo_Cargo]) VALUES (190, 7, N'PROD00000189', N'RON HAVANA CLUB 750ML', 20, CAST(18.00 AS Decimal(10, 2)), CAST(19.00 AS Decimal(10, 2)), CAST(360.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (1, 1, N'PROD00000001', N'GALLETA OREO TACO', N'Taco 12 Unidades', N'UNIDAD', CAST(0.83 AS Decimal(10, 2)), CAST(0.90 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (2, 2, N'PROD00000002', N'SUMESA PASTA 400G', N'Spaghetti Premium', N'UNIDAD', CAST(0.75 AS Decimal(10, 2)), CAST(2.15 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (3, 3, N'PROD00000003', N'CICLON 400GR', N'Detergente', N'UNIDAD', CAST(1.99 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (4, 3, N'PROD00000004', N'DEJA LIMON 1K', N'Detergente 1K', N'UNIDAD', CAST(2.80 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (5, 3, N'PROD00000005', N'MACHO 200GR', N'Jabon', N'UNIDAD', CAST(0.80 AS Decimal(10, 2)), CAST(1.02 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (6, 2, N'PROD00000006', N'ACEITE PALMA ORO', N'1 LITRO EN BOTELLA', N'UNIDAD', CAST(1.35 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (7, 2, N'PROD00000007', N'POLLO COMPLETO MR. POLLO', N'SÚPER EXTRA GRANDE - PESO: 2,50 A 2,80KG', N'KG', CAST(1.89 AS Decimal(10, 2)), CAST(2.10 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (8, 1, N'PROD00000008', N'GALAK 500GR', N'Galletas con sabor a vainilla', N'UNIDAD', CAST(1.35 AS Decimal(10, 2)), CAST(2.15 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (9, 2, N'PROD00000009', N'MAYONESA GUSTADINA 330 G', N'MAYONESA GUSTADINA DOYPACK 330 G', N'UNIDAD', CAST(2.75 AS Decimal(10, 2)), CAST(3.15 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (10, 2, N'PROD00000010', N'SALSA DE TOMATE MARCELLOS GALON', N'SALSA DE TOMATE EN GALON', N'UNIDAD', CAST(8.00 AS Decimal(10, 2)), CAST(9.25 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (11, 2, N'PROD00000011', N'MOSTAZA MAGGI 330GR', N'Botella 330g', N'UNIDAD', CAST(2.15 AS Decimal(10, 2)), CAST(2.75 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (12, 2, N'PROD00000012', N'ALIÑO CONDIMENSA 380GR', N'ALIÑO COMPLETO 380g CONDIMENSA', N'UNIDAD', CAST(3.00 AS Decimal(10, 2)), CAST(3.75 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (13, 2, N'PROD00000013', N'AJO CONDIMENSA 470GR', N'Botella 470g Condimensa', N'UNIDAD', CAST(1.15 AS Decimal(10, 2)), CAST(1.75 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (14, 4, N'PROD00000014', N'COCACOLA 3L ORIGINAL', N'3 LITROS RETONABLE ORIGINAL', N'UNIDAD', CAST(2.05 AS Decimal(10, 2)), CAST(2.75 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (15, 6, N'PROD00000015', N'LECHE PARMALAC LITRO', N'1 LITRO FUNDA', N'UNIDAD', CAST(0.75 AS Decimal(10, 2)), CAST(0.97 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (16, 1, N'PROD00000016', N'TONI CHOCOLATE 1L', N'LecheToni 1 Litro', N'UNIDAD', CAST(2.80 AS Decimal(10, 2)), CAST(3.10 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (17, 1, N'PROD00000017', N'GALLETAS SALTICAS 378 G', N'GALLETAS SALADAS SALTICAS 378 G', N'UNIDAD', CAST(1.70 AS Decimal(10, 2)), CAST(1.99 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (18, 1, N'PROD00000018', N'LONCHYS POLLO 65G', N'FIDEOS INSTANTANEOS POLLO LONCHYS 65 G', N'UNIDAD', CAST(0.87 AS Decimal(10, 2)), CAST(0.95 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (19, 1, N'PROD00000019', N'RUFFLES 245G NATURAL', N'PAPAS FRITAS RUFFLES 245 G NATURAL', N'UNIDAD', CAST(2.45 AS Decimal(10, 2)), CAST(2.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (20, 1, N'PROD00000020', N'AMOR WAFFER 130G FRESA', N'WAFFER AMOR DOBLE CREMA 130 G FRESA', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.10 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (21, 1, N'PROD00000021', N'FERRERO NUTELA 350G', N'CREMA DE AVELLANA NUTELLA 350 G', N'UNIDAD', CAST(6.20 AS Decimal(10, 2)), CAST(7.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (22, 3, N'PROD00000022', N'DEJA BRISA PRIMAVERA 2KG', N'DETERGENTE BRISA DE PRIMAVERA TOQUE DE SUAVIZANTE DETERGENTE BRISA DE PRIMAVERA C/TOQUE DE SUAVIZA', N'UNIDAD', CAST(5.00 AS Decimal(10, 2)), CAST(5.45 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (23, 3, N'PROD00000023', N'AXION ALOE 450G', N'LAVAVAJILLA EN CREMA ALOE AXION 450 G', N'UNIDAD', CAST(1.80 AS Decimal(10, 2)), CAST(2.10 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (24, 3, N'PROD00000024', N'PAPEL HIGIÉNICO FAMILIA X6 ROLLOS', N'PAPEL HIGIÉNICO TRIPLE HOJA FAMILIA 25M X6 ROLLOS', N'UNIDAD', CAST(4.00 AS Decimal(10, 2)), CAST(4.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (25, 3, N'PROD00000025', N'SUAVITEL DOYPACK 360ML ORQUÍDEA', N'SUAVIZANTE SUAVITEL DOYPACK 360ML ORQUÍDEA LAVANDA', N'UNIDAD', CAST(2.10 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (26, 3, N'PROD00000026', N'FUNDA MAYIK 58X71 10U', N'FUNDA PARA BASURA 58X71 CM MAYIK 10 UNIDADES', N'UNIDAD', CAST(0.50 AS Decimal(10, 2)), CAST(0.60 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (27, 3, N'PROD00000027', N'KALIPTO DESINFECTANTE 1 GL', N'DESINFECTANTE KALIPTO 1 GL EUCALIPTO', N'UNIDAD', CAST(4.00 AS Decimal(10, 2)), CAST(4.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (28, 4, N'PROD00000028', N'COCA COLA PACK', N'PACK COCA COLA 2.75 L MAS SPRITE 3 L', N'UNIDAD', CAST(4.70 AS Decimal(10, 2)), CAST(5.20 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (29, 4, N'PROD00000029', N'GATORADE APPLE ICE 750 ML', N'BEBIDA HIDRATANTE APPLE ICE GATORADE 750 ML', N'UNIDAD', CAST(0.50 AS Decimal(10, 2)), CAST(0.65 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (30, 4, N'PROD00000030', N'PEPSI 3L ORIGINAL', N'COLA PEPSI 3 L', N'UNIDAD', CAST(1.95 AS Decimal(10, 2)), CAST(2.20 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (31, 4, N'PROD00000031', N'POWERADE MORA AZUL 500 ML', N'BEBIDA HIDRATANTE MORA AZUL POWERADE 500 ML', N'UNIDAD', CAST(0.35 AS Decimal(10, 2)), CAST(0.43 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (32, 4, N'PROD00000032', N'COLA TROPICAL 1L', N'COLA TROPICAL 1 L', N'UNIDAD', CAST(0.38 AS Decimal(10, 2)), CAST(0.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (33, 5, N'PROD00000033', N'RAID INSECTICIDA 400CC', N'INSECTICIDA RAID 400 CC MOSQUITOS Y MOSCAS', N'UNIDAD', CAST(3.20 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (34, 5, N'PROD00000034', N'ESPIRAL EUCALIPTO MAYIK 10U', N'MATA MOSQUITO EN ESPIRAL EUCALIPTO MAYIK 10 UNI', N'UNIDAD', CAST(0.89 AS Decimal(10, 2)), CAST(1.02 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (35, 5, N'PROD00000035', N'DRAGON INSECTICIDA 475 ML', N'INSECTICIDA LÍQUIDO DRAGÓN 475 ML', N'UNIDAD', CAST(2.41 AS Decimal(10, 2)), CAST(2.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (36, 5, N'PROD00000036', N'SAPOLIO AEROSOL 360 ML', N'INSECTICIDA AEROSOL ZANCUDOS Y MOSCAS SAPOLIO 360 ML', N'UNIDAD', CAST(3.00 AS Decimal(10, 2)), CAST(3.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (37, 6, N'PROD00000037', N'CAFFE LATO MOCACCINO 285 ML PACK', N'CAFFE LATO TONI 285 ML MOCACCINO PACK X 2', N'UNIDAD', CAST(2.30 AS Decimal(10, 2)), CAST(2.65 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (38, 6, N'PROD00000038', N'VITA DESCREMADA 1L TETRAPACK', N'LECHE VITA TETRAFINO 1 L DESCREMADA', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.25 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (39, 6, N'PROD00000039', N'ANDINA SEMIDESCREMADA 900 ML FUNDA', N'LECHE ANDINA 900 ML SEMIDESCREMADA', N'UNIDAD', CAST(0.85 AS Decimal(10, 2)), CAST(0.90 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (40, 6, N'PROD00000040', N'NESTLE SVELTY 1L TETRA-BRIK', N'LECHE SVELTY LA LECHERA TETRA BRIK 1 L EXTRA CALCIO', N'UNIDAD', CAST(1.90 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (41, 6, N'PROD00000041', N'VITA DESLACTOSADA 1L TETRABRIK', N'LECHE VITA TETRABRIK 1 L DESLACTOSADA', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.23 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (42, 7, N'PROD00000042', N'CERVEZA WIERQUER 330 ML 24U', N'CERVEZA WIERQUER 330 ML LATA X24 UNIDADES', N'CAJA', CAST(10.00 AS Decimal(10, 2)), CAST(12.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (43, 7, N'PROD00000043', N'CERVEZA CORONA SIXPACK 355ML', N'CERVEZA CORONA EXTRA 355 ML SIXPACK', N'CAJA', CAST(8.50 AS Decimal(10, 2)), CAST(9.35 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (44, 7, N'PROD00000044', N'CERVEZA PILSENER SIXPACK 355ML', N'CERVEZA PILSENER 355 ML SIXPACK', N'CAJA', CAST(4.20 AS Decimal(10, 2)), CAST(4.82 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (45, 7, N'PROD00000045', N'CERVEZA BIELA SIXPACK 355ML', N'CERVEZA BIELA RESERVA 355 ML SIXPACK', N'CAJA', CAST(5.00 AS Decimal(10, 2)), CAST(5.60 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (46, 7, N'PROD00000046', N'CERVEZA HEINEKEN 355ML 12U', N'CERVEZA HEINEKEN 355 ML X 12 UNIDADES', N'CAJA', CAST(13.00 AS Decimal(10, 2)), CAST(14.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (47, 7, N'PROD00000047', N'SOMETHING SPECIAL 750ML', N'WHISKY SOMETHING SPECIAL 750 ML', N'UNIDAD', CAST(19.70 AS Decimal(10, 2)), CAST(21.20 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (48, 7, N'PROD00000048', N'LICOR MR ALLEN 1L', N'LICOR MR ALLEN 1 L', N'UNIDAD', CAST(5.00 AS Decimal(10, 2)), CAST(6.12 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (49, 7, N'PROD00000049', N'VINO TINTO MERLOT 750ML', N'VINO TINTO MERLOT MONT VALENTINO 750 ML', N'UNIDAD', CAST(3.00 AS Decimal(10, 2)), CAST(4.30 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (50, 2, N'PROD00000050', N'ATUN VAN CAMP''S 142 G', N'ATUN LOMITOS EN ACEITE A/F VAN CAMP''S 142 G', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.35 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (51, 4, N'PROD00000051', N'PONY MALTA 1L', N'PONY MALTA LITRO', N'UNIDAD', CAST(0.50 AS Decimal(10, 2)), CAST(0.75 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (52, 4, N'PROD00000052', N'FRUTARIS MANZANA 1L', N'COLA MANZANA FRUTARIS 1 L', N'UNIDAD', CAST(0.50 AS Decimal(10, 2)), CAST(0.75 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (53, 4, N'PROD00000053', N'MONSTER ULTRA ENERGIZANTE 473ML', N'BEBIDA ENERGIZANTE 473ML MONSTER ULTRA', N'UNIDAD', CAST(2.40 AS Decimal(10, 2)), CAST(2.60 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (54, 4, N'PROD00000054', N'GÜITIG 1.5L', N'AGUA MINERAL CON GAS GÜITIG 1.5 L', N'UNIDAD', CAST(0.50 AS Decimal(10, 2)), CAST(0.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (55, 2, N'PROD00000055', N'DON CAFE 50G SOBRE', N'CAFE DON CAFE 50 G SOBRE', N'UNIDAD', CAST(1.15 AS Decimal(10, 2)), CAST(1.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (56, 2, N'PROD00000056', N'BUENDIA 170G', N'CAFE DESCAFEINADO BUENDIA 170 G', N'UNIDAD', CAST(10.00 AS Decimal(10, 2)), CAST(10.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (57, 6, N'PROD00000057', N'REYLECHE FRUTILLA 200 ML', N'LECHE FRUTILLA REYLECHE TETRABRIK 200 ML', N'UNIDAD', CAST(0.50 AS Decimal(10, 2)), CAST(0.55 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (58, 6, N'PROD00000058', N'HELADO PINGÜINO 900ML MANICHO', N'HELADO PINGÜINO TOP 900 ML MANICHO', N'UNIDAD', CAST(4.00 AS Decimal(10, 2)), CAST(4.30 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (59, 3, N'PROD00000059', N'JABON PALMOLIVE FRUTAS 120 X3', N'JABON YOGURT Y FRUTAS PALMOLIVE 120 G X 3', N'UNIDAD', CAST(1.40 AS Decimal(10, 2)), CAST(1.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (60, 2, N'PROD00000060', N'GELATINA 200G CHICLE', N'GELATINA GELATONI 200 G CHICLE', N'UNIDAD', CAST(0.50 AS Decimal(10, 2)), CAST(0.63 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (61, 2, N'PROD00000061', N'FACUNDO MERMELADA 300G MORA', N'MERMELADA FACUNDO 300 G MORA FRASCO', N'UNIDAD', CAST(1.20 AS Decimal(10, 2)), CAST(1.33 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (62, 2, N'PROD00000062', N'DULCE DE LECHE KIOSKO 250G', N'DULCE DE LECHE KIOSKO 250 G', N'UNIDAD', CAST(1.10 AS Decimal(10, 2)), CAST(1.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (63, 4, N'PROD00000063', N'AGUA SIN GAS DASANI 600ML', N'AGUA DASANI 600 ML BOTELLA', N'UNIDAD', CAST(0.35 AS Decimal(10, 2)), CAST(0.50 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (64, 4, N'PROD00000064', N'AGUA ALL NATURAL 10L', N'AGUA ALL NATURAL 10 L', N'UNIDAD', CAST(2.00 AS Decimal(10, 2)), CAST(2.30 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (65, 4, N'PROD00000065', N'DEL VALLE 1.75L NARANJA', N'JUGO NARANJA DEL VALLE 1.75 L', N'UNIDAD', CAST(0.80 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (66, 4, N'PROD00000066', N'SPRITE 300ML', N'COLA SPRITE 300 ML', N'UNIDAD', CAST(0.20 AS Decimal(10, 2)), CAST(0.28 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (67, 7, N'PROD00000067', N'VODKA RUSSKAYA 750CC', N'VODKA RUSSKAYA 750 CC', N'UNIDAD', CAST(9.70 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (68, 7, N'PROD00000068', N'WHISKY CHIVAS REGAL 700ML', N'WHISKY CHIVAS REGAL 700 ML', N'UNIDAD', CAST(40.00 AS Decimal(10, 2)), CAST(44.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (69, 7, N'PROD00000069', N'WHISKY JOHN MORRIS 750ML', N'WHISKY JOHN MORRIS 750 ML', N'UNIDAD', CAST(9.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (70, 7, N'PROD00000070', N'WHISKY OLD TIMES 745ML RED', N'WHISKY OLD TIMES 745 ML RED', N'UNIDAD', CAST(8.00 AS Decimal(10, 2)), CAST(8.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (71, 7, N'PROD00000071', N'VINO SAUVIGNON 750 ML', N'VINO CABERNET SAUVIGNON RESERVADO 750 ML', N'UNIDAD', CAST(10.00 AS Decimal(10, 2)), CAST(11.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (72, 7, N'PROD00000072', N'WHISKY GRANTS 750ML', N'WHISKY GRANTS 750 ML', N'UNIDAD', CAST(17.00 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (73, 1, N'PROD00000073', N'BOMBONES FERRERO 50G', N'BOMBONES FERRERO ROCHER 50 G', N'UNIDAD', CAST(2.75 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (74, 1, N'PROD00000074', N'DORITOS 275G MEGA QUESO', N'SNACK DE MAIZ DORITOS 275 G MEGA QUESO', N'UNIDAD', CAST(2.00 AS Decimal(10, 2)), CAST(2.30 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (75, 1, N'PROD00000075', N'TABLETA M&M 113.4G CHOCOLATE', N'TABLETA M&M 113.4 G CHOCOLATE', N'UNIDAD', CAST(3.00 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (76, 1, N'PROD00000076', N'HUEVITOS LA UNIVERSAL 265G CEREZA', N'CHOCOLATE HUEVITOS LA UNIVERSAL 265 G CEREZA', N'UNIDAD', CAST(2.00 AS Decimal(10, 2)), CAST(2.60 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (77, 1, N'PROD00000077', N'KITKAT CHOCOLATE BLANCO 41.5G', N'CHOCOLATE KITKAT WHITE CHOCOLATE BLANCO 41.5G', N'UNIDAD', CAST(0.60 AS Decimal(10, 2)), CAST(0.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (78, 1, N'PROD00000078', N'GALLETAS NESTLÉ MARIA 172G', N'GALLETAS DULCES NESTLÉ 172 G', N'UNIDAD', CAST(0.50 AS Decimal(10, 2)), CAST(0.87 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (79, 5, N'PROD00000079', N'BOMBA METALICO DRAGON 350CC', N'BOMBA PARA FUMIGAR MANGO METALICO 350 CC DRAGÓN', N'UNIDAD', CAST(2.20 AS Decimal(10, 2)), CAST(2.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (80, 5, N'PROD00000080', N'RAQUETA RECARGABLE MAYIK', N'RAQUETA MATA INSECTOS RECARGABLE MAYIK', N'UNIDAD', CAST(4.50 AS Decimal(10, 2)), CAST(5.30 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (81, 5, N'PROD00000081', N'RATICIDA KLERAT 50G', N'RATICIDA KLERAT 50 G', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (82, 5, N'PROD00000082', N'INSECTICIDA BAYGON 360ML', N'INSECTICIDA RASTREROS BAYGON 360 ML', N'UNIDAD', CAST(2.80 AS Decimal(10, 2)), CAST(3.10 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (83, 6, N'PROD00000083', N'MARGARINA NATURELLA ALES 500G', N'MARGARINA NATURELLA ALES 500G', N'UNIDAD', CAST(1.20 AS Decimal(10, 2)), CAST(1.60 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (84, 6, N'PROD00000084', N'MARGARINA GIRASOL 240G', N'MARGARINA GIRASOL 240G', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.10 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (85, 6, N'PROD00000085', N'LECHE POLVO LA VAQUITA 190G', N'LECHE POLVO NUTRIMAS LA VAQUITA 190G', N'UNIDAD', CAST(1.20 AS Decimal(10, 2)), CAST(1.50 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (86, 5, N'PROD00000086', N'MATAMOSCAS SURTIDO HAIXING', N'MATAMOSCAS COLOR SURTIDO HAIXING UNIDAD', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.20 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (87, 6, N'PROD00000087', N'LECHE NUTRI ENTERA CARTÓN 200ML', N'LECHE NUTRI ENTERA CARTÓN 200ML', N'UNIDAD', CAST(0.20 AS Decimal(10, 2)), CAST(0.25 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (88, 6, N'PROD00000088', N'LECHE REYLECHE ENTERA 900ML', N'LECHE REYLECHE ENTERA FUNDA 900ML', N'UNIDAD', CAST(0.90 AS Decimal(10, 2)), CAST(0.95 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (89, 6, N'PROD00000089', N'LECHE MILO CHOCOLATADA 185ML', N'LECHE MILO® CHOCOLATADA 185ML', N'UNIDAD', CAST(0.65 AS Decimal(10, 2)), CAST(0.70 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (90, 6, N'PROD00000090', N'MARGARINA BONELLA 3KG', N'MARGARINA BONELLA 3KG', N'UNIDAD', CAST(10.00 AS Decimal(10, 2)), CAST(11.50 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (91, 6, N'PROD00000091', N'LECHE LENUTRIT CHOCOLATE 900ML', N'LECHE LENUTRIT DE CHOCOLATE FUNDA 900ML', N'UNIDAD', CAST(0.85 AS Decimal(10, 2)), CAST(0.93 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (92, 3, N'PROD00000092', N'DIFUSOR GLADE LAVANDA 100ML', N'DIFUSOR GLADE CON AROMA CAMPOS DE LAVANDA 100ML', N'UNIDAD', CAST(5.80 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (93, 3, N'PROD00000093', N'CLOROX LÍQUIDO BOTELLA 1L', N'BLANQUEADOR CLOROX LÍQUIDO REGULAR BOTELLA 1040g', N'UNIDAD', CAST(0.70 AS Decimal(10, 2)), CAST(0.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (94, 3, N'PROD00000094', N'LYSOL LAVANDA 3785ML', N'DESINFECTANTE DE PISOS LYSOL LAVANDA 3785ML', N'UNIDAD', CAST(7.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (95, 3, N'PROD00000095', N'SUAVIZANTE AROMATEL COCO 550ML', N'SUAVIZANTE AROMATEL COCO BAMBÚ DOYPACK 550ML', N'UNIDAD', CAST(1.30 AS Decimal(10, 2)), CAST(1.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (96, 3, N'PROD00000096', N'ESTROPAJO DE ALUMINIO SOLEX', N'ESTROPAJO DE ALUMINIO SOLEX', N'UNIDAD', CAST(0.25 AS Decimal(10, 2)), CAST(0.38 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (97, 1, N'PROD00000097', N'GALLETA CLUB SOCIAL X9 234G', N'PACK 9 UND GALLETA CLUB SOCIAL ORIGINAL 234G', N'UNIDAD', CAST(1.50 AS Decimal(10, 2)), CAST(1.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (98, 1, N'PROD00000098', N'BARRA DE CHOCOLATE LA UNIVERSAL 100G', N'BARRA DE CHOCOLATE SUPERIOR LA UNIVERSAL 100G', N'UNIDAD', CAST(0.80 AS Decimal(10, 2)), CAST(0.95 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (99, 4, N'PROD00000099', N'JUGO PULP NÉCTAR DURAZNO 1L', N'JUGO PULP NÉCTAR DURAZNO 1L', N'UNIDAD', CAST(0.90 AS Decimal(10, 2)), CAST(0.95 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (100, 4, N'PROD00000100', N'JUGO CIFRUT CITRUS PUNCH 3L', N'JUGO CIFRUT CITRUS PUNCH 3L', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.30 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (102, 1, N'PROD00000101', N'BOMBONES FERRERO ROCHER PACK 8', N'PACK 8 UDS BOMBONES FERRERO ROCHER ESTUCHE DE CORAZÓN 100G', N'UNIDAD', CAST(6.50 AS Decimal(10, 2)), CAST(7.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (103, 1, N'PROD00000102', N'CHOCOLATE VIZZIO 131G', N'CHOCOLATE VIZZIO 131G ALMENDRA CUBIERTA DE CHOCOLATE', N'UNIDAD', CAST(2.50 AS Decimal(10, 2)), CAST(2.90 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (104, 1, N'PROD00000103', N'BOMBONES THE BELGIAN CHOCOLATE 200G', N'BOMBONES THE BELGIAN DE CHOCOLATE 200G, SURTIDO', N'UNIDAD', CAST(5.00 AS Decimal(10, 2)), CAST(5.90 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (105, 1, N'PROD00000104', N'PAPAS RUFFLES CRE-CEB 400G', N'PAPAS RUFFLES CREMA Y CEBOLLA 400G', N'UNIDAD', CAST(2.99 AS Decimal(10, 2)), CAST(3.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (106, 1, N'PROD00000105', N'CHOCOLATES SNICKERS MINIS 275G', N'FUNDA DE CHOCOLATES SNICKERS MINIS 275G', N'UNIDAD', CAST(7.00 AS Decimal(10, 2)), CAST(8.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (107, 1, N'PROD00000106', N'CHOCOLATE PACARI 200G PACK4', N'PACK 4 UDS CHOCOLATE PACARI 200G', N'UNIDAD', CAST(7.70 AS Decimal(10, 2)), CAST(8.20 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (108, 1, N'PROD00000107', N'CHOCOLATE SCHOGETTEN ORIGINALS 100G', N'CHOCOLATE LATTE MACCHIATO SCHOGETTEN ORIGINALS 100G', N'UNIDAD', CAST(1.40 AS Decimal(10, 2)), CAST(1.90 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (109, 1, N'PROD00000108', N'BOMBÓN DARK NOGGY 82G', N'BOMBÓN DARK NOGGY CAJA 82G', N'UNIDAD', CAST(1.70 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (110, 1, N'PROD00000109', N'GALLETA OREO ORIGINAL 432G PACK12', N'PACK 12 UDS GALLETA OREO® ORIGINAL 432G', N'UNIDAD', CAST(3.00 AS Decimal(10, 2)), CAST(3.60 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (111, 1, N'PROD00000110', N'KINDER JOY 20G', N'CHOCOLATE KINDER JOY SURTIDO 20G', N'UNIDAD', CAST(0.80 AS Decimal(10, 2)), CAST(1.05 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (112, 1, N'PROD00000111', N'GALLETA FESTIVAL VAINILLA 50G', N'GALLETA VAINILLA FESTIVAL 50G', N'UNIDAD', CAST(0.10 AS Decimal(10, 2)), CAST(0.20 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (113, 1, N'PROD00000112', N'CARAMELO HALLS STRONG LYPTUS 151.2G', N'PACK 6 UND CARAMELO HALLS STRONG LYPTUS 151.2G', N'UNIDAD', CAST(2.00 AS Decimal(10, 2)), CAST(2.30 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (114, 1, N'PROD00000113', N'MILLOWS MASMELO DE CREMA 250G', N'MARSHMALLOWS MILLOWS DE CREMA 250G', N'UNIDAD', CAST(1.50 AS Decimal(10, 2)), CAST(1.90 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (115, 1, N'PROD00000114', N'GALLETAS SALTICAS MINI 30G', N'GALLETAS SALTICAS MINI ORIGINAL', N'UNIDAD', CAST(0.12 AS Decimal(10, 2)), CAST(0.19 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (116, 2, N'PROD00000115', N'ACEITE GIRASOL 2L', N'ACEITE GIRASOL 2L', N'UNIDAD', CAST(5.00 AS Decimal(10, 2)), CAST(5.90 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (117, 2, N'PROD00000116', N'ACEITE DE OLIVA MUELOLIVA 500ML', N'ACEITE DE OLIVA EXTRAVIRGEN MUELOLIVA 500ML', N'UNIDAD', CAST(4.70 AS Decimal(10, 2)), CAST(5.10 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (118, 2, N'PROD00000117', N'ACEITE DE OLIVA EXTRA BETIS 250 ML', N'ACEITE DE OLIVA BETIS EXTRA TRUFA 250 ML', N'UNIDAD', CAST(3.00 AS Decimal(10, 2)), CAST(3.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (119, 2, N'PROD00000118', N'ACEITE ALESOL 500ML', N'ACEITE ALESOL EN BOTELLA 500ML', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.35 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (120, 2, N'PROD00000119', N'ACEITE PALMA DE ORO 750 ML', N'ACEITE VEGETAL PALMA DE ORO 750 ML', N'UNIDAD', CAST(1.40 AS Decimal(10, 2)), CAST(1.70 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (121, 2, N'PROD00000120', N'MANTECA LOS 3 CHANCHITOS 175G', N'MANTECA LOS 3 CHANCHITOS EN FUNDA 175G', N'UNIDAD', CAST(0.25 AS Decimal(10, 2)), CAST(0.32 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (122, 2, N'PROD00000121', N'ACHIOTE PALMA DE ORO 0.5L', N'ACHIOTE PALMA DE ORO 0.5L', N'UNIDAD', CAST(1.50 AS Decimal(10, 2)), CAST(1.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (123, 2, N'PROD00000122', N'FIDEO INSTANTÁNEO RAPIDITO POLLO 100G', N'FIDEO INSTANTÁNEO RAPIDITO POLLO 100G', N'UNIDAD', CAST(0.40 AS Decimal(10, 2)), CAST(0.55 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (124, 2, N'PROD00000123', N'MACARRÓN EKONO 350G', N'FIDEO MACARRÓN EKONO 350G', N'UNIDAD', CAST(0.50 AS Decimal(10, 2)), CAST(0.70 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (125, 2, N'PROD00000124', N'TORNILLO EKONO 350G', N'FIDEO TORNILLO EKONO 350G', N'UNIDAD', CAST(0.60 AS Decimal(10, 2)), CAST(0.70 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (126, 2, N'PROD00000125', N'FRÉJOL DON CHICHO AMARILLO 500G', N'FRÉJOL DON CHICHO AMARILLO 500G', N'UNIDAD', CAST(1.70 AS Decimal(10, 2)), CAST(2.15 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (127, 2, N'PROD00000126', N'FIDEO SPAGHETTI TOMADINI 500G', N'FIDEO SPAGHETTI TOMADINI 500G', N'UNIDAD', CAST(1.05 AS Decimal(10, 2)), CAST(1.30 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (128, 2, N'PROD00000127', N'LENTEJON LA PRADERA 500G', N'LENTEJON LA PRADERA 500G', N'UNIDAD', CAST(1.20 AS Decimal(10, 2)), CAST(1.35 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (129, 2, N'PROD00000128', N'FIDEO CAYAMBE DINO 400G', N'FIDEO CAYAMBE EN FORMA DE DINOSAURIOS 400G', N'UNIDAD', CAST(0.80 AS Decimal(10, 2)), CAST(1.05 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (130, 2, N'PROD00000129', N'CANGUIL EL AGRICULTOR 250G', N'CANGUIL EL AGRICULTOR 250G', N'UNIDAD', CAST(0.40 AS Decimal(10, 2)), CAST(0.55 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (131, 2, N'PROD00000130', N'LASAGNA TOSCANA 400G', N'LASAGNA TOSCANA 400G', N'UNIDAD', CAST(3.70 AS Decimal(10, 2)), CAST(4.20 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (132, 3, N'PROD00000131', N'DETERGENTE DEJA SUPERIOR 1800G', N'DETERGENTE EN POLVO DEJA CUIDADO SUPERIOR 1800G', N'UNIDAD', CAST(3.50 AS Decimal(10, 2)), CAST(41.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (133, 3, N'PROD00000132', N'DETERGENTE CICLÓN FLORAL 5 KG', N'DETERGENTE EN POLVO CICLÓN ULTRA FLORAL 5 KG', N'UNIDAD', CAST(9.75 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (134, 3, N'PROD00000133', N'DETERGENTE LÍQUIDO DEJA FLORAL 500ML', N'DETERGENTE LÍQUIDO DEJA PARA DILUIR FLORAL 500ML', N'UNIDAD', CAST(4.00 AS Decimal(10, 2)), CAST(4.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (135, 3, N'PROD00000134', N'JABÓN LAVATODO FLORAL 960G PACK4', N'PACK 4 UDS JABÓN LAVATODO FLORAL 960G', N'UNIDAD', CAST(1.90 AS Decimal(10, 2)), CAST(2.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (136, 3, N'PROD00000135', N'DETERGENTE LÍQUIDO WOOLITE 1800 ML', N'DETERGENTE LÍQUIDO WOOLITE TODOS LOS DÍAS 1800 ML', N'UNIDAD', CAST(4.80 AS Decimal(10, 2)), CAST(5.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (137, 3, N'PROD00000136', N'SUAVIZANTE PERLA LAV Y ORQ DOYPACK 1300ML', N'SUAVIZANTE PERLA LAVANDA Y ORQUIDEAS DOYPACK 1300ML', N'UNIDAD', CAST(2.70 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (138, 3, N'PROD00000137', N'DETERGENTE GOL LIMÓN 480G', N'DETERGENTE GOL LIMÓN 480G', N'UNIDAD', CAST(0.40 AS Decimal(10, 2)), CAST(0.79 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (139, 3, N'PROD00000138', N'LIMPIA INODORO SAPOLIO 500ML', N'LIMPIA INODORO SAPOLIO WC POWER PLUS 500ML', N'UNIDAD', CAST(1.50 AS Decimal(10, 2)), CAST(1.89 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (140, 3, N'PROD00000139', N'SELLO ROJO 375G', N'LEJÍA ESCAMAS SELLO ROJO 375G', N'UNIDAD', CAST(1.70 AS Decimal(10, 2)), CAST(1.90 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (141, 3, N'PROD00000140', N'DESINFECTANTE TIPS 240ML', N'DESINFECTANTE TIPS 240ML - VARIAS FRAGANCIAS', N'UNIDAD', CAST(0.29 AS Decimal(10, 2)), CAST(0.38 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (142, 3, N'PROD00000141', N'DESINFECTANTE OLIMPIA MANZANA 900ML', N'LIMPIADOR DESINFECTANTE OLIMPIA – MANZANA 900ML', N'UNIDAD', CAST(1.38 AS Decimal(10, 2)), CAST(1.67 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (143, 3, N'PROD00000142', N'DESINFECTANTE FABULOSO FLORAL 2L', N'DESINFECTANTE FABULOSO FLORAL 2 L', N'UNIDAD', CAST(3.20 AS Decimal(10, 2)), CAST(3.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (144, 3, N'PROD00000143', N'CLOROX LÍQUIDO ORIGINAL 160G', N'BLANQUEADOR CLOROX LÍQUIDO ORIGINAL 160G', N'UNIDAD', CAST(0.10 AS Decimal(10, 2)), CAST(0.13 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (145, 3, N'PROD00000144', N'CLORO SAPOLIO 4000G', N'BLANQUEADOR SAPOLIO LEJÍA 4000G', N'UNIDAD', CAST(2.00 AS Decimal(10, 2)), CAST(2.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (146, 3, N'PROD00000145', N'REPUESTO AMBIENTAL GLADE AUTO 7ML', N'DESODORANTE AMBIENTAL GLADE AUTO SPORT LAVANDA MARINA CON REPUESTO 7ML', N'UNIDAD', CAST(7.00 AS Decimal(10, 2)), CAST(7.60 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (147, 5, N'PROD00000146', N'REPELENTE LÍQUIDO RAID ELÉCTRICO', N'REPELENTE LÍQUIDO RAID ELÉCTRICO PARA INSECTOS VOLADORES 32,9 CM3', N'UNIDAD', CAST(9.15 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (148, 5, N'PROD00000147', N'Q-KARACTION GEL CUCARACHA 10G', N'Q-KARACTION GEL CONTROL DE CUCARACHAS 10G', N'UNIDAD', CAST(9.70 AS Decimal(10, 2)), CAST(10.10 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (149, 5, N'PROD00000148', N'TRAMPA ENGOMADA ROEDORES', N'TRAMPA ENGOMADA ROEDORES 2 TRAMPAS', N'UNIDAD', CAST(6.00 AS Decimal(10, 2)), CAST(7.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (150, 5, N'PROD00000149', N'INSECTICIDA LÍQUIDO BAYGON 510ML', N'INSECTICIDA LÍQUIDO BAYGON CON GATILLO 510ML', N'UNIDAD', CAST(3.00 AS Decimal(10, 2)), CAST(3.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (151, 5, N'PROD00000150', N'TRAMPA BIG CHEESE PARA RATÓN', N'TRAMPA BIG CHEESE PARA RATÓN DE MADERA', N'UNIDAD', CAST(1.20 AS Decimal(10, 2)), CAST(1.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (152, 5, N'PROD00000151', N'INSECTICIDA TORVI 1000ML', N'INSECTICIDA LÍQUIDO TORVI 1000ML', N'UNIDAD', CAST(3.75 AS Decimal(10, 2)), CAST(4.30 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (153, 5, N'PROD00000152', N'EL SECRETO DE LA ABUELITA 225G', N'MASILLA CUCARACHICIDA EL SECRETO DE LA ABUELITA 225G', N'UNIDAD', CAST(1.40 AS Decimal(10, 2)), CAST(1.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (154, 5, N'PROD00000153', N'NAFTALINA TRIPLE ACCIÓN 24 UDS', N'NAFTALINA TRIPLE ACCIÓN NAF-TOP 24 UDS', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.25 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (155, 5, N'PROD00000154', N'RATICIDA CAMPEX 50G', N'RATICIDA CAMPEX 50G', N'UNIDAD', CAST(0.70 AS Decimal(10, 2)), CAST(0.90 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (156, 5, N'PROD00000155', N'INSECTICIDA AGUILA REAL LIMÓN 400ML', N'INSECTICIDA AGUILA REAL LIMÓN 400ML', N'UNIDAD', CAST(2.90 AS Decimal(10, 2)), CAST(3.30 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (157, 5, N'PROD00000156', N'INSECTICIDA ZAP VOLADORES 360ML', N'INSECTICIDA ZAP VOLADORES 360ML', N'UNIDAD', CAST(1.50 AS Decimal(10, 2)), CAST(2.20 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (158, 4, N'PROD00000157', N'AGUA SIN GAS DASANI 1200ML PACK6', N'PACK 6 UDS AGUA SIN GAS DASANI 1200ML', N'UNIDAD', CAST(2.20 AS Decimal(10, 2)), CAST(2.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (159, 4, N'PROD00000158', N'AGUA SIN GAS SPLENDOR 5L', N'AGUA SIN GAS SPLENDOR 5L', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.60 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (160, 4, N'PROD00000159', N'AGUA SIN GAS PURE WATER 6L', N'AGUA SIN GAS PURE WATER 6L', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (161, 4, N'PROD00000160', N'AGUA PURE WATER 625 ML', N'AGUA PURE WATER 625 ML', N'UNIDAD', CAST(0.15 AS Decimal(10, 2)), CAST(0.22 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (162, 4, N'PROD00000161', N'COLA TROPICAL 3.8 L', N'COLA TROPICAL 3.8 L', N'KG', CAST(1.80 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (163, 4, N'PROD00000162', N'COLA MANZANA 3.8L', N'COLA MANZANA 3.8L', N'UNIDAD', CAST(1.75 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (164, 4, N'PROD00000163', N'COLA KOLA GALLITO 3.78L', N'COLA KOLA GALLITO 3.78L', N'UNIDAD', CAST(1.70 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (165, 4, N'PROD00000164', N'COLACOCA SIN AZÚCAR 1 LITRO', N'COLA COCA COLA SIN AZÚCAR 1 LITRO', N'UNIDAD', CAST(0.40 AS Decimal(10, 2)), CAST(0.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (166, 4, N'PROD00000165', N'COLA BIG PET 300ML', N'COLA BIG PET 300ML', N'UNIDAD', CAST(0.15 AS Decimal(10, 2)), CAST(0.19 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (167, 4, N'PROD00000166', N'COLA FANTA 1L', N'COLA FANTA 1 LITRO', N'UNIDAD', CAST(0.40 AS Decimal(10, 2)), CAST(0.66 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (168, 4, N'PROD00000167', N'COLA MÁS SABOR NARANJA 3780ML', N'COLA MÁS SABOR NARANJA 3780ML', N'UNIDAD', CAST(1.50 AS Decimal(10, 2)), CAST(1.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (169, 4, N'PROD00000168', N'COLA INCA KOLA 3L', N'COLA INCA KOLA 3L', N'UNIDAD', CAST(2.00 AS Decimal(10, 2)), CAST(2.30 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (170, 4, N'PROD00000169', N'COLA SPRITE 1.75L', N'COLA SPRITE 1.75L', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.21 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (171, 4, N'PROD00000170', N'JUGO NATURA DURAZNO 1L', N'JUGO NATURA® NÉCTAR 1L - VARIOS SABORES', N'UNIDAD', CAST(1.10 AS Decimal(10, 2)), CAST(1.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (172, 4, N'PROD00000171', N'JUGO DEL VALLE NARANJA PACK2', N'PACK 2 UND JUGO DEL VALLE NÉCTAR VARIOS SABORES 1L', N'UNIDAD', CAST(1.70 AS Decimal(10, 2)), CAST(1.90 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (173, 6, N'PROD00000172', N'LECHE REYLECHE SURTIDO 200ML PACK6', N'PACK 6 UDS LECHE REYLECHE SURTIDO 200ML', N'UNIDAD', CAST(2.80 AS Decimal(10, 2)), CAST(3.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (174, 6, N'PROD00000173', N'YOGU YOGU DE MORA 750ML', N'BEBIDA YOGU YOGU DE MORA 750ML', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.49 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (175, 6, N'PROD00000174', N'LECHE TONI FRUTILLA 1L', N'LECHE TONI FRUTILLA 1L', N'UNIDAD', CAST(1.70 AS Decimal(10, 2)), CAST(1.90 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (176, 6, N'PROD00000175', N'LECHE TONI CHOCOLATE 200ML', N'LECHE TONI CHOCOLATE 200ML', N'UNIDAD', CAST(0.50 AS Decimal(10, 2)), CAST(0.70 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (177, 6, N'PROD00000176', N'LECHE ENTERA FUNDA ANDINA 900ML PACK6', N'PACK 6 UDS LECHE ENTERA FUNDA ANDINA 900ML', N'UNIDAD', CAST(5.00 AS Decimal(10, 2)), CAST(5.30 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (178, 6, N'PROD00000177', N'LECHE SEMIDESCREMADA FUNDA ANDINA 900ML PACK6', N'PACK 6 UDS LECHE SEMIDESCREMADA FUNDA ANDINA 900ML', N'UNIDAD', CAST(5.00 AS Decimal(10, 2)), CAST(5.30 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (179, 6, N'PROD00000178', N'LECHE NUTRI SEMIDESCREMADA CARTÓN 1L PACK4', N'PACK 4 UDS LECHE NUTRI SEMIDESCREMADA CARTÓN 1L', N'UNIDAD', CAST(4.00 AS Decimal(10, 2)), CAST(4.35 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (180, 6, N'PROD00000179', N'LECHE INDULAC SEMIDESCREMADA 1L', N'LECHE INDULAC SEMIDESCREMADA 1L', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.28 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (181, 6, N'PROD00000180', N'LECHE TONI CHOCOLATADA 135ML PACK6', N'PACK 6 UDS LECHE TONI CHOCOLATADA CHIQUI 135ML', N'UNIDAD', CAST(2.00 AS Decimal(10, 2)), CAST(2.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (182, 6, N'PROD00000181', N'LECHE TONI DE FRUTILLA 200ML PACK6', N'PACK 6 UDS LECHE TONI DE FRUTILLA 200ML', N'UNIDAD', CAST(3.70 AS Decimal(10, 2)), CAST(4.10 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (183, 6, N'PROD00000182', N'LECHE TONI DE CHOCOLATADA 200ML PACK6', N'PACK 6 UDS LECHE TONI DE CHOCOLATADA 200ML', N'UNIDAD', CAST(3.70 AS Decimal(10, 2)), CAST(4.10 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (184, 6, N'PROD00000183', N'LECHE PARMALAT DESLACTOSADA ZYMIL 1L', N'LECHE PARMALAT DESLACTOSADA ZYMIL CARTÓN 1L', N'UNIDAD', CAST(1.00 AS Decimal(10, 2)), CAST(1.35 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (185, 6, N'PROD00000184', N'LECHE NESQUIK CHOCOLATE 200ML', N'LECHE NESQUIK 200ML CHOCOLATE', N'UNIDAD', CAST(0.40 AS Decimal(10, 2)), CAST(0.65 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (186, 6, N'PROD00000185', N'LECHE NESQUIK 200ML FRUTILLA', N'LECHE NESQUIK 200ML FRUTILLA', N'UNIDAD', CAST(0.40 AS Decimal(10, 2)), CAST(0.65 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (187, 6, N'PROD00000186', N'LECHE EN POLVO NUTRI 100G', N'LECHE EN POLVO NUTRI FORTIFICADA FUNDA 100G', N'UNIDAD', CAST(0.70 AS Decimal(10, 2)), CAST(0.75 AS Decimal(10, 2)), N'SIN IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (188, 6, N'PROD00000187', N'BEBIDA VEGETAL NOTMILK 1L', N'BEBIDA VEGETAL NOTMILK ORIGINAL 1L', N'UNIDAD', CAST(3.00 AS Decimal(10, 2)), CAST(3.20 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (189, 6, N'PROD00000188', N'LECHE DE SOYA ORIENTAL 900G', N'LECHE DE SOYA ORIENTAL INSTANTÁNEA 900G', N'UNIDAD', CAST(11.00 AS Decimal(10, 2)), CAST(12.20 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (190, 7, N'PROD00000189', N'RON HAVANA CLUB 750ML', N'RON HAVANA CLUB ORO ESPECIAL 750ML', N'UNIDAD', CAST(18.00 AS Decimal(10, 2)), CAST(19.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (191, 7, N'PROD00000190', N'RON CASTILLO AÑEJO 750ML', N'RON CASTILLO AÑEJO 750ML', N'UNIDAD', CAST(9.00 AS Decimal(10, 2)), CAST(10.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (192, 7, N'PROD00000191', N'RON ESTELAR SILVER 750ML', N'RON ESTELAR SILVER 750ML', N'UNIDAD', CAST(6.50 AS Decimal(10, 2)), CAST(7.30 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (193, 7, N'PROD00000192', N'RON ABUELO AÑEJO 7 AÑOS - 750ML', N'RON ABUELO AÑEJO 7 AÑOS - 750ML', N'UNIDAD', CAST(14.00 AS Decimal(10, 2)), CAST(16.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (194, 7, N'PROD00000193', N'RON DIPLOMÁTICO AÑEJO 750ML', N'RON DIPLOMÁTICO MANTUANO AÑEJO 750ML', N'UNIDAD', CAST(22.00 AS Decimal(10, 2)), CAST(24.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (195, 7, N'PROD00000194', N'TEQUILA EL CHARRO SILVER 750 ML', N'TEQUILA EL CHARRO SILVER 750 ML', N'UNIDAD', CAST(11.00 AS Decimal(10, 2)), CAST(13.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (196, 7, N'PROD00000195', N'TEQUILA SOMBRERO NEGRO GOLD 750ML', N'TEQUILA SOMBRERO NEGRO GOLD 750ML', N'UNIDAD', CAST(22.00 AS Decimal(10, 2)), CAST(24.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (197, 7, N'PROD00000196', N'CRISTAL SECO 750ML', N'BEBIDA ALCOHÓLICA CRISTAL SECO 750ML', N'UNIDAD', CAST(4.00 AS Decimal(10, 2)), CAST(4.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (198, 7, N'PROD00000197', N'TRÓPICO SECO 750ML', N'LICOR TRÓPICO SECO 750ML', N'UNIDAD', CAST(5.00 AS Decimal(10, 2)), CAST(5.80 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (199, 7, N'PROD00000198', N'AGUARDIENTE NORTEÑO ESPECIAL 750ML', N'AGUARDIENTE BLANCO NORTEÑO ESPECIAL 750ML', N'UNIDAD', CAST(5.00 AS Decimal(10, 2)), CAST(6.00 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (200, 7, N'PROD00000199', N'VODKA SKY 750ML', N'VODKA SKY 750ML', N'UNIDAD', CAST(12.00 AS Decimal(10, 2)), CAST(13.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (201, 7, N'PROD00000200', N'VODKA LIOVA 750ML', N'VODKA LIOVA 750ML', N'UNIDAD', CAST(5.00 AS Decimal(10, 2)), CAST(6.40 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Productos] ([ID_Producto], [ID_Categoria], [Codigo], [Nombre], [Descripcion], [Presentacion], [Costo_Unitario], [Precio_venta], [Tipo_Cargo]) VALUES (202, 7, N'PROD00000201', N'VINO BLANCO LA VIEILLE FERME 750ML', N'VINO BLANCO LA VIEILLE FERME 750ML', N'UNIDAD', CAST(7.00 AS Decimal(10, 2)), CAST(8.50 AS Decimal(10, 2)), N'IVA')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Codigo], [Nombre], [RUC_Proveedor], [Direccion], [Telefono], [Email]) VALUES (1, N'PROV00000001', N'NESTLE', N'0922281621001', N'SANTA TERESITA Y CARLOS VITERI 1050', N'098-241-7171', N'gusteran1@gmail.com')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Codigo], [Nombre], [RUC_Proveedor], [Direccion], [Telefono], [Email]) VALUES (2, N'PROV00000002', N'PRONACA', N'1208769541002', N'BUCAY', N'094-123-5647', N'Pronac_proveedor@gmail.com')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Codigo], [Nombre], [RUC_Proveedor], [Direccion], [Telefono], [Email]) VALUES (3, N'PROV00000003', N'ARCA CONTINENTAL COCACOLA', N'2308972654001', N'MILAGRO', N'152-755-4122', N'arcamilagro@continental.com')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Codigo], [Nombre], [RUC_Proveedor], [Direccion], [Telefono], [Email]) VALUES (4, N'PROV00000004', N'DEVIES CORP S.A.', N'0992231092001', N'Av. 17 de Septiembre 1105, Milagro', N'042-716-7000', N'devcorpmilagro@gmail.com')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Codigo], [Nombre], [RUC_Proveedor], [Direccion], [Telefono], [Email]) VALUES (5, N'PROV00000005', N'INDUSTRIAS LACTEAS TONI S.A', N'0990351260001', N'Km 17 ½ Vía Perimetral', N'099-966-8862', N'usuario@tonicorp.com')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Codigo], [Nombre], [RUC_Proveedor], [Direccion], [Telefono], [Email]) VALUES (6, N'PROV00000006', N'THE TESALIA SPRINGS COMPANY S.A.', N'1790005739001', N'Km 8, 5 Via A Daule Oficinas Pepsi', N'042-211-1180', N'consulta.clientes@cbc.co')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Codigo], [Nombre], [RUC_Proveedor], [Direccion], [Telefono], [Email]) VALUES (7, N'PROV00000007', N'CERVECERIA NACIONAL CN S.A.', N'0990023549001', N'Km. 16,5 Vía a Daule, Guayaquil', N'042-216-2088', N'usuario@cn.com')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Codigo], [Nombre], [RUC_Proveedor], [Direccion], [Telefono], [Email]) VALUES (8, N'PROV00000008', N'CONFITECA C.A.', N'1790084604001', N'KM. 9 1/2 PANAMERICANA SUR S35-60', N'098-391-1098', N'ventas.almacen@confiteca.com.ec')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Codigo], [Nombre], [RUC_Proveedor], [Direccion], [Telefono], [Email]) VALUES (9, N'PROV00000009', N'DISTRIBUIDORA LICORES DEL ECUADOR', N'1791741048001', N'Tomas Sevilla Alta N14 y Av. Los Andes, Ambato, Ecuador', N'097-925-8979', N'sebastian.fiallos@licoresdelecuador.com')
GO
INSERT [dbo].[TipoComprobante] ([ID_Comprobante], [Nombre_Comprobante], [Tipo_Comprobante], [Correlativo]) VALUES (1, N'Facturas', N'F01', 18)
GO
INSERT [dbo].[TipoComprobante] ([ID_Comprobante], [Nombre_Comprobante], [Tipo_Comprobante], [Correlativo]) VALUES (2, N'Nota de Venta', N'NV01', 0)
GO
INSERT [dbo].[TipoComprobante] ([ID_Comprobante], [Nombre_Comprobante], [Tipo_Comprobante], [Correlativo]) VALUES (3, N'Notas de Credito', N'NC01', 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (1, 3, 1, N'FAC00000001', CAST(N'2023-03-06' AS Date), N'F00000001', CAST(3.98 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.24 AS Decimal(12, 2)), CAST(4.22 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (2, 3, 6, N'FAC00000002', CAST(N'2023-03-06' AS Date), N'F00000002', CAST(29.10 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(29.10 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (3, 2, 1, N'FAC00000003', CAST(N'2023-03-06' AS Date), N'F00000003', CAST(27.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.30 AS Decimal(12, 2)), CAST(30.80 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (4, 1, 6, N'FAC00000004', CAST(N'2023-03-07' AS Date), N'F00000004', CAST(1.94 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.94 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (5, 3, 6, N'FAC00000005', CAST(N'2023-03-07' AS Date), N'F00000005', CAST(27.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.30 AS Decimal(12, 2)), CAST(30.80 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (6, 2, 6, N'FAC00000006', CAST(N'2023-03-07' AS Date), N'F00000006', CAST(27.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.30 AS Decimal(12, 2)), CAST(30.80 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (7, 1, 6, N'FAC00000007', CAST(N'2023-03-07' AS Date), N'F00000007', CAST(27.50 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.30 AS Decimal(12, 2)), CAST(30.80 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (8, 3, 6, N'FAC00000008', CAST(N'2023-03-07' AS Date), N'F00000008', CAST(42.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(42.00 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (9, 1, 1, N'FAC00000009', CAST(N'2023-03-07' AS Date), N'F00000009', CAST(24.52 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(1.08 AS Decimal(12, 2)), CAST(25.60 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (10, 3, 1, N'FAC00000010', CAST(N'2023-03-08' AS Date), N'F00000010', CAST(20.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(20.00 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (11, 3, 1, N'FAC00000011', CAST(N'2023-03-08' AS Date), N'F00000011', CAST(16.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.66 AS Decimal(12, 2)), CAST(16.66 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (12, 3, 1, N'FAC00000012', CAST(N'2023-03-17' AS Date), N'F00000012', CAST(31.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(3.72 AS Decimal(12, 2)), CAST(34.72 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (13, 3, 1, N'FAC00000013', CAST(N'2023-03-19' AS Date), N'F00000013', CAST(0.90 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.11 AS Decimal(12, 2)), CAST(1.01 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (14, 3, 1, N'FAC00000014', CAST(N'2023-03-19' AS Date), N'F00000014', CAST(7.70 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.92 AS Decimal(12, 2)), CAST(8.62 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (15, 1, 1, N'FAC00000015', CAST(N'2023-03-19' AS Date), N'F00000015', CAST(125.76 AS Decimal(12, 2)), CAST(0.08 AS Decimal(12, 2)), CAST(12.04 AS Decimal(12, 2)), CAST(137.80 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (16, 3, 1, N'FAC00000016', CAST(N'2023-03-23' AS Date), N'F00000016', CAST(19.40 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(19.40 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (17, 2, 1, N'FAC00000017', CAST(N'2023-03-24' AS Date), N'F00000017', CAST(33.30 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(4.00 AS Decimal(12, 2)), CAST(37.30 AS Decimal(12, 2)), N'Emitido')
GO
INSERT [dbo].[Ventas] ([ID_Venta], [ID_Cliente], [ID_Usuario], [No_Factura], [Fecha_Venta], [Comprobante], [Sub_Total], [Descuento], [IVA], [Monto_Total], [Estado]) VALUES (18, 1, 1, N'FAC00000018', CAST(N'2023-03-24' AS Date), N'F00000018', CAST(154.00 AS Decimal(12, 2)), CAST(0.00 AS Decimal(12, 2)), CAST(18.48 AS Decimal(12, 2)), CAST(172.48 AS Decimal(12, 2)), N'Emitido')
GO
