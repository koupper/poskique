if object_id('dinero') is not null
drop table dinero;

create table dinero(
	id_dinero varchar(30) primary key,
	cantidad_billetes20 int,
	cantidad_billetes50 int,
	cantidad_billetes100 int,
	cantidad_billetes200 int,
	cantidad_billetes500 int,
	cantidad_monedas50centavos int,
	cantidad_monedas1 int,
	cantidad_monedas2 int,
	cantidad_monedas5 int,
	cantidad_monedas10 int,
	total money);
	
	/*insert into dinero(id_dinero, cantidad_billetes20, cantidad_billetes50, cantidad_billetes100, cantidad_billetes200, cantidad_billetes500, cantidad_monedas50centavos, cantidad_monedas1, cantidad_monedas2, cantidad_monedas5, cantidad_monedas10, total)
	values(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.0)*/
	--efectivoAlCierre,
	--fechaInicio,
	--fechaCierre)
	
/*	update dinero set cantidad_billetes20 = ,
	cantidad_billetes50 = ,
	cantidad_billetes100 = ,
	cantidad_billetes200 = ,
	cantidad_billetes500 = ,
	cantidad_monedas50centavos = ,
	cantidad_monedas1 = ,
	cantidad_monedas2 = ,
	cantidad_monedas5 = ,
	cantidad_monedas10 = , 
	total = ,
	where id_dinero = 
	*/


	
	-- revisar si la caja esta abierta
	-- select id
	