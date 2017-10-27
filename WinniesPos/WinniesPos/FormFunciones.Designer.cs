namespace WindowsFormsApplication1
{
    partial class FormEmpleadoFunciones
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelCaja = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.listaPed = new System.Windows.Forms.ListView();
            this.NUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VALOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMoneda1 = new System.Windows.Forms.Button();
            this.btnMoneda50c = new System.Windows.Forms.Button();
            this.btnMoneda2 = new System.Windows.Forms.Button();
            this.btnMoneda5 = new System.Windows.Forms.Button();
            this.btnMoneda10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBillete500 = new System.Windows.Forms.Button();
            this.btnBillete200 = new System.Windows.Forms.Button();
            this.btnBillete100 = new System.Windows.Forms.Button();
            this.btnBillete50 = new System.Windows.Forms.Button();
            this.btnBillete20 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.txboxCantidad = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panelCaja.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 166);
            this.button1.TabIndex = 0;
            this.button1.Text = "INVENTARIOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(947, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 166);
            this.button2.TabIndex = 1;
            this.button2.Text = "TOMA ORDEN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 85);
            this.button3.TabIndex = 2;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelCaja
            // 
            this.panelCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCaja.Controls.Add(this.button4);
            this.panelCaja.Controls.Add(this.listaPed);
            this.panelCaja.Controls.Add(this.groupBox3);
            this.panelCaja.Controls.Add(this.groupBox2);
            this.panelCaja.Controls.Add(this.btnCancelar);
            this.panelCaja.Controls.Add(this.label1);
            this.panelCaja.Controls.Add(this.btnC);
            this.panelCaja.Controls.Add(this.btnCaja);
            this.panelCaja.Controls.Add(this.txboxCantidad);
            this.panelCaja.Location = new System.Drawing.Point(219, 49);
            this.panelCaja.Name = "panelCaja";
            this.panelCaja.Size = new System.Drawing.Size(921, 685);
            this.panelCaja.TabIndex = 15;
            this.panelCaja.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.Location = new System.Drawing.Point(637, 591);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 56);
            this.button4.TabIndex = 8;
            this.button4.Text = "QUITAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listaPed
            // 
            this.listaPed.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listaPed.AllowColumnReorder = true;
            this.listaPed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NUM,
            this.VALOR});
            this.listaPed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listaPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPed.FullRowSelect = true;
            this.listaPed.GridLines = true;
            this.listaPed.Location = new System.Drawing.Point(488, 133);
            this.listaPed.MultiSelect = false;
            this.listaPed.Name = "listaPed";
            this.listaPed.Size = new System.Drawing.Size(267, 422);
            this.listaPed.TabIndex = 32;
            this.listaPed.UseCompatibleStateImageBehavior = false;
            this.listaPed.View = System.Windows.Forms.View.Details;
            // 
            // NUM
            // 
            this.NUM.Text = "NUM";
            this.NUM.Width = 54;
            // 
            // VALOR
            // 
            this.VALOR.Text = "EFECTIVO";
            this.VALOR.Width = 204;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMoneda1);
            this.groupBox3.Controls.Add(this.btnMoneda50c);
            this.groupBox3.Controls.Add(this.btnMoneda2);
            this.groupBox3.Controls.Add(this.btnMoneda5);
            this.groupBox3.Controls.Add(this.btnMoneda10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(165, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 174);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monedas";
            // 
            // btnMoneda1
            // 
            this.btnMoneda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMoneda1.Location = new System.Drawing.Point(4, 96);
            this.btnMoneda1.Name = "btnMoneda1";
            this.btnMoneda1.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda1.TabIndex = 7;
            this.btnMoneda1.Text = "$1";
            this.btnMoneda1.UseVisualStyleBackColor = true;
            this.btnMoneda1.Click += new System.EventHandler(this.btnMoneda1_Click);
            // 
            // btnMoneda50c
            // 
            this.btnMoneda50c.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMoneda50c.Location = new System.Drawing.Point(176, 96);
            this.btnMoneda50c.Name = "btnMoneda50c";
            this.btnMoneda50c.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda50c.TabIndex = 6;
            this.btnMoneda50c.Text = "$0.50";
            this.btnMoneda50c.UseVisualStyleBackColor = true;
            this.btnMoneda50c.Click += new System.EventHandler(this.btnMoneda50c_Click);
            // 
            // btnMoneda2
            // 
            this.btnMoneda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMoneda2.Location = new System.Drawing.Point(176, 37);
            this.btnMoneda2.Name = "btnMoneda2";
            this.btnMoneda2.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda2.TabIndex = 5;
            this.btnMoneda2.Text = "$2";
            this.btnMoneda2.UseVisualStyleBackColor = true;
            this.btnMoneda2.Click += new System.EventHandler(this.btnMoneda2_Click);
            // 
            // btnMoneda5
            // 
            this.btnMoneda5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMoneda5.Location = new System.Drawing.Point(92, 37);
            this.btnMoneda5.Name = "btnMoneda5";
            this.btnMoneda5.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda5.TabIndex = 4;
            this.btnMoneda5.Text = "$5";
            this.btnMoneda5.UseVisualStyleBackColor = true;
            this.btnMoneda5.Click += new System.EventHandler(this.btnMoneda5_Click);
            // 
            // btnMoneda10
            // 
            this.btnMoneda10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMoneda10.Location = new System.Drawing.Point(5, 37);
            this.btnMoneda10.Name = "btnMoneda10";
            this.btnMoneda10.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda10.TabIndex = 3;
            this.btnMoneda10.Text = "$10";
            this.btnMoneda10.UseVisualStyleBackColor = true;
            this.btnMoneda10.Click += new System.EventHandler(this.btnMoneda10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBillete500);
            this.groupBox2.Controls.Add(this.btnBillete200);
            this.groupBox2.Controls.Add(this.btnBillete100);
            this.groupBox2.Controls.Add(this.btnBillete50);
            this.groupBox2.Controls.Add(this.btnBillete20);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(171, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 164);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BILLETES";
            // 
            // btnBillete500
            // 
            this.btnBillete500.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBillete500.Location = new System.Drawing.Point(176, 89);
            this.btnBillete500.Name = "btnBillete500";
            this.btnBillete500.Size = new System.Drawing.Size(81, 56);
            this.btnBillete500.TabIndex = 7;
            this.btnBillete500.Text = "$500";
            this.btnBillete500.UseVisualStyleBackColor = true;
            this.btnBillete500.Click += new System.EventHandler(this.btnBillete500_Click);
            // 
            // btnBillete200
            // 
            this.btnBillete200.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBillete200.Location = new System.Drawing.Point(5, 89);
            this.btnBillete200.Name = "btnBillete200";
            this.btnBillete200.Size = new System.Drawing.Size(81, 56);
            this.btnBillete200.TabIndex = 6;
            this.btnBillete200.Text = "$200";
            this.btnBillete200.UseVisualStyleBackColor = true;
            this.btnBillete200.Click += new System.EventHandler(this.btnBillete200_Click);
            // 
            // btnBillete100
            // 
            this.btnBillete100.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBillete100.Location = new System.Drawing.Point(176, 27);
            this.btnBillete100.Name = "btnBillete100";
            this.btnBillete100.Size = new System.Drawing.Size(81, 56);
            this.btnBillete100.TabIndex = 5;
            this.btnBillete100.Text = "$100";
            this.btnBillete100.UseVisualStyleBackColor = true;
            this.btnBillete100.Click += new System.EventHandler(this.btnBillete100_Click);
            // 
            // btnBillete50
            // 
            this.btnBillete50.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBillete50.Location = new System.Drawing.Point(92, 27);
            this.btnBillete50.Name = "btnBillete50";
            this.btnBillete50.Size = new System.Drawing.Size(81, 56);
            this.btnBillete50.TabIndex = 4;
            this.btnBillete50.Text = "$50";
            this.btnBillete50.UseVisualStyleBackColor = true;
            this.btnBillete50.Click += new System.EventHandler(this.btnBillete50_Click);
            // 
            // btnBillete20
            // 
            this.btnBillete20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBillete20.Location = new System.Drawing.Point(5, 27);
            this.btnBillete20.Name = "btnBillete20";
            this.btnBillete20.Size = new System.Drawing.Size(81, 56);
            this.btnBillete20.TabIndex = 3;
            this.btnBillete20.Text = "$20";
            this.btnBillete20.UseVisualStyleBackColor = true;
            this.btnBillete20.Click += new System.EventHandler(this.btnBillete20_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(372, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(186, 44);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "CON CUANTO INICIA LA CAJA";
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(170, 581);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(90, 66);
            this.btnC.TabIndex = 26;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.Location = new System.Drawing.Point(366, 581);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(186, 66);
            this.btnCaja.TabIndex = 25;
            this.btnCaja.Text = "INICIAR EL DIA";
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // txboxCantidad
            // 
            this.txboxCantidad.Enabled = false;
            this.txboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxCantidad.Location = new System.Drawing.Point(164, 163);
            this.txboxCantidad.Multiline = true;
            this.txboxCantidad.Name = "txboxCantidad";
            this.txboxCantidad.Size = new System.Drawing.Size(282, 49);
            this.txboxCantidad.TabIndex = 23;
            this.txboxCantidad.Text = "0";
            this.txboxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(596, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 166);
            this.button5.TabIndex = 16;
            this.button5.Text = "REPORTES";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormEmpleadoFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 721);
            this.ControlBox = false;
            this.Controls.Add(this.panelCaja);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormEmpleadoFunciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormFunciones_Load);
            this.panelCaja.ResumeLayout(false);
            this.panelCaja.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelCaja;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listaPed;
        private System.Windows.Forms.ColumnHeader NUM;
        private System.Windows.Forms.ColumnHeader VALOR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMoneda1;
        private System.Windows.Forms.Button btnMoneda50c;
        private System.Windows.Forms.Button btnMoneda2;
        private System.Windows.Forms.Button btnMoneda5;
        private System.Windows.Forms.Button btnMoneda10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBillete500;
        private System.Windows.Forms.Button btnBillete200;
        private System.Windows.Forms.Button btnBillete100;
        private System.Windows.Forms.Button btnBillete50;
        private System.Windows.Forms.Button btnBillete20;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.TextBox txboxCantidad;
        private System.Windows.Forms.Button button5;
    }
}