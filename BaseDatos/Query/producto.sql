/*
drop table productosvendidos;
drop table cancelaciones;
drop table formaPago;
drop table ventas;
*/
if OBJECT_ID('producto') is not null
drop table producto;
create table producto(
	id_producto int primary key,
	nombre varchar(80),
	precio money not null,
	id_familia int not null,
	id_receta int
	--foreign key (id_familia) REFERENCES familia(id_familia) 
	--on update cascade
	--on delete cascade	
);

delete producto;
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	1	,'	HOTDOG COMBO INDIVIDUAL	'	,	35	,1,	9);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	2	,'	HOTDOG COMBO PAREJA 	'	,	65	,1,	10);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	3	,'	BURGUER COMBO INDIVIDUAL	'	,	55	,1,	11);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	4	,'	BURGER COMBO PAREJA	'	,	95	,1,	12);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	5	,'	COMBO ALITAS 4 PZS	'	,	50	,1,	1);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	6	,'	COMBO NUGGETS	'	,	45	,1,	13);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	7	,'	COMBO MOLLETES	'	,	30	,1,	14);
							
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	8	,'	HotDog	'	,	17	,2	,	1);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	9	,'	Hamburguesa	'	,	39	,2	,	3);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	10	,'	Nuggest 6 paz	'	,	30	,2	,5);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	11	,'	Alitas 4 PZs	'	,	30	,2	, 2);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	12	,'	Alitas 6 PZs	'	,	40	,2	,4);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	13	,'	Papas 250 Gr	'	,	30	,2,	7);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	14	,'	Molletes 	'	,	25	,2	,6);
							
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	15	,'	Americano (Chico 8 onz)	'	,	8	,3,	38);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	16	,'	Capuccino (Chico 8 onz)	'	,	12	,3,	39);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	17	,'	Latte (Chico 8 onz)	'	,	12	,3,	40);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	18	,'	Moka Canela (Chico 8 onz)	'	,	12	,3,	41);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	19	,'	Chocolate Abuelita (Chico 8 onz)	'	,	12	,3,	42);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	20	,'	Capuccino Vainilla (Chico 8 onz)	'	,	12	,3,	43);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	21	,'	Latte Vainilla (Chico 8 onz)	'	,	12	,3,	44);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	22	,'	Capuccino Moka (Chico 8 onz)	'	,	12	,3,	45);
							
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	23	,'	Americano (Grande 16 onz)	'	,	12	,3,	46);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	24	,'	Capuccino (Grande 16 onz)	'	,	17	,3,	47);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	25	,'	Latte (Grande 16 onz)	'	,	17	,3,	48);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	26	,'	Moka Canela (Grande 16 onz)	'	,	17	,3,	49);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	27	,'	Chocolate Abuelita (Grande 16 onz)	'	,	17	,3,	50);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	28	,'	Capuccino Vainilla (Grande 16 onz)	'	,	17	,3,	51);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	29	,'	Latte Vainilla (Grande 16 onz)	'	,	17	,3,	52);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	30	,'	Capuccino Moka (Grande 16 onz)	'	,	17	,3,	53);
							
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	31	,'	Coca Cola 600 ml	'	,	12	,4,	16);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	32	,'	Coca Light 600 ml	'	,	12	,4,	17);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	33	,'	Coca Zero 600 ml	'	,	12	,4,	18);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	34	,'	Manzana Lift 600 ml	'	,	12	,4,	19);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	35	,'	Fanta 600 ml	'	,	12	,4,	20);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	36	,'	Sprite 600 ml	'	,	12	,4,	21);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	37	,'	Senzao 600 ml	'	,	12	,4,	22);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	38	,'	Delaware Uva 600 ml	'	,	12	,4,	23);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	39	,'	Fresca 600 ml	'	,	12	,4,	24);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	40	,'	Naranja & Nada 600 ml	'	,	12	,4,	25);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	41	,'	Limon & Nada 600 ml	'	,	12	,4,	26);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	42	,'	Agua Ciel 1 Lt 	'	,	12	,4,	27);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	43	,'	FRUTSI 	'	,	7	,4,	28);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	44	,'	JUGO MINIBRICK	'	,	7	,4,	29);
							
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	45	,'	CC ZERO 400 ml	'	,	10	,4,	30);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	46	,'	DELAWAR 400 ml	'	,	10	,4,	31);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	47	,'	 FANTA NARANJA 400 ml	'	,	10	,4,	32);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	48	,'	FANTA FRESA 400 ml	'	,	10	,4,	33);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	49	,'	LIFT 400 ml	'	,	10	,4,	1);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	50	,'	SIDRAL MAN BOT 400 ml	'	,	10	,4,	34);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	51	,'	SPRITE 400 ml	'	,	10	,4,	35);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	52	,'	SPRITE ZERO 400 ml 	'	,	10	,4,	36);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	53	,'	Agua de Sabor 473 ML Horchata	'	,	12	,4,	8);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	54	,'	Agua de Sabor 1 Lt Horchata 	'	,	20	,4,	8);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	55	,'	Agua de Sabor 473 ML Tamarindo	'	,	12	,4,	8);
insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	56	,'	Agua de Sabor 1 Lt Tamarindo 	'	,	20	,4,	8);

insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	57	,'	Dona de chocolate 	'	,	11	,2,	54);

insert into producto(id_producto, nombre, precio, id_familia,id_receta) values(	58	,'	16 oz Cafe Americano + dona 	'	,	22	,1,	55);

