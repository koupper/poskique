if OBJECT_ID('cancelaciones') is not null
drop table cancelaciones;

create table cancelaciones(
	id_cancelacion int  primary key, --identity, 
	codigo_empleado int,
	id_tienda int,
	id_venta varchar(25),
	fecha datetime default getdate()--,	
	--foreign key (codigo_empleado) references usuario(codigo_empleado)
	--on delete cascade
--	on update cascade,
--	foreign key (id_venta) references ventas(id_venta)
	
);

