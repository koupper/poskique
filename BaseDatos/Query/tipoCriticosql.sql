if OBJECT_ID('tipo_criticos') is not null
drop table tipo_criticos;


	create table tipo_criticos(
id_tipo_critico int, 
descripcion varchar(30)
);
insert into tipo_criticos(id_tipo_critico,descripcion) values(1,'perecederos');
insert into tipo_criticos(id_tipo_critico,descripcion) values(2,'desechables');
insert into tipo_criticos(id_tipo_critico,descripcion) values(3,'bebidas embotelladas');