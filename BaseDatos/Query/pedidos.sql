if OBJECT_ID('pedidos') is not null
drop table pedidos;

create table pedidos(

	id_pedido int identity primary key,
	id_ingrediente int,
	cantidad int,
	id_tienda int,
	id_empleado int,
	fecha datetime default GETDATE(),
	atendido bit 
);


update caja set id_tienda = 0;