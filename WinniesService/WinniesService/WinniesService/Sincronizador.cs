using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using WindowsFormsApplication1.Clases.Modelos;
using WindowsFormsApplication1.Clases;
using System.Data;
using System.IO;

namespace WinniesService
{
    public class Sincronizador
    {
        BaseDatos cnnRemoto;
        BaseDatos cnnLocal;
        
        string path = @"C:/poslog/log.txt";
        public Sincronizador()
        {
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "inicializando sincronizacion  en segundo plano...");
            }

            string servidorRemoto = ConfigurationManager.AppSettings["servidor_remoto"];
            string usuarioRemoto = ConfigurationManager.AppSettings["usuario_remoto"];
            string passRemoto = ConfigurationManager.AppSettings["password_remoto"];
            string baseDatosRemota = ConfigurationManager.AppSettings["base_datos_remoto"];

            string servidorLocal = ConfigurationManager.AppSettings["servidor_local"];
            string baseDatosLocal = ConfigurationManager.AppSettings["base_datos_local"];
            
            cnnRemoto = new BaseDatos(servidorRemoto, baseDatosRemota, "User Id=" + usuarioRemoto + ";Password=" + passRemoto + "");
            cnnLocal = new BaseDatos(servidorLocal, baseDatosLocal, "Integrated Security = true");

            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "objeto de sincronizacion inicializado");
            }
        }

        /// <summary>
        /// En este metodo lo importante es lo que dicta el servidor
        /// </summary>

        public void sincronizarUsuarios()
        {

            Tienda tienda = cnnLocal.consultarTienda();
            string idSucursal = tienda.idTienda.ToString();
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando usuarios...");
            }
            actualizarDeLaNubeALocal("usuario", " where codigo_tienda = "+ idSucursal);


        }

        public void sincronizarPrivilegiosAsignados()
        {
            Tienda tienda = cnnLocal.consultarTienda();
            string idSucursal = tienda.idTienda.ToString();
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando privilegiosasignados...");
            }


            actualizarDeLaNubeALocal("privilegiosasignados a inner join usuario b on a.codigo_empleado = b.codigo_empleado", " where b.codigo_tienda = " + idSucursal, "a.*");
        }

        public void sincronizarPrivilegios()
        {
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando privilegios...");
            }
            actualizarDeLaNubeALocal("privilegios", "");
        }

        public void sincronizarPerfil()
        {
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando perfiles...");
            }
            
            actualizarDeLaNubeALocal("perfiles", "");
        }

        public void sincronizarTienda()
        {
            Tienda tienda = cnnLocal.consultarTienda();
            string idSucursal = tienda.idTienda.ToString();
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando tienda...");
            }
            actualizarDeLaNubeALocal("tienda", " where id_tienda = "+ idSucursal);
        }

        public void sincronizarFamilias()
        {

            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando familia...");
            }
            actualizarDeLaNubeALocal("familia", "");
        }

        public void sincronizarProductos()
        {

            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando producto...");
            }
            actualizarDeLaNubeALocal("producto", "");
        }

        public void sincronizarInventarios()
        {
            Tienda tienda = cnnLocal.consultarTienda();
            string idSucursal = tienda.idTienda.ToString();
            
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando producto...");
            }
            actualizarDeLocalALaNube("inventario", " where id_tienda = " + idSucursal);
        }

        public void sincronizarPedidos()
        {
            Tienda tienda = cnnLocal.consultarTienda();
            string idSucursal = tienda.idTienda.ToString();

            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando producto...");
            }
            actualizarDeLocalALaNube("pedidos", " where id_tienda = " + idSucursal);
        }


        public void sincronizarVentas()
        {

            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando ventas...");
            }
            actualizarDeLocalALaNube("ventas", "");
        }

        public void sincronizarDinero()
        {
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando dinero...");
            }  
            actualizarDeLocalALaNube("dinero", "");
        }

        public void sincronizarCaja()
        {

            Tienda tienda = cnnLocal.consultarTienda();
            string idSucursal = tienda.idTienda.ToString();
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando caja...");
            }
            actualizarDeLocalALaNube("caja", " where id_tienda = " + idSucursal);

        }

        public void sincronizarFormaPago()
        {

            Tienda tienda = cnnLocal.consultarTienda();
            string idSucursal = tienda.idTienda.ToString();
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando formaPago...");
            }
            actualizarDeLocalALaNube("formaPago", "");

        }

        public void sincronizarProductosVendidos()
        {

            Tienda tienda = cnnLocal.consultarTienda();
            string idSucursal = tienda.idTienda.ToString();
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando productos vendidos...");
            }
            actualizarDeLocalALaNube("productosvendidos", "");

        }

        public void actualizarDeLaNubeALocal(string tabla, string whereClause, string select = "*")
        {
            string nombresucursal = ConfigurationManager.AppSettings["nombre sucursal"];


            string servidorRemoto = ConfigurationManager.AppSettings["servidor_remoto"];
            string usuarioRemoto = ConfigurationManager.AppSettings["usuario_remoto"];
            string passRemoto = ConfigurationManager.AppSettings["password_remoto"];
            string baseDatosRemota = ConfigurationManager.AppSettings["base_datos_remoto"];

            string servidorLocal = ConfigurationManager.AppSettings["servidor_local"];
            string baseDatosLocal = ConfigurationManager.AppSettings["base_datos_local"];

            cnnLocal = new BaseDatos(servidorLocal, baseDatosLocal, "Integrated Security = true");
            cnnRemoto = new BaseDatos(servidorRemoto, baseDatosRemota, "User Id=" + usuarioRemoto + ";Password=" + passRemoto + "");



            string[] tablaArray = tabla.Split(' ');

            //revisar consistencia
            string queryEstructura = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tablaArray[0]+ "'";
            DataTable estructuraTablaRemota = cnnRemoto.consultar(queryEstructura);
            DataTable estructuraTablaLocal = cnnLocal.consultar(queryEstructura);

            string query = Utils.compararEstructuras(estructuraTablaLocal, estructuraTablaRemota, tablaArray[0]);

            if (!string.IsNullOrEmpty(query))
            {
                cnnLocal.ejecutarComando(query);
            }

            //Actualizar datos e insertar los faltantes
            queryEstructura = "SELECT " + select + " FROM " + tabla + whereClause;
            DataTable datosRemotos = cnnRemoto.consultar(queryEstructura);
            DataTable datosLocales = cnnLocal.consultar(queryEstructura);

            //armamos el query para actualizar
            query = Utils.armarQueryActualizacion(estructuraTablaRemota, datosLocales, datosRemotos, tablaArray[0]);
            if (!string.IsNullOrEmpty(query))
            {
                cnnLocal.ejecutarComando(query);
            }


            //armamos el query para insertar
            query = Utils.insertarDatosLocales(estructuraTablaRemota, datosLocales, datosRemotos, tablaArray[0]);
            if (!string.IsNullOrEmpty(query))
            {
                cnnLocal.ejecutarComando(query);
            }

            // eliminamos los datos que ya no deben de existir de manera local
            queryEstructura = "SELECT  " + select + " FROM " + tabla + whereClause; ;
            datosLocales = cnnLocal.consultar(queryEstructura);



            query = Utils.armarQueryDeleteLocal(estructuraTablaRemota, datosLocales, datosRemotos, tablaArray[0]);
            if (!string.IsNullOrEmpty(query))
            {
                cnnLocal.ejecutarComando(query);
            }


            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " ok");
            }
        }

        public void actualizarDeLocalALaNube(string tabla, string whereClause, bool identity = false)
        {
            string nombresucursal = ConfigurationManager.AppSettings["nombre sucursal"];


            string servidorRemoto = ConfigurationManager.AppSettings["servidor_remoto"];
            string usuarioRemoto = ConfigurationManager.AppSettings["usuario_remoto"];
            string passRemoto = ConfigurationManager.AppSettings["password_remoto"];
            string baseDatosRemota = ConfigurationManager.AppSettings["base_datos_remoto"];

            string servidorLocal = ConfigurationManager.AppSettings["servidor_local"];
            string baseDatosLocal = ConfigurationManager.AppSettings["base_datos_local"];

            cnnLocal = new BaseDatos(servidorLocal, baseDatosLocal, "Integrated Security = true");
            cnnRemoto = new BaseDatos(servidorRemoto, baseDatosRemota, "User Id=" + usuarioRemoto + ";Password=" + passRemoto + "");


            //revisar consistencia
            string queryEstructura = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabla + "'";
            DataTable estructuraTablaRemota = cnnRemoto.consultar(queryEstructura);
            DataTable estructuraTablaLocal = cnnLocal.consultar(queryEstructura);

            string query = Utils.compararEstructuras(estructuraTablaLocal, estructuraTablaRemota, tabla);

            if (!string.IsNullOrEmpty(query))
            {
                cnnLocal.ejecutarComando(query);
            }

            //Actualizar datos e insertar los faltantes
            queryEstructura = "SELECT * FROM " + tabla + whereClause;
            DataTable datosRemotos = cnnRemoto.consultar(queryEstructura);
            DataTable datosLocales = cnnLocal.consultar(queryEstructura);

            //armamos el query para actualizar
            query = Utils.armarQueryActualizacion(estructuraTablaRemota, datosRemotos, datosLocales, tabla);
            if (!string.IsNullOrEmpty(query))
            {
                cnnRemoto.ejecutarComando(query);
            }

            //armamos el query para insertar
            query = Utils.insertarDatosLocales(estructuraTablaRemota, datosRemotos, datosLocales, tabla, identity);
            if (!string.IsNullOrEmpty(query))
            {
                cnnRemoto.ejecutarComando(query);
            }

           /* // eliminamos los datos que ya no deben de existir de manera local
            queryEstructura = "SELECT * FROM " + tabla + whereClause; ;
            datosLocales = cnnLocal.consultar(queryEstructura);
            


            query = Utils.armarQueryDeleteLocal(estructuraTablaRemota, datosRemotos, datosLocales, tabla);
            if (!string.IsNullOrEmpty(query))
            {
                cnnRemoto.ejecutarComando(query);
            }*/
            using (StreamWriter file = File.AppendText(path))
            {
                file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " ok");
            }
        }

        /*
        public void sincronizarVentas()
        {
            string idSucursal = ConfigurationManager.AppSettings["id_tienda"];
            string nombresucursal = ConfigurationManager.AppSettings["nombre sucursal"];

            IList<Venta> listadoVentasRemoto = null;
            IList<Venta> listadoVentasLocal = null;

            listadoVentasRemoto = cnnRemoto.consultarVentas(idSucursal);
            listadoVentasLocal = cnnLocal.consultarVentas(idSucursal);
            
            //ventas nuevas
            //IList<Venta> listadoVentasUpdate = new List<Venta>();

            var results = listadoVentasLocal.Where(m => !listadoVentasRemoto.Contains(m)).ToList<Venta>();



            // actualizar local
            foreach (Venta venta in results)
            {
                IList<Producto> listadoProductosLocal = cnnLocal.consultarProductosComprados(venta);
                IList<FormaPago> listadoFomaPagoLocal = cnnLocal.consultarFormaPago(venta);
                cnnRemoto.registrarVenta(venta, listadoProductosLocal, listadoFomaPagoLocal, "");
            }
        }*/
    }

}
