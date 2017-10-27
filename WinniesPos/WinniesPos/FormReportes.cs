using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class FormReportes : Form
    {
        BaseDatos cnn;
        public FormReportes()
        {
            InitializeComponent();
            cnn = new BaseDatos();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            string dateTimeString = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy HH:mm:ss");
            dateTimePicker1.Value = DateTime.Parse(dateTimeString);
            // TODO: This line of code loads data into the 'POSDataSet.corteCaja' table. You can move, or remove it, as needed.
           
            this.corteCajaTableAdapter.Fill(this.POSDataSet.corteCaja, dateTimePicker1.Value, dateTimePicker2.Value);
            


            WindowState = FormWindowState.Maximized;
            //this.rvDinero.RefreshReport();
            //this.rvVentas.RefreshReport();
            this.rvCortes.RefreshReport();
            /*this.rvProductosVendidosPorHora.RefreshReport();
            this.rvProductosPorDia.RefreshReport();
            this.rvProductosPorHora.RefreshReport();
            this.rvVentasTotales.RefreshReport();
            */

            rvDinero.Visible = false;
            rvCortes.Visible = false;
            rvVentas.Visible = false;
            rvProductosVendidosPorHora.Visible = false;
            rvProductosPorDia.Visible = false;
            rvProductosPorHora.Visible = false;
            rvVentasTotales.Visible = false;


            cmbReportes.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbReportes.Text)
            {
                case "Caja":
                    // TODO: This line of code loads data into the 'POSDataSet.corteCaja' table. You can move, or remove it, as needed.
                    this.corteCajaTableAdapter.Fill(this.POSDataSet.corteCaja, dateTimePicker1.Value, dateTimePicker2.Value);
                    this.rvCortes.RefreshReport();
           
                    rvCortes.Visible = true;
                    rvDinero.Visible = false;
                    rvVentas.Visible = false;
                    rvProductosPorHora.Visible = false;
                    rvProductosPorDia.Visible = false;
                    rvVentasTotales.Visible = false;

                    break;
                case "Popularidad por dia":
                    // TODO: esta línea de código carga datos en la tabla 'DataReportes.productosfavortiospordia' Puede moverla o quitarla según sea necesario.
                    this.productosfavortiospordiaTableAdapter.Fill(this.DataReportes.productosfavortiospordia, dateTimePicker1.Value, dateTimePicker2.Value);
                    this.rvProductosPorDia.RefreshReport();
           
                    rvVentasTotales.Visible = false;
                    rvCortes.Visible = false;
                    rvDinero.Visible = false;
                    rvVentas.Visible = false;
                    rvProductosPorHora.Visible = false;
                    rvProductosPorDia.Visible = true;

                    break;

                case "Popularidad por hora":
                    // TODO: esta línea de código carga datos en la tabla 'DataReportes.producto' Puede moverla o quitarla según sea necesario.
                    this.productoTableAdapter.Fill(this.DataReportes.producto, dateTimePicker1.Value, dateTimePicker2.Value);
                    rvProductosPorHora.RefreshReport();
                   
                    rvCortes.Visible = false;
                    rvDinero.Visible = false;
                    rvVentas.Visible = false;
                    rvProductosPorHora.Visible = true;
                    rvProductosPorDia.Visible = false;
                    rvVentasTotales.Visible = false;
                    break;

                case "Ventas por hora":
                    // TODO: esta línea de código carga datos en la tabla 'DataReportes.ventasporhora' Puede moverla o quitarla según sea necesario.
                    this.ventasporhoraAdapter.Fill(this.DataReportes.ventasporhora, dateTimePicker1.Value, dateTimePicker2.Value);
                    this.rvDinero.RefreshReport();
           
                    rvCortes.Visible = false;
                    rvDinero.Visible = true;
                    rvVentas.Visible = false;
                    rvProductosPorHora.Visible = false;
                    rvProductosPorDia.Visible = false;
                    rvVentasTotales.Visible = false;
                    break;
                case "Ventas":
                    // TODO: This line of code loads data into the 'DataReportes.ventas' table. You can move, or remove it, as needed.
                    this.ventasTableAdapter.Fill(this.DataReportes.ventas, dateTimePicker1.Value, dateTimePicker2.Value);
                    rvVentasTotales.RefreshReport();
          
                    rvCortes.Visible = false;
                    rvDinero.Visible = false;
                    rvVentas.Visible = false;
                    rvVentasTotales.Visible = true;
                    rvProductosPorHora.Visible = false;
                    rvProductosPorDia.Visible = false;
                    break;
                case "Tickets":
                    // TODO: This line of code loads data into the 'DataReportes.productosvendidos' table. You can move, or remove it, as needed.
                    this.productosvendidosTableAdapter.Fill(this.DataReportes.productosvendidos, dateTimePicker1.Value, dateTimePicker2.Value);

                    rvVentas.RefreshReport();
                 
               
                    rvCortes.Visible = false;
                    rvDinero.Visible = false;
                    rvVentas.Visible = true;
                    rvVentasTotales.Visible = false;
                    rvProductosPorHora.Visible = false;
                    rvProductosPorDia.Visible = false;
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            FormEmpleadoFunciones funciones = new FormEmpleadoFunciones();
            funciones.Show();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            switch (cmbReportes.Text)
            {
                case "Caja":
                    // TODO: This line of code loads data into the 'POSDataSet.corteCaja' table. You can move, or remove it, as needed.
                    this.corteCajaTableAdapter.Fill(this.POSDataSet.corteCaja, dateTimePicker1.Value, dateTimePicker2.Value);
                    this.rvCortes.RefreshReport();
           
                    break;
                case "Popularidad por dia":
                    // TODO: esta línea de código carga datos en la tabla 'DataReportes.productosfavortiospordia' Puede moverla o quitarla según sea necesario.
                    this.productosfavortiospordiaTableAdapter.Fill(this.DataReportes.productosfavortiospordia, dateTimePicker1.Value, dateTimePicker2.Value);
                    this.rvProductosPorDia.RefreshReport();
           
                    break;

                case "Popularidad por hora":
                    // TODO: esta línea de código carga datos en la tabla 'DataReportes.producto' Puede moverla o quitarla según sea necesario.
                    this.productoTableAdapter.Fill(this.DataReportes.producto, dateTimePicker1.Value, dateTimePicker2.Value);
                    rvProductosPorHora.RefreshReport();
                   
                    break;


                case "Ventas por hora":
                    // TODO: esta línea de código carga datos en la tabla 'DataReportes.ventasporhora' Puede moverla o quitarla según sea necesario.
                    this.ventasporhoraAdapter.Fill(this.DataReportes.ventasporhora, dateTimePicker1.Value, dateTimePicker2.Value);
                    this.rvDinero.RefreshReport();
           
                    break;
                case "Ventas":
                    // TODO: This line of code loads data into the 'DataReportes.ventas' table. You can move, or remove it, as needed.
                    this.ventasTableAdapter.Fill(this.DataReportes.ventas, dateTimePicker1.Value, dateTimePicker2.Value);
                    rvVentasTotales.RefreshReport();
                    break;
                case "Tickets":
                    // TODO: This line of code loads data into the 'DataReportes.productosvendidos' table. You can move, or remove it, as needed.
                    this.productosvendidosTableAdapter.Fill(this.DataReportes.productosvendidos, dateTimePicker1.Value, dateTimePicker2.Value);

                    rvVentas.RefreshReport();
                 
                    break;
            }

            this.rvDinero.RefreshReport();
            this.rvVentas.RefreshReport();
            this.rvProductosVendidosPorHora.RefreshReport();
            this.rvProductosPorHora.RefreshReport();
            this.rvVentasTotales.RefreshReport();
        }

       
    }
}
