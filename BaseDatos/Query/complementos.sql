if OBJECT_ID('complementos') is not null
drop table complementos;
create table complementos(
id_complemento int,
descripcion varchar(30),
id_producto int,
numero_personas int,
primary key(id_complemento));

--HOTDOG COMBO INDIVIDUAL	
insert into complementos(id_complemento, descripcion, id_producto, numero_personas )
values(1, 'REFRESCO $10', 1, 1);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(2, 'REFIL $5', 1, 1);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(3, 'SIN COMPLEMENTO', 1, 1);

--HOTDOG COMBO PAREJA	
insert into complementos(id_complemento, descripcion, id_producto, numero_personas )
values(4, 'REFRESCO COMBO 1 $10', 2, 2);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(5, 'REFIL COMBO 1 $5', 2, 2);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(6, 'SIN COMPLEMENTO COMBO 1', 2, 2);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas )
values(7, 'REFRESCO COMBO 2 $10', 2, 2);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(8, 'REFIL COMBO 2 $5', 2, 2);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(9, 'SIN COMPLEMENTO COMBO 2', 2, 2);

-- BURGUER COMBO INDIVIDUAL
insert into complementos(id_complemento, descripcion, id_producto, numero_personas )
values(10, 'REFRESCO $10', 3, 1);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(11, 'REFIL $5', 3, 1);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(12, 'SIN COMPLEMENTO', 3, 1);

-- BURGER COMBO PAREJA	
insert into complementos(id_complemento, descripcion, id_producto, numero_personas )
values(13, 'REFRESCO COMBO 1 $10', 4, 2);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(14, 'REFIL COMBO 1 $5', 4, 2);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(15, 'SIN COMPLEMENTO COMBO 1', 4, 2);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas )
values(16, 'REFRESCO COMBO 2 $10', 4, 2);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(17, 'REFIL COMBO 2 $5', 4, 2);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(18, 'SIN COMPLEMENTO COMBO 2', 4, 2);

-- COMBO ALITAS 4 PZS

insert into complementos(id_complemento, descripcion, id_producto, numero_personas )
values(19, 'REFRESCO $10', 5, 1);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(20, 'REFIL $5', 5, 1);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(21, 'SIN COMPLEMENTO', 5, 1);

-- COMBO NUGGETS

insert into complementos(id_complemento, descripcion, id_producto, numero_personas )
values(22, 'REFRESCO $10', 6, 1);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(23, 'REFIL $5', 6, 1);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(24, 'SIN COMPLEMENTO', 6, 1);

-- COMBO MOLLETES

insert into complementos(id_complemento, descripcion, id_producto, numero_personas )
values(25, 'CAFE CAPUCHINO $10', 7, 1);
insert into complementos(id_complemento, descripcion, id_producto, numero_personas)
values(26, 'SIN COMPLEMENTO', 7, 1);

select a.id_complemento, a.descripcion, a.id_producto, a.numero_personas from complementos a inner join producto b on a.id_producto = b.id_producto inner join familia c on c.id_familia = b.id_familia where a.id_producto = 1 and c.id_familia = 1;