if OBJECT_ID('ventas') is not null
drop table ventas;

create table ventas(

	id_venta varchar(25) primary key, 
	total money,
	codigo_empleado int,
	id_tienda int,
	fecha datetime default getdate(),	
	id_caja varchar(30),
	no_ticket int identity--,
	--foreign key (codigo_empleado) references usuario(codigo_empleado)
	--on delete cascade
	--on update cascade,
	--foreign key (id_caja) references caja(id_caja)

);

--delete ventas;


