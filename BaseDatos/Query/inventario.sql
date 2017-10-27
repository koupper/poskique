if OBJECT_ID('inventario') is not null
drop table inventario;
create table inventario(
	id_inventario int identity,
	id_ingrediente int,
	inventario_inicial int default 0,
	mermas int default 0,
	prestamo int default 0,
	cortecias int default 0,
	entradas int default 0,
	salidas int default 0,
	inventario_final int default 0,
	minimo int default 0,
	maximo int default 0, 
	id_tienda int,
	fechaMovimiento datetime default getdate()
	
	
	--foreign key (id_ingrediente) REFERENCES ingredientes(id_ingrediente) 
	--on update cascade
	--on delete cascade
);

insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(1	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(2	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(3	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(4	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(5	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(6	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(7	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(8	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(9	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(10	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(11	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(12	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(13	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(14	,	500	,      500, 50 ,1000,6);

insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(15	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(16	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(17	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(18	,	500	,      500, 50 ,1000,6);

insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(19	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(20	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(21	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(22	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(23	,	500	,      500, 50 ,1000,6);

insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(24	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(25	,	500	,      500, 50 ,1000,6);

insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(26	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(27	,	500	,      500, 50 ,1000,6);

insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(28	,	5000,  5000, 500 ,10000,6);

insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(29	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(30	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(31	,	500	,      500, 50 ,1000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(32	,	20000,	20000, 5000 ,40000,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(33	,	10000,	10000, 500 ,20000,6);

insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(34	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(35	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(36	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(37	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(38	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(39	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(40	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(41	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(42	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(43	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(44	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(45	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(46	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(47	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(48	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(49	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(50	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(51	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(52	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(53	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(54	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(55	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(56	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(57	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(58	,	50, 50, 5 ,100,6);
insert into inventario(id_ingrediente,entradas, inventario_final,minimo,maximo,id_tienda) values(59	,	50, 50, 5 ,100,6);

--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	41	,41	,	50,		'Pza',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	42	,42	,	500,	'Gr',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	43	,43	,	500,	'Gr',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	44	,44	,	500,	'Gr',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	45	,45	,	500,	'Gr',	'pza',	0,	0,	0,	0,	0,	0,	0,6);

--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	46	,46	,	50,		'Pza',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	47	,47	,	500,	'Gr',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	48	,48	,	500,	'Gr',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	49	,49	,	500,	'Gr',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	50	,50	,	50,		'pza',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	51	,51	,	100,	'pza',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	52	,52	,	100,	'pza',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--insert into inventario(id_ingrediente,entradas, inventario_final,id_tienda) values(	53	,53	,	500,	'Gr',	'pza',	0,	0,	0,	0,	0,	0,	0,6);
--AQUI ESTA BIEN PERO HAY QUE CAPTURAR LO QUE FALTA
/*
--update inventario set descripcion = '', presentacion = '', inventario_inicial = ,mermas = ,  prestamo = , cortesias = ,  entradas = , Pz_vendidas = , diferencias =, inventario_inventario_final =  where id_inventario = and id_tienda =;

insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Medias noches','Pz',	17	,	5	, 	0	, 	0	,	0	, 	2	,	5	,	10	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Bollo hamburguesa ','Pz',	0	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	0	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Salchichas','Pz',	232	,	4	, 	0	, 	0	,	240	, 	2	,	4	,	466	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Jamón','Pz',	150	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	0	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Queso americano','Pz',	158	,	0	, 	0	, 	0	,	104	, 	0	,	0	,	262	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Crema','Bote',	1	,	0	, 	0	, 	0	,	2	, 	0	,	0	,	3	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Carne de Hambuerguesa','Pz',	0	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	0	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Alitas','Pz',	180	,	0	, 	0	, 	0	,	0	, 	16	,	0	,	36	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Nuggets','Pz',	200	,	0	, 	0	, 	0	,	0	, 	64	,	0	,	72	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Papa francesa (2.266)','Bolsa',	10.5	,	0	, 	0	, 	0	,	0	, 	1	,	0	,	9.5	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Mayonesa','Bote',	2	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	2	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Mostaza','Bote',	1	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	1	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Catsup','Bote',	2.5	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	2.5	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Valentina ','Bote',	1	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	1	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Queso liquido P/ Nachos','Lt',	6	,	0	, 	0	, 	0	,	7	, 	0.8	,	0	,	12.2	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Chiles en vinagre','Bolsa',	3	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	3	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'BBQ','Bote',	2	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	2	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Coca Cola','600 mil',	43	,	0	, 	0	, 	0	,	192	, 	19	,	0	,	216	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Coca Cola zero','600 mil',	24	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	24	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Coca Cola Ligth','600 mil',	29	,	0	, 	0	, 	0	,	0	, 	2	,	0	,	27	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Fanta','600 mil',	36	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	36	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Manzana','600 mil',	9	,	0	, 	0	, 	0	,	12	, 	1	,	0	,	20	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Sprite','600 mil',	19	,	0	, 	0	, 	0	,	12	, 	1	,	0	,	30	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Fresca','600 mil',	11	,	0	, 	0	, 	0	,	12	, 	1	,	0	,	22	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Delawer','600 mil',	13	,	0	, 	0	, 	0	,	12	, 	1	,	0	,	24	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Naranja y nada','600 mil',	21	,	0	, 	0	, 	0	,	12	, 	0	,	0	,	33	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'limon y nada','600 mil',	22	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	22	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Zenzao','600 mil',	25	,	0	, 	0	, 	0	,	12	, 	3	,	0	,	34	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Ciel','1 lt',	24	,	0	, 	0	, 	1	,	0	, 	1	,	0	,	22	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Frutsi','Pz',	21	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	21	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Jugo del Valle','Pz',	53	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	53	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Bolsas de Cafe Americano','Paque',	0	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	0	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Bolsas de Cafe Capuccino','Paque',	3	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	3	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Bolsas de Cafe Moka','Paque',	5	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	5	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Bolsas de Cafe Capuccino Vainilla','Paque',	4	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	4	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Bolsas de Chocolate abuelita','Paque',	8	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	8	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Vasos de 8 oz','Paque',	150	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	150	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Vasos de 16 oz','Paque',	350	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	350	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Paqutes de Popotes','Paque',	0	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	0	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Paquetes de Agitadores','Paque',	0	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	0	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Sobres de Azucar','Paque',	2823	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	2823	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Sobres de Splenda','Paque',	1250	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	1250	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Sobres de crema para cafe','Paque',	90	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	90	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Charola de 855 (500)','Paque',	18000	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	18000	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Charola de 835 (500)','Paque',	9250	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	9250	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Domo de Hamburguesa (500)','Paque',	54	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	54	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Bolsa de basura ','Pz',	10	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	10	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Bosa de asa','Kl',	1.5	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	1.5	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Tenedores (1000)','Caja',	200	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	200	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Guantes de plastico ','Caja',	1	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	1	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Servilletas','Pz',	2000	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	2000	,6);
insert into inventario(id_tienda,descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_inventario_final,id_tienda) values( 	1	,'Rollo terminco','Pz',	5	,	0	, 	0	, 	0	,	0	, 	0	,	0	,	5	,6);
*/