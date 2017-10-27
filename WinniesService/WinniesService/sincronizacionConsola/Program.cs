using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinniesService;
using System.Configuration;
using WindowsFormsApplication1.Clases;
using WindowsFormsApplication1.Clases.Modelos;
namespace sincronizacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string servidorLocal = ConfigurationManager.AppSettings["servidor_local"];
            string baseDatosLocal = ConfigurationManager.AppSettings["base_datos_local"];
            
            BaseDatos cnnLocal = new BaseDatos(servidorLocal, baseDatosLocal, "Integrated Security = true");
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            Tienda tienda = cnnLocal.consultarTienda();
            config.AppSettings.Settings.Remove("id_tienda");
            config.AppSettings.Settings.Add("id_tienda", tienda.idTienda.ToString());

            config.AppSettings.Settings.Remove("nombre sucursal");
            config.AppSettings.Settings.Add("nombre sucursal", tienda.nombreTienda);


            config.Save(ConfigurationSaveMode.Full);

            Sincronizador sinc = new Sincronizador();
          
            // sincronizacion de la nube a local
            #region usuarios
                sinc.sincronizarUsuarios();
                sinc.sincronizarPrivilegios();
                sinc.sincronizarPrivilegiosAsignados();
                sinc.sincronizarPerfil();
            #endregion

            #region sucursal
                sinc.sincronizarTienda();   
            #endregion

            #region productos
                sinc.sincronizarFamilias();
                sinc.sincronizarProductos();
            #endregion

                // sincronizacion local a la nube

            #region productos vendidos
                sinc.sincronizarDinero();
                sinc.sincronizarCaja();
                sinc.sincronizarVentas();
                sinc.sincronizarFormaPago();
                sinc.sincronizarProductosVendidos();

                
            #endregion
               
            #region inventarios
                sinc.sincronizarInventarios();
                sinc.sincronizarPedidos();
            #endregion
                // sinc.sincronizarProductos();
           // sinc.sincronizarVentas();

            Console.WriteLine();
            
            
           
        }
    }
}
