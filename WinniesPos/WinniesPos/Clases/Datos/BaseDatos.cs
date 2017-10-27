using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using WindowsFormsApplication1.Clases.Modelos;
using System.Configuration;
using System.IO;

namespace WindowsFormsApplication1.Clases
{
    public class BaseDatos
    {
        private SqlConnection cnn;
        private string path;
        public BaseDatos(string servidor = @".\SQLEXPRESS", string baseDatos = "POS", string seguridad = "Integrated Security = true")
        {
            try
            {
                path = @"C:/poslog/log.txt";
               // seguridad =  "User Id= winnies ;Password= PuntoDeVenta";

               // servidor = "winnies.cfxhssdnndw7.us-east-1.rds.amazonaws.com,1433";


                // servidor = @"PVT-PC\POS"; // sancosme
                // servidor = @"SERGIOIVANL8109\SERGIO";
                // string sCon = @"ZARAGOZA\SQLEXPRESS";
                // string sCon = @"Data Source=ZARAGOZA\SQLEXPRESS; Initial Catalog=POS; Integrated Security = true";
                // string sCon = @"Data Source=ELT\SQLEXPRESS; Initial Catalog=POS; Integrated Security = true";
                 // servidor = @"HP8200-PC\SQLEXPRESS"; // sancosme
                //
                string sCon = @"Data Source=" + servidor + "; Initial Catalog=" + baseDatos + ";" + seguridad;
                this.cnn = new SqlConnection(sCon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.constructor" + ex.Message );
                }
            }
        }

       
        #region operaciones generales
        public void eliminar(string query)
            {
                try
                {
                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand(query,cnn);
                    cmd.ExecuteNonQuery();
                    this.cnn.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    using (StreamWriter file = File.AppendText(path))
                    {
                        file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.eliminar" + ex.Message + " :" + query);
                    }
                }
            }

            public void ejecutarComando(string query)
            {
                try
                {
                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();
                    
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    using (StreamWriter file = File.AppendText(path))
                    {
                        file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.ejecutarComando" + ex.Message + " :" + query);
                    }
                }
                finally
                {
                    this.cnn.Close();
                }
            }

            public DataTable consultar(string query)
            {
                try
                {
                    using (DataTable dt = new DataTable())
                    {

                        this.cnn.Open();
                        SqlCommand cmd = new SqlCommand(query, cnn);
                        using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        

                        return dt;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    using (StreamWriter file = File.AppendText(path))
                    {
                        file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultar" + ex.Message + " :" + query);
                    }
                    return null;
                }
                finally
                {
                    this.cnn.Close();
                }
            }

        #endregion

        #region consultas especiales
        public bool primerQ()
        {
            bool listo = false;
            try
            {
                this.cnn.Open();
                string query = "IF (select top 1 cast(datepart(dd, getdate())as int) - cast(datepart(dd, fechaMovimiento)as int) from inventario order by fechaMovimiento desc) >= 7 BEGIN insert into inventario(id_ingrediente, inventario_inicial, minimo, maximo, id_tienda) select id_ingrediente + 1, inventario_final, minimo, maximo, id_tienda from inventario END; ";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                listo = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.primeraQuery" + ex.Message);
                }
            }
            finally
            {
                this.cnn.Close();
            }
            return listo;

        }

        public Caja abrirCajaMaestra()
        {
            Caja cajaMaestra = null;
            try
            {
                this.cnn.Open();
                string query = 
                                "IF(select COUNT(*) from corteCaja where estatus = 1) = 0 " +
                                "begin "+
	                            "insert into corteCaja(estatus) " +
	                            "values(1); "+
	
                                "end "+

                                "select * from corteCaja where estatus = 1; ";

                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   cajaMaestra =  new Caja()
                    {
                        idCaja = dr["id_corte_caja"].ToString(),
                        estatus = bool.Parse(dr["estatus"].ToString())
                    };
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.primeraQuery" + ex.Message);
                }
            }
            finally
            {
                this.cnn.Close();
            }
            return cajaMaestra;

        } 

            public Usuario consultarUsuario(int codigo)
            {
                Usuario usuario = null;
                try
                {
                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand("select * from usuario where codigo_empleado = " + codigo, cnn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        usuario = new Usuario {
                            codigoEmpleado = Convert.ToInt32(dr["codigo_empleado"]),
                            lPermisos = new List<Privilegio>()
                        };

                    }
                    
                    this.cnn.Close();
                    usuario.lPermisos = consultarPrivilegios(usuario.codigoEmpleado);
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    using (StreamWriter file = File.AppendText(path))
                    {
                        file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarUsuario" + ex.Message);
                    }
                    
                }
                return usuario;
            }
        
