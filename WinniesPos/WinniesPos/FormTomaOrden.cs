using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;
using WindowsFormsApplication1.Clases.Modelos;
using System.Configuration;
using WindowsFormsApplication1.Clases.Datos;
using System.Drawing.Printing;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class FormTomaOrden : Form
    {
        bool baderaCero = false;
        BaseDatos cnn;
        Dinero dinero, dineroNuevo,  dineroEnCaja, dineroCuadre;
        Ingredientes ing;
        IList<Producto> listadoProductos;
        IList<Familia> listadoMenu;
        IList<Producto> lProductosComprados;
        IList<FormaPago> lFormasPago;
        IList<InventarioIng> lDescInv;
        IList<Ingredientes> lingredientes;
        IList<Receta> lReceta;
        IList<Critico> lCriticos;
        
        IList<TipoCritico> listatiposCriticos;
       
        public int combo;
        public int i = 0;
        public int j = 0;
        bool banderaCierreDia = false;

        Producto comboBraker = new Producto();
        
        bool banderaActivo = true;
        bool banderaExtra = false;
        bool banderaRef = false;
        bool banderaBeb = false;
        bool banderaCorte = false;
        bool banderaPagoDiferido = false; 
        decimal  total = 0;
        decimal  pago = 0;
        decimal  porPagar = 0;
        int numeroDeDenominacionesSeleccionadas = 0;
        int contadorcombo = 0;
        decimal cambio = 0;
        int personasCmoplemento = 0;

        bool visa, mastercard, american;

        string tipoTarjeta = string.Empty;
        string numeroTarjeta = string.Empty;

        Producto comboSeleccionadoObj = null;
        IList<Complementos> lComplementos;

        Dictionary<Button, int> dFilasComplementos = null;

        public void reiniciodevariables()
        {
            baderaCero = false;
         i = 0;
         j = 0;

        Producto comboBraker = new Producto();

         banderaActivo = true;
         banderaExtra = false;
         banderaRef = false;
         banderaBeb = false;
         banderaCorte = false;
         total = 0;
         pago = 0;
         porPagar = 0;
         numeroDeDenominacionesSeleccionadas = 0;
         contadorcombo = 0;
         cambio = 0;

            visa = false;
            mastercard = false;
            american = false;

         tipoTarjeta = string.Empty;
         numeroTarjeta = string.Empty;

         comboSeleccionadoObj = null;

    }
        public FormTomaOrden()
        {
            InitializeComponent();
            cnn = new BaseDatos();
            lProductosComprados = new List<Producto>();
            lFormasPago = new List<FormaPago>();
            dinero = new Dinero();
            dineroNuevo = new Dinero();
            ing = new Ingredientes();
            dineroCuadre = new Dinero();
            dFilasComplementos = new Dictionary<Button, int>();

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (banderaActivo && lbSubTotal.Text != "$0")
            {
                if (lProductosComprados.Count > 0)
                {
                    panelMonedas.Visible = true;
                    btnCancelar.Visible = true;
                    this.Invalidate();
                }
            }
        }

        private void FormTomaOrden_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            listadoMenu = cnn.consultarMenu();
            lDescInv = cnn.consultarInventario();
            lReceta = cnn.consultarReceta();
            lingredientes = cnn.consultarIngredientes();
            //Se generan los botones del menu 
            int ra = 50;
            int filas = 1;
            foreach (Familia menu in listadoMenu)
            {
                Button PRUEBA = new Button();
                PRUEBA.Name = menu.idFamilia.ToString(); //el identificador del menu
                
                PRUEBA.Text = menu.nombre;
                i += 1;
                PRUEBA.Width = 102;
                PRUEBA.Height = 66;
                PRUEBA.Top = 10;
                PRUEBA.Left = ra;
                if (ra >= PRUEBA.Width * 4)
                {
                    filas++;
                    ra = 50;
                    PRUEBA.Top += filas * (PRUEBA.Height + 10)/2;
                    PRUEBA.Left = ra;
                }
                else
                {
                    ra += 110;
                }


                PRUEBA.Click += boton_click;
                groupBox1.Controls.Add(PRUEBA);

            }

            //Se cargan los botones de los proudctos
            string idProducto = listadoMenu.FirstOrDefault().idFamilia.ToString();
            crearBotonesProductos(idProducto, panel1);

            FormEmpleadoFunciones pantallaFunciones = new FormEmpleadoFunciones();
            pantallaFunciones.Close();

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

        private void boton_click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
                string idProducto = ((Button)sender).Name;
                lbTitulo.Text = ((Button)sender).Text;
                crearBotonesProductos(idProducto, panel1);
            }

        }


        private void crearBotonesProductos(string id, Panel panel, bool isComplento = false)
        {
            if (banderaActivo)
            {
                panel.Controls.Clear();

                string menu = id;
                if (isComplento == false)
                {
                    listadoProductos = cnn.consultarProducto(Convert.ToInt32(menu));
                }
                else
                {
                    listadoProductos = cnn.consultarProductoComplementario(int.Parse(id));
                }
                int re = 50;
                int filas = 1;
                int topButton = 10;


                foreach (Producto producto in listadoProductos)
                {
                    Button productoButton = new Button();

                    
                    productoButton.Text = (isComplento ? "":"" ) + producto.nombre + "\n$" + producto.precio.ToString("n2", CultureInfo.InvariantCulture);
                   
                    productoButton.Name = producto.idProducto.ToString();
                    j += 1;

                    productoButton.Width = 102;
                    productoButton.Height = 66;

                    productoButton.Top = topButton;
                    productoButton.Left = re;

                    if (re >= productoButton.Width * 3)
                    {
                        filas++;
                        re = 50;
                        topButton += productoButton.Height + (productoButton.Height / 5);
                    }
                    else
                    {
                        re += 110;
                    }

                    productoButton.Click += producto_clic;

                    panel.Controls.Add(productoButton);


                }
                banderaBeb = false;
                banderaRef = false;
            }
        }


        private void producto_clic(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
                Button boton = ((Button)sender);
                int idProducto = Convert.ToInt32(boton.Name);

                Producto prod = listadoProductos.Where(producto => producto.idProducto == idProducto).FirstOrDefault();

                int numeroProductosSimilares = lProductosComprados.Count(producto => producto == prod);






                //panelExtras.Controls.Clear();
                lComplementos = cnn.consultarComplementos(prod.idProducto, prod.idFamilia);
                if (lComplementos.Count>0)
                {

                    int leftButton = 46;
                    int topButton = 86;
                    int filas = 1;
                   
                    foreach (Complementos complemento in lComplementos)
                    {
                        
                        Button extraButton = new Button();
                        extraButton.Text = complemento.descripcion;

                        extraButton.Width = 139;
                        extraButton.Height = 119;

                        extraButton.Top = topButton;
                        extraButton.Left = leftButton;
                        IList<Producto> listadoProductosTemp = cnn.consultarProductoComplementario(complemento.idComplemento);
                        if (listadoProductosTemp.Count > 0)
                        {
                            extraButton.Click += bebidaClic;
                        }
                        else
                        {
                            extraButton.Click += btnExtraSolo;
                        }
                        extraButton.Name = complemento.idComplemento.ToString();
                        dFilasComplementos[extraButton] = filas;
                       
                        if (leftButton >= extraButton.Width * 2)
                        {
                            filas++;
                            leftButton = 50;
                            topButton += extraButton.Height + (extraButton.Height / 2);
                            
                        }
                        else
                        {
                            leftButton += extraButton.Width+ 40;
                            
                        }

                        extraButton.Font = new Font("Microsoft Sans Serif", 13f);
                        panelExtras.Controls.Add(extraButton);
                        personasCmoplemento = complemento.numeroPersonas;
                    }

                    
                    comboSeleccionadoObj = prod;
                    panelExtras.Visible = true;

                }
                else
                {
                    
                    
                    panelExtras.Visible = false;
                   // panelExtras.Controls.Clear();
                    
                    if (panelRefresco.Visible == true)
                    {// comboSeleccionadoObj.idProducto +
                        prod.nombre = " -> " + prod.nombre;
                         panelRefresco.Visible = false;
                         panelRefresco.Controls.Clear();
                        //crearBotonesProductos(comboSeleccionadoObj.idFamilia.ToString(), panel1);
                        panelExtras.Visible = true;
                        comboSeleccionadoObj.lComplementos.Add(prod);
                        //panelExtras.Controls.Clear();

                        personasCmoplemento -= 1;
                        if (personasCmoplemento <= 0)
                        {
                            crearBotonesProductos(comboSeleccionadoObj.idFamilia.ToString(), panel1);
                            personasCmoplemento = 0;
                            comboSeleccionadoObj = null;
                            panelExtras.Controls.Clear();
                            panelExtras.Visible = false;
                            dFilasComplementos = new Dictionary<Button, int>();

                        }
                       
                    }
                }

                if (numeroProductosSimilares == 0)
                {
                    string textoItem = string.Empty;
                    if (!prod.nombre.Contains(" -> "))
                    {
                        textoItem = (numeroProductosSimilares + 1).ToString();
                    }
                    else
                    {
                        textoItem = " ";

                      
                        
                    }
                    ListViewItem Lista = new ListViewItem(textoItem);
                    Lista.SubItems.Add(prod.nombre);
                    Lista.SubItems.Add(prod.precio.ToString("n2", CultureInfo.InvariantCulture));
                    Lista.Name = prod.idProducto.ToString();
                    listaPed.Items.Add(Lista);
                }
                else
                {
                    ListViewItem item = listaPed.FindItemWithText(prod.nombre);
                    item.Text = (numeroProductosSimilares + 1).ToString();
                }

                total += prod.precio;
                lbSubTotal.Text = "$" + total.ToString("n2", CultureInfo.InvariantCulture);
                lbPorPagar.Text = "$" + ((total - pago) < 0 ? 0 : (total - pago)).ToString("n2", CultureInfo.InvariantCulture);

                if (comboSeleccionadoObj == null)
                {
                    lProductosComprados.Add(prod);
                }
                else
                {
                    IList<Producto> lcombos = lProductosComprados.Where(producto => producto.idProducto == comboSeleccionadoObj.idProducto && producto.lComplementos == null).ToList();
                    if (lcombos.Count == 0)
                    {
                        lProductosComprados.Add(prod);
                        //comboSeleccionadoObj = null;
                    }
                    else
                    {
                        if (lcombos[lcombos.Count - 1].idProducto == prod.idProducto)
                        {
                            lProductosComprados.Add(prod);

                        }
                        else
                        {
                            lcombos[lcombos.Count - 1].lComplementos.Add(prod);

                            //comboSeleccionadoObj = null;

                        }

                    }
                }



            }

        }

        private void calcularMetodosPagos(decimal precio)
        {
            if (visa == false && mastercard == false && american == false)
            {

                FormaPago formaPagoObj = lFormasPago.Where(formaPago => formaPago.metodoPago == "efectivo").FirstOrDefault();
                if (formaPagoObj == null)
                {
                    lFormasPago.Add(new FormaPago()
                    {
                        metodoPago = "efectivo",
                        detalle = "pago en efectivo",
                        monto = precio,
                        numeroTarjeta = string.Empty
                    });
                }
                else
                {
                    formaPagoObj.monto += precio;
                }
            }
            else
            {
                if (visa)
                {
                    FormaPago formaPagoObj = lFormasPago.Where(formaPago => formaPago.metodoPago == "tarjeta").FirstOrDefault();
                    if (formaPagoObj == null)
                    {
                        lFormasPago.Add(new FormaPago()
                        {
                            metodoPago = "tarjeta",
                            detalle = "visa",
                            monto = precio,
                            numeroTarjeta = numeroTarjeta
                        });
                    }
                    else
                    {
                        formaPagoObj.monto += precio;
                    }
                }
                else if (mastercard)
                {
                    FormaPago formaPagoObj = lFormasPago.Where(formaPago => formaPago.metodoPago == "tarjeta").FirstOrDefault();
                    if (formaPagoObj == null)
                    {
                        lFormasPago.Add(new FormaPago()
                        {
                            metodoPago = "tarjeta",
                            detalle = "master card",
                            monto = precio,
                            numeroTarjeta = numeroTarjeta
                        });
                    }
                    else
                    {
                        formaPagoObj.monto += precio;
                    }
                }
                else if (american)
                {
                    FormaPago formaPagoObj = lFormasPago.Where(formaPago => formaPago.metodoPago == "tarjeta").FirstOrDefault();
                    if (formaPagoObj == null)
                    {
                        lFormasPago.Add(new FormaPago()
                        {
                            metodoPago = "tarjeta",
                            detalle = "amercan express",
                            monto = precio,
                            numeroTarjeta = numeroTarjeta
                        });
                    }
                    else
                    {
                        formaPagoObj.monto += precio;
                    }
                }
            }
        }

        private void btnQuitarProd_Click(object sender, EventArgs e)
        {
            
            if (banderaActivo)
            {
                foreach (ListViewItem item in listaPed.SelectedItems)
                {
                    Producto prod = lProductosComprados.Where(producto => producto.idProducto == Convert.ToInt32(item.Name)).FirstOrDefault();

                    if (prod.lComplementos.Count > 0)
                    {
                        if (prod.idProducto == Convert.ToInt32(item.Name))
                        {


                            
                            foreach (Producto prodComplementario in prod.lComplementos)
                            {
                                ListViewItem subItem = listaPed.FindItemWithText(prodComplementario.nombre);//prod.lComplementos.nombre);

                               if (subItem != null)
                               {
                                    total -= prodComplementario.precio;
                                    subItem.Remove();
                                    //prod.lComplementos.Remove(prodComplementario);
                                }
                                
                           
                            }

                            total -= prod.precio;
                            item.Remove();
                            
                            lProductosComprados.Remove(prod);
                            
                        }
                    }
                    else
                    {
                        lProductosComprados.Remove(prod);
                        total -= prod.precio;
                    }


                    if (item.Text.Equals(" ") || Convert.ToInt32(item.Text) == 1)
                        item.Remove();

                    else
                        item.Text = (Convert.ToInt32(item.Text) - 1).ToString();


                    lbSubTotal.Text = "$" + total.ToString("n2", CultureInfo.InvariantCulture);
                    lbPorPagar.Text = "$" + total.ToString("n2", CultureInfo.InvariantCulture);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelMonedas.Visible = false;
            btnCancelar.Visible = false;
            lFormasPago.Clear();
            banderaActivo = true;
            panelCambio.Visible = false;
            panelDenominaciones.Visible = false;
           // //txboxCantidad.Text= "0";
            textBoxCantidad.Text = "$0";
            this.pago = 0;
            textboxDineroCa.Text = "0";
            lbPorPagar.Text = lbSubTotal.Text;
            lbPago.Text = "$0";
            dinero.reiniciarCuenta();
            dineroNuevo.reiniciarCuenta();
            visa = false;
            mastercard = false;
            american = false;

        }



        private void btnNumeroTarjeta_Click(object sender, EventArgs e)
        {
            
            
            if (visa || mastercard || american)
            {
                Button btn = ((Button)sender);

                if (txtTarjeta.Text == "0" && btn.Text == "0")
                {
                    baderaCero = true;
                }

                if (txtTarjeta.Text == "0" && baderaCero == false)
                {
                    txtTarjeta.Text = "";
                }
                if (txtTarjeta.Text.ToCharArray().Count() <= 3)
                {
                    txtTarjeta.Text += btn.Text;
                }
            }
            else
            {
                MessageBox.Show("Selecciona una tarjeta de credito");
            }


        }

        private void btnNumero_Click(object sender, EventArgs e)
        {

            if (banderaActivo)
            {
                if (textBoxMonedas.Text.Length < 2)
                {
                    Button btn = ((Button)sender);
                    //agregarNumero(btn.Text);
                    textBoxMonedas.Text += btn.Text;
                    numeroDeDenominacionesSeleccionadas = int.Parse(btn.Text);
                }
               
            }


        }

        private void btnNumeroC_Click(object sender, EventArgs e)
        {

            if (banderaActivo)
            {
                Button btn = ((Button)sender);
                agregarNumero(btn.Text);
              //  textboxDineroCa.Text += btn.Text;     
            }


        }

        private void agregarNumero(string numero)
        {
            if (textboxDineroCa.Text.Length == 1 && textboxDineroCa.Text == "0")
            {
                textboxDineroCa.Text= "";
            }
            if (textboxDineroCa.Text.Length < 6)
            {


                if (numero == "." && !textboxDineroCa.Text.Contains(".") && textboxDineroCa.Text== "")
                {
                    if (textboxDineroCa.Text== "")
                    {
                        textboxDineroCa.Text= "0.0";
                    }

                }
                else
                {
                    if (textboxDineroCa.Text== "0.0")
                    {
                        textboxDineroCa.Text= "0.";
                    }

                    if (numero == "." && textboxDineroCa.Text.Contains("."))
                    {
                        return;
                    }

                    textboxDineroCa.Text+= numero;
                    string pag = textboxDineroCa.Text;
                    this.pago = decimal.Parse(pag);
                    lbPago.Text = "$" + this.pago.ToString ("n2");
                    lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");



                }

            }
        }


        private void btnC_Click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
                textBoxCantidad.Text= "$0";
                this.pago = 0;
                lbPago.Text = "$0";
                lbPorPagar.Text = lbSubTotal.Text;
                dinero.reiniciarCuenta();
                dineroNuevo.reiniciarCuenta();
              

            }
        }

        private void mostrarDineroCaja()
        {
            listDineroEnCaja.Items.Clear();
            if (dineroEnCaja.billetes500 > 0)
            {
                ListViewItem Lista = new ListViewItem((dineroEnCaja.billetes500).ToString());
                Lista.SubItems.Add("Billetes -> $500");
                listDineroEnCaja.Items.Add(Lista);
            }

            if (dineroEnCaja.billetes200 > 0)
            {
                ListViewItem Lista = new ListViewItem((dineroEnCaja.billetes200).ToString());
                Lista.SubItems.Add("Billetes -> $200");
                listDineroEnCaja.Items.Add(Lista);
            }

            if (dineroEnCaja.billetes100 > 0)
            {
                ListViewItem Lista = new ListViewItem((dineroEnCaja.billetes100).ToString());
                Lista.SubItems.Add("Billetes $100");
                listDineroEnCaja.Items.Add(Lista);
            }

            if (dineroEnCaja.billetes50 > 0)
            {
                ListViewItem Lista = new ListViewItem((dineroEnCaja.billetes50).ToString());
                Lista.SubItems.Add("Billetes $50");
                listDineroEnCaja.Items.Add(Lista);
            }

            if (dineroEnCaja.billetes20 > 0)
            {
                ListViewItem Lista = new ListViewItem((dineroEnCaja.billetes20).ToString());
                Lista.SubItems.Add("Billetes $20");
                listDineroEnCaja.Items.Add(Lista);
            }

            if (dineroEnCaja.monedas10 > 0)
            {
                ListViewItem Lista = new ListViewItem((dineroEnCaja.monedas10).ToString());
                Lista.SubItems.Add("Monedas -> $10");
                listDineroEnCaja.Items.Add(Lista);
            }

            if (dineroEnCaja.monedas5 > 0)
            {
                ListViewItem Lista = new ListViewItem((dineroEnCaja.monedas5).ToString());
                Lista.SubItems.Add("Monedas $5");
                listDineroEnCaja.Items.Add(Lista);
            }

            if (dineroEnCaja.monedas2 > 0)
            {
                ListViewItem Lista = new ListViewItem((dineroEnCaja.monedas2).ToString());
                Lista.SubItems.Add("Monedas $2");
                listDineroEnCaja.Items.Add(Lista);
            }

            if (dineroEnCaja.monedas1 > 0)
            {
                ListViewItem Lista = new ListViewItem((dineroEnCaja.monedas1).ToString());
                Lista.SubItems.Add("Monedas $1");
                listDineroEnCaja.Items.Add(Lista);
            }

            if (dineroEnCaja.monedas50centavos > 0)
            {
                ListViewItem Lista = new ListViewItem((dineroEnCaja.monedas50centavos).ToString());
                Lista.SubItems.Add("Monedas $0.50");
                listDineroEnCaja.Items.Add(Lista);
            }
    
        }
        private void btnPagarCa_Click(object sender, EventArgs e)
        {
            /*  if (banderaActivo && lbSubTotal.Text != "$0")
              {
                  string texto = string.Empty;
                  panelMonedas.Visible = false;
                  cambio = pago - total;
                  // ajuste dinero no justificado, decimales que no se puede dar cambio
                  decimal d = cambio;
                  d = d % 1;

                  decimal pagoAjustado = pago;
                  if (pago > total)
                  {
                      if(d < (decimal)0.5){
                          pagoAjustado -= (decimal)d;
                      }
                      else{
                          pagoAjustado -= (decimal)d;
                          pagoAjustado += (decimal)0.50;
                      }
                    
                  }

                  if (pagoAjustado > total)
                  {

                      if (visa || mastercard || american)
                      {
                          MessageBox.Show("Si es un pago por tarjeta debe dar el cambio exacto");
                      }
                      else
                      {
                          texto = string.Format("Tienes que dar: {0} en cambio", cambio.ToString("c2"));//Convert.ToString(cambio), CultureInfo.InvariantCulture);

                          string idDineroCaja = Convert.ToString(ConfigurationManager.AppSettings["codigo_dinero"]);
                          dineroEnCaja = cnn.consultarDineroEnCaja(idDineroCaja);

                          mostrarDineroCaja();
                        

                          pictureBoxWarning.Visible = false;
                          banderaActivo = false;
                          lblCambio.Text = texto;
                          panelCambio.Visible = true;
                          panelCambioDash.Visible = true;
                          btnCancelarDash.Visible = true;
                      }

                  }
                  else if (pagoAjustado < total)
                  {
                    
                      decimal deb = total-pagoAjustado;
                      texto = string.Format("Faltan {0} por pagar", deb.ToString("c2"));
                      pictureBoxWarning.Visible = true;
                      banderaActivo = false;
                      lblCambio.Text = texto;
                      panelCambio.Visible = true;
                      panelCambioDash.Visible = false;
                      btnCancelarDash.Visible = false;

                  }
                  else
                  {*/
            if (banderaPagoDiferido)
            {
                if (total != Convert.ToDecimal(labelTotalCuadre.Text, CultureInfo.InvariantCulture))
                {
                    string mensaje = "Debe dar el pago excto, ni mas ni menos";
                    if (total <  Convert.ToDecimal(labelTotalCuadre.Text))
                        mensaje += " sobran "+ ( Convert.ToDecimal(labelTotalCuadre.Text) - total).ToString("c2");
                    else
                        mensaje += " faltan "+   (total - Convert.ToDecimal(labelTotalCuadre.Text)).ToString("c2");
                    MessageBox.Show(mensaje);
                    return;
                }

                lFormasPago.Add(new FormaPago()
                {
                    metodoPago = "efectivo",
                    detalle = "pago en efectivo",
                    monto = Convert.ToDecimal(labelEfectivoCuadre.Text, CultureInfo.InvariantCulture),
                    numeroTarjeta = string.Empty
                });

                string compania = "";
                if (visa)
                {
                    compania = "visa";
                }
                else if (mastercard)
                {
                    compania = "master card";
                }
                 lFormasPago.Add(new FormaPago()
                {
                    metodoPago = "tarjeta",
                    detalle = compania,
                    monto = Convert.ToDecimal(labelTarjetaCuadre.Text, CultureInfo.InvariantCulture),
                    numeroTarjeta = numeroTarjeta
                });
            }

            string codigoEmpleado = ConfigurationManager.AppSettings["codigo_trabajador"];
            string idTienda = ConfigurationManager.AppSettings["id_tienda"];
            string idCaja = ConfigurationManager.AppSettings["codigo_caja"];

            Venta venta = new Venta(Convert.ToInt32(codigoEmpleado), Convert.ToInt32(idTienda));
            venta.codigoEmpleado = Convert.ToInt32(codigoEmpleado);
            venta.idTienda = Convert.ToInt32(idTienda);
            venta.total = total;

            if (banderaPagoDiferido == false)
            {
                if (pago <= total)
                {
                    calcularMetodosPagos(pago);
                }
                else
                {
                    calcularMetodosPagos(total);
                }
            }
            else
            {
                pago = total;
            }

            if (cnn.registrarVenta(venta, lProductosComprados, lFormasPago, idCaja))
            {
                //Registra la operación en la caja y re calcula el dinero que debe de estar en la caja

                descontarProductos();
                existencias();
                MessageBox.Show("Vendido");

                imprimirTicket(venta);
                // imprimirTicket(venta);
                imprimirComanda(venta);



                if (!(visa || mastercard || american))
                {
                    string idDineroCaja = Convert.ToString(ConfigurationManager.AppSettings["codigo_dinero"]);
                    dineroEnCaja = cnn.consultarDineroEnCaja(idDineroCaja);
                    cnn.reCalcularDinero(dineroNuevo, dineroEnCaja);


                }






                listaPed.Items.Clear();
                lProductosComprados.Clear();
                lFormasPago.Clear();
                panelActiveVisa.Visible = false;
                panelActiveAE.Visible = false;
                panelActiveMC.Visible = false;
                btnPagarDiferido.Visible = false;
                banderaPagoDiferido = false;
                btnPagarDiferido.Visible = false;
                labelTotalPagarDiferido.Visible = false;
                labelTotalPagarDiferidoMensaje.Visible = false;
                labelRestantePagarDiferidoMensaje.Visible = false;
                labelRestanteDiferido.Visible = false;
                visa = panelActiveVisa.Visible;
                mastercard = panelActiveMC.Visible;
                american = panelActiveAE.Visible;


                //txboxCantidad.Text= "0";
                this.pago = 0;
                this.total = 0;
                this.porPagar = 0;
                this.panelMonedas.Visible = false;
                banderaActivo = true;
                lbPago.Text = "$0";
                lbSubTotal.Text = "$0";
                lbPorPagar.Text = lbSubTotal.Text;
                FormTomaOrden pantallaTomaOrden = new FormTomaOrden();
                pantallaTomaOrden.Show();
                this.Dispose();
                //codigo para mandar a imprimir
                //Se tiene que imprimir lo que esta en la lista; this.lProductosComprados

            }

            /* }


         }*/


        }

        private void imprimirTicket(Venta venta)
        {
            //Creamos una instancia d ela clase CrearTicket
            Impresora ticket = new Impresora();

            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            for (int i = 1; i <= 2; i++)
            {


              //  ticket.TextoIzquierda("");
              //  ticket.TextoIzquierda("");
              //  ticket.TextoIzquierda("");

                ticket.lineasIgual();
                ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");

                //Texto final del Ticket.
                ticket.TextoIzquierda("");

                ticket.AgregarTotales("CAMBIO            $", (decimal)pago - (decimal)total);
                ticket.AgregarTotales("EFECTIVO          $", (decimal)pago);
                ticket.TextoIzquierda("");
                ticket.AgregarTotales("TOTAL             $", (decimal)total);
                decimal iva = (total * (decimal)0.16);
                //Resumen de la venta. Sólo son ejemplos
                
                ticket.AgregarTotales("subtotal neto     $", ((decimal)total) - iva);
                ticket.AgregarTotales("SUBTOTAL          $", (decimal)total);

                ticket.lineasIgual();

                
                foreach (Producto producto in lProductosComprados)
                {
                    ListViewItem item = listaPed.FindItemWithText(producto.nombre);

                    if (item != null)
                    {
                        int numeroProductosSimilares = 1;//lProductosComprados.Count(prod => prod == producto);
                        ticket.AgregaArticulo(producto.nombre, numeroProductosSimilares, (decimal)producto.precio);
                    }
                }

                //Articulos a vender.


                ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO

                ticket.lineasGuio();
                ticket.TextoIzquierda(ConfigurationManager.AppSettings["nombre sucursal"]);

                ticket.TextoIzquierda("LUGAR DE EXPEDICIÓN:");

                string idCaja = ConfigurationManager.AppSettings["codigo_caja"];

                string numeroTicket = cnn.consultarNumeroTicket(idCaja);
                string fechat = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");
            
                ticket.TextoIzquierda("No de ticket: " + numeroTicket);
                ticket.TextoIzquierda("");
                ticket.TextoExtremos("#Cta.   #" + venta.idVenta + "", "");
                ticket.TextoDerecha(fechat);

                ticket.lineasGuio();
                ticket.TextoIzquierda("regimen de incorporacion fiscal");
                ticket.TextoIzquierda("R.F.C: GEW 151203  7Y3");
                ticket.TextoCentro("GRUPO EMPRESARIAL WINNIES S.A. DE C.V.");
               

               // ticket.TextoIzquierda("");
               // ticket.TextoIzquierda("");
               // ticket.TextoIzquierda("");
               // ticket.TextoIzquierda("");
               // ticket.TextoIzquierda("");
               
                ticket.CortaTicket();


            }


            PrinterSettings settings = new PrinterSettings();

            bool impresionCorrecta = ticket.ImprimirTicket(settings.PrinterName);
            //Nombre de la impresora ticketera



        }

        private void imprimirComanda(Venta venta)
        {
            //Creamos una instancia d ela clase CrearTicket
            Impresora ticket = new Impresora();

            
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            for (int i = 1; i <= 1; i++)
            {


              /*  ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
*/
                ticket.lineasIgual();

                foreach (Producto producto in lProductosComprados)
                {
                    ListViewItem item = listaPed.FindItemWithText(producto.nombre);

                    if (item != null)
                    {
                        int numeroProductosSimilares = lProductosComprados.Count(prod => prod == producto);
                        ticket.AgregaArticulo(producto.nombre, numeroProductosSimilares, (decimal)producto.precio);
                    }
                }

                //Articulos a vender.


                ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO

                ticket.lineasGuio();
                ticket.TextoIzquierda(ConfigurationManager.AppSettings["nombre sucursal"]);

                ticket.TextoIzquierda("LUGAR DE EXPEDICIÓN:");

                string idCaja = ConfigurationManager.AppSettings["codigo_caja"];

                string numeroTicket = cnn.consultarNumeroTicket(idCaja);
                string fechat = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");

                ticket.TextoIzquierda("No de ticket: " + numeroTicket);
                ticket.TextoIzquierda("");
                ticket.TextoDerecha(fechat);

              /*  ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                */
                ticket.CortaTicket();


            }

            PrinterSettings settings = new PrinterSettings();

            bool impresionCorrecta = ticket.ImprimirTicket(settings.PrinterName);
            if (impresionCorrecta)
                MessageBox.Show("Imprimiendo...");


            else
            {
                MessageBox.Show("Error en la impresión");
            }
            //Nombre de la impresora ticketera



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (!panelCambioDash.Visible)
            {
                panelCambio.Visible = false;
                banderaActivo = true;
                panelMonedas.Visible = true;
                return;
            }
            decimal cambioDado = cambio;//decimal.Parse(textBoxCambio.Text);
            if (cambioDado == cambio )
            {
                panelCambio.Visible = false;
                banderaActivo = true;

                string codigoEmpleado = ConfigurationManager.AppSettings["codigo_trabajador"];
                string idTienda = ConfigurationManager.AppSettings["id_tienda"];
                string idCaja = ConfigurationManager.AppSettings["codigo_caja"];

                Venta venta = new Venta(Convert.ToInt32(codigoEmpleado), Convert.ToInt32(idTienda));
                venta.codigoEmpleado = Convert.ToInt32(codigoEmpleado);
                venta.idTienda = Convert.ToInt32(idTienda);
                venta.total = total;
                if (pago <= total)
                {
                    calcularMetodosPagos(pago);
                }
                else
                {
                    calcularMetodosPagos(total);
                }
                if (cnn.registrarVenta(venta, lProductosComprados, lFormasPago, idCaja) && (total <= pago))
                {
                    descontarProductos();
                    existencias();
                    MessageBox.Show("Vendido");
                    imprimirTicket(venta);
                   // imprimirTicket(venta);
                     imprimirComanda(venta);
                    int il = 0;
                    foreach (Producto producto in listadoProductos)
                    {
                        
                    }


                        if (!(visa || mastercard || american))
                    {
                        string idDineroCaja = Convert.ToString(ConfigurationManager.AppSettings["codigo_dinero"]);
                        //dineroEnCaja = cnn.consultarDineroEnCaja(idDineroCaja);
                        cnn.reCalcularDinero(dineroNuevo, dineroEnCaja);


                    }


                    listaPed.Items.Clear();
                    lProductosComprados.Clear();
                    lFormasPago.Clear();

                    //txboxCantidad.Text= "0";
                    this.pago = 0;
                    this.total = 0;
                    this.porPagar = 0;
                    this.panelMonedas.Visible = false;
                    banderaActivo = true;
                    lbPago.Text = "$0";
                    lbSubTotal.Text = "$0";
                    lbPorPagar.Text = lbSubTotal.Text;
                    visa = panelActiveVisa.Visible;
                    mastercard = panelActiveMC.Visible;
                    american = panelActiveAE.Visible;

                    FormTomaOrden pantallaTomaOrden = new FormTomaOrden();
                    pantallaTomaOrden.Show();
                    this.Dispose();
                    //codigo para mandar a imprimir
                    //Se tiene que imprimir lo que esta en la lista; this.lProductosComprados
                }
            }
            else
            {
                MessageBox.Show("Para cerrar la compra, es necesario entregar el cambio exacto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCriticos.Visible = true;
            panelExtras.Visible = false;
          
        }

        private void btnBillete20_Click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
                decimal i = 20;
               // decimal pagado = decimal.Parse(txboxCantidad.Text) + 20;
                lbPago.Text = lbPago.Text + 20;
                //txboxCantidad.Text= "0";
               // agregarNumero(pagado.ToString("n2"));

                dineroNuevo.billetes20 += 1;
                //dineroNuevo.billetes20 += 1;

                //txboxCantidad.Text+= numero;
                
                this.pago += i * numeroDeDenominacionesSeleccionadas;
                lbPago.Text = "$" + this.pago.ToString("n2");
                lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");
                numeroDeDenominacionesSeleccionadas = 0;

                panelDenominaciones.Visible = false;
                panelMonedas.Visible = true;

                textBoxCantidad.Text = "$" + pago;
                banderaActivo = true;
            }

        }

        private void btnBillete50_Click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
               // decimal pagado = decimal.Parse(txboxCantidad.Text) + 50;
                //txboxCantidad.Text= "0";
               // agregarNumero(pagado.ToString("n2"));

                dineroNuevo.billetes50 += 1;
                decimal i = 50;
                this.pago += i * numeroDeDenominacionesSeleccionadas;
                lbPago.Text = "$" + this.pago.ToString("n2");
                lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");
                numeroDeDenominacionesSeleccionadas = 0;

                panelDenominaciones.Visible = false;
                panelMonedas.Visible = true;

                textBoxCantidad.Text = "$" + pago;
                banderaActivo = true;
            }


        }

        private void btnBillete100_Click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
               // decimal pagado = decimal.Parse(txboxCantidad.Text) + 100;
                //txboxCantidad.Text= "0";
               // agregarNumero(pagado.ToString("n2"));
                dineroNuevo.billetes100 += 1;
                decimal i = 100;
                this.pago += i * numeroDeDenominacionesSeleccionadas;
                lbPago.Text = "$" + this.pago.ToString("n2");
                lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");
                numeroDeDenominacionesSeleccionadas = 0;

                panelDenominaciones.Visible = false;
                panelMonedas.Visible = true;

                textBoxCantidad.Text = "$" + pago;
                banderaActivo = true;
            }


        }

        private void btnBillete200_Click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
               // decimal pagado = decimal.Parse(txboxCantidad.Text) + 200;
                //txboxCantidad.Text= "0";
               // agregarNumero(pagado.ToString("n2"));
                dineroNuevo.billetes200 += 1;

                decimal i = 200;
                this.pago += i * numeroDeDenominacionesSeleccionadas;
                lbPago.Text = "$" + this.pago.ToString("n2");
                lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");
                numeroDeDenominacionesSeleccionadas = 0;

                panelDenominaciones.Visible = false;
                panelMonedas.Visible = true;

                textBoxCantidad.Text = "$" + pago;
                banderaActivo = true;
            }


        }

        private void btnBillete500_Click(object sender, EventArgs e)
        {

            if (banderaActivo)
            {
               // decimal pagado = decimal.Parse(txboxCantidad.Text) + 500;
                //txboxCantidad.Text= "0";
               // agregarNumero(pagado.ToString("n2"));
                dineroNuevo.billetes500 += 1;

                decimal i = 500;
                this.pago += i * numeroDeDenominacionesSeleccionadas;
                lbPago.Text = "$" + this.pago.ToString("n2");
                lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");
                numeroDeDenominacionesSeleccionadas = 0;

                panelDenominaciones.Visible = false;
                panelMonedas.Visible = true;

                textBoxCantidad.Text = "$" + pago;
                banderaActivo = true;

            }


        }

        private void btnPagoTarjeta_Click(object sender, EventArgs e)
        {
            panelTarjeta.Visible = true;
            banderaActivo = false;
            panelMonedas.Visible = false;
            panelDenominaciones.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            banderaCorte = false;
            panelConttra.Visible = true;
            panelAutorizacion.Visible = true;
            panelTec.Visible = true;

            panelExtras.Visible = false;
            //string idDineroCaja = Convert.ToString(ConfigurationManager.AppSettings["codigo_dinero"]);
            //dineroEnCaja = cnn.consultarDineroEnCaja(idDineroCaja);

            //string titulo = "Pre corte de caja";
            //string turno = string.Empty;


            //string idCaja = ConfigurationManager.AppSettings["codigo_caja"];
            //string hora = cnn.consultarFechaHoraInicioCaja(idCaja).Value.Hour.ToString();
            //string horaMatutina = ConfigurationManager.AppSettings["turno matutino"];
            //string horaVespertina = ConfigurationManager.AppSettings["turno vespertino"];

            //if (int.Parse(hora) >= int.Parse(horaMatutina) && int.Parse(hora) < int.Parse(horaVespertina))
            //{
            //    turno = "M";
            //}
            //else
            //{
            //    turno = "V";
            //} 
            
            //Impresora ticket = new Impresora();
            //string fecha = DateTime.Now.ToString("yyyy-dd-MM HH:MM:ss");
            //string fechaStr = DateTime.Now.ToString("dd-MM-yyyy HH:MM:ss");
            //string fechaInicio = cnn.consultarFechaHoraInicioCaja(idCaja).Value.ToString("dd-MM-yyyy HH:MM:ss");
            //decimal fondoInicial = cnn.consultarFondoInicial(idCaja);
           
            //ticket.AbreCajon();
            //ticket.CortaTicket();
            //ticket.TextoIzquierda(titulo);
            //ticket.TextoIzquierda("INICIO CAJA:     " + fechaInicio);
            //ticket.TextoIzquierda("FECHA IMPRESIÓN: " + fechaStr);
            //ticket.TextoIzquierda("SUCURSAL:" + ConfigurationManager.AppSettings["nombre sucursal"]);
            //ticket.TextoIzquierda("CAJERO DE PRE CORTE:" + ConfigurationManager.AppSettings["codigo_trabajador"]);
            //ticket.TextoIzquierda("");


            //decimal dineroEfectivo = 0;
            //decimal dineroTarjeta = 0;

            //if (turno == "M")
            //{

            //    dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCaja("efectivo", idCaja), CultureInfo.InvariantCulture);
            //    dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCaja("tarjeta", idCaja), CultureInfo.InvariantCulture);

            //    ticket.TextoIzquierda("T. Matutino");
            //    ticket.TextoIzquierda("EFECTIVO: " + (cnn.consultarGanaciasTotales(idCaja)).ToString("c2"));
            //    ticket.TextoIzquierda("TARJETA: " + dineroTarjeta.ToString("c2"));
            //    ticket.TextoIzquierda("TOTAL: " + (cnn.consultarGanaciasTotales(idCaja)).ToString("c2"));
            //}
            //else
            //{
            //    dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCaja("efectivo", idCaja), CultureInfo.InvariantCulture);
            //    dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCaja("tarjeta", idCaja), CultureInfo.InvariantCulture);

            //    ticket.TextoIzquierda("T.vespertino");
            //    ticket.TextoIzquierda("EFECTIVO: " + (cnn.consultarGanaciasTotales(idCaja)).ToString("c2"));
            //    ticket.TextoIzquierda("TARJETA: " + dineroTarjeta.ToString("c2"));
            //    ticket.TextoIzquierda("TOTAL: " + (cnn.consultarGanaciasTotales(idCaja)).ToString("c2"));
            //}

            
            //ticket.TextoIzquierda("VENTA TOTAL");
            //ticket.TextoIzquierda("FONDO INICIAL: " + fondoInicial.ToString("c2").Replace(",", "."));
            //ticket.TextoIzquierda("ARQUEO DE CAJA: " + (Convert.ToDecimal(fondoInicial) + cnn.consultarGanaciasTotales(idCaja)).ToString("c2"));
            //ticket.TextoIzquierda("");
            //ticket.TextoExtremos("$500.00", dineroEnCaja.billetes500.ToString());
            //ticket.TextoExtremos("$200.00", dineroEnCaja.billetes200.ToString());
            //ticket.TextoExtremos("$100.00", dineroEnCaja.billetes100.ToString());
            //ticket.TextoExtremos("$50.00", dineroEnCaja.billetes50.ToString());
            //ticket.TextoExtremos("$20.00", dineroEnCaja.billetes20.ToString());
            //ticket.TextoExtremos("$10.00", dineroEnCaja.monedas10.ToString());
            //ticket.TextoExtremos("$5.00", dineroEnCaja.monedas5.ToString());
            //ticket.TextoExtremos("$2.00", dineroEnCaja.monedas2.ToString());
            //ticket.TextoExtremos("$1.00", dineroEnCaja.monedas1.ToString());
            //ticket.TextoExtremos("$0.50", dineroEnCaja.monedas50centavos.ToString());
            //ticket.TextoExtremos("TOTAL: $", dineroEnCaja.cantidad.ToString());
            //ticket.TextoIzquierda("Firma Cajero 1_____________");
            //ticket.TextoDerecha("Firma Encargado ______________");
            //ticket.TextoIzquierda("Firma Cajero 2_____________");

            //ticket.CortaTicket();

            //PrinterSettings settings = new PrinterSettings();

            //ticket.ImprimirTicket(settings.PrinterName);

            //MessageBox.Show("Pre corte");


        }

        private void btnCancelarTarjeta_Click(object sender, EventArgs e)
        {
            
            panelTarjeta.Visible = false;
            txtTarjeta.Text = "0";
            visa = false;
            btnCancelar.Visible = false;
            mastercard = false;
            american = false;
            panelActiveVisa.Visible = false;
            panelActiveMC.Visible = false;
            panelActiveAE.Visible = false;
            lblTipoPago.Text = "efectivo";
            baderaCero = false;
            banderaActivo = true;
            if (banderaPagoDiferido)
                panelCuadreCaja.Visible = true;
            

        }

        private void pBoxVisa_Click(object sender, EventArgs e)
        {
            tipoTarjeta = "Visa";
            
            panelActiveVisa.Visible = !panelActiveVisa.Visible;
            panelActiveAE.Visible = false;
            panelActiveMC.Visible = false;

            visa = panelActiveVisa.Visible;
            mastercard = panelActiveMC.Visible;
            american = panelActiveAE.Visible;

            if (panelActiveVisa.Visible)
            {
                lblTipoPago.Text = "tarjeta " + tipoTarjeta;
            }
            else
            {
/*                banderaActivo = true;
                panelTarjeta.Visible = false;
                numeroTarjeta = "";
                txtTarjeta.Text = "0";
                */
                lblTipoPago.Text = "efectivo";
            }






        }

        private void pBMasterCard_Click(object sender, EventArgs e)
        {
            tipoTarjeta = "Mastercard";

           
            panelActiveVisa.Visible = false;
            panelActiveAE.Visible = false;
            panelActiveMC.Visible = !panelActiveMC.Visible;

            visa = panelActiveVisa.Visible;
            mastercard = panelActiveMC.Visible;
            american = panelActiveAE.Visible;

            if (panelActiveMC.Visible)
            {
                lblTipoPago.Text = "tarjeta " + tipoTarjeta;
            }
            else
            {
             /*   banderaActivo = true;
                panelTarjeta.Visible = false;
                numeroTarjeta = "";
                txtTarjeta.Text = "0";*/
                lblTipoPago.Text = "efectivo";
            }




        }

        private void pBAmerican_Click(object sender, EventArgs e)
        {
            tipoTarjeta = "American Express";

            panelActiveVisa.Visible = false;
            panelActiveAE.Visible = !panelActiveAE.Visible;
            panelActiveMC.Visible = false;

            visa = panelActiveVisa.Visible;
            mastercard = panelActiveMC.Visible;
            american = panelActiveAE.Visible;

            if (panelActiveAE.Visible)
            {
                lblTipoPago.Text = "tarjeta American Express";
            }
            else
            {
              /*  banderaActivo = true;
                panelTarjeta.Visible = false;
                numeroTarjeta = "";
                txtTarjeta.Text = "0";*/
                lblTipoPago.Text = "efectivo";
            }

            
            



        }

        private void btnMoneda10_Click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
               // decimal pagado = decimal.Parse(txboxCantidad.Text) + 10;
                //txboxCantidad.Text= "0";
               // agregarNumero(pagado.ToString("n2"));
                decimal i = Convert.ToDecimal(10);

                this.pago += i * numeroDeDenominacionesSeleccionadas;
                lbPago.Text = "$" + this.pago.ToString("n2");
                lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");
                numeroDeDenominacionesSeleccionadas = 0;
                dineroNuevo.monedas10 += 1;

                panelDenominaciones.Visible = false;
                panelMonedas.Visible = true;

                textBoxCantidad.Text = "$" + pago;
                banderaActivo = true;
            }
        }

        private void btnMoneda5_Click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
               // decimal pagado = decimal.Parse(txboxCantidad.Text) + 5;
                //txboxCantidad.Text= "0";
               // agregarNumero(pagado.ToString("n2"));
                decimal i = Convert.ToDecimal(5);

                this.pago += i * numeroDeDenominacionesSeleccionadas;
                lbPago.Text = "$" + this.pago.ToString("n2");
                lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");
                numeroDeDenominacionesSeleccionadas = 0;
                dineroNuevo.monedas5 += 1;

                panelDenominaciones.Visible = false;
                panelMonedas.Visible = true;

                textBoxCantidad.Text = "$" + pago;
                banderaActivo = true;
            }
        }

        private void btnMoneda2_Click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
               // decimal pagado = decimal.Parse(txboxCantidad.Text) + 2;
                //txboxCantidad.Text= "0";
               // agregarNumero(pagado.ToString("n2"));
                dineroNuevo.monedas2 += 1;

                decimal i = Convert.ToDecimal(2);

                this.pago += i * numeroDeDenominacionesSeleccionadas;
                lbPago.Text = "$" + this.pago.ToString("n2");
                lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");
                numeroDeDenominacionesSeleccionadas = 0;

                panelDenominaciones.Visible = false;
                panelMonedas.Visible = true;

                textBoxCantidad.Text = "$" + pago;
                banderaActivo = true;
            }
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            panelConttra.Visible = true;
            banderaCorte = true;
            panelAutorizacion.Visible = true;
            panelTec.Visible = true;

            panelExtras.Visible = false;
            //string idDineroCaja = Convert.ToString(ConfigurationManager.AppSettings["codigo_dinero"]);
            //dineroEnCaja = cnn.consultarDineroEnCaja(idDineroCaja);

            //string titulo = "Corte de caja";
            //string turno = string.Empty;
            //string idCaja = ConfigurationManager.AppSettings["codigo_caja"];
            //string hora = cnn.consultarFechaHoraInicioCaja(idCaja).Value.Hour.ToString();
            //string horaMatutina = ConfigurationManager.AppSettings["turno matutino"];
            //string horaVespertina = ConfigurationManager.AppSettings["turno vespertino"];

            //if (int.Parse(hora) >= int.Parse(horaMatutina) && int.Parse(hora) < int.Parse(horaVespertina))
            //{
            //    turno = "M";
            //}
            //else
            //{
            //    turno = "V";
            //}

            //Impresora ticket = new Impresora();

            //string fecha = DateTime.Now.ToString("yyyy-dd-MM HH:MM:ss");
            //string fechaStr = DateTime.Now.ToString("dd-MM-yyyy HH:MM:ss");
            //string fechaInicio = cnn.consultarFechaHoraInicioCaja(idCaja).Value.ToString("dd-MM-yyyy HH:MM:ss");
            //decimal fondoInicial = cnn.consultarFondoInicial(idCaja);
            //string ticketInicio = cnn.consultarTicketInicial(idCaja);
            //string ticketFinal = cnn.consultarTicketFinal(idCaja);

            //ticket.AbreCajon();
            //ticket.TextoIzquierda(titulo);
            //ticket.TextoIzquierda("INICIO CAJA:     " + fechaInicio);
            //ticket.TextoIzquierda("FECHA IMPRESIÓN: " + fechaStr);
            //ticket.TextoIzquierda("DEL TICKET: " + ticketInicio + " AL TICKET: " + ticketFinal);
            
            //ticket.TextoIzquierda("SUCURSAL:" + ConfigurationManager.AppSettings["nombre sucursal"]);
            //ticket.TextoIzquierda("CAJERO DE CORTE:" + ConfigurationManager.AppSettings["codigo_trabajador"]);
            //ticket.TextoIzquierda("");

            //decimal dineroEfectivo = 0;
            //decimal dineroTarjeta = 0;

            //if (turno == "M")
            //{

            //    dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCaja("efectivo", idCaja), CultureInfo.InvariantCulture);
            //    dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCaja("tarjeta", idCaja), CultureInfo.InvariantCulture);
            
            //    ticket.TextoIzquierda("T. Matutino");
            //    ticket.TextoIzquierda("EFECTIVO: " + (cnn.consultarGanaciasTotales(idCaja)).ToString("c2"));
            //    ticket.TextoIzquierda("TARJETA: " + dineroTarjeta.ToString("c2"));
            //    ticket.TextoIzquierda("TOTAL: " + (cnn.consultarGanaciasTotales(idCaja)).ToString("c2"));
            //}
            //else
            //{
            //    dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCaja("efectivo", idCaja), CultureInfo.InvariantCulture);
            //    dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCaja("tarjeta", idCaja), CultureInfo.InvariantCulture);
            
            //    ticket.TextoIzquierda("T.vespertino");
            //    ticket.TextoIzquierda("EFECTIVO: " + (cnn.consultarGanaciasCaja("efectivo", idCaja)).ToString("c2"));
            //    ticket.TextoIzquierda("TARJETA: " + dineroTarjeta.ToString("c2"));
            //    ticket.TextoIzquierda("TOTAL: " + (cnn.consultarGanaciasTotales(idCaja)).ToString("c2"));
            
            //}
            //ticket.TextoIzquierda("VENTA TOTAL");

            //ticket.TextoIzquierda("");

            //ticket.TextoIzquierda("TOTAL: " + (cnn.consultarGanaciasCaja("efectivo", idCaja)).ToString("c2"));
            //ticket.TextoIzquierda("FONDO INICIAL: " + fondoInicial.ToString("c2").Replace(",", "."));
            //ticket.TextoIzquierda("ARQUEO DE CAJA: " + (Convert.ToDecimal(fondoInicial) + cnn.consultarGanaciasCaja("efectivo", idCaja)).ToString("c2"));
            
            //ticket.TextoExtremos("$500.00", dineroEnCaja.billetes500.ToString());
            //ticket.TextoExtremos("$200.00", dineroEnCaja.billetes200.ToString());
            //ticket.TextoExtremos("$100.00", dineroEnCaja.billetes100.ToString());
            //ticket.TextoExtremos("$50.00", dineroEnCaja.billetes50.ToString());
            //ticket.TextoExtremos("$20.00", dineroEnCaja.billetes20.ToString());
            //ticket.TextoExtremos("$10.00", dineroEnCaja.monedas10.ToString());
            //ticket.TextoExtremos("$5.00", dineroEnCaja.monedas5.ToString());
            //ticket.TextoExtremos("$2.00", dineroEnCaja.monedas2.ToString());
            //ticket.TextoExtremos("$1.00", dineroEnCaja.monedas1.ToString());
            //ticket.TextoExtremos("$0.50", dineroEnCaja.monedas50centavos.ToString());
            //ticket.TextoExtremos("TOTAL: $", dineroEnCaja.cantidad.ToString());
            //ticket.TextoIzquierda("Firma Cajero 1_____________");
            //ticket.TextoDerecha("Firma Encargado ______________");
            //ticket.TextoIzquierda("Firma Cajero 2_____________");
            //ticket.CortaTicket();

          
            //PrinterSettings settings = new PrinterSettings();

            //ticket.ImprimirTicket(settings.PrinterName);
            


            //string idTienda = ConfigurationManager.AppSettings["id_tienda"];
            
            //cnn.cerrarCaja(fecha, idCaja, dineroEfectivo + dineroTarjeta);
            //MessageBox.Show("Caja cerrada");
            ////Caja cajaCerrada = cnn.consultarEstatusCaja(idTienda);
            //FormLogin login = new FormLogin();
            //login.Show();
            //this.Dispose();
        }

        private void btnMoneda1_Click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
             //   decimal pagado = Convert.ToDecimal(txboxCantidad.Text) + (decimal)1;
                //txboxCantidad.Text= "0";
               // agregarNumero(pagado.ToString("n2"));
                dineroNuevo.monedas1 += 1;

                decimal i = Convert.ToDecimal(1);

                this.pago += i * numeroDeDenominacionesSeleccionadas;
                lbPago.Text = "$" + this.pago.ToString("n2");
                lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");
                numeroDeDenominacionesSeleccionadas = 0;

                panelDenominaciones.Visible = false;
                panelMonedas.Visible = true;

                textBoxCantidad.Text = "$" + pago;
                banderaActivo = true;
            }
        }

        private void btnMoneda50c_Click(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
               // decimal pagado = Convert.ToDecimal(txboxCantidad.Text) + (decimal)0.5;
                //txboxCantidad.Text= "0";
               // agregarNumero(pagado.ToString("n2"));
                
                decimal i = Convert.ToDecimal(0.5);
                dineroNuevo.monedas50centavos += 1;

                this.pago += i * numeroDeDenominacionesSeleccionadas;
                lbPago.Text = "$" + this.pago.ToString("n2");
                lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");
                numeroDeDenominacionesSeleccionadas = 0;

                panelDenominaciones.Visible = false;
                panelMonedas.Visible = true;

                textBoxCantidad.Text = "$" + pago;
                banderaActivo = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            decimal dineroCambio = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture) + 20;

            if (dineroCambio <= (decimal)cambio)
            {
                if (dineroEnCaja.billetes20 > 0)
                {
                    dinero.billetes20 += 1;
                    dineroEnCaja.billetes20 -=1;
                    textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);


                    if (dinero.billetes20 == 1)
                    {
                        ListViewItem Lista = new ListViewItem((dinero.billetes20).ToString());
                        Lista.SubItems.Add("Billetes $20");
                        Lista.Name = "20";
                        listCambio.Items.Add(Lista);
                    }
                    else
                    {
                        ListViewItem item = listCambio.FindItemWithText("Billetes $20");
                        item.Name = "20";
                        item.Text = (dinero.billetes20).ToString();
                    }

                    //descuenta dinero en la caja
                    ListViewItem itemCaja = listDineroEnCaja.FindItemWithText("Billetes $20");

                    itemCaja.Name = "20";
                    itemCaja.Text = (dineroEnCaja.billetes20).ToString();
                }
            }
            else
            {
                MessageBox.Show("No puede dar mas cambio del solicitado");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            decimal dineroCambio = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture) + 50;

            if (dineroCambio <= (decimal)cambio)
            {
                if (dineroEnCaja.billetes50 > 0)
                {
                    dinero.billetes50 += 1;
                    dineroEnCaja.billetes50 -= 1;
                    textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);


                    if (dinero.billetes50 == 1)
                    {
                        ListViewItem Lista = new ListViewItem((dinero.billetes50).ToString());
                        Lista.SubItems.Add("Billetes $50");
                        Lista.Name = "50";
                        listCambio.Items.Add(Lista);
                    }
                    else
                    {
                        ListViewItem item = listCambio.FindItemWithText("Billetes $50");
                        item.Name = "50";
                        item.Text = (dinero.billetes50).ToString();
                    }

                    //descuenta dinero en la caja
                    ListViewItem itemCaja = listDineroEnCaja.FindItemWithText("Billetes $50");

                    itemCaja.Name = "50";
                    itemCaja.Text = (dineroEnCaja.billetes50).ToString();
                }
            }
            else
            {
                MessageBox.Show("No puede dar mas cambio del solicitado");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            decimal dineroCambio = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture) + 100;

            if (dineroCambio <= (decimal)cambio)
            {
                if (dineroEnCaja.billetes100 > 0)
                {
                    dinero.billetes100 += 1;
                    dineroEnCaja.billetes100 -= 1;
                    textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);


                    if (dinero.billetes100 == 1)
                    {
                        ListViewItem Lista = new ListViewItem((dinero.billetes100).ToString());
                        Lista.SubItems.Add("Billetes $100");
                        Lista.Name = "100";
                        listCambio.Items.Add(Lista);
                    }
                    else
                    {
                        ListViewItem item = listCambio.FindItemWithText("Billetes $100");
                        item.Name = "100";
                        item.Text = (dinero.billetes100).ToString();
                    }

                    //descuenta dinero en la caja
                    ListViewItem itemCaja = listDineroEnCaja.FindItemWithText("Billetes $100");

                    itemCaja.Name = "100";
                    itemCaja.Text = (dineroEnCaja.billetes100).ToString();
                }
            }
            else
            {
                MessageBox.Show("No puede dar mas cambio del solicitado");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            decimal dineroCambio = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture) + 200;

            if (dineroCambio <= (decimal)cambio)
            {
                if (dineroEnCaja.billetes200 > 0)
                {
                    dinero.billetes200 += 1;
                    dineroEnCaja.billetes200 -= 1;
                    textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);


                    if (dinero.billetes200 == 1)
                    {
                        ListViewItem Lista = new ListViewItem((dinero.billetes200).ToString());
                        Lista.SubItems.Add("Billetes -> $200");
                        Lista.Name = "200";
                        listCambio.Items.Add(Lista);
                    }
                    else
                    {
                        ListViewItem item = listCambio.FindItemWithText("Billetes -> $200");
                        item.Name = "200";
                        item.Text = (dinero.billetes200).ToString();
                    }

                    //descuenta dinero en la caja
                    ListViewItem itemCaja = listDineroEnCaja.FindItemWithText("Billetes -> $200");

                    itemCaja.Name = "200";
                    itemCaja.Text = (dineroEnCaja.billetes200).ToString();
                }
            }
            else
            {
                MessageBox.Show("No puede dar mas cambio del solicitado");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal dineroCambio = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture) + 500;

            if (dineroCambio <= (decimal)cambio)
            {
                if (dineroEnCaja.billetes500 > 0)
                {
                    dinero.billetes500 += 1;
                    dineroEnCaja.billetes500 -= 1;
                    textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);


                    if (dinero.billetes500 == 1)
                    {
                        ListViewItem Lista = new ListViewItem((dinero.billetes500).ToString());
                        Lista.SubItems.Add("Billetes -> $500");
                        Lista.Name = "500";
                        listCambio.Items.Add(Lista);
                    }
                    else
                    {
                        ListViewItem item = listCambio.FindItemWithText("Billetes -> $500");
                        item.Name = "500";
                        item.Text = (dinero.billetes500).ToString();
                    }

                    //descuenta dinero en la caja
                    ListViewItem itemCaja = listDineroEnCaja.FindItemWithText("Billetes -> $500");

                    itemCaja.Name = "500";
                    itemCaja.Text = (dineroEnCaja.billetes500).ToString();
                }
            }
            else
            {
                MessageBox.Show("No puede dar mas cambio del solicitado");
            }
        }
        
        private void button7_Click_1(object sender, EventArgs e)
        {
            decimal dineroCambio = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture) + 10;

            if (dineroCambio <= (decimal)cambio)
            {
                if (dineroEnCaja.monedas10 > 0)
                {
                    dinero.monedas10 += 1;
                    dineroEnCaja.monedas10 -= 1;
                    textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);


                    if (dinero.monedas10 == 1)
                    {
                        ListViewItem Lista = new ListViewItem((dinero.monedas10).ToString());
                        Lista.SubItems.Add("Monedas -> $10");
                        Lista.Name = "10";
                        listCambio.Items.Add(Lista);
                    }
                    else
                    {
                        ListViewItem item = listCambio.FindItemWithText("Monedas -> $10");
                        item.Name = "10";
                        item.Text = (dinero.monedas10).ToString("n2");
                    }

                    //descuenta dinero en la caja
                    ListViewItem itemCaja = listDineroEnCaja.FindItemWithText("Monedas -> $10");

                    itemCaja.Name = "10";
                    itemCaja.Text = (dineroEnCaja.monedas10).ToString();
                }
            }
            else
            {
                MessageBox.Show("No puede dar mas cambio del solicitado");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal dineroCambio = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture) + 5;
            
            if (dineroCambio <= (decimal)cambio)
            {
                if (dineroEnCaja.monedas5 > 0)
                {
                    dinero.monedas5 += 1;
                    dineroEnCaja.monedas5 -= 1;
                    
                    textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);


                    if (dinero.monedas5 == 1)
                    {
                        ListViewItem Lista = new ListViewItem((dinero.monedas5).ToString());
                        Lista.SubItems.Add("Monedas $5");
                        Lista.Name = "5";
                        listCambio.Items.Add(Lista);
                    }
                    else
                    {
                        ListViewItem item = listCambio.FindItemWithText("Monedas $5");
                        item.Name = "5";
                        item.Text = (dinero.monedas5).ToString();
                    }

                    //descuenta dinero en la caja
                    ListViewItem itemCaja = listDineroEnCaja.FindItemWithText("Monedas $5");

                    itemCaja.Name = "5";
                    itemCaja.Text = (dineroEnCaja.monedas5).ToString();
                }
            }
            else
            {
                MessageBox.Show("No puede dar mas cambio del solicitado");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal dineroCambio = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture) + 2;

            if (dineroCambio <= (decimal)cambio)
            {
                if (dineroEnCaja.monedas2 > 0)
                {
                    dinero.monedas2 += 1;
                    dineroEnCaja.monedas2 -= 1;
                    textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);


                    if (dinero.monedas2 == 1)
                    {
                        ListViewItem Lista = new ListViewItem((dinero.monedas2).ToString());
                        Lista.SubItems.Add("Monedas $2");
                        Lista.Name = "2";
                        listCambio.Items.Add(Lista);
                    }
                    else
                    {
                        ListViewItem item = listCambio.FindItemWithText("Monedas $2");
                        item.Name = "2";
                        item.Text = (dinero.monedas2).ToString();
                    }

                    //descuenta dinero en la caja
                    ListViewItem itemCaja = listDineroEnCaja.FindItemWithText("Monedas $2");

                    itemCaja.Name = "2";
                    itemCaja.Text = (dineroEnCaja.monedas2).ToString();
                }
            }
            else
            {
                MessageBox.Show("No puede dar mas cambio del solicitado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal dineroCambio = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture) + 1;

            if (dineroCambio <= (decimal)cambio)
            {
                if (dineroEnCaja.monedas1 > 0)
                {
                    dinero.monedas1 += 1;
                    dineroEnCaja.monedas1 -= 1;
                    textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);


                    if (dinero.monedas1 == 1)
                    {
                        ListViewItem Lista = new ListViewItem((dinero.monedas1).ToString());
                        Lista.SubItems.Add("Monedas $1");
                        Lista.Name = "1";
                        listCambio.Items.Add(Lista);
                    }
                    else
                    {
                        ListViewItem item = listCambio.FindItemWithText("Monedas $1");
                        item.Name = "1";
                        item.Text = (dinero.monedas1).ToString();
                    }

                    //descuenta dinero en la caja
                    ListViewItem itemCaja = listDineroEnCaja.FindItemWithText("Monedas $1");

                    itemCaja.Name = "1";
                    itemCaja.Text = (dineroEnCaja.monedas1).ToString();
                }
            }
            else
            {
                MessageBox.Show("No puede dar mas cambio del solicitado");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal dineroCambio = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture) + (decimal)0.5;

            if (dineroCambio <= (decimal)cambio)
            {
                if (dineroEnCaja.monedas50centavos > 0)
                {
                    dinero.monedas50centavos += 1;
                    dineroEnCaja.monedas50centavos -= 1;
                    textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);


                    if (dinero.monedas50centavos == 1)
                    {
                        ListViewItem Lista = new ListViewItem((dinero.monedas50centavos).ToString());
                        Lista.SubItems.Add("Monedas $0.50");
                        Lista.Name = "0.50";
                        listCambio.Items.Add(Lista);
                    }
                    else
                    {
                        ListViewItem item = listCambio.FindItemWithText("Monedas $0.50");
                        item.Name = "0.50";
                        item.Text = (dinero.monedas50centavos).ToString();
                    }

                    //descuenta dinero en la caja
                    ListViewItem itemCaja = listDineroEnCaja.FindItemWithText("Monedas $0.50");

                    itemCaja.Name = "0.50";
                    itemCaja.Text = (dineroEnCaja.monedas50centavos).ToString();
                }
            }
            else
            {
                MessageBox.Show("No puede dar mas cambio del solicitado");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listCambio.Items)
            {
                int numero = int.Parse(item.Text);
                numero -= 1;
                decimal valorAQuitarDeLaCaja = Convert.ToDecimal(item.Name, CultureInfo.InvariantCulture);
                decimal valorEnCaja = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture);
                valorEnCaja = valorEnCaja - valorAQuitarDeLaCaja;
                textBoxCambio.Text = Convert.ToString(valorEnCaja, CultureInfo.InvariantCulture);
                if (numero <= 0)
                {
                    numero = 0;
                    item.Remove();
                }

                item.Text = numero.ToString();

                string subitemText = item.SubItems[1].Text;
                ListViewItem itemCaja = listDineroEnCaja.FindItemWithText(subitemText);

                itemCaja.Text = (numero + 1).ToString();
                string opcion = itemCaja.Name;
                switch (opcion)
                {
                    case "500":
                        dineroEnCaja.billetes500 = dinero.billetes500;
                        break;
                    case "200":
                        dineroEnCaja.billetes200 = dinero.billetes200;
                        break;
                    case "100":
                        dineroEnCaja.billetes100 = dinero.billetes100;
                        break;
                    case "50":
                        dineroEnCaja.billetes50 = dinero.billetes50;
                        break;
                    case "20":
                        dineroEnCaja.billetes20 = dinero.billetes20;
                        break;
                    case "10":
                        dineroEnCaja.monedas10 = dinero.monedas10;
                        break;
                    case "5":
                        dineroEnCaja.monedas5 = dinero.monedas5;
                        break;
                    case "2":
                        dineroEnCaja.monedas2 = dinero.monedas2;
                        break;
                    case "1":
                        dineroEnCaja.monedas1 = dinero.monedas1;
                        break;
                    case "0.50":
                        dineroEnCaja.monedas50centavos = dinero.monedas50centavos;
                        
                        break;
                }
                
            }

            dinero.reiniciarCuenta();
            textBoxCambio.Text = "0";
            listCambio.Items.Clear();
        }

        private void cancelarCambio_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listCambio.SelectedItems)
            {
                int numero = int.Parse(item.Text);
                numero -= 1;
                decimal valorAQuitarDeLaCaja = Convert.ToDecimal(item.Name, CultureInfo.InvariantCulture);
                decimal valorEnCaja = Convert.ToDecimal(textBoxCambio.Text, CultureInfo.InvariantCulture);
                valorEnCaja = valorEnCaja - valorAQuitarDeLaCaja;
                textBoxCambio.Text = Convert.ToString(valorEnCaja, CultureInfo.InvariantCulture);
                if (numero <= 0)
                {
                    numero = 0;
                    item.Remove();
                }

                item.Text = numero.ToString();

                string subitemText = item.SubItems[1].Text;
                ListViewItem itemCaja = listDineroEnCaja.FindItemWithText(subitemText);
                
                itemCaja.Text = (numero + 1).ToString();
                string opcion = itemCaja.Name;
                switch (opcion)
                {
                    case "500":
                        dineroEnCaja.billetes500 += 1;
                        dinero.billetes500 -= 1;
                        break;
                    case "200":
                        dineroEnCaja.billetes200 += 1;
                        dinero.billetes200 -= 1;
                        break;
                    case "100":
                        dineroEnCaja.billetes100 += 1;
                        dinero.billetes100 -= 1;
                        break;
                    case "50":
                        dineroEnCaja.billetes50 += 1;
                        dinero.billetes50 -= 1;
                        break;
                    case "20":
                        dineroEnCaja.billetes20 += 1;
                        dinero.billetes20 -= 1;
                        break;
                    case "10":
                        dineroEnCaja.monedas10 += 1;
                        dinero.monedas10 -= 1;
                        break;
                    case "5":
                        dineroEnCaja.monedas5 += 1;
                        dinero.monedas5 -= 1;
                        break;
                    case "2":
                        dineroEnCaja.monedas2 += 1;
                        dinero.monedas2 -= 1;
                        break;
                    case "1":
                        dineroEnCaja.monedas1 += 1;
                        dinero.monedas1 -= 1;
                        break;
                    case "0.50":
                        dineroEnCaja.monedas50centavos += 1;
                        dinero.monedas50centavos -= 1;
                        break;
                }

            }
        }

        private void panelCambioDash_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {

            panelExtras.Visible = true;
           
        }

        private void bebidaClic(object sender, EventArgs e)
        {
            banderaBeb = true;
            banderaActivo = true;
            panelRefresco.Visible = true;
            panelExtras.Visible = false;
            crearBotonesProductos(((Button)sender).Name, panelRefresco, true);

            if (personasCmoplemento > 1)
            {
                int fila = dFilasComplementos[((Button)sender)];

                IList<Button> listaBotones = dFilasComplementos.Where(dic => dic.Value == fila).Select(s => s.Key).ToList();
               // IList<Button> lBotones = dFilasComplementos.Where(filas => filas.Value = fila).ToList();
                foreach (Button btn in listaBotones)
                {
                    btn.Enabled = false;
                }
                
            }
        }


        private void btnExtraSolo(object sender, EventArgs e)
        {
            if (personasCmoplemento >= 1)
            {
                int fila = dFilasComplementos[((Button)sender)];

                IList<Button> listaBotones = dFilasComplementos.Where(dic => dic.Value == fila).Select(s => s.Key).ToList();
                // IList<Button> lBotones = dFilasComplementos.Where(filas => filas.Value = fila).ToList();
                foreach (Button btn in listaBotones)
                {
                    btn.Enabled = false;
                }

                personasCmoplemento -= 1;
                if (personasCmoplemento <= 0)
                {
                    personasCmoplemento = 0;
                    panelExtras.Visible = false;
                    panelExtras.Controls.Clear();
                    banderaActivo = true;
                    crearBotonesProductos(comboSeleccionadoObj.idFamilia.ToString(), panel1);
                    comboSeleccionadoObj = null;
                }

            }
            else
            {
                panelExtras.Visible = false;
                panelExtras.Controls.Clear();
                banderaActivo = true;
                crearBotonesProductos(comboSeleccionadoObj.idFamilia.ToString(), panel1);
                comboSeleccionadoObj = null;
           
            }
        }

        private void panelCambio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelarDash_Click(object sender, EventArgs e)
        {
            panelCambio.Visible = false;
            dineroEnCaja.reiniciarCuenta();
            dinero.reiniciarCuenta();
            decimal dineroCambio = 0;
            textBoxCambio.Text = Convert.ToString(dineroCambio, CultureInfo.InvariantCulture);
            listCambio.Items.Clear();
            listDineroEnCaja.Items.Clear();
            banderaActivo = true;

            panelMonedas.Visible = true;
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtTarjeta.Text = "0";
            baderaCero = false;
        }

        private void tarjeta_Click(object sender, EventArgs e)
        {
            if (!(txtTarjeta.Text == string.Empty) && (txtTarjeta.Text != "0") && txtTarjeta.Text.ToCharArray().Count() == 4)
            {
                banderaActivo = true;
                panelTarjeta.Visible = false;
                numeroTarjeta = txtTarjeta.Text;
                baderaCero = false;

                if (banderaPagoDiferido == false)
                {
                    string codigoEmpleado = ConfigurationManager.AppSettings["codigo_trabajador"];
                    string idTienda = ConfigurationManager.AppSettings["id_tienda"];
                    string idCaja = ConfigurationManager.AppSettings["codigo_caja"];

                    Venta venta = new Venta(Convert.ToInt32(codigoEmpleado), Convert.ToInt32(idTienda));
                    venta.codigoEmpleado = Convert.ToInt32(codigoEmpleado);
                    venta.idTienda = Convert.ToInt32(idTienda);
                    venta.total = total;
                    //-------------------------------------------------------------------------------------------------
                    calcularMetodosPagos(total);
                    if (cnn.registrarVenta(venta, lProductosComprados, lFormasPago, idCaja))
                    {
                        pago = total;
                        descontarProductos();
                        MessageBox.Show("Vendido");
                        imprimirTicket(venta);
                        // imprimirTicket(venta);
                        imprimirComanda(venta);
                        listaPed.Items.Clear();
                        lProductosComprados.Clear();
                        lFormasPago.Clear();

                        //txboxCantidad.Text= "0";
                        this.pago = 0;
                        this.total = 0;
                        this.porPagar = 0;
                        this.panelMonedas.Visible = false;
                        banderaActivo = true;
                        lbPago.Text = "$0";
                        lbSubTotal.Text = "$0";
                        lbPorPagar.Text = lbSubTotal.Text;
                        visa = panelActiveVisa.Visible;
                        mastercard = panelActiveMC.Visible;
                        american = panelActiveAE.Visible;

                        FormTomaOrden pantallaTomaOrden = new FormTomaOrden();
                        pantallaTomaOrden.Show();
                        this.Dispose();
                    }
                }
                else
                {
                    if (banderaPagoDiferido)
                    {
                        panelTarjeta.Visible = false;
                        panelCuadreCaja.Visible = true;
                        btnEfectivoCuadre.Enabled = true;
                        btnTarjetaCuadre.Enabled = false;
                        panelTarjetaCuadre.Visible = true;
                        panelEfectivoCuadre.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingresa los ultimos 4 digitos de la tarjeta");
            }
        }

        private void panelExtras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            panelMonedas.Visible = false;
            panelDenominaciones.Visible = true;
            textBoxMonedas.Text = "";
            
        }

        private void btnAceptarAuto_Click(object sender, EventArgs e)
        {
            if (txtContra.Text == "") { return; }
            int contra = int.Parse(txtContra.Text);
            if (privilegios(contra))
            {
                if (banderaCorte == false)
                //precorte
                {
                    string idDineroCaja = Convert.ToString(ConfigurationManager.AppSettings["codigo_dinero"]);
                    dineroEnCaja = cnn.consultarDineroEnCaja(idDineroCaja);

                    string titulo = "Subtotal";
                    string turno = string.Empty;


                    string idCaja = ConfigurationManager.AppSettings["codigo_caja"];
                    string hora = cnn.consultarFechaHoraInicioCaja(idCaja).Value.Hour.ToString();
                    string horaMatutina = ConfigurationManager.AppSettings["turno matutino"];
                    string horaVespertina = ConfigurationManager.AppSettings["turno vespertino"];
                    decimal fondoInicial = cnn.consultarFondoInicial(idCaja);
                    string fechaInicio = cnn.consultarFechaHoraInicioCaja(idCaja).Value.ToString("dd-MM-yyyy HH:MM:ss");
                    string fechaStr = DateTime.Now.ToString("dd-MM-yyyy HH:MM:ss");
                    string fecha = DateTime.Now.ToString("yyyy-dd-MM HH:MM:ss");
                    decimal dineroEfectivo = 0;
                    decimal dineroTarjeta = 0;

                    dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCaja("tarjeta", idCaja), CultureInfo.InvariantCulture);
                    dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCaja("efectivo", idCaja), CultureInfo.InvariantCulture);
                    

                    if (int.Parse(hora) >= int.Parse(horaMatutina) && int.Parse(hora) < int.Parse(horaVespertina))
                    {
                        turno = "M";
                    }
                    else
                    {
                        turno = "V";
                    }

                    Impresora ticket = new Impresora();

                  /*  ticket.TextoIzquierda("");

                    ticket.TextoIzquierda("");

                    ticket.TextoIzquierda("");
                    */
                    ticket.TextoIzquierda("Firma Cajero 2_____________");
                    ticket.TextoDerecha("Firma Encargado ______________");
                    ticket.TextoIzquierda("Firma Cajero 1_____________");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("ARQUEO DE CAJA: " + (Convert.ToDecimal(fondoInicial) + cnn.consultarGanaciasTotales(idCaja)).ToString("c2"));
                    ticket.TextoIzquierda("FONDO INICIAL: " + fondoInicial.ToString("c2").Replace(",", "."));
                    ticket.TextoIzquierda("VENTA TOTAL");
                    ticket.TextoIzquierda("TOTAL: " + (cnn.consultarGanaciasTotales(idCaja)).ToString("c2"));
                    ticket.TextoIzquierda("TARJETA: " + dineroTarjeta.ToString("c2"));
                    ticket.TextoIzquierda("EFECTIVO: " + dineroEfectivo.ToString("c2"));
                    ticket.TextoIzquierda("TICKET PROMEDIO: " + cnn.consultarTiketPromedio(idCaja).ToString("c2"));
                    ticket.TextoIzquierda("TRANSACCIONES: " + cnn.consultarTransacciones(idCaja));
                    ticket.TextoIzquierda("TICKETS: " + cnn.consultarTicketInicial(idCaja) + " al " + cnn.consultarTicketFinal(idCaja));
                    if (turno == "M")
                    {
                        ticket.TextoIzquierda("T. Matutino");
                    }
                    else
                    {
                        ticket.TextoIzquierda("T.vespertino");
                    }
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("CAJERO DE SUBTOTAL:" + ConfigurationManager.AppSettings["codigo_trabajador"]);
                    ticket.TextoIzquierda("SUCURSAL:" + ConfigurationManager.AppSettings["nombre sucursal"]);
                    ticket.TextoIzquierda("FECHA IMPRESIÓN: " + fechaStr);
                    ticket.TextoIzquierda("INICIO CAJA:     " + fechaInicio);
                    ticket.TextoIzquierda(titulo);

                  /*  ticket.TextoIzquierda("");

                    ticket.TextoIzquierda("");

                    ticket.TextoIzquierda("");

                    ticket.TextoIzquierda("");
                    */ticket.CortaTicket();

                    PrinterSettings settings = new PrinterSettings();

                    ticket.ImprimirTicket(settings.PrinterName);
                    MessageBox.Show("Imprimiendo...");

                }
                //CORTE 
                else
                {
                    panelCuadreCaja.Visible = true;
                  
            
            //        panelCuadreCaja.Visible = true;

                }
            }

            panelConttra.Visible = false;
            panelTec.Visible = false;
            panelAutorizacion.Visible = false;
            txtContra.Text = "";
        }

        private void btnNumeroCuadre(object sender, EventArgs e)
        {
            if (textBoxCuadreIndique.Text == "0")
            {
                textBoxCuadreIndique.Text = ((Button)sender).Text;
            }
            else
            {
                textBoxCuadreIndique.Text += ((Button)sender).Text;
            }
        }


        private void btnTarjetaCuadreClic(object sender, EventArgs e)
        {
            if (textBoxTarjetaCuadre.Text == "0")
            {
                textBoxTarjetaCuadre.Text = ((Button)sender).Text;
            }
            else
            {
                textBoxTarjetaCuadre.Text += ((Button)sender).Text;
            }
        }


        private void btnCantidadDenominacionCuadre(object sender, EventArgs e)
        {
            

            int cantidad = int.Parse(textBoxCuadreIndique.Text);

            decimal valor = Convert.ToDecimal(((Button)sender).Text.Replace("$", ""), CultureInfo.InvariantCulture);
            if(cantidad > 0 ){

                switch (valor.ToString())
                {
                    case "500":
                        dineroCuadre.billetes500 = cantidad;
                        break;
                    case "200":
                        dineroCuadre.billetes200 = cantidad;
                        break;
                    case "100":
                        dineroCuadre.billetes100 = cantidad;
                        break;
                    case "50":
                        dineroCuadre.billetes50 = cantidad;
                        break;
                    case "20":
                        dineroCuadre.billetes20 = cantidad;
                        break;
                    case "10":
                        dineroCuadre.monedas10 = cantidad;
                        break;
                    case "5":
                        dineroCuadre.monedas5 = cantidad;
                        break;
                    case "2":
                        dineroCuadre.monedas2 = cantidad;
                        break;
                    case "1":
                        dineroCuadre.monedas1 = cantidad;
                        break;
                    case "0.5":
                        dineroCuadre.monedas50centavos = cantidad;
                        break;
                }
                ListViewItem Lista = new ListViewItem(cantidad.ToString() + " x $"+ valor);
                Lista.SubItems.Add("Efectivo");
                Lista.SubItems.Add((cantidad * valor).ToString());
                Lista.Name = "e," + (cantidad * valor).ToString();
                listViewCuadreCaja.Items.Add(Lista);
                textBoxCuadreIndique.Text = "0";
                labelEfectivoCuadre.Text = (Convert.ToDecimal(labelEfectivoCuadre.Text) + (cantidad * valor)).ToString();
                labelTotalCuadre.Text = (decimal.Parse(labelTarjetaCuadre.Text) + decimal.Parse(labelEfectivoCuadre.Text)).ToString();
                if (banderaActivo)
                {
                    decimal totalPagar = Convert.ToDecimal(labelTotalPagarDiferido.Text.Replace("$", ""), CultureInfo.InvariantCulture) - Convert.ToDecimal(labelTotalCuadre.Text.Replace("$", ""), CultureInfo.InvariantCulture);
                   
                    if(totalPagar < 0 )
                        totalPagar = 0;

                    labelRestanteDiferido.Text = totalPagar.ToString("c2");
                }

               
            }
           
        }


        private void btnCancelarAuto_Click(object sender, EventArgs e)
        {
            panelConttra.Visible = false;
            panelTec.Visible = false;
            panelAutorizacion.Visible = false;
            txtContra.Text = "";
        }

        private void agregarNumeroTecladoContra(object sender, EventArgs e)
        {
            txtContra.Text += ((Button) sender).Text;

        }
       
        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtContra.Text += ".";
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {
            txtContra.Text = "";
        }

        private void button16_Click_2(object sender, EventArgs e)
        {
            if (banderaActivo)
            {
                textBoxMonedas.Text = "";
            } 
            

        }

        private void panelCorte_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtVerCorte_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCorteAceptar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Dispose();
        }

        public void descontarProductos()
        {
            foreach (Producto producto in lProductosComprados)
            {
                IList<Receta> ingredientes = lReceta.Where(ingrediente => ingrediente.idReceta == producto.idReceta).ToList();
                foreach (Receta descontado in ingredientes)
                {
                    InventarioIng invlocal = lDescInv.Where(invProd => invProd.idIngrediente== descontado.idIngrediente).FirstOrDefault();
                    invlocal.salidas += descontado.cantidadRequerida;
                    invlocal.inventarioFinal -= descontado.cantidadRequerida;
                    
                    cnn.VentaInventario(invlocal.salidas,invlocal.inventarioFinal,invlocal.idInventario);

                }
            }
        }
        public bool existencias()
        {
            bool existencia = false;
            foreach (Producto producto in lProductosComprados)
            {
                IList<Receta> ingredientes = lReceta.Where(ingrediente => ingrediente.idReceta == producto.idReceta).ToList();
                foreach (Receta descontado in ingredientes)
                {
                    InventarioIng invlocal = lDescInv.Where(invProd => invProd.idIngrediente == descontado.idIngrediente).FirstOrDefault();
                    if (invlocal.inventarioFinal <= invlocal.minimo)
                    {
                        Ingredientes localIngre = lingredientes.Where(ingre => ingre.idIngrediente == invlocal.idIngrediente).FirstOrDefault();
                        //MessageBox.Show("NECESITA HACER UN PEDIDO DE " + localIngre.descripcion.ToString());
                    }
                    else
                    {
                        existencia = true;
                    }
                }

             }
            return existencia;
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            textboxDineroCa.Text = "0";
            string pag = textboxDineroCa.Text;
            this.pago = decimal.Parse(pag);
            lbPago.Text = "$" + this.pago.ToString("n2");
            lbPorPagar.Text = "$" + ((total - this.pago) < 0 ? 0 : (total - this.pago)).ToString("n2");

        }
        public bool privilegios(int contra)
        {
            bool permiso = false;
            try
            {
                Usuario gerente = cnn.consultarUsuario(contra);
                if(gerente!=null)
                {
                    foreach (Privilegio privilegio in gerente.lPermisos)
                    {
                        if (privilegio.idPrivilegio == 1)
                        {
                            permiso = true;
                        }
                    }
                    if(permiso == false)
                        {
                        MessageBox.Show("Este usuario tampoco tiene los permisos requeridos");
                        }
                }
                else
                {
                    MessageBox.Show("Usuario invalido");
                }
            }
            catch
            {

            }
            
            return permiso;
        }

        private void btnCCuadre_Click(object sender, EventArgs e)
        {
            textBoxCuadreIndique.Text = "0";
        }

        private void btnTarjetaCuadre_Click(object sender, EventArgs e)
        {
           // if (banderaPagoDiferido == false)
            //{

            if (banderaPagoDiferido)
            {
                panelTarjeta.Visible = true;
                panelCuadreCaja.Visible = false;
            }
            else
            {
                btnEfectivoCuadre.Enabled = true;
                btnTarjetaCuadre.Enabled = false;
                panelTarjetaCuadre.Visible = true;
                panelEfectivoCuadre.Visible = false;
            }
         /*   }
            else
            {

            }*/
        }

        private void btnEfectivoCuadre_Click(object sender, EventArgs e)
        {
            btnEfectivoCuadre.Enabled = false;
            btnTarjetaCuadre.Enabled = true;
            panelTarjetaCuadre.Visible = false;
            panelEfectivoCuadre.Visible = true;
        }

        private void btncCuadreTarjeta_Click(object sender, EventArgs e)
        {
            textBoxTarjetaCuadre.Text = "0";
        }

        private void btnOkCuadreTarjeta_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(textBoxTarjetaCuadre.Text) > 0)
            {

                ListViewItem Lista = new ListViewItem(" ");
                Lista.SubItems.Add("Tarjeta");
                Lista.SubItems.Add((textBoxTarjetaCuadre.Text).ToString());
                Lista.Name = "t," + textBoxTarjetaCuadre.Text;
                listViewCuadreCaja.Items.Add(Lista);
                labelTarjetaCuadre.Text = (Convert.ToDecimal(labelTarjetaCuadre.Text) + (decimal.Parse(textBoxTarjetaCuadre.Text))).ToString();
                textBoxTarjetaCuadre.Text = "0";
                labelTotalCuadre.Text = (decimal.Parse(labelTarjetaCuadre.Text) + decimal.Parse(labelEfectivoCuadre.Text)).ToString();

                if (banderaActivo)
                {
                    decimal totalPagar = Convert.ToDecimal(labelTotalPagarDiferido.Text.Replace("$", ""), CultureInfo.InvariantCulture) - Convert.ToDecimal(labelTotalCuadre.Text.Replace("$", ""), CultureInfo.InvariantCulture);

                    if (totalPagar < 0)
                        totalPagar = 0;

                    labelRestanteDiferido.Text = totalPagar.ToString("c2");
                }
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewCuadreCaja.SelectedItems)
            {
                string valorAQuitarDeLaCaja = item.Name;

                string[] row = valorAQuitarDeLaCaja.Split(',');
                if (row[0] == "t")
                {
                    labelTarjetaCuadre.Text = (Convert.ToDecimal(labelTarjetaCuadre.Text) - (decimal.Parse(row[1]))).ToString();
                
                }
                else if (row[0] == "e")
                {
                    labelEfectivoCuadre.Text = (Convert.ToDecimal(labelEfectivoCuadre.Text) - (decimal.Parse(row[1]))).ToString();
                
                }
                item.Remove();
                labelTotalCuadre.Text = (decimal.Parse(labelTarjetaCuadre.Text) + decimal.Parse(labelEfectivoCuadre.Text)).ToString();
                
            }

            if (banderaActivo)
            {
                decimal totalPagar = Convert.ToDecimal(labelTotalPagarDiferido.Text.Replace("$", ""), CultureInfo.InvariantCulture) - Convert.ToDecimal(labelTotalCuadre.Text.Replace("$", ""), CultureInfo.InvariantCulture);

                if (totalPagar < 0)
                    totalPagar = 0;

                labelRestanteDiferido.Text = totalPagar.ToString("c2");
            }
        }

        private void btnCajaCuadre_Click(object sender, EventArgs e)
        {
            
           
            if (banderaCierreDia == false)
            {


                realizarRetiro();
                panelCuadreCaja.Visible = false;
                panelCorte.Visible = true;
            }
            else
            {
                cierreDiaTicket();
            }
           
        }

        private string realizarRetiro()
        {
            string idDineroCaja = Convert.ToString(ConfigurationManager.AppSettings["codigo_dinero"]);
            cnn.actualizarDineroCaja(dineroCuadre, idDineroCaja);
            dineroEnCaja = cnn.consultarDineroEnCaja(idDineroCaja);

            string titulo = "RETIRO";
            string turno = string.Empty;
            string idCaja = ConfigurationManager.AppSettings["codigo_caja"];
            string hora = cnn.consultarFechaHoraInicioCaja(idCaja).Value.Hour.ToString();
            string horaMatutina = ConfigurationManager.AppSettings["turno matutino"];
            string horaVespertina = ConfigurationManager.AppSettings["turno vespertino"];

            if (int.Parse(hora) >= int.Parse(horaMatutina) && int.Parse(hora) < int.Parse(horaVespertina))
            {
                turno = "M";
            }
            else
            {
                turno = "V";
            }

            Impresora ticket = new Impresora();
         /*   ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            */
            string fecha = DateTime.Now.ToString("yyyy-dd-MM HH:MM:ss");
            string fechaStr = DateTime.Now.ToString("dd-MM-yyyy HH:MM:ss");
            string fechaInicio = cnn.consultarFechaHoraInicioCaja(idCaja).Value.ToString("dd-MM-yyyy HH:MM:ss");
            decimal fondoInicial = cnn.consultarFondoInicial(idCaja);
            string ticketInicio = cnn.consultarTicketInicial(idCaja);
            string ticketFinal = cnn.consultarTicketFinal(idCaja);


            decimal dineroEfectivo = 0;
            decimal dineroTarjeta = 0;

            dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCaja("efectivo", idCaja), CultureInfo.InvariantCulture);
            dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCaja("tarjeta", idCaja), CultureInfo.InvariantCulture);

            ticket.TextoIzquierda("Firma Encargado _____________");
            ticket.TextoIzquierda("Firma Cajero 2  _____________");
            ticket.TextoIzquierda("Firma Cajero 1  _____________");
            decimal sfCantidad = dineroCuadre.cantidad - dineroEfectivo;
            if (sfCantidad < 0)
            {
                ticket.TextoIzquierda("FALTANTE " + sfCantidad.ToString("c2"));
            }
            else if (sfCantidad > 0)
            {
                ticket.TextoIzquierda("SOBRANTE " + sfCantidad.ToString("c2"));
            }
            ticket.lineasIgual();
            ticket.TextoIzquierda("TOTAL EN CAJA: " + (Convert.ToDecimal(fondoInicial) + dineroCuadre.cantidad).ToString("c2"));
            ticket.TextoIzquierda("FONDO INICIAL: " + fondoInicial.ToString("c2").Replace(",", "."));
            ticket.TextoIzquierda("TICKET PROMEDIO: " + cnn.consultarTiketPromedio(idCaja).ToString("c2"));
            ticket.TextoIzquierda("TRANSACCIONES: " + cnn.consultarTransacciones(idCaja));
            ticket.TextoIzquierda("TICKETS: " + cnn.consultarTicketInicial(idCaja) + " al " + cnn.consultarTicketFinal(idCaja));
            ticket.TextoIzquierda("TOTAL de venta: " + (dineroEfectivo + dineroTarjeta).ToString("c2"));
            ticket.TextoIzquierda("venta con TARJETA: " + dineroTarjeta.ToString("c2"));
            ticket.TextoIzquierda("venta en EFECTIVO: " + dineroEfectivo.ToString("c2"));
            ticket.TextoExtremos("$0.50   x " + dineroEnCaja.monedas50centavos.ToString(), ((decimal)0.5 * dineroEnCaja.monedas50centavos).ToString());
            ticket.TextoExtremos("$1.00   x " + dineroEnCaja.monedas1.ToString(), (1 * dineroEnCaja.monedas1).ToString());
            ticket.TextoExtremos("$2.00   x " + dineroEnCaja.monedas2.ToString(), (2 * dineroEnCaja.monedas2).ToString());
            ticket.TextoExtremos("$5.00   x " + dineroEnCaja.monedas5.ToString(), (5 * dineroEnCaja.monedas5).ToString());
            ticket.TextoExtremos("$10.00  x " + dineroEnCaja.monedas10.ToString(), (10 * dineroEnCaja.monedas10).ToString());
            ticket.TextoExtremos("$20.00  x " + dineroEnCaja.billetes20.ToString(), (20 * dineroEnCaja.billetes20).ToString());
            ticket.TextoExtremos("$50.00  x " + dineroEnCaja.billetes50.ToString(), (50 * dineroEnCaja.billetes50).ToString());
            ticket.TextoExtremos("$100.00 x " + dineroEnCaja.billetes100.ToString(), (100 * dineroEnCaja.billetes100).ToString());
            ticket.TextoExtremos("$200.00 x " + dineroEnCaja.billetes200.ToString(), (200 * dineroEnCaja.billetes200).ToString());
            ticket.TextoExtremos("$500.00 x " + dineroEnCaja.billetes500.ToString(), (500 * dineroEnCaja.billetes500).ToString());
            ticket.lineasIgual();
            if (turno == "M")
            {
                ticket.TextoIzquierda("T. Matutino");
            }
            else
            {

                ticket.TextoIzquierda("T.vespertino");
            }
            ticket.TextoIzquierda("CAJERO DE CORTE:" + ConfigurationManager.AppSettings["codigo_trabajador"]);
            ticket.TextoIzquierda("SUCURSAL:" + ConfigurationManager.AppSettings["nombre sucursal"]);
            ticket.TextoIzquierda("FECHA IMPRESIÓN: " + fechaStr);
            ticket.TextoIzquierda(titulo);
