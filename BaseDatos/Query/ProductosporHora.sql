if OBJECT_ID('productosporhora') is not null
drop table productosporhora;

create table productosporhora(
	id_producto_vendido int ,
	cantidad int,
	hora int,
	
	);