if object_id('tienda') is not null
drop table tienda;
create table tienda(
id_tienda int primary key,
nombre varchar(30)
);

insert into tienda(id_tienda, nombre) values(1, 'ZARAGOZA');
insert into tienda(id_tienda, nombre) values(2, 'ROSARIO');
insert into tienda(id_tienda, nombre) values(3, 'PANTITLAN');
insert into tienda(id_tienda, nombre) values(4, 'JUANACATLAN');
insert into tienda(id_tienda, nombre) values(5, 'SAN COSME');
