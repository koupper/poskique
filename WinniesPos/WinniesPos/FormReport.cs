using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1
{
    public partial class FormReport : Form
    {
        BaseDatos cnn;

        public FormReport()
        {
            cnn = new BaseDatos();

            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            cmbReportes.SelectedIndex = 0;
            cargarReporte();
        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void cargarReporte()
        {
            string reporte = string.Empty;
            string dataTimeInicial = dtInicio.Value.Date.ToString("yyyy/MM/dd HH:mm:ss");
            dtInicio.Value = DateTime.Parse(dataTimeInicial);
            
            string fecha1 = dtInicio.Value.Date.ToString("yyyy/MM/dd HH:mm:ss");
            string fecha2 = dtFin.Value.ToString("yyyy/MM/dd") + " 23:59:59";


            DataTable dataTable = null;
            switch (cmbReportes.Text)
            {
                case "Caja":
                    dataTable = cnn.consultarCaja(fecha1, fecha2);
                    reporte = "Caja.rdlc";

                    break;
                case "Popularidad por dia":
                    reporte = "FavoritosPorDia.rdlc";

                    dataTable = cnn.consultarPopularidadPorDia(fecha1, fecha2);


                    break;

                case "Popularidad por hora":
                    reporte = "FavoritosPorHora.rdlc";

                    dataTable = cnn.consultarPopularidadPorHora(fecha1, fecha2);


                    break;

                case "Ventas por hora":
                    reporte = "ventasporhora.rdlc";
                    dataTable = cnn.consultarVentasPorHora(fecha1, fecha2);
                    break;

                case "Ventas":


                    dataTable = cnn.consultarVentasPorDia(fecha1, fecha2);
                    reporte = "ventas.rdlc";

                    break;
                case "Tickets":
                    dataTable = cnn.consultarTickets(fecha1, fecha2);
                    reporte = "productosDelTicket.rdlc";

                    break;
                case "Ticket promedio por dia":
                    dataTable = cnn.consultarTicketPromedioDia(fecha1, fecha2);
                    reporte = "ticketpromediodia.rdlc";

                    break;
                case "Ticket promedio por hora":
                    dataTable = cnn.consultarTicketPromedioHora(fecha1, fecha2);
                    reporte = "ticketpromediohora.rdlc";

                    break;
                case "Numero transacciones / ticket promedio por dia":
                    dataTable = cnn.consultarTransaccionesDia(fecha1, fecha2);
                    reporte = "transaccionesdiaticketpromedio.rdlc";

                    break;
                case "Numero transacciones / ticket promedio por hora":
                    dataTable = cnn.consultarTransaccionesHora(fecha1, fecha2);
                    reporte = "transaccioneshora.rdlc";

                    break;
            }



            
            
            
            

            reportes.ProcessingMode = ProcessingMode.Local;
            reportes.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reportes." + reporte;
            reportes.LocalReport.DataSources.Clear();
            reportes.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataTable));
            reportes.LocalReport.Refresh();
            reportes.RefreshReport();
        }

        private void dtFin_ValueChanged(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void cmbReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            FormEmpleadoFunciones funciones = new FormEmpleadoFunciones();
            funciones.Show();
        }
    }
}
