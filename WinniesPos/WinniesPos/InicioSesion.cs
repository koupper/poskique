using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;
using System.Configuration;
using WindowsFormsApplication1.Clases.Modelos;
using System.Globalization;
using WindowsFormsApplication1.Clases.Datos;
using System.Drawing.Printing;

namespace WindowsFormsApplication1
{
    public partial class FormLogin : Form
    {
        int billetes20, billetes50, billetes100, billetes200, billetes500, monedas10, monedas5, monedas2, monedas1, monedas50c;
        BaseDatos cnn;
        IList<Critico> lCriticos;
        Usuario usuario;
        bool fueCargado;
        IList<TipoCritico> listatiposCriticos;
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            cnn = new BaseDatos();
            fueCargado = false;
            cnn.primerQ();

            

            /*
             * 
             * 
             */

            IList<TipoCritico> listatiposCriticos = cnn.consultarTiposCriticos();
            cmbCriticos.Items.Clear();
            foreach (TipoCritico selec in listatiposCriticos)
            {

                cmbCriticos.Items.Add(selec.descripcion.ToString());
            }

            IList<InventarioIng> listaInventario = cnn.consultarInventario();

            IList<Ingredientes> listaIngredientes = cnn.consultarIngredientes();
            foreach (InventarioIng ingrediente in listaInventario)
            {
                dtInicio.Value = Convert.ToDateTime(ingrediente.fecha);
                string fecha, invInic, entradas, salidas, mermas, invFin, min, max;
                fecha = ingrediente.fecha;
                invInic = ingrediente.inventarioInicial.ToString();
                entradas = ingrediente.entradas.ToString();
                salidas = ingrediente.salidas.ToString();
                mermas = ingrediente.mermas.ToString();
                invFin = ingrediente.inventarioFinal.ToString();
                min = ingrediente.minimo.ToString();
                max = ingrediente.maximo.ToString();
                Ingredientes localIng = listaIngredientes.Where(ing => ing.idIngrediente == ingrediente.idIngrediente).FirstOrDefault();
                if (localIng != null)
                {
                    string producto = localIng.descripcion;
                    string unidadM = localIng.unidadMedida;
                    tblInv.Rows.Add(fecha, producto, invInic, unidadM, entradas, salidas, mermas, invFin, min, max);

                }
                

            }
           

        }

        private void cerrarCaja(string idDineroCaja, string idCaja)
        {
            
            Dinero dineroEnCaja = cnn.consultarDineroEnCaja(idDineroCaja);

            string titulo = "Corte de caja";
            string turno = string.Empty;

            string hora = cnn.consultarFechaHoraInicioCaja(idCaja).Value.Hour.ToString();
            string horaMatutina = ConfigurationManager.AppSettings["turno matutino"];
            string horaVespertina = ConfigurationManager.AppSettings["turno vespertino"];

            if (int.Parse(hora) >= int.Parse(horaMatutina) && int.Parse(hora) < int.Parse(horaVespertina))
            {
                turno = "M";
            }else
            {
                turno = "V";
            }

            Impresora ticket = new Impresora();
            string fecha = DateTime.Now.ToString("yyyy-dd-MM HH:MM:ss");
            ticket.AbreCajon();
            ticket.TextoIzquierda(titulo);
            ticket.TextoIzquierda("FECHA:" + fecha);
            ticket.TextoIzquierda("SUCURSAL:" + ConfigurationManager.AppSettings["nombre sucursal"]);
            ticket.TextoIzquierda("CAJERO DE CORTE:" + ConfigurationManager.AppSettings["codigo_trabajador"]);
            
            ticket.TextoIzquierda("");

            decimal dineroEfectivo = 0;
            decimal dineroTarjeta = 0;

            if (turno == "M")
            {

                dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCaja("efectivo", idCaja), CultureInfo.InvariantCulture);
                dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCaja("tarjeta", idCaja), CultureInfo.InvariantCulture);
            
