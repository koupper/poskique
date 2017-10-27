if OBJECT_ID('usuario') is not null
drop table usuario;

create table usuario(
codigo_empleado int,
codigo_tienda int,
contrasena char(12) not null,
nombre varchar(30),
apellido varchar(30),
primary key(codigo_empleado)
);



insert into usuario(codigo_empleado, codigo_tienda, contrasena, nombre, apellido ) 
values(100, 1, 'Sergioivan15', 'Sergio', 'Lopez');
insert into usuario(codigo_empleado, codigo_tienda, contrasena, nombre, apellido ) 
values(101, 1, 'Contraseña15', 'Ariel', 'Zamorano');