        public bool mandarPedido(int idIngrediente, int cantidad, int idTienda,int idTrabajdor)
        {
            bool solicitud = false;
            try
            {
                this.cnn.Open();
                string query = "insert into pedidos  (id_ingrediente,cantidad,id_tienda,id_empleado,atendido) values ("+idIngrediente + "," + cantidad + "," + idTienda + ","+ idTrabajdor + ",'false');";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                solicitud = true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.actualizarInventario" + ex.Message);
                }
            }
            finally
            {
                this.cnn.Close();

            }
            return solicitud;
        }
        public bool actualizarInventario(int invIni, int mermas, int entradas, int salidas, int idInventario)
        {
            bool actualizacionExitosa = false;
            try
            {
                this.cnn.Open();
                int final = invIni + entradas - salidas - mermas;
                string query = "update inventario set entradas = '" + entradas + "', mermas ='" + mermas + "', inventario_final = '" + final + "' where id_inventario = " + idInventario + ";";

                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                actualizacionExitosa = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.actualizarInventario" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return actualizacionExitosa;
        }
        public bool VentaInventario(int salidas,int invFinal,int idInventario)
        {
            bool actualizacionExitosa = false;
            try
            {
                this.cnn.Open();
                string query = "update inventario set salidas = '" + salidas + " ', inventario_final ='" + invFinal + "' where id_inventario = " + idInventario + ";";

                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                actualizacionExitosa = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.actualizarInventario" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return actualizacionExitosa;
        }
        public IList<TipoCritico> consultarTiposCriticos()
        {
            IList<TipoCritico> listado = new List<TipoCritico>();
            try
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    this.cnn.Close();
                this.cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from tipo_criticos;", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listado.Add(
                        new TipoCritico
                        {
                            idTipoCritico = Convert.ToInt32(dr["id_tipo_critico"].ToString()),
                            descripcion = dr["descripcion"].ToString()   

                        });

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultartipocritico" + ex.Message);
                }
            }
            finally
            {
                this.cnn.Close();
            }

            return listado;
        }
        public IList<Critico> consultarCriticos()
        {
            IList<Critico> listado = new List<Critico>();
            try
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    this.cnn.Close();
                this.cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from criticos;", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listado.Add(
                        new Critico
                        {
                            idCritico = Convert.ToInt32(dr["id_critico"].ToString()),
                            idProducto = Convert.ToInt32(dr["id_producto"].ToString()),
                            idTipoCritico = Convert.ToInt32(dr["id_tipo_critico"].ToString())

                        });

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarInventario" + ex.Message);
                }
            }
            finally
            {
                this.cnn.Close();
            }

            return listado;
        }

        public IList<Pedido> consultarPedidos()
        {
            IList<Pedido> listado = new List<Pedido>();
            try
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    this.cnn.Close();
                    this.cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from pedidos;", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listado.Add(
                        new Pedido()
                        {
                            idPedido = Convert.ToInt32(dr["id_pedido"].ToString()),
                            idIngrediente = Convert.ToInt32(dr["id_ingrediente"].ToString()),
                            cantidad = Convert.ToInt32(dr["cantidad"].ToString()),
                            idTienda = Convert.ToInt32(dr["id_tienda"].ToString()),
                            fecha = dr["fecha"].ToString(),
                            atendido = Convert.ToBoolean(dr["atendido"]),
                        }
                        );

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarInventario" + ex.Message);
                }
            }
            finally
            {
                this.cnn.Close();
            }
            return listado;
        }
        public IList<Receta> consultarReceta()
        {
            IList<Receta> listado = new List<Receta>();
            try
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    this.cnn.Close();
                this.cnn.Open();
                SqlCommand cmd = new SqlCommand("select * from recetas;", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    {
                    listado.Add(
                        new Receta() {
                            idReceta = Convert.ToInt32(dr["id_receta"].ToString()),
                            idIngrediente = Convert.ToInt32(dr["id_ingrediente"].ToString()),
                            cantidadRequerida = Convert.ToInt32(dr["cantidad_requerida"].ToString()),
                            nombreReceta = Convert.ToString(dr["nombre_receta"]),
                        });
                    }

                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarInventario" + ex.Message);
                }

                return null;

            }
            finally
            {
                this.cnn.Close();
            }
            return listado;
        }
        public IList<Ingredientes> consultarIngredientes()
        {
            IList<Ingredientes> listado = new List<Ingredientes>();
            try
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    this.cnn.Close();
                this.cnn.Open();

                SqlCommand cmd = new SqlCommand("select * from ingredientes;", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listado.Add(
                        new Ingredientes()
                        {
                            idIngrediente = Convert.ToInt32(dr["id_ingrediente"].ToString()),
                            descripcion = dr["descripcion"].ToString(),
                            unidadMedida = dr["unidad_medida"].ToString(),

                        });

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarIngredientes" + ex.Message);
                }

                return null;
            }
            finally
            {
                this.cnn.Close();
            }
            return listado;
        }
        public IList<InventarioIng> consultarInventario()
            {
            IList<InventarioIng> listado = new List<InventarioIng>();
            try
            {
                
                {
                    if (cnn != null && cnn.State == ConnectionState.Open)
                        this.cnn.Close();
                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand("select * from inventario; ", cnn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listado.Add(
                            new InventarioIng()
                            {
                                idInventario = Convert.ToInt32(dr["id_inventario"].ToString()),
                                idIngrediente = Convert.ToInt32(dr["id_ingrediente"].ToString()),
                                inventarioInicial = Convert.ToInt32(dr["inventario_inicial"].ToString()),
                                mermas = Convert.ToInt32(dr["mermas"].ToString()),
                                prestamo = Convert.ToInt32(dr["prestamo"].ToString()),
                                cortecias = Convert.ToInt32(dr["cortecias"].ToString()),
                                entradas = Convert.ToInt32(dr["entradas"].ToString()),
                                salidas = Convert.ToInt32(dr["salidas"].ToString()),
                                inventarioFinal = Convert.ToInt32(dr["inventario_final"].ToString()),
                                minimo = Convert.ToInt32(dr["minimo"].ToString()),
                                maximo = Convert.ToInt32(dr["maximo"].ToString()),
                                idTienda = Convert.ToInt32(dr["id_tienda"].ToString()),
                                fecha = dr["fechaMovimiento"].ToString(),    
                            });
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarInventario" + ex.Message);
                }

                return null;
            }
            finally
            {
                this.cnn.Close();
            }
            return listado;
        }
        public IList<InventarioIng> consultarInventario(DateTime date1,DateTime date2)
        {
            IList<InventarioIng> listado = new List<InventarioIng>();
            try
            {

                {
                    if (cnn != null && cnn.State == ConnectionState.Open)
                        this.cnn.Close();
                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand("select * from inventario where fechaMovimiento between '" + date1.ToString() +"' and '" + date2.ToString() +"';", cnn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listado.Add(
                            new InventarioIng()
                            {
                                idInventario = Convert.ToInt32(dr["id_inventario"].ToString()),
                                idIngrediente = Convert.ToInt32(dr["id_ingrediente"].ToString()),
                                inventarioInicial = Convert.ToInt32(dr["inventario_inicial"].ToString()),
                                mermas = Convert.ToInt32(dr["mermas"].ToString()),
                                prestamo = Convert.ToInt32(dr["prestamo"].ToString()),
                                cortecias = Convert.ToInt32(dr["cortecias"].ToString()),
                                entradas = Convert.ToInt32(dr["entradas"].ToString()),
                                salidas = Convert.ToInt32(dr["salidas"].ToString()),
                                inventarioFinal = Convert.ToInt32(dr["inventario_final"].ToString()),
                                minimo = Convert.ToInt32(dr["minimo"].ToString()),
                                maximo = Convert.ToInt32(dr["maximo"].ToString()),
                                idTienda = Convert.ToInt32(dr["id_tienda"].ToString()),
                                fecha = dr["fechaMovimiento"].ToString(),
                            });
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarInventario" + ex.Message);
                }

                return null;
            }
            finally
            {
                this.cnn.Close();
            }
            return listado;
        }
        //    try
        //    {
        //        using (DataTable dt = new DataTable())
        //        {
        //            if (cnn != null && cnn.State == ConnectionState.Open)
        //                this.cnn.Close();
        //            this.cnn.Open();
        //            SqlCommand cmd = new SqlCommand("select descripcion,  presentacion, inventario_inicial,mermas, prestamo, cortesias, entradas, Pz_vendidas, diferencias, inventario_final, id_inventario from inventario where id_inventario >= " + idTienda + ";", cnn);
        //            dt.Load(cmd.ExecuteReader());


        //            return dt;
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        using (StreamWriter file = File.AppendText(path))
        //        {
        //            file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarInventario" + ex.Message);
        //        }

        //        return null;
        //    }
        //    finally
        //    {
        //        this.cnn.Close();
        //    }
        //}


        private IList<Privilegio> consultarPrivilegios(int codigoEmpleado)
            {

                IList<Privilegio> lPrivilegios = new List<Privilegio>();

                try
                {

                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand("select a.id_privilegio, b.descripcion from privilegiosasignados a inner join privilegios b on a.id_privilegio=b.id_privilegio inner join usuario c on c.codigo_empleado=a.codigo_empleado where a.codigo_empleado = " + codigoEmpleado, cnn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Privilegio privilegio = new Privilegio
                        {
                            idPrivilegio = Convert.ToInt32(dr["id_privilegio"]),
                            descripcion = Convert.ToString(dr["descripcion"])
                        };

                        lPrivilegios.Add(privilegio);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    using (StreamWriter file = File.AppendText(path))
                    {
                        file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarPrivilegios" + ex.Message);
                    }
                    
                }
                finally
                {
                    this.cnn.Close();
                }
                return lPrivilegios;
            }

            public IList<Familia> consultarMenu()
            {
                IList<Familia> listado = new List<Familia>();

                try
                {

                    this.cnn.Open();

                    SqlCommand cmd = new SqlCommand("select * from familia;", cnn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listado.Add(
                            new Familia()
                            {
                                idFamilia = Convert.ToInt32(dr["id_familia"].ToString()),
                                nombre = dr["nombre"].ToString()
                            });
                    } 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    using (StreamWriter file = File.AppendText(path))
                    {
                        file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarMenu" + ex.Message);
                    }
                    
                }
                finally
                {
                    this.cnn.Close();
                }

                return listado;
            }

            public IList<Producto> consultarProducto(int idFamilia)
            {
                IList<Producto> listado = new List<Producto>();
                try
                {
                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand("select * from producto where id_familia = " + idFamilia + ";", cnn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listado.Add(
                            new Producto()
                            {
                                idProducto = Convert.ToInt32(dr["id_producto"].ToString()),
                                nombre = dr["nombre"].ToString(),
                                precio = Convert.ToDecimal(dr["precio"].ToString()),
                                idFamilia = int.Parse(dr["id_familia"].ToString()),
                                idReceta = Convert.ToInt32(dr["id_receta"].ToString()),
                                
                            });
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    using (StreamWriter file = File.AppendText(path))
                    {
                        file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarProducto" + ex.Message);
                    }
                    
                }
                finally
                {
                    this.cnn.Close();
                }
                return listado;
            }

            public IList<Producto> consultarProductoComplementario(int idComplemento)
            {
                IList<Producto> listado = new List<Producto>();
                try
                {
                    this.cnn.Open();
                    string query = "select b.id_producto, cast(b.id_producto as varchar(30))+':'+a.texto_complementario + b.nombre nombre, a.costo_especial, b.id_familia, b.id_receta  from productosComplementarios a inner join producto b on a.id_producto_complementario = b.id_producto where a.id_complemento = " + idComplemento + " ;";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listado.Add(
                            new Producto()
                            {
                                idProducto = Convert.ToInt32(dr["id_producto"].ToString()),
                                nombre = dr["nombre"].ToString(),
                                precio = Convert.ToDecimal(dr["costo_especial"].ToString()),
                                idFamilia = int.Parse(dr["id_familia"].ToString()),
                                idReceta = Convert.ToInt32(dr["id_receta"].ToString()),


                            });
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    using (StreamWriter file = File.AppendText(path))
                    {
                        file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarProducto" + ex.Message);
                    }

                }
                finally
                {
                    this.cnn.Close();
                }
                return listado;
            }


            public bool registrarVenta(Venta objVenta, IList<Producto> productos, IList<FormaPago> formasPago, string idCaja)
            {
                bool ventaExitosa = false;
                IList<Producto> listado = new List<Producto>();
                try
                {
                    this.cnn.Open();


                    string query = "insert into ventas (id_venta, total, codigo_empleado, id_tienda, id_caja) values('" + objVenta.idVenta + "', " + Convert.ToString(objVenta.total, CultureInfo.InvariantCulture) + ", " + objVenta.codigoEmpleado + ", " + objVenta.idTienda + ", '" + idCaja + "');";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();

                    query = "";
                    foreach (Producto producto in productos)
                    {
                        query += "insert into productosvendidos (id_producto, id_venta, costo_venta) values(" + producto.idProducto + ", '" + objVenta.idVenta + "', "+producto.precio+" ); \n";
                        /*foreach (Producto complemento in producto.lComplementos)
                        {
                            query += "insert into productosvendidos (id_producto, id_venta, costo_venta) values(" + complemento.idProducto + ", '" + objVenta.idVenta + "', " + complemento.precio + " ); \n";
                        }*/
                    }


                    cmd = new SqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();

                    foreach (FormaPago formaPago in formasPago)
                    {
                        if (formaPago.monto > 0)
                        {
                            string val = objVenta.idTienda.ToString();
                            string fechatar = "";
                            fechatar = DateTime.Now.ToString("yyyymmmddHHmmssffffff");
                            fechatar = val + fechatar;

                            string IFP = fechatar;
                            string numeroTarjeta = formaPago.numeroTarjeta == string.Empty ? "null" : "'" + formaPago.numeroTarjeta + "'";
                            query = "insert into formaPago(id_formaPago, id_venta, metodoPago, detalle, monto, numero_tarjeta) values('" + IFP + "','" + objVenta.idVenta + "','" + formaPago.metodoPago + "','" + formaPago.detalle + "'," + Convert.ToString(objVenta.total, CultureInfo.InvariantCulture) + ", " + numeroTarjeta + ");";

                            cmd = new SqlCommand(query, cnn);
                            cmd.ExecuteNonQuery();
                        }
                     }


                    ventaExitosa = true;

                    return ventaExitosa;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    using (StreamWriter file = File.AppendText(path))
                    {
                        file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.registrarVenta" + ex.Message);
                    }
                    
                    return false;
                }
                finally
                {
                    this.cnn.Close();
                }
            }
            
        #endregion


        #region actualizar datos locales

        public bool actualizarProductos(Producto prod)
        {
            bool actualizacionExitosa = false;
            
            try
            {
                this.cnn.Open();

                string precio = Convert.ToString(prod.precio,CultureInfo.InvariantCulture );
                string query = "update producto set "+
                                "nombre = '"+prod.nombre+"', " +
                                "precio = " + precio + ", " +
                                "id_familia = " + prod.idFamilia + " " +
                                "where id_producto =  "+prod.idProducto+";";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                actualizacionExitosa = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.actualizarProductos" + ex.Message);
                }
                    

            }
            finally
            {
                this.cnn.Close();

            }

            return actualizacionExitosa;
        }

        
        #endregion

        public IList<Venta> consultarVentas(string idSucursal)
        {
            IList<Venta> listado = new List<Venta>();
            try
            {
                this.cnn.Open();
                string query = "select * from ventas where id_tienda = " + idSucursal + ";";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listado.Add(
                        new Venta()
                        {
                            idVenta = dr["id_venta"].ToString().ToString(),
                            total = Convert.ToDecimal(dr["total"].ToString()),
                            codigoEmpleado = int.Parse(dr["codigo_empleado"].ToString()),
                            fechaVenta = DateTime.Parse(dr["fecha"].ToString())
                        });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarVentas" + ex.Message);
                }
                    
            }
            finally
            {
                this.cnn.Close();
            }

            return listado;
        }

        public IList<Producto> consultarProductosComprados(Venta venta)
        {
            IList<Producto> listado = new List<Producto>();
            try
            {
                this.cnn.Open();
                string query = "SELECT   b.* FROM productosvendidos a inner join producto b on a.id_producto = b.id_producto inner join ventas c on c.id_venta = a.id_venta where a.id_venta = '" + venta.idVenta + "'";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listado.Add(
                        new Producto()
                        {
                            idProducto = Convert.ToInt32(dr["id_producto"].ToString()),
                            nombre = dr["nombre"].ToString(),
                            precio = Convert.ToDecimal(dr["precio"].ToString()),
                            idFamilia = int.Parse(dr["id_familia"].ToString())
                        });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarProductosComprados" + ex.Message);
                }
                    
            }
            finally
            {
                this.cnn.Close();
            }
            return listado;
        }
        
        public IList<FormaPago> consultarFormaPago(Venta venta)
        {
            IList<FormaPago> listado = new List<FormaPago>();
            try
            {
                this.cnn.Open();
                string query = "SELECT  metodoPago , detalle, monto  FROM formaPago where id_venta = '" + venta.idVenta + "'";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listado.Add(
                        new FormaPago()
                        {
                            metodoPago = dr["metodoPago"].ToString(),
                            monto = Convert.ToDecimal(dr["monto"].ToString()),
                            detalle = dr["detalle"].ToString(),
                            
                        });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarFormaPago" + ex.Message);
                }
                    
            }
            finally
            {
                this.cnn.Close();
            }
            return listado;
        }

        public bool iniciarElDia(Caja caja, Caja cajaMaestra)
        {
            bool operacionExitosa = false;
            try
            {
                this.cnn.Open();


                string query = "insert into dinero(id_dinero, cantidad_billetes20, cantidad_billetes50, cantidad_billetes100, cantidad_billetes200, cantidad_billetes500, cantidad_monedas50centavos, cantidad_monedas1, cantidad_monedas2, cantidad_monedas5, cantidad_monedas10, total)";
                string values = " values('" + caja.dinero.idDinero +"', "+ caja.dinero.billetes20 + ", "+ caja.dinero.billetes50 + ", "+ caja.dinero.billetes100 + ", "+ caja.dinero.billetes200 + ", "+ caja.dinero.billetes500 + ", "+ caja.dinero.monedas50centavos + ", "+ caja.dinero.monedas1 + ", "+ caja.dinero.monedas2 + ", "+ caja.dinero.monedas5 + ",  "+ caja.dinero.monedas10 + ", "+ Convert.ToString(caja.dinero.cantidad,CultureInfo.InvariantCulture) + ")";
                string queryvals = query + values;
                SqlCommand cmd = new SqlCommand(queryvals, cnn);
                cmd.ExecuteNonQuery();


                query = "insert into caja(id_caja, id_tienda,codigo_empleado, efectivoInicial, efectivoAlCierre, id_dinero, fechaCierre, estatus, caja_maestra)";
                values = " values('" + caja.idCaja + "', " + caja.idTienda + ", " + caja.codigoEmpleado + ", " + Convert.ToString( caja.dinero.cantidad, CultureInfo.InvariantCulture) + ", null , '" + caja.dinero.idDinero + "', null, 1, "+cajaMaestra.idCaja+");";
                queryvals = query + values;
                cmd = new SqlCommand(queryvals, cnn);
                cmd.ExecuteNonQuery();


                operacionExitosa = true;

                return operacionExitosa;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.iniciarElDia" + ex.Message);
                }
                    
                return false;
            }
            finally
            {
                this.cnn.Close();
            }
        }

        public void reCalcularDinero(Dinero pagoDelCliente, Dinero dinerEnCaja)
        {

            Dinero dineroEnCaja = dinerEnCaja;
            try
            {
                this.cnn.Open();
                /*string query = "SELECT  * FROM dinero where id_dinero = " + idDineroCaja + "";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dineroEnCaja = new Dinero()
                    {
                        billetes20 = Convert.ToDecimal(dr["cantidad_billetes20"].ToString(), CultureInfo.InvariantCulture),
                        billetes50 = Convert.ToDecimal(dr["cantidad_billetes50"].ToString(), CultureInfo.InvariantCulture),
                        billetes100 = Convert.ToDecimal(dr["cantidad_billetes100"].ToString(), CultureInfo.InvariantCulture),
                        billetes200 = Convert.ToDecimal(dr["cantidad_billetes200"].ToString(), CultureInfo.InvariantCulture),
                        billetes500 = Convert.ToDecimal(dr["cantidad_billetes500"].ToString(), CultureInfo.InvariantCulture),
                        monedas1 = Convert.ToDecimal(dr["cantidad_monedas1"].ToString(), CultureInfo.InvariantCulture),
                        monedas10 = Convert.ToDecimal(dr["cantidad_monedas10"].ToString(), CultureInfo.InvariantCulture),
                        monedas2 = Convert.ToDecimal(dr["cantidad_monedas2"].ToString(), CultureInfo.InvariantCulture),
                        monedas5 = Convert.ToDecimal(dr["cantidad_monedas5"].ToString(), CultureInfo.InvariantCulture),
                        monedas50centavos = Convert.ToDecimal(dr["cantidad_monedas50centavos"].ToString(), CultureInfo.InvariantCulture)
                    };
                }
                */
               
               Dinero dineroFinal = pagoDelCliente + dineroEnCaja;

               string  query = " update dinero set cantidad_billetes20 = " + dineroFinal.billetes20 + "," +
                            "cantidad_billetes50 = " + dineroFinal.billetes50 + "," +
                            "cantidad_billetes100 = " + dineroFinal.billetes100 + " ," +
                            "cantidad_billetes200 = " + dineroFinal.billetes200 + " ," +
                            "cantidad_billetes500 = " + dineroFinal.billetes500 + "," +
                            "cantidad_monedas50centavos = " + dineroFinal.monedas50centavos + " ," +
                            "cantidad_monedas1 = " + dineroFinal.monedas1 + "," +
                            "cantidad_monedas2 = " + dineroFinal.monedas2 + "," +
                            "cantidad_monedas5 = " + dineroFinal.monedas5 + "," +
                            "cantidad_monedas10 = " + dineroFinal.monedas10 + "," +
                            "total = " + Convert.ToString(dineroFinal.cantidad, CultureInfo.InvariantCulture) + " " +
                            "where id_dinero = '" + dineroEnCaja.idDinero+ "'";

                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.reCalcularDinero" + ex.Message);
                }
                    
            }
            finally
            {
                this.cnn.Close();
            }

        }

        public Tienda consultarTienda()
        {
            Tienda tienda = new Tienda();
            try
            {
                this.cnn.Open();
                string query = "SELECT * FROM tienda;";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tienda = new Tienda()
                    {

                        idTienda = Convert.ToInt32(dr["id_tienda"].ToString(), CultureInfo.InvariantCulture),
                        nombreTienda = Convert.ToString(dr["nombre"].ToString(), CultureInfo.InvariantCulture)
                      };
                }

                return tienda;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarDineroEnCaja" + ex.Message);
                }

                return null;
            }
            finally
            {
                this.cnn.Close();
            }
        }

        public Dinero consultarDineroEnCaja(string idDineroCaja)
        {
            Dinero dineroEnCaja = new Dinero();
            try
            {
                this.cnn.Open();
                string query = "SELECT * FROM dinero where id_dinero = '" + idDineroCaja + "'";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dineroEnCaja = new Dinero()
                    {
                        
                        idDinero = idDineroCaja,
                        billetes20 = Convert.ToDecimal(dr["cantidad_billetes20"].ToString(), CultureInfo.InvariantCulture),
                        billetes50 = Convert.ToDecimal(dr["cantidad_billetes50"].ToString(), CultureInfo.InvariantCulture),
                        billetes100 = Convert.ToDecimal(dr["cantidad_billetes100"].ToString(), CultureInfo.InvariantCulture),
                        billetes200 = Convert.ToDecimal(dr["cantidad_billetes200"].ToString(), CultureInfo.InvariantCulture),
                        billetes500 = Convert.ToDecimal(dr["cantidad_billetes500"].ToString(), CultureInfo.InvariantCulture),
                        monedas1 = Convert.ToDecimal(dr["cantidad_monedas1"].ToString(), CultureInfo.InvariantCulture),
                        monedas10 = Convert.ToDecimal(dr["cantidad_monedas10"].ToString(), CultureInfo.InvariantCulture),
                        monedas2 = Convert.ToDecimal(dr["cantidad_monedas2"].ToString(), CultureInfo.InvariantCulture),
                        monedas5 = Convert.ToDecimal(dr["cantidad_monedas5"].ToString(), CultureInfo.InvariantCulture),
                        monedas50centavos = Convert.ToDecimal(dr["cantidad_monedas50centavos"].ToString(), CultureInfo.InvariantCulture)
                    };
                }

                return dineroEnCaja;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarDineroEnCaja" + ex.Message);
                }
                    
                return null;
            }
            finally
            {
                this.cnn.Close();
            }
        }

        public Caja consultarEstatusCaja(int idTienda)
        {
            Caja caja = new Caja();
            try
            {
                this.cnn.Open();
                string query = "select top 1 id_caja, id_dinero, estatus from caja where id_tienda = " + idTienda + " order by fechaInicio desc ";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    caja = new Caja()
                    {
                        estatus = Convert.ToBoolean(dr["estatus"].ToString()),
                        idCaja = Convert.ToString(dr["id_caja"].ToString()),
                        dinero = new Dinero()
                        {
                            idDinero = Convert.ToString(dr["id_dinero"].ToString())
                        }

                    };

                }

                

                return caja;
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarEstatusCaja" + ex.Message);
                }
                    
                return new Caja() { dinero = new Dinero() };
            }
            finally { cnn.Close(); }
            
        }

        public bool cerrarCaja(string fecha, string idCaja, decimal efectivoAlCierre, decimal sfCantidad)
        {
            bool operacionExitosa = false;
            string query = string.Empty;
            try
            {
                this.cnn.Open();

                query = "update caja set fechaCierre = '" + fecha + "', estatus = 0, efectivoAlCierre = " + Convert.ToString(efectivoAlCierre, CultureInfo.InvariantCulture) + 
                     (sfCantidad > 0 ? " , sobrante = " + sfCantidad + "" : " , faltante = "+sfCantidad) +
                    " where id_caja = '" + idCaja + "'";

                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                operacionExitosa = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.cierreCaja " + ex.Message + " :" + query);
                }
                    
            }
            finally
            {
                this.cnn.Close();
            }
            return operacionExitosa;
        }

        internal decimal consultarGanaciasTotales(string idCaja)
        {
            decimal total = 0;
            try
            {
                this.cnn.Open();



                string query = "select sum(total) total from ventas where id_caja = '" + idCaja + "'";

                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    total = Convert.ToDecimal(dr["total"].ToString());
                }

                
                return total;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarGananciasCaja" + ex.Message);
                }


            }
            finally
            {

                this.cnn.Close();
            }
            //try
            //{
            //    this.cnn.Open();

            //    string tipoConsultaStr = string.Empty;
            //    switch(tipoConsulta)
            //    {
            //        case "efectivo":
            //            tipoConsultaStr = " d.detalle = 'pago en efectivo' ";
            //            break;
            //        case "tarjeta":
            //            tipoConsultaStr = " d.detalle <> 'pago en efectivo' ";
            //            break;
            //    }
            //    string query = "select a.total from dinero a inner join caja b on a.id_dinero = b.id_dinero where b.id_caja = '"+idCaja+"'";
            //    SqlCommand cmd = new SqlCommand(query, cnn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        total = Convert.ToDecimal(dr["total"].ToString());
            //    }

            //    this.cnn.Close();

            //    return total;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}

            return total;
        }

          internal decimal consultarGanaciasCajaMaestra(string tipoConsulta, string idCaja)
        {
            decimal total = 0;
            try
            {
                this.cnn.Open();
                string query = "select sum(a.monto)total from "+
                                "formaPago a "+
                                "inner join ventas b on a.id_venta = b.id_venta "+
                                "inner join caja c on c.id_caja = b.id_caja "+
                                "inner join corteCaja d on d.id_corte_caja = c.caja_maestra "+
                                "where a.metodoPago = '"+tipoConsulta+"' and d.id_corte_caja = "+idCaja+";";

                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string valor = dr["total"].ToString();
                    valor = valor.Replace(",", ".");
                    total = string.IsNullOrEmpty(dr["total"].ToString()) ? 0 : Convert.ToDecimal(valor, CultureInfo.InvariantCulture);
                }

                return total;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarGananciasCaja" + ex.Message);
                }


            }
            finally
            {

                this.cnn.Close();

            }
            return total;
              
          }
        

        internal decimal consultarGanaciasCaja(string tipoConsulta, string idCaja)
        {
            decimal total = 0;
            try
            {
                this.cnn.Open();
                string query = "select sum(a.monto)total from formaPago a inner join ventas b on a.id_venta = b.id_venta where a.metodoPago = '" + tipoConsulta + "' and b.id_caja = '" + idCaja + "';";

                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string valor = dr["total"].ToString();
                    valor = valor.Replace(",", ".");
                    total = string.IsNullOrEmpty(dr["total"].ToString()) ? 0 : Convert.ToDecimal(valor, CultureInfo.InvariantCulture);
                }

                return total;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarGananciasCaja" + ex.Message);
                }


            }
            finally
            {

                this.cnn.Close();

            }
            //try
            //{
            //    this.cnn.Open();

            //    string tipoConsultaStr = string.Empty;
            //    switch(tipoConsulta)
            //    {
            //        case "efectivo":
            //            tipoConsultaStr = " d.detalle = 'pago en efectivo' ";
            //            break;
            //        case "tarjeta":
            //            tipoConsultaStr = " d.detalle <> 'pago en efectivo' ";
            //            break;
            //    }
            //    string query = "select a.total from dinero a inner join caja b on a.id_dinero = b.id_dinero where b.id_caja = '"+idCaja+"'";
            //    SqlCommand cmd = new SqlCommand(query, cnn);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        total = Convert.ToDecimal(dr["total"].ToString());
            //    }

            //    this.cnn.Close();

            //    return total;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
                
            //}
            
            return total;
        }

        public bool consultarSiEsNecesarioRealizarCorteCaja(string idCaja)
        {
            DateTime? fechaInicio = null;
            try
            {
                this.cnn.Open();


                string query = "select fechaInicio from caja where id_caja = '" + idCaja + "';";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fechaInicio = Convert.ToDateTime(dr["fechaInicio"].ToString());
                }


                this.cnn.Close();

                // 8:00 am  
                // 16:00 pm

                //17:00 pm

                // 1:00 am

                string horaMatutina = ConfigurationManager.AppSettings["turno matutino"];
                string horaVespertina = ConfigurationManager.AppSettings["turno vespertino"];


                //Horario matutino

                if (fechaInicio.Value.Hour >= int.Parse(horaMatutina) && DateTime.Now.Hour < int.Parse(horaVespertina))
                {
                    //Seguimos en el rango de horario matutino
                    return false;

                }
                else if (fechaInicio.Value.Hour >= int.Parse(horaMatutina) && DateTime.Now.Hour >= int.Parse(horaVespertina))
                {
                    // ya nos pasamos de la hora matutina y hay que cmabiar de horario
                    return false;
                }
                else if (fechaInicio.Value.Hour >= int.Parse(horaVespertina) && DateTime.Now.Hour <= int.Parse(horaVespertina))
                {
                    // seguimos en el  rango de horario vespertino 
                    return true;
                }
                else if (fechaInicio.Value.Hour >= int.Parse(horaVespertina) && DateTime.Now.Hour >  int.Parse(horaMatutina))
                {
                    // seguimos en el  rango de horario vespertino  pero hay que cambiar
                    return true;
                }

               


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarSiEsNecesarioRealizarCortecaja" + ex.Message);
                }
                    

            }

            return false;

        }

        public DateTime? consultarFechaHoraInicioCaja(string idCaja)
        {
            DateTime? fechaInicio = null;
            try
            {
                this.cnn.Open();


                string query = "select fechaInicio from caja where id_caja = '" + idCaja + "';";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fechaInicio = Convert.ToDateTime(dr["fechaInicio"].ToString());
                }


                this.cnn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarFechaHoraInicioCaja" + ex.Message);
                }
                    
            }

            return fechaInicio;

        }

        public DateTime? consultarFechaHoraInicioCajaMaestra(string idCaja)
        {
            DateTime? fechaInicio = null;
            try
            {
                this.cnn.Open();


                string query = "select fechaInicio from corteCaja where id_corte_caja = '" + idCaja + "';";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fechaInicio = Convert.ToDateTime(dr["fechaInicio"].ToString());
                }


                this.cnn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarFechaHoraInicioCajaMaestra" + ex.Message);
                }

            }

            return fechaInicio;

        }

        
        #region datosRemotos


        public string consultarNumeroTicket(string idCaja)
        {
            string numeroTicket = string.Empty;
            try
            {
                this.cnn.Open();
                string query = "select max(no_ticket) noTicket from ventas where id_caja = '" + idCaja + "';";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    numeroTicket = Convert.ToString(int.Parse(dr["noTicket"].ToString().Replace(",",".")));
                        
               }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarNumeroTicket" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return numeroTicket;
        }

        public string consultarTicketInicial(string idCaja)
        {
            string numeroTicket = string.Empty;
            try
            {
                this.cnn.Open();
                string query = "select min(no_ticket) noTicket from ventas where id_caja = '" + idCaja + "';";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    numeroTicket = Convert.ToString(int.Parse(dr["noTicket"].ToString()));
                        
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarTicketInicial" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return numeroTicket;
        }

        public string consultarTransacciones(string idCaja)
        {
            string numeroTickets = string.Empty;
            try
            {
                this.cnn.Open();
                string query = "select count(*) numeroTickets from ventas where id_caja = '" + idCaja + "';";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    numeroTickets = Convert.ToString(int.Parse(dr["numeroTickets"].ToString()));

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarTransacciones" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return numeroTickets;
        }

        public string consultarTicketInicialCajaMaestra(string idCaja)
        {
            string numeroTicket = string.Empty;
            try
            {
                this.cnn.Open();
                string query = "select min(no_ticket) noTicket "
                                +" from "
                                +" ventas a inner join caja b on a.id_caja = b.id_caja"
                                +" inner join corteCaja c on c.id_corte_caja = b.caja_maestra "
                                +" where b.caja_maestra = "+idCaja+";";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    numeroTicket = Convert.ToString(int.Parse(dr["noTicket"].ToString()));

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarTicketInicialCajaMaestra" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return numeroTicket;
        }

        public string consultarTransaccionesCajaMaestra(string idCaja)
        {
            string numeroTicket = string.Empty;
            try
            {
                this.cnn.Open();
                string query = "select count(*) noTicket "
                                + " from "
                                + " ventas a inner join caja b on a.id_caja = b.id_caja"
                                + " inner join corteCaja c on c.id_corte_caja = b.caja_maestra "
                                + " where b.caja_maestra = " + idCaja + ";";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    numeroTicket = Convert.ToString(int.Parse(dr["noTicket"].ToString()));

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarTransaccionesCajaMaestra" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return numeroTicket;
        }


        public string consultarTicketFinal(string idCaja)
         {
             string numeroTicket = string.Empty;
             try
             {
                 this.cnn.Open();
                 string query = "select max(no_ticket) noTicket from ventas where id_caja = '" + idCaja + "';";
                 SqlCommand cmd = new SqlCommand(query, cnn);
                 SqlDataReader dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {

                     numeroTicket = dr["noTicket"].ToString().Replace(",",".");

                 }

             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
                 using (StreamWriter file = File.AppendText(path))
                 {
                     file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarTicketFinal" + ex.Message);
                 }

             }
             finally
             {
                 this.cnn.Close();
             }
             return numeroTicket;
         }

        public string consultarTicketFinalMaestra(string idCaja)
        {
            string numeroTicket = string.Empty;
            try
            {
                this.cnn.Open();
                string query = "select max(no_ticket) noTicket "
                                 + " from "
                                 + " ventas a inner join caja b on a.id_caja = b.id_caja"
                                 + " inner join corteCaja c on c.id_corte_caja = b.caja_maestra "
                                 + " where b.caja_maestra = " + idCaja + ";";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    numeroTicket = dr["noTicket"].ToString().Replace(",", ".");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarTicketFinalMaestra" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return numeroTicket;
        }

         public decimal consultarFondoInicial(string idCaja)
        {
            decimal numeroTicket = 0;
            try
            {
                this.cnn.Open();
                string query = "select efectivoInicial from caja where id_caja = '" + idCaja + "';";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    numeroTicket = Convert.ToDecimal(dr["efectivoInicial"].ToString());
                        
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarFondoInicial" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return ((numeroTicket));
        }

        public IList<Usuario> consultarUsuarios(int idSucursal)
        {
            string query = string.Empty;
            IList<Usuario> listado = new List<Usuario>();
            try
            {
                this.cnn.Open();
                query = "SELECT  * from usuario where codigo_tienda = "+ idSucursal;
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listado.Add(
                        new Usuario()
                        {
                            codigoEmpleado = int.Parse(dr["codigo_empleado"].ToString()),
                            codigoTienda = int.Parse(dr["codigo_tienda"].ToString()),
                        });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarUsuarios" + ex.Message + (cnn == null ? " base de datos nula local" : cnn.ConnectionString) + " query:" + query);
                }
                    
            }
            finally
            {
                this.cnn.Close();
            }
            return listado;
        }


        #endregion

        internal bool actualizarDineroCaja(Dinero dineroCuadre, string idDinero)
        {
            bool actualizacionExitosa = false;
            try
            {
                this.cnn.Open();
                string query = " update dinero set cantidad_billetes20 = " + dineroCuadre.billetes20 + "," +
                           "cantidad_billetes50 = " + dineroCuadre.billetes50 + "," +
                           "cantidad_billetes100 = " + dineroCuadre.billetes100 + " ," +
                           "cantidad_billetes200 = " + dineroCuadre.billetes200 + " ," +
                           "cantidad_billetes500 = " + dineroCuadre.billetes500 + "," +
                           "cantidad_monedas50centavos = " + dineroCuadre.monedas50centavos + " ," +
                           "cantidad_monedas1 = " + dineroCuadre.monedas1 + "," +
                           "cantidad_monedas2 = " + dineroCuadre.monedas2 + "," +
                           "cantidad_monedas5 = " + dineroCuadre.monedas5 + "," +
                           "cantidad_monedas10 = " + dineroCuadre.monedas10 + "," +
                           "total = " + Convert.ToString(dineroCuadre.cantidad, CultureInfo.InvariantCulture) + " " +
                           "where id_dinero = '" + idDinero + "'";

                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                actualizacionExitosa = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.actualizarInventario" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return actualizacionExitosa;
        }

        internal decimal consultarTiketPromedioMaestro(string idCaja)
        {
            decimal total = 0;
            try
            {
                this.cnn.Open();



                string query = "select avg(a.monto)total from "+
                                "formaPago a "+
                                "inner join ventas b on a.id_venta = b.id_venta "+
                                "inner join caja c on c.id_caja = b.id_caja "+
                                "inner join corteCaja d on d.id_corte_caja = c.caja_maestra "+
                                "where d.id_corte_caja = "+idCaja+";";

                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    total = Convert.ToDecimal(dr["total"].ToString());
                }


                return total;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarTiketPromedio" + ex.Message);
                }


            }
            finally
            {

                this.cnn.Close();
            }


            return total;
        }

        internal decimal consultarTiketPromedio(string idCaja)
        {
            decimal total = 0;
            try
            {
                this.cnn.Open();



                string query = "select avg(total) total from ventas where id_caja = '" + idCaja + "'";

                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    total = Convert.ToDecimal(dr["total"].ToString());
                }


                return total;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarTiketPromedio" + ex.Message);
                }


            }
            finally
            {

                this.cnn.Close();
            }


            return total;
        }

        internal bool finalizarCajaMaestra(Caja cajaMaestra)
        {
            bool operacionExitosa = false;
            string query = string.Empty;
            try
            {
                this.cnn.Open();

                query = "update corteCaja set estatus = 0, fechaCierre = '" + DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss") +"' "+
                   
                    " where id_corte_caja = " + cajaMaestra.idCaja + ";" ;

                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                operacionExitosa = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.finalizarCajaMaestra " + ex.Message + " :" + query);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return operacionExitosa;
        }

        internal decimal consultarDineroFaltante(string idCaja)
        {
            decimal faltante = 0;
            try
            {
                this.cnn.Open();
                string query = "select sum(isnull(a.faltante,0)) faltante from caja a inner join corteCaja b on a.caja_maestra = b.id_corte_caja "+
                                "where id_corte_caja = "+ idCaja;


                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    faltante = Convert.ToDecimal(dr["faltante"].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarTicketInicialCajaMaestra" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return faltante;
        }

        internal decimal consultarDineroSobrante(string idCaja)
        {
            decimal sobrante = 0;
            try
            {
                this.cnn.Open();
                string query = "select sum(isnull(a.sobrante,0)) sobrante from caja a inner join corteCaja b on a.caja_maestra = b.id_corte_caja "+
                                "where id_corte_caja = "+ idCaja;


                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    sobrante = Convert.ToDecimal(dr["sobrante"].ToString());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarTicketInicialCajaMaestra" + ex.Message);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return sobrante;
        }

        internal IList<Complementos> consultarComplementos(int idProducto, int idFamilia)
        {
            string query = string.Empty;
            IList<Complementos> listado = new List<Complementos>();
            try
            {
                this.cnn.Open();
                query = "select a.id_complemento, a.descripcion, a.id_producto, a.numero_personas from complementos a inner join producto b on a.id_producto = b.id_producto inner join familia c on c.id_familia = b.id_familia where a.id_producto = " + idProducto + " and c.id_familia = " + idFamilia + ";";
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    listado.Add(
                        new Complementos()
                        {
                            idComplemento = int.Parse(dr["id_complemento"].ToString()),
                            idProducto = int.Parse(dr["id_producto"].ToString()), 
                            descripcion = dr["descripcion"].ToString(),
                            numeroPersonas = int.Parse(dr["numero_personas"].ToString())
                        });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "BaseDatos.consultarUsuarios" + ex.Message + (cnn == null ? " base de datos nula local" : cnn.ConnectionString) + " query:" + query);
                }

            }
            finally
            {
                this.cnn.Close();
            }
            return listado;
        }
    }
}