                ticket.TextoIzquierda("T. Matutino");
                ticket.TextoIzquierda("EFECTIVO: $" + dineroEfectivo);
                ticket.TextoIzquierda("TARJETA: $" + dineroTarjeta);
                ticket.TextoIzquierda("TOTAL: " + (dineroEfectivo+dineroTarjeta));
            }
            else
            {
                dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCaja("efectivo", idCaja), CultureInfo.InvariantCulture);
                dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCaja("tarjeta", idCaja), CultureInfo.InvariantCulture);
            
                ticket.TextoIzquierda("T.vespertino");
                ticket.TextoIzquierda("EFECTIVO: $" + dineroEfectivo);
                ticket.TextoIzquierda("TARJETA: $" + dineroTarjeta);
                ticket.TextoIzquierda("TOTAL: " + (dineroEfectivo + dineroTarjeta));
            }
            ticket.TextoIzquierda("VENTA TOTAL");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("$500.00", dineroEnCaja.billetes500.ToString());
            ticket.TextoExtremos("$200.00", dineroEnCaja.billetes200.ToString());
            ticket.TextoExtremos("$100.00", dineroEnCaja.billetes100.ToString());
            ticket.TextoExtremos("$50.00", dineroEnCaja.billetes50.ToString());
            ticket.TextoExtremos("$20.00", dineroEnCaja.billetes20.ToString());
            ticket.TextoExtremos("$10.00", dineroEnCaja.monedas10.ToString());
            ticket.TextoExtremos("$5.00", dineroEnCaja.monedas5.ToString());
            ticket.TextoExtremos("$2.00", dineroEnCaja.monedas2.ToString());
            ticket.TextoExtremos("$1.00", dineroEnCaja.monedas1.ToString());
            ticket.TextoExtremos("$0.50", dineroEnCaja.monedas50centavos.ToString());
            ticket.TextoExtremos("TOTAL: $", dineroEnCaja.cantidad.ToString());
            ticket.TextoIzquierda("Firma Cajero 1_____________");
            ticket.TextoDerecha("Firma Encargado ______________");
            ticket.TextoIzquierda("Firma Cajero 2_____________");
            ticket.CortaTicket();
          
            PrinterSettings settings = new PrinterSettings();

            ticket.ImprimirTicket(settings.PrinterName);

            
            cnn.cerrarCaja(fecha, idCaja, dineroEnCaja.cantidad, 0);
            MessageBox.Show("Caja cerrada");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txboxCodigo.Text);
                usuario = cnn.consultarUsuario(codigo);

                if (usuario != null )
                {

                    panelCriticos.Visible = true;
                }
                else
                {
                    txboxCodigo.Text = "";
                }
            }
            catch{} //Excepcion controlada


        }

        private void validarUsuario(Usuario usuario)
        {
            panelCriticos.Visible = true;
            fueCargado = true;
            //Se guarda el codigo del trabajador que esta logueado
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("codigo_trabajador");
            config.AppSettings.Settings.Add("codigo_trabajador", txboxCodigo.Text);

            Tienda tienda = cnn.consultarTienda();
            config.AppSettings.Settings.Remove("id_tienda");
            config.AppSettings.Settings.Add("id_tienda", tienda.idTienda.ToString());

            config.AppSettings.Settings.Remove("nombre sucursal");
            config.AppSettings.Settings.Add("nombre sucursal", tienda.nombreTienda);


            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");


            if (usuario.lPermisos.Count == 1)
            {
                switch (usuario.lPermisos.First().idPrivilegio)
                {
                    //
                    case 1:

                        FormEmpleadoFunciones pantallaFunciones = new FormEmpleadoFunciones();
                        pantallaFunciones.Show();
                        this.Hide();
                        break;
                    //ventas al publico
                    case 2:

                        int idTienda = Convert.ToInt32(ConfigurationManager.AppSettings["id_tienda"], CultureInfo.InvariantCulture);

                        Caja cajaCerrada = cnn.consultarEstatusCaja(idTienda);

                        if (!cajaCerrada.estatus)
                        {

                            panelCriticos.Visible = false;
                            panelCaja.Visible = true;
                            
                           

                        }
                        else
                        {


                            config.AppSettings.Settings.Remove("codigo_caja");
                            config.AppSettings.Settings.Add("codigo_caja", cajaCerrada.idCaja);

                            config.AppSettings.Settings.Remove("codigo_dinero");
                            config.AppSettings.Settings.Add("codigo_dinero", cajaCerrada.dinero.idDinero);


                            bool esNecesarioCorteCaja = cnn.consultarSiEsNecesarioRealizarCorteCaja(cajaCerrada.idCaja);

                            if (esNecesarioCorteCaja)
                            {
                                DialogResult result1 = MessageBox.Show("Necesario corte de caja",
                                                                        "¿Deseas hacer el corte en este momento?",
                                MessageBoxButtons.YesNo);

                                if (result1 == DialogResult.Yes)
                                {
                                    cerrarCaja(cajaCerrada.dinero.idDinero, cajaCerrada.idCaja);
                                    panelCaja.Visible = true;
                                }
                            }
                            else
                            {


                                config.Save(ConfigurationSaveMode.Modified);
                                ConfigurationManager.RefreshSection("appSettings");

                                FormTomaOrden pantallaTomaOrden = new FormTomaOrden();
                                pantallaTomaOrden.Show();
                                this.Hide();
                            }
                        }

                        break;

                }
            }
            else
            {
                FormGerenteFunciones pantallaFunciones = new FormGerenteFunciones();
                pantallaFunciones.Show();
                this.Hide();

            }
    
        }

       
        private void btn_Click(object sender, EventArgs e)
        {
            if(txboxCodigo.Text == "CODIGO DE EMPLEADO"){
                txboxCodigo.Text = "";
            }

            if (txboxCodigo.Text.Length < 4)
            {
                Button btn = ((Button)sender);
                txboxCodigo.Text += btn.Text;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txboxCodigo.Text = "";
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {

                if (txboxCantidad.Text.Length == 1 && txboxCantidad.Text == "0")
                {
                    txboxCantidad.Text = "";
                }
                if (txboxCantidad.Text.Length < 6)
                {

                    Button btn = ((Button)sender);
                    if (btn.Text == "." && !txboxCantidad.Text.Contains(".") && txboxCantidad.Text == "")
                    {
                        if (txboxCantidad.Text == "")
                        {
                            txboxCantidad.Text = "0.0";
                        }

                    }
                    else
                    {
                        if (txboxCantidad.Text == "0.0")
                        {
                            txboxCantidad.Text = "0.";
                        }

                        if (btn.Text == "." && txboxCantidad.Text.Contains("."))
                        {
                            return;
                        }

                        txboxCantidad.Text += btn.Text;
                        string pag = txboxCantidad.Text;
                        
                    }

                
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelCaja.Visible = false;
            txboxCantidad.Text = "0";
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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            if (fueCargado)
            {
                string dataTime = dtInicio.Value.Date.ToString("dd/MM/yyyy HH:mm:ss");
                dtInicio.Value = DateTime.Parse(dataTime);
                IList<InventarioIng> listaInventario = cnn.consultarInventario(dtInicio.Value, dateTimePicker2.Value);


                IList<Ingredientes> listaIngredientes = cnn.consultarIngredientes();
                if (listaInventario.Count >= 1)
                {
                    tblInv.Rows.Clear();

                    foreach (InventarioIng inv in listaInventario)
                    {

                        dtInicio.Value = Convert.ToDateTime(inv.fecha);
                        string fecha, invInic, entradas, salidas, mermas, invFin, min, max;
                        fecha = inv.fecha;
                        invInic = inv.inventarioInicial.ToString();
                        entradas = inv.entradas.ToString();
                        salidas = inv.salidas.ToString();
                        mermas = inv.mermas.ToString();
                        invFin = inv.inventarioFinal.ToString();
                        min = inv.minimo.ToString();
                        max = inv.maximo.ToString();
                        Ingredientes localIng = listaIngredientes.Where(ing => ing.idIngrediente == inv.idIngrediente).FirstOrDefault();
                        if (localIng != null)
                        {

                            string producto = localIng.descripcion;
                            string unidadM = localIng.unidadMedida;
                            tblInv.Rows.Add(fecha, producto, invInic, unidadM, entradas, salidas, mermas, invFin, min, max);

                        }

                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias");
                }
            }
}

        private void panelCriticos_Paint(object sender, PaintEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listaPed.SelectedItems)
            {
                int numero = int.Parse(item.Text);
                numero -=1;
                decimal valorAQuitarDeLaCaja = Convert.ToDecimal(item.Name, CultureInfo.InvariantCulture);
                decimal valorEnCaja = Convert.ToDecimal(txboxCantidad.Text, CultureInfo.InvariantCulture);
                valorEnCaja = valorEnCaja - valorAQuitarDeLaCaja;
                txboxCantidad.Text = Convert.ToString(valorEnCaja, CultureInfo.InvariantCulture);
                if (numero <= 0){
                    numero = 0;
                    item.Remove();
                }

                item.Text = numero.ToString();

            }
        }

        private void panelCaja_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCritilcos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbCriticos.Text;
            tblInv.Rows.Clear();
            cmbCriticos.Items.Clear();
            cmbCriticos.Text = "CRITICOS";
            listatiposCriticos = cnn.consultarTiposCriticos();
            TipoCritico tipoLocal = listatiposCriticos.Where(tipo => tipo.descripcion == select).FirstOrDefault();
            if (tipoLocal != null)
            {
                lCriticos = cnn.consultarCriticos();

                IList<Critico> listaLocal = lCriticos.Where(tipo => tipo.idTipoCritico == tipoLocal.idTipoCritico).ToList();

                IList<InventarioIng> listaInventario = cnn.consultarInventario();

                IList<Ingredientes> listaIngredientes = cnn.consultarIngredientes();


                foreach (TipoCritico selec in listatiposCriticos)
                {

                    cmbCriticos.Items.Add(selec.descripcion.ToString());
                }


                foreach (Critico cit in listaLocal)
                {
                    InventarioIng localinv = listaInventario.Where(inv => inv.idIngrediente == cit.idProducto).FirstOrDefault();
                    Ingredientes localIngre = listaIngredientes.Where(ingre => ingre.idIngrediente == cit.idProducto).FirstOrDefault();

                    string fecha, invInic, entradas, salidas, mermas, invFin, min, max;
                    fecha = localinv.fecha;
                    invInic = localinv.inventarioInicial.ToString();
                    entradas = localinv.entradas.ToString();
                    salidas = localinv.salidas.ToString();
                    mermas = localinv.mermas.ToString();
                    invFin = localinv.inventarioFinal.ToString();
                    min = localinv.minimo.ToString();
                    max = localinv.maximo.ToString();
                    //Ingredientes localIng = listaIngredientes.Where(ing => ing.idIngrediente == ingrediente.idIngrediente).FirstOrDefault();
                    string producto = localIngre.descripcion;
                    string unidadM = localIngre.unidadMedida;
                    tblInv.Rows.Add(fecha, producto, invInic, unidadM, entradas, salidas, mermas, invFin, min, max);

                }
            }
            

        }

        private void button15_Click(object sender, EventArgs e)
        {
            validarUsuario(usuario);
               
         
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panelCaja.Visible = false;
            panelCriticos.Visible = false;
        }

    }
}