/*
            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");
            */
            ticket.CortaTicket();


            PrinterSettings settings = new PrinterSettings();
            

            ticket.ImprimirTicket(settings.PrinterName);


            


            string idTienda = ConfigurationManager.AppSettings["id_tienda"];

            cnn.cerrarCaja(fecha, idCaja, dineroCuadre.cantidad, sfCantidad);
            //Caja cajaCerrada = cnn.consultarEstatusCaja(idTienda);

            ticket = new Impresora();
            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");


            fecha = DateTime.Now.ToString("yyyy-dd-MM HH:MM:ss");
            fechaStr = DateTime.Now.ToString("dd-MM-yyyy HH:MM:ss");
            fechaInicio = cnn.consultarFechaHoraInicioCaja(idCaja).Value.ToString("dd-MM-yyyy HH:MM:ss");
            fondoInicial = cnn.consultarFondoInicial(idCaja);
            ticketInicio = cnn.consultarTicketInicial(idCaja);
            ticketFinal = cnn.consultarTicketFinal(idCaja);


            ticket.AbreCajon();
            ticket.TextoIzquierda(titulo);
            //ticket.TextoIzquierda("INICIO CAJA:     " + fechaInicio);
            ticket.TextoIzquierda("FECHA IMPRESIÓN: " + fechaStr);
            //ticket.TextoIzquierda("DEL TICKET: " + ticketInicio + " AL TICKET: " + ticketFinal);

            ticket.TextoIzquierda("SUCURSAL:" + ConfigurationManager.AppSettings["nombre sucursal"]);
            ticket.TextoIzquierda("CAJERO DE CORTE:" + ConfigurationManager.AppSettings["codigo_trabajador"]);
            //ticket.TextoIzquierda("");

            dineroEfectivo = 0;
            dineroTarjeta = 0;

            dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCaja("efectivo", idCaja), CultureInfo.InvariantCulture);
            dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCaja("tarjeta", idCaja), CultureInfo.InvariantCulture);

            if (turno == "M")
            {
                ticket.TextoIzquierda("T. Matutino");
            }
            else
            {

                ticket.TextoIzquierda("T.vespertino");
            }

            ticket.lineasIgual();
            ticket.TextoExtremos("$500.00 x " + dineroEnCaja.billetes500.ToString(), (500 * dineroEnCaja.billetes500).ToString());
            ticket.TextoExtremos("$200.00 x " + dineroEnCaja.billetes200.ToString(), (200 * dineroEnCaja.billetes200).ToString());
            ticket.TextoExtremos("$100.00 x " + dineroEnCaja.billetes100.ToString(), (100 * dineroEnCaja.billetes100).ToString());
            ticket.TextoExtremos("$50.00  x " + dineroEnCaja.billetes50.ToString(), (50 * dineroEnCaja.billetes50).ToString());
            ticket.TextoExtremos("$20.00  x " + dineroEnCaja.billetes20.ToString(), (20 * dineroEnCaja.billetes20).ToString());
            ticket.TextoExtremos("$10.00  x " + dineroEnCaja.monedas10.ToString(), (10 * dineroEnCaja.monedas10).ToString());
            ticket.TextoExtremos("$5.00   x " + dineroEnCaja.monedas5.ToString(), (5 * dineroEnCaja.monedas5).ToString());
            ticket.TextoExtremos("$2.00   x " + dineroEnCaja.monedas2.ToString(), (2 * dineroEnCaja.monedas2).ToString());
            ticket.TextoExtremos("$1.00   x " + dineroEnCaja.monedas1.ToString(), (1 * dineroEnCaja.monedas1).ToString());
            ticket.TextoExtremos("$0.50   x " + dineroEnCaja.monedas50centavos.ToString(), ((decimal)0.5 * dineroEnCaja.monedas50centavos).ToString());


            ticket.TextoIzquierda("venta en EFECTIVO: " + dineroEfectivo.ToString("c2"));
            ticket.TextoIzquierda("venta con TARJETA: " + dineroTarjeta.ToString("c2"));
            ticket.TextoIzquierda("TOTAL de venta: " + (dineroEfectivo + dineroTarjeta).ToString("c2"));
            ticket.TextoIzquierda("TRANSACCIONES: " + cnn.consultarTransacciones(idCaja));
            ticket.TextoIzquierda("TICKETS: " + cnn.consultarTicketInicial(idCaja) + " al " + cnn.consultarTicketFinal(idCaja));
            ticket.TextoIzquierda("TICKET PROMEDIO: " + cnn.consultarTiketPromedio(idCaja).ToString("c2"));
            ticket.TextoIzquierda("FONDO INICIAL: " + fondoInicial.ToString("c2").Replace(",", "."));
            ticket.TextoIzquierda("TOTAL EN CAJA: " + (Convert.ToDecimal(fondoInicial) + dineroCuadre.cantidad).ToString("c2"));

            ticket.lineasIgual();
            sfCantidad = dineroCuadre.cantidad - dineroEfectivo;
            if (sfCantidad < 0)
            {
                ticket.TextoIzquierda("FALTANTE " + sfCantidad.ToString("c2"));
            }
            else if (sfCantidad > 0)
            {
                ticket.TextoIzquierda("SOBRANTE " + sfCantidad.ToString("c2"));
            }


            ticket.TextoIzquierda("Firma Cajero 1  _____________");
            ticket.TextoIzquierda("Firma Cajero 2  _____________");
            ticket.TextoIzquierda("Firma Encargado _____________");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");


            string ver = ticket.verTicket();
            txtVerCorte.Text = ver;
            return ver;
        }

        private void btnCancelarCuadre_Click(object sender, EventArgs e)
        {
            panelCuadreCaja.Visible = false;
            if (banderaPagoDiferido)
                btnCancelar.Visible = false;
        }

        private void btnCierreDia_Click(object sender, EventArgs e)
        {
            banderaCorte = true;
            panelConttra.Visible = true;
            panelAutorizacion.Visible = true;
            panelTec.Visible = true;
            banderaCierreDia = true;

            panelExtras.Visible = false;
          
        }

        private void button76_Click(object sender, EventArgs e)
        {

            FormLogin login = new FormLogin();
            login.Show();
            this.Dispose();
        }


        private void cierreDiaTicket()
        {
            string corteTexto =  realizarRetiro();

            Caja cajaMaestra = cnn.abrirCajaMaestra();

            string titulo = "Cierre del día";
            string turno = string.Empty;
            string idCaja = cajaMaestra.idCaja;
            string hora = cnn.consultarFechaHoraInicioCajaMaestra(idCaja).Value.Hour.ToString();
            string horaMatutina = ConfigurationManager.AppSettings["turno matutino"];
            string horaVespertina = ConfigurationManager.AppSettings["turno vespertino"];


            if (int.Parse(hora) >= int.Parse(horaMatutina) && int.Parse(hora) < int.Parse(horaVespertina))
            {
                turno = "M";
            }
            else
            {
                turno = "V";
            }

            Impresora ticket = new Impresora();
           /* ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");
            */
            ticket.lineasIgual();

            string fecha = DateTime.Now.ToString("yyyy-dd-MM HH:MM:ss");
            string fechaStr = DateTime.Now.ToString("dd-MM-yyyy HH:MM:ss");
            string fechaInicio = cnn.consultarFechaHoraInicioCajaMaestra(idCaja).Value.ToString("dd-MM-yyyy HH:MM:ss");
            string ticketInicio = cnn.consultarTicketInicialCajaMaestra(idCaja);
            string ticketFinal = cnn.consultarTicketFinalMaestra(idCaja);
            decimal faltante = cnn.consultarDineroFaltante(idCaja);
            decimal sobrante = cnn.consultarDineroSobrante(idCaja);

            decimal dineroEfectivo = 0;
            decimal dineroTarjeta = 0;

            dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCajaMaestra("efectivo", idCaja), CultureInfo.InvariantCulture);
            dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCajaMaestra("tarjeta", idCaja), CultureInfo.InvariantCulture);




            ticket.TextoIzquierda("Firma Encargado _____________");

            ticket.TextoIzquierda("Firma Cajero 2  _____________");
            ticket.TextoIzquierda("Firma Cajero 1  _____________");
            ticket.TextoIzquierda("SOBRANTE " + sobrante.ToString("c2"));
            ticket.TextoIzquierda("FALTANTE " + faltante.ToString("c2"));
            ticket.lineasIgual();

            ticket.TextoIzquierda("TICKET PROMEDIO: " + cnn.consultarTiketPromedioMaestro(idCaja).ToString("c2"));

            ticket.TextoIzquierda("TRANSACCIONES: " + cnn.consultarTransaccionesCajaMaestra(idCaja));
            ticket.TextoIzquierda("TICKETS: " + cnn.consultarTicketInicialCajaMaestra(idCaja) + " al " + cnn.consultarTicketFinalMaestra(idCaja));
            ticket.TextoIzquierda("TOTAL de venta: " + (dineroEfectivo + dineroTarjeta).ToString("c2"));
            ticket.TextoIzquierda("venta con TARJETA: " + dineroTarjeta.ToString("c2"));
            ticket.TextoIzquierda("venta en EFECTIVO: " + dineroEfectivo.ToString("c2"));
            ticket.lineasIgual();
            if (turno == "M")
            {
                ticket.TextoIzquierda("T. Matutino");
            }
            else
            {

                ticket.TextoIzquierda("T.vespertino");
            }
            ticket.TextoIzquierda("CAJERO DE CORTE:" + ConfigurationManager.AppSettings["codigo_trabajador"]);
            ticket.TextoIzquierda("SUCURSAL:" + ConfigurationManager.AppSettings["nombre sucursal"]);
            ticket.TextoIzquierda("FECHA IMPRESIÓN: " + fechaStr);
            ticket.TextoIzquierda(titulo);
          /*  ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");*/

            ticket.CortaTicket();



            PrinterSettings settings = new PrinterSettings();
            ticket.ImprimirTicket(settings.PrinterName);
           /* ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket = new Impresora();
            */
            ticket.lineasIgual();

            fecha = DateTime.Now.ToString("yyyy-dd-MM HH:MM:ss");
            fechaStr = DateTime.Now.ToString("dd-MM-yyyy HH:MM:ss");
            fechaInicio = cnn.consultarFechaHoraInicioCajaMaestra(idCaja).Value.ToString("dd-MM-yyyy HH:MM:ss");
            ticketInicio = cnn.consultarTicketInicialCajaMaestra(idCaja);
            ticketFinal = cnn.consultarTicketFinalMaestra(idCaja);

            ticket.AbreCajon();
            ticket.TextoIzquierda(titulo);
            //ticket.TextoIzquierda("INICIO CAJA:     " + fechaInicio);
            ticket.TextoIzquierda("FECHA IMPRESIÓN: " + fechaStr);
            //ticket.TextoIzquierda("DEL TICKET: " + ticketInicio + " AL TICKET: " + ticketFinal);

            ticket.TextoIzquierda("SUCURSAL:" + ConfigurationManager.AppSettings["nombre sucursal"]);
            ticket.TextoIzquierda("CAJERO DE CORTE:" + ConfigurationManager.AppSettings["codigo_trabajador"]);
            //ticket.TextoIzquierda("");

            dineroEfectivo = 0;
            dineroTarjeta = 0;

            dineroEfectivo = Convert.ToDecimal(cnn.consultarGanaciasCajaMaestra("efectivo", idCaja), CultureInfo.InvariantCulture);
            dineroTarjeta = Convert.ToDecimal(cnn.consultarGanaciasCajaMaestra("tarjeta", idCaja), CultureInfo.InvariantCulture);

            if (turno == "M")
            {
                ticket.TextoIzquierda("T. Matutino");
            }
            else
            {

                ticket.TextoIzquierda("T.vespertino");
            }

            ticket.lineasIgual();
            /*   ticket.TextoExtremos("$500.00 x " + dineroCuadre.billetes500.ToString(), (500 * dineroCuadre.billetes500).ToString());
               ticket.TextoExtremos("$200.00 x " + dineroCuadre.billetes200.ToString(), (200 * dineroCuadre.billetes200).ToString());
               ticket.TextoExtremos("$100.00 x " + dineroCuadre.billetes100.ToString(), (100 * dineroCuadre.billetes100).ToString());
               ticket.TextoExtremos("$50.00  x " + dineroCuadre.billetes50.ToString(), (50 * dineroCuadre.billetes50).ToString());
               ticket.TextoExtremos("$20.00  x " + dineroCuadre.billetes20.ToString(), (20 * dineroCuadre.billetes20).ToString());
               ticket.TextoExtremos("$10.00  x " + dineroCuadre.monedas10.ToString(), (10 * dineroCuadre.monedas10).ToString());
               ticket.TextoExtremos("$5.00   x " + dineroCuadre.monedas5.ToString(), (5 * dineroCuadre.monedas5).ToString());
               ticket.TextoExtremos("$2.00   x " + dineroCuadre.monedas2.ToString(), (2 * dineroCuadre.monedas2).ToString());
               ticket.TextoExtremos("$1.00   x " + dineroCuadre.monedas1.ToString(), (1 * dineroCuadre.monedas1).ToString());
               ticket.TextoExtremos("$0.50   x " + dineroCuadre.monedas50centavos.ToString(), ((decimal)0.5 * dineroCuadre.monedas50centavos).ToString());

               */

            ticket.TextoIzquierda("venta en EFECTIVO: " + dineroEfectivo.ToString("c2"));
            ticket.TextoIzquierda("venta con TARJETA: " + dineroTarjeta.ToString("c2"));
            ticket.TextoIzquierda("TOTAL de venta: " + (dineroEfectivo + dineroTarjeta).ToString("c2"));
            ticket.TextoIzquierda("TRANSACCIONES: " + cnn.consultarTransaccionesCajaMaestra(idCaja));
            
            ticket.TextoIzquierda("TICKETS: " + cnn.consultarTicketInicialCajaMaestra(idCaja) + " al " + cnn.consultarTicketFinalMaestra(idCaja));
            ticket.TextoIzquierda("TICKET PROMEDIO: " + cnn.consultarTiketPromedioMaestro(idCaja).ToString("c2"));
            //ticket.TextoIzquierda("TOTAL EN CAJA: " + (dineroCuadre.cantidad).ToString("c2"));

            ticket.lineasIgual();

            faltante = cnn.consultarDineroFaltante(idCaja);
            sobrante = cnn.consultarDineroSobrante(idCaja);

            ticket.TextoIzquierda("FALTANTE " + faltante.ToString("c2"));
            ticket.TextoIzquierda("SOBRANTE " + sobrante.ToString("c2"));


            ticket.TextoIzquierda("Firma Cajero 1  _____________");
            ticket.TextoIzquierda("Firma Cajero 2  _____________");
            ticket.TextoIzquierda("Firma Encargado _____________");
          /*  ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");

            ticket.TextoIzquierda("");*/

            string ver = ticket.verTicket();


            textBoxResumen.Text = corteTexto + ver;
            


            string idTienda = ConfigurationManager.AppSettings["id_tienda"];

            cnn.finalizarCajaMaestra(cajaMaestra);
           
            //Caja cajaCerrada = cnn.consultarEstatusCaja(idTienda);
            panelCuadreCaja.Visible = false;
            panelResumenDatos.Visible = true;
           
        }

        private void button44_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Dispose();
            
        }

        private void cmbCriticos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbCriticos.Text;
            tblInv.Rows.Clear();
            cmbCriticos.Items.Clear();
            cmbCriticos.Text = "CRITICOS";
            listatiposCriticos = cnn.consultarTiposCriticos();
            TipoCritico tipoLocal = listatiposCriticos.Where(tipo => tipo.descripcion == select).FirstOrDefault();
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

        private void button43_Click(object sender, EventArgs e)
        {
            panelCriticos.Visible = false;

        }

        private void btnC_Click_2(object sender, EventArgs e)
        {
            txtContra.Text = "";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            
        }

        private void panelCuadreCaja_Paint(object sender, PaintEventArgs e)
        {
            if (banderaPagoDiferido)
            {
                btnPagarDiferido.Visible = true;
                labelTotalPagarDiferido.Visible = true;
                labelTotalPagarDiferidoMensaje.Visible = true;
                labelRestantePagarDiferidoMensaje.Visible = true;
                labelRestanteDiferido.Visible = true;
            }
        }

        private void btnPagoDiferido_Click(object sender, EventArgs e)
        {
            panelCuadreCaja.Visible = true;
            banderaPagoDiferido = true;
            panelMonedas.Visible = false;
            labelTotalPagarDiferido.Text = total.ToString("c2");
        }

       
     



        
    }
}
