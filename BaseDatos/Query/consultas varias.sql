
-- consultas de ganancias para el corte de caja
-- consulta matutina
select isnull(sum(a.precio), 0) as total from producto a inner join productosvendidos b on a.id_producto = b.id_producto inner join ventas c on c.id_venta = b.id_venta where c.fecha between '2017-01-06 12:00:00' and GETDATE()

-- consulta vespertina
select isnull(sum(a.precio), 0) as total from producto a inner join productosvendidos b on a.id_producto = b.id_producto inner join ventas c on c.id_venta = b.id_venta where c.fecha between '2017-01-06 12:00:00' and GETDATE()


-- consulta de dinero en efectivo
select isnull(sum(a.precio), 0) as total from producto a inner join productosvendidos b on a.id_producto = b.id_producto inner join ventas c on c.id_venta = b.id_venta inner join formaPago d on d.id_venta = c.id_venta inner join caja e on e.id_caja = c.id_caja where c.fecha between e.fechaInicio and GETDATE() and d.detalle = 'pago en efectivo';


-- consulta tarjeta
select isnull(sum(a.precio), 0) as total from producto a inner join productosvendidos b on a.id_producto = b.id_producto inner join ventas c on c.id_venta = b.id_venta inner join formaPago d on d.id_venta = c.id_venta inner join caja e on e.id_caja = c.id_caja where c.fecha between e.fechaInicio and GETDATE() and d.detalle <> 'pago en efectivo' and d.detalle <> null;


-- Cosultas para productos d inventario

select c.nombre, 
cast(DATEPART(dd,a.fechaMovimiento) as varchar(5)) + '/' +
cast(DATEPART(mm ,a.fechaMovimiento)  as varchar(5)) + '/' +
cast(DATEPART(yyyy,a.fechaMovimiento) as varchar(5)) as 'fecha de movimiento', b.descripcion as producto, 
b.unidad_medida as 'unidad de medida', a.inventario_inicial as 'inventario inicial', 
a.entradas, a.salidas, a.mermas, a.cortecias, a.inventario_final as 'inventario final'
from 
inventario a inner join ingredientes b on a.id_ingrediente = b.id_ingrediente
inner join tienda c on c.id_tienda = a.id_tienda


where
c.id_tienda = 0

and a.fechaMovimiento between '2017-02-14 00:00:00' and '2017-02-15 00:00:00';



  
   IF (select top 1 cast(datepart(dd, getdate())as int) - cast(datepart(dd, fechaMovimiento)as int) from inventario order by fechaMovimiento desc) >= 7 
   BEGIN
		insert into inventario(id_ingrediente, inventario_inicial, minimo, maximo, id_tienda)
		select id_ingrediente+1, inventario_final, minimo, maximo, id_tienda from inventario
   END;


