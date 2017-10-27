using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.Configuration;
using WindowsFormsApplication1.Clases;
using WindowsFormsApplication1.Clases.Modelos;
using System.IO;


namespace WinniesService
{
    partial class WinniesService : ServiceBase
    {
        private static System.Timers.Timer aTimer;
        
       
        public WinniesService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: agregar código aquí para iniciar el servicio.
            // Create a timer with a ten second interval.
            int horas = 1;
            int minutos = 60;
            int segundo = 1000 * 60;
            int tiempo = segundo * minutos * horas;
            aTimer = new System.Timers.Timer();

            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            aTimer.Interval = tiempo;
            aTimer.Enabled = true;

        }

        // Specify what you want to happen when the Elapsed event is 
        // raised.
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            string path = @"C:/poslog/log.txt";

            try
            {
                Console.WriteLine("sincronizando información", e.SignalTime);
                

                string servidorLocal = ConfigurationManager.AppSettings["servidor_local"];
                string baseDatosLocal = ConfigurationManager.AppSettings["base_datos_local"];

                
                BaseDatos cnnLocal = new BaseDatos(servidorLocal, baseDatosLocal, "Integrated Security = true");
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                Tienda tienda = cnnLocal.consultarTienda();

                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando servidor local: " + servidorLocal);
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") +  " sucursal:" + tienda.nombreTienda);
                }

/*
                config.AppSettings.Settings.Remove("id_tienda");
                config.AppSettings.Settings.Add("id_tienda", tienda.idTienda.ToString());

                config.AppSettings.Settings.Remove("nombre sucursal");
                config.AppSettings.Settings.Add("nombre sucursal", tienda.nombreTienda);


                config.Save(ConfigurationSaveMode.Full);*/
                
                Sincronizador sinc = new Sincronizador();


                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "sincronizando información para la tienda: " + tienda.nombreTienda);
                }


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

                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "fin de sincronización :D");
                }


                // sinc.sincronizarProductos();
                // sinc.sincronizarVentas();
            }
            catch (Exception ex)
            {
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + "Erro al sincronizar :(   " + ex.Message);
                }

            }


        }

        protected override void OnStop()
        {
            // TODO: agregar código aquí para realizar cualquier anulación necesaria para detener el servicio.
        }
    }
}
