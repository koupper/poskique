using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases.Modelos;
using System.Configuration;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1
{
    public partial class FormPagos : Form
    {
        IList<Producto> lProductos;
        BaseDatos cnn;
        public float total = 0;
        
        public FormPagos(IList<Producto> lProductos)
        {
            this.lProductos = lProductos;
            InitializeComponent();
            cnn = new BaseDatos();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

      

        private void FormPagos_Load(object sender, EventArgs e)
        {
            foreach (Producto producto in lProductos)
            {
                ListViewItem item = listaPed.FindItemWithText(producto.nombre);

                if (item == null)
                {
                    int numeroProductosSimilares = lProductos.Count(prod => prod == producto);
                    ListViewItem Lista = new ListViewItem((numeroProductosSimilares).ToString());
                    Lista.SubItems.Add(producto.nombre);
                    Lista.SubItems.Add(producto.precio.ToString());
                    Lista.Name = producto.idProducto.ToString();
                    listaPed.Items.Add(Lista);
                }
            }
        }

        private void btnPagarCa_Click(object sender, EventArgs e)
        {

        }

        private void btnPagoExacto_Click(object sender, EventArgs e)
        {
            string codigoEmpleado =  ConfigurationManager.AppSettings["codigo_trabajador"];
            string idTienda =  ConfigurationManager.AppSettings["id_tienda"];

            Venta venta = new Venta(Convert.ToInt32(codigoEmpleado), Convert.ToInt32(idTienda));
            venta.total = float.Parse(txboxCantidad.Text);

            if (cnn.registrarVenta(venta, lProductos))
            {
                //codigo para mandar a imprimir
                
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txboxCantidad.Text = "0";
        }
    }
}
