using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de BaseDatos
/// </summary>
public class BaseDatos
{
    private SqlConnection cnn;
    
    public BaseDatos()
    {
        try
        {
            string seguridad =  "User Id= winnies ;Password= PuntoDeVenta";

            string servidor = "winnies.cfxhssdnndw7.us-east-1.rds.amazonaws.com,1433";

            string sCon = @"Data Source=" + servidor + "; Initial Catalog= POS;" + seguridad;
            this.cnn = new SqlConnection(sCon);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
           
        }
    }
   
    public DataTable consultarInverntaio(string idTienda, string fechaInicio = "", string fechaFinal = "")
    {
        string query =
            "select c.nombre, " +
            "cast(DATEPART(dd, a.fechaMovimiento) as varchar(5)) + '/' + " +
            "cast(DATEPART(mm, a.fechaMovimiento) as varchar(5)) + '/' + " +
            "cast(DATEPART(yyyy, a.fechaMovimiento) as varchar(5)) as 'fecha de movimiento', b.descripcion as producto, " +
            "b.unidad_medida as 'unidad de medida', a.inventario_inicial as 'inventario inicial', " +
            "a.entradas, a.salidas, a.mermas, a.cortecias, a.inventario_final as 'inventario final' " +
            "from inventario a inner " +
            "join ingredientes b on a.id_ingrediente = b.id_ingrediente " +
            "inner join tienda c on c.id_tienda = a.id_tienda " +
            (idTienda.Equals("0") ? "" : "where c.id_tienda = " + idTienda) +
            (fechaInicio.Equals("") || fechaFinal.Equals("")  ? "" : "and a.fechaMovimiento between '"+ fechaInicio + "' and '"+ fechaFinal + "'; ");
             
            
           
        try
        {
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            using (DataSet ds = new DataSet())
            {
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return new DataTable();
        }
        finally
        {
            cnn.Close();
        }
    }

    public DataTable consultarPersonal(int index)
    {
        try
        {
            string query;
            if(index == 0)
            {
               query = "select a.codigo_empleado codigo, a.nombre, a.apellido, a.contrasena, b.nombre tienda, a.activo from usuario a inner join tienda b on a.codigo_tienda = id_tienda order by tienda";
            }
            else
            {
                query = "select a.codigo_empleado codigo, a.nombre, a.apellido, a.contrasena, b.nombre tienda, a.activo from usuario a inner join tienda b on a.codigo_tienda = id_tienda where a.codigo_tienda = " + index.ToString() + " order by tienda";
            }
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            using (DataSet ds = new DataSet())
            {
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return new DataTable();
        }
        finally
        {
            cnn.Close();
        }
    }

    public String agregarPersonal(int codemp, int codtienda, string contrasena, string nombre, string apellido, bool activo)
    {
        string query = "INSERT INTO dbo.usuario (codigo_empleado,codigo_tienda,contrasena,nombre,apellido,activo) VALUES ('" + codemp + "','" + codtienda + "','" + contrasena + "','" + nombre + "','" + apellido + "','" + activo + "')";
        try
        {
            cnn.Open();
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            return "se agrego correctamente al nuevo usuario";
        }
        catch(Exception ex)
        {
            return "hubo un error al agregar al usuario: " + ex.ToString();
        }
        finally
        {
            cnn.Close();
        }
    }

    public String editarPersonal(int codemp, int codtienda, string contrasena, string nombre, string apellido, int activo)
    {
        string query = "UPDATE dbo.usuario set codigo_tienda = "+ codtienda +", contrasena= '"+ contrasena +"', nombre= '"+ nombre +"', apellido = '"+ apellido +"', activo = "+ activo +" where codigo_empleado = " + codemp;
        try
        {
            cnn.Open();
            SqlCommand command = new SqlCommand(query, cnn);
            SqlDataReader reader = command.ExecuteReader();
            return "se cambiaron correctamente los datos";
        }
        catch (Exception ex)
        {
            return "hubo un error al modificar al usuario: " + ex.ToString();
        }
        finally
        {
            cnn.Close();
        }
    }

    public DataTable consultarTiendas()
    {
        string query = "select 0 as id_tienda, 'TODAS LAS SUCURSALES' as nombre " +
                        "UNION " +
                        "select * from tienda;";
        
        try
        {
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            using (DataSet ds = new DataSet())
            {
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return new DataTable();
        }
        finally
        {
            cnn.Close();
        }
    }

    public DataTable generarReporte(int indexrep, int indexsuc, string fecha1, string fecha2)
    {
        try
        {
            int sw;
            string query;
            if (indexrep == 0)
            {
                sw = 0;
                if (indexsuc == 0)
                {
                    if ((fecha1 != "") && (fecha2 != ""))
                        sw = 1;
                }
                else if (indexsuc != 0)
                    if ((fecha1 != "") && (fecha2 != ""))
                        sw = 2;
                    else
                        sw=0;
            }
            else if (indexrep == 1)
            {
                sw = 3;
                if (indexsuc == 0)
                {
                    if ((fecha1 != "") && (fecha2 != ""))
                        sw = 5;
                }
                else if (indexsuc != 0)
                {
                    sw = 4;
                    if ((fecha1 != "") && (fecha2 != ""))
                        sw = 6;
                }
            }
            else if (indexrep == 2)
            {
                sw = 7;
                if ((fecha1 != "") && (fecha2 != ""))
                    sw = 8;
            }
            else
            {
                sw = 4;
            }

            switch (sw)
            {
                case 0:
                    query = "select  a.nombre, count(a.id_producto) 'prductos vendidos hasta la fecha' from producto a inner join productosvendidos b on a.id_producto = b.id_producto group by a.nombre order by count(a.id_producto)desc";
                    break;
                case 1:
                    query = "select  a.nombre, count(a.id_producto) 'prductos vendidos hasta la fecha' from producto a inner join productosvendidos b on a.id_producto = b.id_producto inner join ventas c on b.id_venta = c.id_venta where cast(replace(convert(char(10), c.fecha, 103), '/', '-') as varchar(20)) between '" + fecha1 + "' and '" + fecha2 + "' group by a.nombre order by count(a.id_producto)desc";
                    break;
                case 2:
                    query = "select  a.nombre, count(a.id_producto) 'prductos vendidos hasta la fecha' from producto a inner join productosvendidos b on a.id_producto = b.id_producto inner join ventas c on b.id_venta = c.id_venta where cast(replace(convert(char(10), c.fecha, 103), '/', '-') as varchar(20)) between '" + fecha1 + "' and '" + fecha2 + "' and c.id_tienda =" + indexsuc + " group by a.nombre order by count(a.id_producto)desc";
                    break;
                case 3:
                    query = "SELECT * FROM (select a.nombre sucursal, cast(replace(convert(char(10), c.fecha, 103), '/', '-')as varchar(20)) fecha, '$' + cast(cast (sum(c.total) as  decimal(16,2)) as varchar(30))total from tienda a inner join caja b on a.id_tienda = b.id_tienda inner join ventas c on c.id_caja = b.id_caja group by a.nombre, cast(replace(convert(char(10), c.fecha, 103), '/', '-')as varchar(20)))aqui PIVOT (max(total) for sucursal in ([ZARAGOZA],[ROSARIO],[PANTITLAN],[JUANACATLAN],[SAN COSME])) tambien ORDER BY CONVERT(VARCHAR(10), CONVERT(date, fecha, 105), 23) desc";
                    break;
                case 4:
                    query = "select c.nombre sucursal,  cast(replace(convert(char(10), b.fecha, 103), '/', '-')as varchar(20)) fecha, sum(a.monto) total, a.metodoPago concepto from formaPago a inner join ventas b on a.id_venta = b.id_venta inner join tienda c on c.id_tienda = b.id_tienda where numero_tarjeta is null and c.id_tienda = " + indexsuc + " group by cast(replace(convert(char(10), b.fecha, 103), '/', '-')as varchar(20)) , a.metodoPago, c.nombre union select c.nombre sucursal, cast(replace(convert(char(10), b.fecha, 103), '/', '-')as varchar(20)) fecha, sum(a.monto) total, a.metodoPago concepto from formaPago a inner join ventas b on a.id_venta = b.id_venta inner join tienda c on c.id_tienda = b.id_tienda where numero_tarjeta is not null and c.id_tienda = " + indexsuc + " group by cast(replace(convert(char(10), b.fecha, 103), '/', '-')as varchar(20)), a.metodoPago, c.nombre union select c.nombre sucursal, cast(replace(convert(char(10), b.fecha, 103), '/', '-')as varchar(20)) fecha, sum(a.monto) total, 'total' concepto from formaPago a inner join ventas b on a.id_venta = b.id_venta inner join tienda c on c.id_tienda = b.id_tienda where c.id_tienda = " + indexsuc + " group by cast(replace(convert(char(10), b.fecha, 103), '/', '-')as varchar(20)) , c.nombre ";
                    break;
                case 5:
                    query = "select c.nombre sucursal,  cast(replace(convert(char(10), b.fecha, 103), '/', '-')as varchar(20)) fecha, sum(a.monto) total, a.metodoPago concepto from formaPago a inner join ventas b on a.id_venta = b.id_venta inner join tienda c on c.id_tienda = b.id_tienda where numero_tarjeta is null and cast(replace(convert(char(10), b.fecha, 103), '/', '-')as varchar(20)) between '" + fecha1 + "' and '" + fecha2 + "'" +
                                      " group by cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)), a.metodoPago, c.nombre union" +
                                      " select c.nombre sucursal, cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)) fecha, sum(a.monto) total, a.metodoPago concepto from formaPago a inner join ventas b on a.id_venta = b.id_venta inner join tienda c on c.id_tienda = b.id_tienda where numero_tarjeta is not null and cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)) between '" + fecha1 + "' and '" + fecha2 + "'" +
                                      " group by cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)), a.metodoPago, c.nombre union" +
                                      " select c.nombre sucursal, cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)) fecha, sum(a.monto) total, 'total' concepto from formaPago a inner join ventas b on a.id_venta = b.id_venta inner join tienda c on c.id_tienda = b.id_tienda where cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)) between '" + fecha1 + "' and '" + fecha2 + "'" +
                                      " group by cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)), c.nombre";
                    break;
                case 6:
                    query = "select c.nombre sucursal,  cast(replace(convert(char(10), b.fecha, 103), '/', '-')as varchar(20)) fecha, sum(a.monto) total, a.metodoPago concepto from formaPago a inner join ventas b on a.id_venta = b.id_venta inner join tienda c on c.id_tienda = b.id_tienda where numero_tarjeta is null and cast(replace(convert(char(10), b.fecha, 103), '/', '-')as varchar(20)) between '" + fecha1 + "' and '" + fecha2 + "' and c.id_tienda = " + indexsuc +
                                      " group by cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)), a.metodoPago, c.nombre union" +
                                      " select c.nombre sucursal, cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)) fecha, sum(a.monto) total, a.metodoPago concepto from formaPago a inner join ventas b on a.id_venta = b.id_venta inner join tienda c on c.id_tienda = b.id_tienda where numero_tarjeta is not null and cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)) between '" + fecha1 + "' and '" + fecha2 + "' and c.id_tienda = " + indexsuc +
                                      " group by cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)), a.metodoPago, c.nombre union" +
                                      " select c.nombre sucursal, cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)) fecha, sum(a.monto) total, 'total' concepto from formaPago a inner join ventas b on a.id_venta = b.id_venta inner join tienda c on c.id_tienda = b.id_tienda where cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)) between '" + fecha1 + "' and '" + fecha2 + "' and c.id_tienda = " + indexsuc +
                                      " group by cast(replace(convert(char(10), b.fecha, 103), '/', '-') as varchar(20)), c.nombre ";
                    break;
                case 7:
                    query = "SELECT  '$' + cast(cast (sum(total) as  decimal(16,2)) as varchar(30))total, cast(DATEPART(HOUR, fecha) as varchar(2))+ ' hrs' hora FROM [POS].[dbo].[ventas] " + (indexsuc == 0 ? "" : " where id_tienda = " + indexsuc) + " group by DATEPART(HOUR, fecha)order by hora desc";
                    break;
                case 8:
                    query = "SELECT  '$' + cast(cast (sum(total) as  decimal(16,2)) as varchar(30))total, cast(DATEPART(HOUR, fecha) as varchar(2))+ ' hrs' hora FROM [POS].[dbo].[ventas]where fecha between '" + fecha1 + "' and '" + fecha2 + "'and id_tienda = " + indexsuc + " group by DATEPART(HOUR, fecha)order by hora desc";
                    break;
                default:
                    query = "";
                    break;
            }

            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            using (DataSet ds = new DataSet())
            {
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return new DataTable();
        }
        finally
        {
            cnn.Close();
        }
    }

    public List<datos> obtenerPermisos(int codemp)
    {
        string query = "select id_privilegio from dbo.privilegiosasignados where codigo_empleado = " + codemp;
        try
        {
            cnn.Open();
            List<datos> lista = new List<datos>();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new datos()
                {
                    permiso = Convert.ToInt32(reader["id_privilegio"]),
                    idsql = Convert.ToInt32(reader["id_privilegioasignado"])
                });
            }
            return lista;
        }
        catch (Exception ex)
        {
             List<datos> lista = new List<datos>();
            return lista;
        }
        finally
        {
            cnn.Close();
        }
    }

    public void agregarPermisos(int idprivilegio, int usuario)
    {
        string query = "INSERT INTO privilegiosasignados values (" + idprivilegio + "," + usuario + ")";
        try
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader reader = cmd.ExecuteReader();

        }
        catch (Exception ex)
        {
            
        }
        finally
        {
            cnn.Close();
        }
    }
}

public class datos
{
    public int permiso { get; set; }
    public int idsql { get; set; }

}