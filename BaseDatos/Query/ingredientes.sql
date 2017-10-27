if OBJECT_ID('ingredientes') is not null
drop table ingredientes;
create table ingredientes(
id_ingrediente int,
descripcion varchar(30),
unidad_medida varchar (4)
);
	--foreign key (id_producto) REFERENCES producto(id_producto) 
	--on update cascade
	--on delete cascade,
	


-- *********Individuales***********
-- hotdog
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	1	,'	Media Noche	',	'pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	2	,'	Salchicha	',	'pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	3	,'	Crema	',	'Gr'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	4	,'	Jitomate	',	'Gr'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	5	,'	Cebolla	'	,	'Gr'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	6	,'	Chile Serrano	',	'Gr'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	7	,'	Chiles en Vinagre	',	'Gr'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	8	,'	Sal con ajo	',	'Gr'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	9	,'	Mostaza	',	'Gr'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	10	,'	Catsup	',	'Gr'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	11	,'	Hoja de Polipapel	',	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	12	,'	Servilletas	',	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	13	,'	Bolsa de Polipapel	',	'Pza');
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	14	,'	Aderezo	'			,	'Gr' );

---- COSTEO ALITAS 4 PZS		
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	15	,'	Alitas	',		'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	16	,'	Valentina	'	,	'Ml'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	17	,'	Salsa BBQ	'	,	'Ml'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	18	,'	charola 835	'	,	'Gr'	);

---- HAMBURGUESA				
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	19	,'	Bollo	',		'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	20	,'	Carne Hamburguesa 110 Gr	',		'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	21	,'	Mayonesa	',	'Ml'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	22	,'	Lechuga	',	'Gr'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	23	,'	Queso Americano	',		'pza'	);

----  6 NUGGTES						
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	24	,'	Nugget	',	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	25	,'	Queso Liquido	'	,	'Gr'	);
---- MOLLETES
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	26	,'	Bolillo	',	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	27	,'	Frijoles Refritos	'	,	'Gr'	);
----- PAPAS
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	28	,'	Papa Francesa	'	,	'Gr'	);
----AGUA DE SABOR
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	29	,'	Vaso 16Oz	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	30	,'	Popote	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	31	,'	Tapa Plana	'	,	'Gr'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	32	,'	Agua Purificada	'	,	'Ml'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	33	,'	Jarabe Saborizante	'	,	'Ml'	);
-----REFRESCOS
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	34	,'	Coca Cola 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	35	,'	Coca Light 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	36	,'	Coca Zero 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	37	,'	Manzana Lift 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	38	,'	Fanta 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	39	,'	Sprite 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	40	,'	Senzao 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	41	,'	Delaware Uva 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	42	,'	Fresca 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	43	,'	Naranja & Nada 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	44	,'	Limon & Nada 600 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	45	,'	Agua Ciel 1 Lt  	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	46	,'	FRUTSI  	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	47	,'	JUGO MINIBRICK 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	48	,'	CC ZERO 400 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	49	,'	DELAWAR 400 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	50	,'	FANTA NARANJA 400 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	51	,'	FANTA FRESA 400 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	52	,'	LIFT 400 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	53	,'	SIDRAL MAN BOT 400 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	54	,'	SPRITE 400 ml 	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	55	,'	SPRITE ZERO 400 ml  	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	56	,'	Vaso 33Oz	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	57	,'	Vaso cafe 8 Oz	'	,	'Pza'	);
insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	58	,'	Vaso cafe 16 Oz	'	,	'Pza'	);

insert into ingredientes(id_ingrediente, descripcion,unidad_medida) values(	59 ,'	Dona de chocolate	'	,	'Pza'	);
