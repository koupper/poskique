namespace WindowsFormsApplication1
{
    partial class FormPagos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbPago = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnQuitarProd = new System.Windows.Forms.Button();
            this.listaPed = new System.Windows.Forms.ListView();
            this.NUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PROD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COSTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.btnPagoTarjeta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBillete20 = new System.Windows.Forms.Button();
            this.btnBillete50 = new System.Windows.Forms.Button();
            this.btnBillete100 = new System.Windows.Forms.Button();
            this.btnBillete200 = new System.Windows.Forms.Button();
            this.btnBillete500 = new System.Windows.Forms.Button();
            this.btnPagoExacto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txboxCantidad = new System.Windows.Forms.TextBox();
            this.btn00 = new System.Windows.Forms.Button();
            this.btnPagarCa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.lbPago);
            this.panel2.Controls.Add(this.lbSubTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 100);
            this.panel2.TabIndex = 6;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(221, 74);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(29, 20);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "$0";
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPago.Location = new System.Drawing.Point(221, 44);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(29, 20);
            this.lbPago.TabIndex = 4;
            this.lbPago.Text = "$0";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.Location = new System.Drawing.Point(221, 12);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(29, 20);
            this.lbSubTotal.TabIndex = 3;
            this.lbSubTotal.Text = "$0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PAGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUB TOTAL";
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(696, 502);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(206, 66);
            this.btnProductos.TabIndex = 10;
            this.btnProductos.Text = "PANTALLA DE PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnQuitarProd
            // 
            this.btnQuitarProd.Location = new System.Drawing.Point(343, 502);
            this.btnQuitarProd.Name = "btnQuitarProd";
            this.btnQuitarProd.Size = new System.Drawing.Size(222, 66);
            this.btnQuitarProd.TabIndex = 9;
            this.btnQuitarProd.Text = "QUITAR PRODUCTO";
            this.btnQuitarProd.UseVisualStyleBackColor = true;
            // 
            // listaPed
            // 
            this.listaPed.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listaPed.AllowColumnReorder = true;
            this.listaPed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NUM,
            this.PROD,
            this.COSTO});
            this.listaPed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listaPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPed.FullRowSelect = true;
            this.listaPed.GridLines = true;
            this.listaPed.Location = new System.Drawing.Point(2, 12);
            this.listaPed.MultiSelect = false;
            this.listaPed.Name = "listaPed";
            this.listaPed.Size = new System.Drawing.Size(339, 450);
            this.listaPed.TabIndex = 11;
            this.listaPed.UseCompatibleStateImageBehavior = false;
            this.listaPed.View = System.Windows.Forms.View.Details;
            // 
            // NUM
            // 
            this.NUM.Text = "NUM";
            this.NUM.Width = 51;
            // 
            // PROD
            // 
            this.PROD.Text = "PRODUCTO ";
            this.PROD.Width = 193;
            // 
            // COSTO
            // 
            this.COSTO.Text = "COSTO";
            this.COSTO.Width = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "PAGOS";
            // 
            // btnPagoTarjeta
            // 
            this.btnPagoTarjeta.Location = new System.Drawing.Point(16, 42);
            this.btnPagoTarjeta.Name = "btnPagoTarjeta";
            this.btnPagoTarjeta.Size = new System.Drawing.Size(242, 63);
            this.btnPagoTarjeta.TabIndex = 1;
            this.btnPagoTarjeta.Text = "PAGO CON TARJETA";
            this.btnPagoTarjeta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBillete500);
            this.groupBox1.Controls.Add(this.btnBillete200);
            this.groupBox1.Controls.Add(this.btnBillete100);
            this.groupBox1.Controls.Add(this.btnBillete50);
            this.groupBox1.Controls.Add(this.btnBillete20);
            this.groupBox1.Location = new System.Drawing.Point(3, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BILLETES";
            // 
            // btnBillete20
            // 
            this.btnBillete20.Location = new System.Drawing.Point(6, 30);
            this.btnBillete20.Name = "btnBillete20";
            this.btnBillete20.Size = new System.Drawing.Size(81, 56);
            this.btnBillete20.TabIndex = 3;
            this.btnBillete20.Text = "$20";
            this.btnBillete20.UseVisualStyleBackColor = true;
            // 
            // btnBillete50
            // 
            this.btnBillete50.Location = new System.Drawing.Point(93, 30);
            this.btnBillete50.Name = "btnBillete50";
            this.btnBillete50.Size = new System.Drawing.Size(81, 56);
            this.btnBillete50.TabIndex = 4;
            this.btnBillete50.Text = "$50";
            this.btnBillete50.UseVisualStyleBackColor = true;
            // 
            // btnBillete100
            // 
            this.btnBillete100.Location = new System.Drawing.Point(177, 30);
            this.btnBillete100.Name = "btnBillete100";
            this.btnBillete100.Size = new System.Drawing.Size(81, 56);
            this.btnBillete100.TabIndex = 5;
            this.btnBillete100.Text = "$100";
            this.btnBillete100.UseVisualStyleBackColor = true;
            // 
            // btnBillete200
            // 
            this.btnBillete200.Location = new System.Drawing.Point(38, 108);
            this.btnBillete200.Name = "btnBillete200";
            this.btnBillete200.Size = new System.Drawing.Size(81, 56);
            this.btnBillete200.TabIndex = 6;
            this.btnBillete200.Text = "$200";
            this.btnBillete200.UseVisualStyleBackColor = true;
            // 
            // btnBillete500
            // 
            this.btnBillete500.Location = new System.Drawing.Point(125, 108);
            this.btnBillete500.Name = "btnBillete500";
            this.btnBillete500.Size = new System.Drawing.Size(81, 56);
            this.btnBillete500.TabIndex = 7;
            this.btnBillete500.Text = "$500";
            this.btnBillete500.UseVisualStyleBackColor = true;
            // 
            // btnPagoExacto
            // 
            this.btnPagoExacto.Location = new System.Drawing.Point(16, 351);
            this.btnPagoExacto.Name = "btnPagoExacto";
            this.btnPagoExacto.Size = new System.Drawing.Size(242, 56);
            this.btnPagoExacto.TabIndex = 3;
            this.btnPagoExacto.Text = "PAGO EXACTO";
            this.btnPagoExacto.UseVisualStyleBackColor = true;
            this.btnPagoExacto.Click += new System.EventHandler(this.btnPagoExacto_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPagoExacto);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnPagoTarjeta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(343, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 449);
            this.panel1.TabIndex = 7;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(201, 69);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 66);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(105, 69);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 66);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(9, 69);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 66);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(201, 141);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 66);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(105, 141);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 66);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(9, 141);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 66);
            this.btn4.TabIndex = 18;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(201, 213);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 66);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(105, 213);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 66);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(9, 213);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 66);
            this.btn1.TabIndex = 21;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(9, 285);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 66);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // txboxCantidad
            // 
            this.txboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxCantidad.Location = new System.Drawing.Point(9, 10);
            this.txboxCantidad.Multiline = true;
            this.txboxCantidad.Name = "txboxCantidad";
            this.txboxCantidad.Size = new System.Drawing.Size(282, 49);
            this.txboxCantidad.TabIndex = 23;
            this.txboxCantidad.Text = "0";
            this.txboxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn00
            // 
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(105, 285);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(186, 66);
            this.btn00.TabIndex = 24;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btnPagarCa
            // 
            this.btnPagarCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarCa.Location = new System.Drawing.Point(105, 357);
            this.btnPagarCa.Name = "btnPagarCa";
            this.btnPagarCa.Size = new System.Drawing.Size(186, 66);
            this.btnPagarCa.TabIndex = 25;
            this.btnPagarCa.Text = "PAGAR";
            this.btnPagarCa.UseVisualStyleBackColor = true;
            this.btnPagarCa.Click += new System.EventHandler(this.btnPagarCa_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Controls.Add(this.btnPagarCa);
            this.panel3.Controls.Add(this.btn00);
            this.panel3.Controls.Add(this.txboxCantidad);
            this.panel3.Controls.Add(this.btn0);
            this.panel3.Controls.Add(this.btn1);
            this.panel3.Controls.Add(this.btn2);
            this.panel3.Controls.Add(this.btn3);
            this.panel3.Controls.Add(this.btn4);
            this.panel3.Controls.Add(this.btn5);
            this.panel3.Controls.Add(this.btn6);
            this.panel3.Controls.Add(this.btn7);
            this.panel3.Controls.Add(this.btn8);
            this.panel3.Controls.Add(this.btn9);
            this.panel3.Location = new System.Drawing.Point(621, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 449);
            this.panel3.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(9, 357);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 66);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "C";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.ControlBox = false;
            this.Controls.Add(this.listaPed);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnQuitarProd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPagos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbPago;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnQuitarProd;
        private System.Windows.Forms.ListView listaPed;
        private System.Windows.Forms.ColumnHeader NUM;
        private System.Windows.Forms.ColumnHeader PROD;
        private System.Windows.Forms.ColumnHeader COSTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPagoTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBillete500;
        private System.Windows.Forms.Button btnBillete200;
        private System.Windows.Forms.Button btnBillete100;
        private System.Windows.Forms.Button btnBillete50;
        private System.Windows.Forms.Button btnBillete20;
        private System.Windows.Forms.Button btnPagoExacto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txboxCantidad;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnPagarCa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLimpiar;
    }
}