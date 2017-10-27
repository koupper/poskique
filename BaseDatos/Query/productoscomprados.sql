if OBJECT_ID('productosvendidos') is not null
drop table productosvendidos;

create table productosvendidos(
	id_productos_vendidos int identity,
	id_producto int,
	id_venta varchar(25),
	costo_venta money
	primary key(id_producto, id_venta, id_productos_vendidos)
	--foreign key (id_producto) references producto(id_producto)
	--on update cascade
	--on delete cascade,
	--foreign key (id_venta) references ventas(id_venta)
	--on update cascade
	--on delete cascade
	
);

