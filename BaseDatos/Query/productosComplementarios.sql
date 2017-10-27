if OBJECT_ID('productosComplementarios') is not null
drop table productosComplementarios;
create table productosComplementarios(
id_producto_complementario int, -- este
costo_especial money,
texto_complementario varchar(30),
id_complemento int,
primary key(id_complemento, id_producto_complementario)
);

-- HOTDOG COMBO INDIVIDUAL
-- REFRESCO
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (1, 31, 10, 'Cambio de bebida ');
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (1, 32, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (1, 33, 10,'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (1, 34, 10, 'Cambio de bebida ' )
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (1, 35, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (1, 36, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (1, 37, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (1, 38, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (1, 39, 10, 'Cambio de bebida ')
-- REFIL
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (2, 53, 5, 'refill de')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (2, 55, 5, 'refill de' )


-- HOTDOG COMBO PAREJA 
-- REFRESCO 1
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (4, 31, 10, 'Cambio de bebida 1');
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (4, 32, 10, 'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (4, 33, 10,'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (4, 34, 10, 'Cambio de bebida 1' )
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (4, 35, 10, 'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (4, 36, 10, 'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (4, 37, 10, 'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (4, 38, 10, 'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (4, 39, 10, 'Cambio de bebida 1')
-- REFIL 1
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (5, 53, 5, 'refill 1 de')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (5, 55, 5, 'refill 1 de' )
-- REFRESCO 2
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (7, 31, 10, 'Cambio de bebida 2');
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (7, 32, 10, 'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (7, 33, 10,'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (7, 34, 10, 'Cambio de bebida 2' )
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (7, 35, 10, 'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (7, 36, 10, 'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (7, 37, 10, 'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (7, 38, 10, 'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (7, 39, 10, 'Cambio de bebida 2')

-- REFIL 2
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (8, 53, 5, 'refill 2 de')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (8, 55, 5, 'refill 2 de' )

-- BURGUER COMBO INDIVIDUAL
-- REFRESCO
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (10, 31, 10, 'Cambio de bebida ');
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (10, 32, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (10, 33, 10,'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (10, 34, 10, 'Cambio de bebida ' )
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (10, 35, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (10, 36, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (10, 37, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (10, 38, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (10, 39, 10, 'Cambio de bebida ')
-- REFIL
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (11, 53, 5, 'refill de')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (11, 55, 5, 'refill de' )
-- BURGER COMBO PAREJA	
-- REFRESCO 1
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (13, 31, 10, 'Cambio de bebida 1');
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (13, 32, 10, 'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (13, 33, 10,'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (13, 34, 10, 'Cambio de bebida 1' )
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (13, 35, 10, 'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (13, 36, 10, 'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (13, 37, 10, 'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (13, 38, 10, 'Cambio de bebida 1')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (13, 39, 10, 'Cambio de bebida 1')
-- REFIL 1
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (14, 53, 5, 'refill 1 de')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (14, 55, 5, 'refill 1 de' )
-- REFRESCO 2
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (16, 31, 10, 'Cambio de bebida 2');
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (16, 32, 10, 'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (16, 33, 10,'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (16, 34, 10, 'Cambio de bebida 2' )
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (16, 35, 10, 'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (16, 36, 10, 'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (16, 37, 10, 'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (16, 38, 10, 'Cambio de bebida 2')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (16, 39, 10, 'Cambio de bebida 2')

-- REFIL 2
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (17, 53, 5, 'refill 2 de')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (17, 55, 5, 'refill 2 de' )
-- COMBO ALITAS 4 PZS
-- REFRESCO
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (19, 31, 10, 'Cambio de bebida ');
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (19, 32, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (19, 33, 10,'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (19, 34, 10, 'Cambio de bebida ' )
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (19, 35, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (19, 36, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (19, 37, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (19, 38, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (19, 39, 10, 'Cambio de bebida ')
-- REFIL
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (20, 53, 5, 'refill de')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (20, 55, 5, 'refill de' )
-- COMBO NUGGETS
-- REFRESCO
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (22, 31, 10, 'Cambio de bebida ');
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (22, 32, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (22, 33, 10,'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (22, 34, 10, 'Cambio de bebida ' )
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (22, 35, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (22, 36, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (22, 37, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (22, 38, 10, 'Cambio de bebida ')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (22, 39, 10, 'Cambio de bebida ')
-- REFIL
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (23, 53, 5, 'refill de')
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (23, 55, 5, 'refill de' )

-- COMBO MOLLETES
-- REFRESCO
insert into productosComplementarios(id_complemento, id_producto_complementario, costo_especial, texto_complementario) 
values (25, 16, 10, 'Cambio de bebida ');


select b.id_producto, cast(b.id_producto as varchar(30))+':'+a.texto_complementario + b.nombre nombre, a.costo_especial, b.id_familia, b.id_receta  from productosComplementarios a inner join producto b on a.id_producto_complementario = b.id_producto where a.id_complemento = 2 ;