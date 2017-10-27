using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases.Modelos;
using WindowsFormsApplication1.Clases;
using System.Configuration;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class FormEmpleadoFunciones : Form
    {
        BaseDatos cnn;
        int billetes20, billetes50, billetes100, billetes200, billetes500, monedas10, monedas5, monedas2, monedas1, monedas50c;
       
        string idTienda = ConfigurationManager.AppSettings["id_tienda"];
        public FormEmpleadoFunciones()
        {
            InitializeComponent();
            cnn = new BaseDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormTomaOrden pantallaTomaOrden = new FormTomaOrden();
            //pantallaTomaOrden.Show();
            FormInventario PantallaInventario = new FormInventario();
            PantallaInventario.Show();
            this.Hide();
        }

        private void FormFunciones_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            /*string codigo =  ConfigurationManager.AppSettings["codigo_trabajador"];
            
            Usuario usuario = cnn.consultarUsuario(Convert.ToInt32(codigo));
            
           */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            Caja cajaCerrada = cnn.consultarEstatusCaja(Convert.ToInt32(idTienda));
            if (!cajaCerrada.estatus)
            {
                panelCaja.Visible = true;
            }
            else
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    
                config.AppSettings.Settings.Remove("codigo_caja");
                config.AppSettings.Settings.Add("codigo_caja", cajaCerrada.idCaja);

                config.AppSettings.Settings.Remove("codigo_dinero");
                config.AppSettings.Settings.Add("codigo_dinero", cajaCerrada.dinero.idDinero);


                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");


                FormTomaOrden pantallaOrden = new FormTomaOrden();
                pantallaOrden.Show();
                this.Hide();
            
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //FormReportes pantallaReportes = new FormReportes();
            //pantallaReportes.Show();
            //this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelCaja.Visible = false;
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            //Se guarda el codigo del trabajador que esta logueado
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Remove("codigo_caja");
            config.AppSettings.Settings.Add("codigo_caja", "");

            config.AppSettings.Settings.Remove("codigo_dinero");
            config.AppSettings.Settings.Add("codigo_dinero", "");

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            int idTienda = Convert.ToInt32(ConfigurationManager.AppSettings["id_tienda"], CultureInfo.InvariantCulture);


            Dinero dinero = new Dinero(idTienda)
            {
                billetes20 = billetes20,
                billetes50 = billetes50,
                billetes100 = billetes100,
                billetes200 = billetes200,
                billetes500 = billetes500,
                monedas1 = monedas1,
                monedas10 = monedas10,
                monedas2 = monedas2,
                monedas5 = monedas5,
                monedas50centavos = monedas50c
            };



            int codigoEmpleado = Convert.ToInt32(ConfigurationManager.AppSettings["codigo_trabajador"], CultureInfo.InvariantCulture);
            int dineroEnCaja = Convert.ToInt32(Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);

            Caja caja = new Caja(codigoEmpleado, idTienda, dineroEnCaja, dinero);
            Caja cajaMaestra = cnn.abrirCajaMaestra();
            if (cnn.iniciarElDia(caja, cajaMaestra))
            {
                config.AppSettings.Settings.Remove("codigo_caja");
                config.AppSettings.Settings.Add("codigo_caja", caja.idCaja.ToString());

                config.AppSettings.Settings.Remove("codigo_dinero");
                config.AppSettings.Settings.Add("codigo_dinero", caja.dinero.idDinero.ToString());

                config.AppSettings.Settings.Remove("caja_cerrada");
                config.AppSettings.Settings.Add("caja_cerrada", "cerrada");


                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                string cajaCerrada = ConfigurationManager.AppSettings["caja_cerrada"];


                FormTomaOrden pantallaTomaOrden = new FormTomaOrden();
                pantallaTomaOrden.Show();
                this.Hide();
            }
        }

        private void btnBillete20_Click(object sender, EventArgs e)
        {
            decimal dinero = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture) + 20;
            txboxCantidad.Text = Convert.ToString(dinero, CultureInfo.InvariantCulture);
            billetes20 += 1;
            if (billetes20 == 1)
            {
                ListViewItem Lista = new ListViewItem((billetes20).ToString());
                Lista.SubItems.Add("Billetes $20");
                Lista.Name = "20";
                listaPed.Items.Add(Lista);
            }
            else
            {
                ListViewItem item = listaPed.FindItemWithText("Billetes $20");
                item.Name = "20";
                item.Text = (billetes20).ToString();
            }
        }

        private void btnBillete50_Click(object sender, EventArgs e)
        {
            decimal dinero = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture) + 50;
            txboxCantidad.Text = Convert.ToString(dinero, CultureInfo.InvariantCulture);
            billetes50 += 1;
            if (billetes50 == 1)
            {
                ListViewItem Lista = new ListViewItem((billetes50).ToString());
                Lista.SubItems.Add("Billetes $50");
                Lista.Name = "50";
                listaPed.Items.Add(Lista);
            }
            else
            {
                ListViewItem item = listaPed.FindItemWithText("Billetes $50");
                item.Name = "50";
                item.Text = (billetes50).ToString();
            }
        }

        private void btnBillete100_Click(object sender, EventArgs e)
        {
            decimal dinero = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture) + 100;
            txboxCantidad.Text = Convert.ToString(dinero, CultureInfo.InvariantCulture);
            billetes100 += 1;
            if (billetes100 == 1)
            {
                ListViewItem Lista = new ListViewItem((billetes100).ToString());
                Lista.SubItems.Add("Billetes $100");
                Lista.Name = "100";
                listaPed.Items.Add(Lista);
            }
            else
            {
                ListViewItem item = listaPed.FindItemWithText("Billetes $100");
                item.Name = "100";
                item.Text = (billetes100).ToString();
            }
        }

        private void btnBillete200_Click(object sender, EventArgs e)
        {
            decimal dinero = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture) + 200;
            txboxCantidad.Text = Convert.ToString(dinero, CultureInfo.InvariantCulture);
            billetes200 += 1;
            if (billetes200 == 1)
            {
                ListViewItem Lista = new ListViewItem((billetes200).ToString());
                Lista.SubItems.Add("Billetes -> $200");
                Lista.Name = "200";
                listaPed.Items.Add(Lista);
            }
            else
            {
                ListViewItem item = listaPed.FindItemWithText("Billetes -> $200");
                item.Name = "200";
                item.Text = (billetes200).ToString();
            }
        }

        private void btnBillete500_Click(object sender, EventArgs e)
        {
            decimal dinero = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture) + 500;
            txboxCantidad.Text = Convert.ToString(dinero, CultureInfo.InvariantCulture);
            billetes500 += 1;
            if (billetes500 == 1)
            {
                ListViewItem Lista = new ListViewItem((billetes500).ToString());
                Lista.SubItems.Add("Billetes -> $500");
                Lista.Name = "500";
                listaPed.Items.Add(Lista);
            }
            else
            {
                ListViewItem item = listaPed.FindItemWithText("Billetes -> $500");
                item.Name = "500";
                item.Text = (billetes500).ToString();
            }
        }

        private void btnMoneda10_Click(object sender, EventArgs e)
        {
            decimal dinero = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture) + 10;
            txboxCantidad.Text = Convert.ToString(dinero, CultureInfo.InvariantCulture);
            monedas10 += 1;
            if (monedas10 == 1)
            {
                ListViewItem Lista = new ListViewItem((monedas10).ToString());
                Lista.SubItems.Add("Monedas -> $10");
                Lista.Name = "10";
                listaPed.Items.Add(Lista);
            }
            else
            {
                ListViewItem item = listaPed.FindItemWithText("Monedas -> $10");
                item.Name = "10";
                item.Text = (monedas10).ToString();
            }
        }

        private void btnMoneda5_Click(object sender, EventArgs e)
        {
            decimal dinero = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture) + 5;
            txboxCantidad.Text = Convert.ToString(dinero, CultureInfo.InvariantCulture);
            monedas5 += 1;
            if (monedas5 == 1)
            {
                ListViewItem Lista = new ListViewItem((monedas5).ToString());
                Lista.SubItems.Add("Monedas $5");
                Lista.Name = "5";
                listaPed.Items.Add(Lista);
            }
            else
            {
                ListViewItem item = listaPed.FindItemWithText("Monedas $5");
                item.Name = "5";
                item.Text = (monedas5).ToString();
            }
        }

        private void btnMoneda2_Click(object sender, EventArgs e)
        {
            decimal dinero = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture) + 2;
            txboxCantidad.Text = Convert.ToString(dinero, CultureInfo.InvariantCulture);
            monedas2 += 1;
            if (monedas2 == 1)
            {
                ListViewItem Lista = new ListViewItem((monedas2).ToString());
                Lista.SubItems.Add("Monedas $2");
                Lista.Name = "2";
                listaPed.Items.Add(Lista);
            }
            else
            {
                ListViewItem item = listaPed.FindItemWithText("Monedas $2");
                item.Name = "2";
                item.Text = (monedas2).ToString();
            }
        }

        private void btnMoneda1_Click(object sender, EventArgs e)
        {
            decimal dinero = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture) + 1;
            txboxCantidad.Text = Convert.ToString(dinero, CultureInfo.InvariantCulture);
            monedas1 += 1;
            if (monedas1 == 1)
            {
                ListViewItem Lista = new ListViewItem((monedas1).ToString());
                Lista.SubItems.Add("Monedas $1");
                Lista.Name = "1";
                listaPed.Items.Add(Lista);
            }
            else
            {
                ListViewItem item = listaPed.FindItemWithText("Monedas $1");
                item.Name = "1";
                item.Text = (monedas1).ToString();
            }
        }

        private void btnMoneda50c_Click(object sender, EventArgs e)
        {
            decimal dinero = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture) + (decimal)0.50;
            txboxCantidad.Text = Convert.ToString(dinero, CultureInfo.InvariantCulture);
            monedas50c += 1;
            if (monedas50c == 1)
            {
                ListViewItem Lista = new ListViewItem((monedas50c).ToString());
                Lista.SubItems.Add("Monedas $0.50");
                Lista.Name = "0.50";
                listaPed.Items.Add(Lista);
            }
            else
            {
                ListViewItem item = listaPed.FindItemWithText("Monedas $0.50");
                item.Name = "0.50";
                item.Text = (monedas50c).ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txboxCantidad.Text = "0";
            listaPed.Items.Clear();
            billetes20 = 0; billetes50 = 0; billetes100 = 0; billetes200 = 0;
            billetes500 = 0; monedas10 = 0; monedas5 = 0; monedas2 = 0;
            monedas1 = 0; monedas50c = 0;
        }
    }
}
