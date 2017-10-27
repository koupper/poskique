if OBJECT_ID('recetas') is not null
drop table recetas;
create table recetas(
	id_receta int,
	id_ingrediente int,
	cantidad_requerida int, 
	nombre_receta varchar(30)--,
);

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	1,	1,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	2,	1,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	3,	20,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	4,	30,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	5,	10,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	6,	2,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	7,	20,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	8,	1,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	9,	1,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	10,	25,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	11,	1,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	12,	2,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	13,	1,	'Hot Dog'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	1	,	14,	12,	'Hot Dog'	);

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	2	,	15,	4,	'alitas 4'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	2	,	10,	10,	'alitas 4'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	2	,	16,	12,	'alitas 4'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	2	,	17,	12,	'alitas 4'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	2	,	12,	2,	'alitas 4'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	2	,	18,	1,	'alitas 4'	);

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	19,	1,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	20,	1,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	21,	10,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	7,	20,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	5,	9,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	14,	12,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	4,	24,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	22,	26,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	9,	7,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	10,	25,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	23,	1,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	11,	1,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	12,	2,	'Hamburgesa'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	3	,	13,	1,	'Hamburgesa'	);


insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	4	,	15,	6,	'alitas 6'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	4	,	10,	12,	'alitas 6'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	4	,	16,	14,	'alitas 6'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	4	,	17,	14,	'alitas 6'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	4	,	12,	4,	'alitas 6'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	4	,	18,	1,	'alitas 6'	);

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	5	,	24,	6,	'nuggets 6'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	5	,	10,	13,	'nuggets 6'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	5	,	16,	10,	'nuggets 6'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	5	,	25,	10,	'nuggets 6'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	5	,	21,	10,	'nuggets 6'	);

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	6	,	26,	1,	'molletes'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	6	,	5,	20,	'molletes'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	6	,	4,	30,	'molletes'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	6	,	6,	10,	'molletes'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	6	,	23,	4,	'molletes'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	6	,	12,	2,	'molletes'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	6	,	13,	1,	'molletes'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	6	,	27,	70,	'molletes'	);

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	7	,	28,	250,'Papas'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	7	,	10,	12,	'Papas'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	7	,	16,	14,	'Papas'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	7	,	17,	14,	'Papas'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	7	,	12,	4,	'Papas'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	7	,	18,	1,	'Papas'	);

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	8	,	29,	1,	'Agua'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	8	,	30,	1,	'Agua'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	8	,	31,	1,	'Agua'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	8	,	32,	473,'Agua'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	8	,	33,	23,	'Agua'	);

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	1,	1,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	2,	1,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	3,	20,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	4,	30,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	5,	10,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	6,	2,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	7,	20,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	8,	1,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	9,	1,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	10,	25,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	11,	1,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	12,	2,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	13,	1,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	14,	12,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	28,	250,'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	10,	12,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	16,	14,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	17,	14,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	12,	4,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	18,	1,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	29,	1,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	30,	1,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	31,	1,	'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	32,	473,'HD combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	9	,	33,	23,	'HD combo I');

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	1,	2,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	2,	2,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	3,	40,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	4,	60,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	5,	20,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	6,	4,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	7,	40,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	8,	2,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	9,	2,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	10,	50,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	11,	2,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	12,	4,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	13,	2,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	14,	25,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	28,	500,'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	10,	24,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	16,	28,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	17,	28,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	12,	8,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	18,	2,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	29,	2,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	30,	2,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	31,	2,	'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	32,	946,'HD combo P');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	10	,	33,	46,	'HD combo P');

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	19,	1,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	20,	1,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	21,	10,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	7,	20,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	5,	9,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	14,	12,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	4,	24,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	22,	26,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	9,	7,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	10,	25,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	23,	1,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	11,	1,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	12,	2,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	13,	1,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	28,	250,'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	10,	12,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	16,	14,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	17,	14,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	12,	4,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	18,	1,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	29,	1,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	30,	1,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	31,	1,	'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	32,	473,'Bur combo I');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	11	,	33,	23,	'Bur combo I');

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	19,	2,	'Hamburgesa Combo Pareja');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	20,	2,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	21,	20,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	7,	40,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	5,	18,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	14,	24,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	4,	48,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	22,	52,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	9,	14,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	10,	50,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	23,	2,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	11,	2,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	12,	4,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	13,	2,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	28,	500,'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	10,	24,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	16,	28,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	17,	28,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	12,	8,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	18,	2,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	29,	2,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	30,	2,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	31,	2,	'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	32,	946,'Hamburgesa Combo Pareja'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	12	,	33,	46,	'Hamburgesa Combo Pareja'	);

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	24,	6,	'Combo nuggets');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	10,	13,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	16,	10,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	25,	10,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	21,	10,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	28,	250,'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	10,	12,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	16,	14,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	17,	14,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	12,	4,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	18,	1,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	29,	1,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	30,	1,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	31,	1,	'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	32,	473,'Combo nuggets'	);
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	13	,	33,	23,	'Combo nuggets'	);

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	14	,	26,	1,	'Combo molletes');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	14	,	5,	20,	'Combo molletes');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	14	,	4,	30,	'Combo molletes');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	14	,	6,	10,	'Combo molletes');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	14	,	23,	4,	'Combo molletes');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	14	,	12,	2,	'Combo molletes');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	14	,	13,	1,	'Combo molletes');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	14	,	27,	70,	'Combo molletes');

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	15,	6,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	10,	12,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	16,	14,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	17,	14,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	12,	4,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	18,	1,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	28,	250,'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	10,	12,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	16,	14,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	17,	14,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	12,	4,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	18,	1,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	29,	1,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	30,	1,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	31,	1,	'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	32,	473,'Combo alitas 6');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	15	,	33,	23,	'Combo alitas 6');

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	16	,	34,	1,	'Coca Cola 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	17	,	35,	1,	'Coca Light 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	18	,	36,	1,	'Coca Zero 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	19	,	37,	1,	'Manzana Lift 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	20	,	38,	1,	'Fanta 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	21	,	39,	1,	'Sprite 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	22	,	40,	1,	'Senzao 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	23	,	41,	1,	'Delaware Uva 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	24	,	42,	1,	'Fresca 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	25	,	43,	1,	'Naranja & Nada 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	26	,	44,	1,	'Limon & Nada 600 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	27	,	45,	1,	'Agua Ciel 1 Lt');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	28	,	46,	1,	'FRUTSI');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	29	,	47,	1,	'JUGO MINIBRICK');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	30	,	48,	1,	'CC ZERO 400 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	31	,	49,	1,	'DELAWAR 400 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	32	,	50,	1,	'FANTA NARANJA 400 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	33	,	51,	1,	'FANTA FRESA 400 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	34	,	52,	1,	'LIFT 400 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	35	,	53,	1,	'SIDRAL MAN BOT 400 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	36	,	54,	1,	'SPRITE 400 ml');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	37	,	55,	1,	'SPRITE ZERO 400 ml');
-- cafe 8oz 15 - 22

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	38	,	57,	1,	'Americano (Chico 8 onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	39	,	57,	1,	'Capuccino (Chico 8 onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	40	,	57,	1,	'Latte (Chico 8 onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	41	,	57,	1,	'Moka Canela (Chico 8 onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	42	,	57,	1,	'Chocolate Abuelita (Chico 8 onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	43	,	57,	1,	'Capuccino Vainilla (Chico 8 onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	44	,	57,	1,	'Latte Vainilla (Chico 8 onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	45	,	57,	1,	'Capuccino Moka (Chico 8 onz)');

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	46	,	58,	1,	'Americano (Grande 16  onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	47	,	58,	1,	'Capuccino (Grande 16  onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	48	,	58,	1,	'Latte (Grande 16  onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	49	,	58,	1,	'Moka Canela (Grande 16  onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	50	,	58,	1,	'Chocolate Abuelita (Grande 16 onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	51	,	58,	1,	'Capuccino Vainilla (Grande 16 onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	52	,	58,	1,	'Latte Vainilla (Grande 16  onz)');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	53	,	57,	1,	'Capuccino Moka (Grande 16  onz)');

insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	54	,	59,	1,	'Dona de chocolate');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	55	,	59,	1,	'16 oz Cafe Americano + dona ');
insert into recetas(id_receta,id_ingrediente,cantidad_requerida,nombre_receta) values(	55	,	58,	1,	'16 oz Cafe Americano + dona ');





