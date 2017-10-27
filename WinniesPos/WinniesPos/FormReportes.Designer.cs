
namespace WindowsFormsApplication1
{
    partial class FormReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventasPorHoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataReportes = new WindowsFormsApplication1.DataReportes();
            this.productosvendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corteCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.POSDataSet = new WindowsFormsApplication1.POSDataSet();
            this.productosfavortiospordiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvDinero = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvCortes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbReportes = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.corteCajaTableAdapter = new WindowsFormsApplication1.POSDataSetTableAdapters.corteCajaTableAdapter();
            this.rvProductosVendidosPorHora = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rvProductosPorDia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvProductosPorHora = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvVentasTotales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventasTableAdapter = new WindowsFormsApplication1.DataReportesTableAdapters.ventasTableAdapter();
            this.productosvendidosTableAdapter = new WindowsFormsApplication1.DataReportesTableAdapters.productosvendidosTableAdapter();
            this.ventasPorHoraTableAdapter = new WindowsFormsApplication1.DataReportesTableAdapters.ventasTableAdapter();
            this.ventasporhoraAdapter = new WindowsFormsApplication1.DataReportesTableAdapters.ventasporhoraAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.DataReportesTableAdapters.TableAdapterManager();
            this.productoTableAdapter = new WindowsFormsApplication1.DataReportesTableAdapters.productoTableAdapter();
            this.productosfavortiospordiaTableAdapter = new WindowsFormsApplication1.DataReportesTableAdapters.productosfavortiospordiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasPorHoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosvendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corteCajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosfavortiospordiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ventasPorHoraBindingSource
            // 
            this.ventasPorHoraBindingSource.DataMember = "ventasporhora";
            this.ventasPorHoraBindingSource.DataSource = this.DataReportes;
            // 
            // DataReportes
            // 
            this.DataReportes.DataSetName = "DataReportes";
            this.DataReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosvendidosBindingSource
            // 
            this.productosvendidosBindingSource.DataMember = "productosvendidos";
            this.productosvendidosBindingSource.DataSource = this.DataReportes;
            // 
            // corteCajaBindingSource
            // 
            this.corteCajaBindingSource.DataMember = "corteCaja";
            this.corteCajaBindingSource.DataSource = this.POSDataSet;
            // 
            // POSDataSet
            // 
            this.POSDataSet.DataSetName = "POSDataSet";
            this.POSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosfavortiospordiaBindingSource
            // 
            this.productosfavortiospordiaBindingSource.DataMember = "productosfavortiospordia";
            this.productosfavortiospordiaBindingSource.DataSource = this.DataReportes;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.DataReportes;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "ventas";
            this.ventasBindingSource.DataSource = this.DataReportes;
            // 
            // rvDinero
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ventasPorHoraBindingSource;
            this.rvDinero.LocalReport.DataSources.Add(reportDataSource1);
            this.rvDinero.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reportes.ventasporhora.rdlc";
            this.rvDinero.Location = new System.Drawing.Point(28, 109);
            this.rvDinero.Name = "rvDinero";
            this.rvDinero.Size = new System.Drawing.Size(1221, 495);
            this.rvDinero.TabIndex = 0;
            // 
            // rvVentas
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.productosvendidosBindingSource;
            this.rvVentas.LocalReport.DataSources.Add(reportDataSource2);
            this.rvVentas.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reportes.productosDelTicket.rdlc";
            this.rvVentas.Location = new System.Drawing.Point(28, 109);
            this.rvVentas.Name = "rvVentas";
            this.rvVentas.Size = new System.Drawing.Size(1221, 495);
            this.rvVentas.TabIndex = 1;
            this.rvVentas.Visible = false;
            // 
            // rvCortes
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.corteCajaBindingSource;
            this.rvCortes.LocalReport.DataSources.Add(reportDataSource3);
            this.rvCortes.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reportes.Caja.rdlc";
            this.rvCortes.Location = new System.Drawing.Point(28, 109);
            this.rvCortes.Name = "rvCortes";
            this.rvCortes.Size = new System.Drawing.Size(1221, 495);
            this.rvCortes.TabIndex = 2;
            this.rvCortes.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(275, 42);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // cmbReportes
            // 
            this.cmbReportes.FormattingEnabled = true;
            this.cmbReportes.Items.AddRange(new object[] {
            "Caja",
            "Popularidad por dia",
            "Popularidad por hora",
            "Ventas",
            "Ventas por hora",
            "Tickets"});
            this.cmbReportes.Location = new System.Drawing.Point(537, 42);
            this.cmbReportes.Name = "cmbReportes";
            this.cmbReportes.Size = new System.Drawing.Size(235, 21);
            this.cmbReportes.TabIndex = 7;
            this.cmbReportes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1038, 37);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(189, 35);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // corteCajaTableAdapter
            // 
            this.corteCajaTableAdapter.ClearBeforeFill = true;
            // 
            // rvProductosVendidosPorHora
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.ventasPorHoraBindingSource;
            this.rvProductosVendidosPorHora.LocalReport.DataSources.Add(reportDataSource4);
            this.rvProductosVendidosPorHora.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reportes.ventasporhora.rdlc";
            this.rvProductosVendidosPorHora.Location = new System.Drawing.Point(30, 109);
            this.rvProductosVendidosPorHora.Name = "rvProductosVendidosPorHora";
            this.rvProductosVendidosPorHora.Size = new System.Drawing.Size(1219, 495);
            this.rvProductosVendidosPorHora.TabIndex = 9;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1276, 25);
            this.fillByToolStrip.TabIndex = 10;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // rvProductosPorDia
            // 
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.productosfavortiospordiaBindingSource;
            this.rvProductosPorDia.LocalReport.DataSources.Add(reportDataSource5);
            this.rvProductosPorDia.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reportes.FavoritosPorDia.rdlc";
            this.rvProductosPorDia.Location = new System.Drawing.Point(28, 109);
            this.rvProductosPorDia.Name = "rvProductosPorDia";
            this.rvProductosPorDia.Size = new System.Drawing.Size(1221, 495);
            this.rvProductosPorDia.TabIndex = 11;
            // 
            // rvProductosPorHora
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.productoBindingSource;
            this.rvProductosPorHora.LocalReport.DataSources.Add(reportDataSource6);
            this.rvProductosPorHora.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reportes.FavoritosPorHora.rdlc";
            this.rvProductosPorHora.Location = new System.Drawing.Point(28, 109);
            this.rvProductosPorHora.Name = "rvProductosPorHora";
            this.rvProductosPorHora.Size = new System.Drawing.Size(1221, 495);
            this.rvProductosPorHora.TabIndex = 12;
            // 
            // rvVentasTotales
            // 
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.ventasBindingSource;
            this.rvVentasTotales.LocalReport.DataSources.Add(reportDataSource7);
            this.rvVentasTotales.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reportes.ventas.rdlc";
            this.rvVentasTotales.Location = new System.Drawing.Point(28, 109);
            this.rvVentasTotales.Name = "rvVentasTotales";
            this.rvVentasTotales.Size = new System.Drawing.Size(1221, 495);
            this.rvVentasTotales.TabIndex = 13;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // productosvendidosTableAdapter
            // 
            this.productosvendidosTableAdapter.ClearBeforeFill = true;
            // 
            // ventasPorHoraTableAdapter
            // 
            this.ventasPorHoraTableAdapter.ClearBeforeFill = true;
            // 
            // ventasporhoraAdapter
            // 
            this.ventasporhoraAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.DataReportesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // productosfavortiospordiaTableAdapter
            // 
            this.productosfavortiospordiaTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 632);
            this.ControlBox = false;
            this.Controls.Add(this.rvVentasTotales);
            this.Controls.Add(this.rvProductosPorHora);
            this.Controls.Add(this.rvProductosPorDia);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.rvProductosVendidosPorHora);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbReportes);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rvCortes);
            this.Controls.Add(this.rvVentas);
            this.Controls.Add(this.rvDinero);
            this.Name = "FormReportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasPorHoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosvendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corteCajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosfavortiospordiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvDinero;
        private Microsoft.Reporting.WinForms.ReportViewer rvVentas;
        private Microsoft.Reporting.WinForms.ReportViewer rvCortes;
        private System.Windows.Forms.BindingSource corteCajaBindingSource;
        private POSDataSet POSDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbReportes;
        private System.Windows.Forms.Button btnSalir;
        private POSDataSetTableAdapters.corteCajaTableAdapter corteCajaTableAdapter;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private DataReportes DataReportes;
        private DataReportesTableAdapters.ventasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.BindingSource productosvendidosBindingSource;
        private DataReportesTableAdapters.productosvendidosTableAdapter productosvendidosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvProductosVendidosPorHora;
        private System.Windows.Forms.BindingSource ventasPorHoraBindingSource;
        private DataReportesTableAdapters.ventasTableAdapter ventasPorHoraTableAdapter;
        private DataReportesTableAdapters.ventasporhoraAdapter ventasporhoraAdapter;
        private DataReportesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private Microsoft.Reporting.WinForms.ReportViewer rvProductosPorDia;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DataReportesTableAdapters.productoTableAdapter productoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvProductosPorHora;
        private Microsoft.Reporting.WinForms.ReportViewer rvVentasTotales;
        private System.Windows.Forms.BindingSource productosfavortiospordiaBindingSource;
        private DataReportesTableAdapters.productosfavortiospordiaTableAdapter productosfavortiospordiaTableAdapter;
    }
}