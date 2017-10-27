namespace WindowsFormsApplication1
{
    partial class FormTomaOrden
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

        /*{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTomaOrden));
            this.button1 = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnQuitarProd = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.COSTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaPed = new System.Windows.Forms.ListView();
            this.NUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PRODUCTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.lbPago = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPorPagar = new System.Windows.Forms.Label();
            this.panelPago = new System.Windows.Forms.Panel();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPagarCa = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBillete500 = new System.Windows.Forms.Button();
            this.btnBillete200 = new System.Windows.Forms.Button();
            this.btnBillete100 = new System.Windows.Forms.Button();
            this.btnBillete50 = new System.Windows.Forms.Button();
            this.btnBillete20 = new System.Windows.Forms.Button();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.tipoPagoLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMoneda1 = new System.Windows.Forms.Button();
            this.btnMoneda50c = new System.Windows.Forms.Button();
            this.btnMoneda2 = new System.Windows.Forms.Button();
            this.btnMoneda5 = new System.Windows.Forms.Button();
            this.btnMoneda10 = new System.Windows.Forms.Button();
            this.btnPagoTarjeta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.txboxCantidad = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.panelTarjeta = new System.Windows.Forms.Panel();
            this.btnCancelarTarjeta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pBAmerican = new System.Windows.Forms.PictureBox();
            this.pBMasterCard = new System.Windows.Forms.PictureBox();
            this.pBoxVisa = new System.Windows.Forms.PictureBox();
            this.panelActiveVisa = new System.Windows.Forms.Panel();
            this.panelActiveMC = new System.Windows.Forms.Panel();
            this.panelActiveAE = new System.Windows.Forms.Panel();
            this.panelCambio = new System.Windows.Forms.Panel();
            this.panelCambioDash = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.listDineroEnCaja = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.listCambio = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VALOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.btnCancelarDash = new System.Windows.Forms.Button();
            this.pictureBoxWarning = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCambio = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelRefresco = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCorte = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelPago.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAmerican)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMasterCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVisa)).BeginInit();
            this.panelCambio.SuspendLayout();
            this.panelCambioDash.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).BeginInit();
            this.panelRefresco.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(1007, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 130);
            this.button1.TabIndex = 8;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(793, 270);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(85, 20);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "COMBOS";
            // 
            // btnQuitarProd
            // 
            this.btnQuitarProd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnQuitarProd.FlatAppearance.BorderSize = 5;
            this.btnQuitarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQuitarProd.Location = new System.Drawing.Point(560, 624);
            this.btnQuitarProd.Name = "btnQuitarProd";
            this.btnQuitarProd.Size = new System.Drawing.Size(130, 130);
            this.btnQuitarProd.TabIndex = 4;
            this.btnQuitarProd.Text = "QUITAR PRODUCTO";
            this.btnQuitarProd.UseVisualStyleBackColor = true;
            this.btnQuitarProd.Click += new System.EventHandler(this.btnQuitarProd_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPagar.Location = new System.Drawing.Point(1005, 627);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(130, 130);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(1005, 627);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 130);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // COSTO
            // 
            this.COSTO.Text = "COSTO";
            this.COSTO.Width = 77;
            // 
            // listaPed
            // 
            this.listaPed.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listaPed.AllowColumnReorder = true;
            this.listaPed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NUM,
            this.PRODUCTO,
            this.COSTO});
            this.listaPed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listaPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPed.FullRowSelect = true;
            this.listaPed.GridLines = true;
            this.listaPed.Location = new System.Drawing.Point(97, 149);
            this.listaPed.MultiSelect = false;
            this.listaPed.Name = "listaPed";
            this.listaPed.Size = new System.Drawing.Size(457, 472);
            this.listaPed.TabIndex = 1;
            this.listaPed.UseCompatibleStateImageBehavior = false;
            this.listaPed.View = System.Windows.Forms.View.Details;
            // 
            // NUM
            // 
            this.NUM.Text = "NUM";
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.Text = "PRODUCTO";
            this.PRODUCTO.Width = 204;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(560, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 325);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(560, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Familias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "POR PAGAR";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.Location = new System.Drawing.Point(266, 12);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(29, 20);
            this.lbSubTotal.TabIndex = 3;
            this.lbSubTotal.Text = "$0";
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPago.Location = new System.Drawing.Point(266, 44);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(29, 20);
            this.lbPago.TabIndex = 4;
            this.lbPago.Text = "$0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbPorPagar);
            this.panel2.Controls.Add(this.lbPago);
            this.panel2.Controls.Add(this.lbSubTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(97, 624);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 129);
            this.panel2.TabIndex = 4;
            // 
            // lbPorPagar
            // 
            this.lbPorPagar.AutoSize = true;
            this.lbPorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorPagar.Location = new System.Drawing.Point(266, 74);
            this.lbPorPagar.Name = "lbPorPagar";
            this.lbPorPagar.Size = new System.Drawing.Size(29, 20);
            this.lbPorPagar.TabIndex = 5;
            this.lbPorPagar.Text = "$0";
            // 
            // panelPago
            // 
            this.panelPago.Controls.Add(this.btnC);
            this.panelPago.Controls.Add(this.btnPagarCa);
            this.panelPago.Controls.Add(this.panel4);
            this.panelPago.Location = new System.Drawing.Point(558, 149);
            this.panelPago.Name = "panelPago";
            this.panelPago.Size = new System.Drawing.Size(577, 472);
            this.panelPago.TabIndex = 10;
            this.panelPago.Visible = false;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(2, 400);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(258, 66);
            this.btnC.TabIndex = 33;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPagarCa
            // 
            this.btnPagarCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarCa.Location = new System.Drawing.Point(360, 400);
            this.btnPagarCa.Name = "btnPagarCa";
            this.btnPagarCa.Size = new System.Drawing.Size(204, 66);
            this.btnPagarCa.TabIndex = 32;
            this.btnPagarCa.Text = "PAGAR";
            this.btnPagarCa.UseVisualStyleBackColor = true;
            this.btnPagarCa.Click += new System.EventHandler(this.btnPagarCa_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.lblTipoPago);
            this.panel4.Controls.Add(this.tipoPagoLabel);
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.btnPagoTarjeta);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(565, 390);
            this.panel4.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBillete500);
            this.groupBox2.Controls.Add(this.btnBillete200);
            this.groupBox2.Controls.Add(this.btnBillete100);
            this.groupBox2.Controls.Add(this.btnBillete50);
            this.groupBox2.Controls.Add(this.btnBillete20);
            this.groupBox2.Location = new System.Drawing.Point(10, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BILLETES";
            // 
            // btnBillete500
            // 
            this.btnBillete500.Location = new System.Drawing.Point(177, 82);
            this.btnBillete500.Name = "btnBillete500";
            this.btnBillete500.Size = new System.Drawing.Size(81, 56);
            this.btnBillete500.TabIndex = 7;
            this.btnBillete500.Text = "$500";
            this.btnBillete500.UseVisualStyleBackColor = true;
            this.btnBillete500.Click += new System.EventHandler(this.btnBillete500_Click);
            // 
            // btnBillete200
            // 
            this.btnBillete200.Location = new System.Drawing.Point(6, 82);
            this.btnBillete200.Name = "btnBillete200";
            this.btnBillete200.Size = new System.Drawing.Size(81, 56);
            this.btnBillete200.TabIndex = 6;
            this.btnBillete200.Text = "$200";
            this.btnBillete200.UseVisualStyleBackColor = true;
            this.btnBillete200.Click += new System.EventHandler(this.btnBillete200_Click);
            // 
            // btnBillete100
            // 
            this.btnBillete100.Location = new System.Drawing.Point(177, 20);
            this.btnBillete100.Name = "btnBillete100";
            this.btnBillete100.Size = new System.Drawing.Size(81, 56);
            this.btnBillete100.TabIndex = 5;
            this.btnBillete100.Text = "$100";
            this.btnBillete100.UseVisualStyleBackColor = true;
            this.btnBillete100.Click += new System.EventHandler(this.btnBillete100_Click);
            // 
            // btnBillete50
            // 
            this.btnBillete50.Location = new System.Drawing.Point(93, 20);
            this.btnBillete50.Name = "btnBillete50";
            this.btnBillete50.Size = new System.Drawing.Size(81, 56);
            this.btnBillete50.TabIndex = 4;
            this.btnBillete50.Text = "$50";
            this.btnBillete50.UseVisualStyleBackColor = true;
            this.btnBillete50.Click += new System.EventHandler(this.btnBillete50_Click);
            // 
            // btnBillete20
            // 
            this.btnBillete20.Location = new System.Drawing.Point(6, 20);
            this.btnBillete20.Name = "btnBillete20";
            this.btnBillete20.Size = new System.Drawing.Size(81, 56);
            this.btnBillete20.TabIndex = 3;
            this.btnBillete20.Text = "$20";
            this.btnBillete20.UseVisualStyleBackColor = true;
            this.btnBillete20.Click += new System.EventHandler(this.btnBillete20_Click);
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(363, 52);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(45, 13);
            this.lblTipoPago.TabIndex = 10;
            this.lblTipoPago.Text = "efectivo";
            // 
            // tipoPagoLabel
            // 
            this.tipoPagoLabel.AutoSize = true;
            this.tipoPagoLabel.Location = new System.Drawing.Point(275, 51);
            this.tipoPagoLabel.Name = "tipoPagoLabel";
            this.tipoPagoLabel.Size = new System.Drawing.Size(83, 13);
            this.tipoPagoLabel.TabIndex = 9;
            this.tipoPagoLabel.Text = "TIPO DE PAGO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMoneda1);
            this.groupBox3.Controls.Add(this.btnMoneda50c);
            this.groupBox3.Controls.Add(this.btnMoneda2);
            this.groupBox3.Controls.Add(this.btnMoneda5);
            this.groupBox3.Controls.Add(this.btnMoneda10);
            this.groupBox3.Location = new System.Drawing.Point(272, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 146);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monedas";
            // 
            // btnMoneda1
            // 
            this.btnMoneda1.Location = new System.Drawing.Point(5, 79);
            this.btnMoneda1.Name = "btnMoneda1";
            this.btnMoneda1.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda1.TabIndex = 7;
            this.btnMoneda1.Text = "$1";
            this.btnMoneda1.UseVisualStyleBackColor = true;
            this.btnMoneda1.Click += new System.EventHandler(this.btnMoneda1_Click);
            // 
            // btnMoneda50c
            // 
            this.btnMoneda50c.Location = new System.Drawing.Point(92, 79);
            this.btnMoneda50c.Name = "btnMoneda50c";
            this.btnMoneda50c.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda50c.TabIndex = 6;
            this.btnMoneda50c.Text = "$0.50";
            this.btnMoneda50c.UseVisualStyleBackColor = true;
            this.btnMoneda50c.Click += new System.EventHandler(this.btnMoneda50c_Click);
            // 
            // btnMoneda2
            // 
            this.btnMoneda2.Location = new System.Drawing.Point(177, 20);
            this.btnMoneda2.Name = "btnMoneda2";
            this.btnMoneda2.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda2.TabIndex = 5;
            this.btnMoneda2.Text = "$2";
            this.btnMoneda2.UseVisualStyleBackColor = true;
            this.btnMoneda2.Click += new System.EventHandler(this.btnMoneda2_Click);
            // 
            // btnMoneda5
            // 
            this.btnMoneda5.Location = new System.Drawing.Point(93, 20);
            this.btnMoneda5.Name = "btnMoneda5";
            this.btnMoneda5.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda5.TabIndex = 4;
            this.btnMoneda5.Text = "$5";
            this.btnMoneda5.UseVisualStyleBackColor = true;
            this.btnMoneda5.Click += new System.EventHandler(this.btnMoneda5_Click);
            // 
            // btnMoneda10
            // 
            this.btnMoneda10.Location = new System.Drawing.Point(6, 20);
            this.btnMoneda10.Name = "btnMoneda10";
            this.btnMoneda10.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda10.TabIndex = 3;
            this.btnMoneda10.Text = "$10";
            this.btnMoneda10.UseVisualStyleBackColor = true;
            this.btnMoneda10.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPagoTarjeta
            // 
            this.btnPagoTarjeta.Location = new System.Drawing.Point(16, 27);
            this.btnPagoTarjeta.Name = "btnPagoTarjeta";
            this.btnPagoTarjeta.Size = new System.Drawing.Size(242, 63);
            this.btnPagoTarjeta.TabIndex = 1;
            this.btnPagoTarjeta.Text = "PAGO CON TARJETA";
            this.btnPagoTarjeta.UseVisualStyleBackColor = true;
            this.btnPagoTarjeta.Click += new System.EventHandler(this.btnPagoTarjeta_Click);
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnPunto);
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
            this.panel3.Location = new System.Drawing.Point(1159, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 389);
            this.panel3.TabIndex = 10;
            this.panel3.Visible = false;
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(105, 285);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(90, 66);
            this.btnPunto.TabIndex = 27;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn00
            // 
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(201, 285);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(90, 66);
            this.btn00.TabIndex = 24;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // txboxCantidad
            // 
            this.txboxCantidad.Enabled = false;
            this.txboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxCantidad.Location = new System.Drawing.Point(9, 10);
            this.txboxCantidad.Multiline = true;
            this.txboxCantidad.Name = "txboxCantidad";
            this.txboxCantidad.Size = new System.Drawing.Size(282, 49);
            this.txboxCantidad.TabIndex = 23;
            this.txboxCantidad.Text = "0";
            this.txboxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btn0.Click += new System.EventHandler(this.btnNumero_Click);
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
            this.btn1.Click += new System.EventHandler(this.btnNumero_Click);
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
            this.btn2.Click += new System.EventHandler(this.btnNumero_Click);
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
            this.btn3.Click += new System.EventHandler(this.btnNumero_Click);
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
            this.btn4.Click += new System.EventHandler(this.btnNumero_Click);
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
            this.btn5.Click += new System.EventHandler(this.btnNumero_Click);
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
            this.btn6.Click += new System.EventHandler(this.btnNumero_Click);
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
            this.btn7.Click += new System.EventHandler(this.btnNumero_Click);
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
            this.btn8.Click += new System.EventHandler(this.btnNumero_Click);
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
            this.btn9.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // panelTarjeta
            // 
            this.panelTarjeta.Controls.Add(this.btnCancelarTarjeta);
            this.panelTarjeta.Controls.Add(this.label5);
            this.panelTarjeta.Controls.Add(this.pBAmerican);
            this.panelTarjeta.Controls.Add(this.pBMasterCard);
            this.panelTarjeta.Controls.Add(this.pBoxVisa);
            this.panelTarjeta.Controls.Add(this.panelActiveVisa);
            this.panelTarjeta.Controls.Add(this.panelActiveMC);
            this.panelTarjeta.Controls.Add(this.panelActiveAE);
            this.panelTarjeta.Location = new System.Drawing.Point(386, 194);
            this.panelTarjeta.Name = "panelTarjeta";
            this.panelTarjeta.Size = new System.Drawing.Size(423, 321);
            this.panelTarjeta.TabIndex = 13;
            this.panelTarjeta.Visible = false;
            // 
            // btnCancelarTarjeta
            // 
            this.btnCancelarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTarjeta.Location = new System.Drawing.Point(127, 237);
            this.btnCancelarTarjeta.Name = "btnCancelarTarjeta";
            this.btnCancelarTarjeta.Size = new System.Drawing.Size(186, 66);
            this.btnCancelarTarjeta.TabIndex = 26;
            this.btnCancelarTarjeta.Text = "CANCELAR";
            this.btnCancelarTarjeta.UseVisualStyleBackColor = true;
            this.btnCancelarTarjeta.Click += new System.EventHandler(this.btnCancelarTarjeta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // pBAmerican
            // 
            this.pBAmerican.Image = global::WindowsFormsApplication1.Properties.Resources.american;
            this.pBAmerican.Location = new System.Drawing.Point(317, 124);
            this.pBAmerican.Name = "pBAmerican";
            this.pBAmerican.Size = new System.Drawing.Size(94, 86);
            this.pBAmerican.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAmerican.TabIndex = 2;
            this.pBAmerican.TabStop = false;
            this.pBAmerican.Click += new System.EventHandler(this.pBAmerican_Click);
            // 
            // pBMasterCard
            // 
            this.pBMasterCard.Image = global::WindowsFormsApplication1.Properties.Resources.mastercard;
            this.pBMasterCard.Location = new System.Drawing.Point(144, 124);
            this.pBMasterCard.Name = "pBMasterCard";
            this.pBMasterCard.Size = new System.Drawing.Size(153, 86);
            this.pBMasterCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMasterCard.TabIndex = 1;
            this.pBMasterCard.TabStop = false;
            this.pBMasterCard.Click += new System.EventHandler(this.pBMasterCard_Click);
            // 
            // pBoxVisa
            // 
            this.pBoxVisa.Image = global::WindowsFormsApplication1.Properties.Resources.visa;
            this.pBoxVisa.Location = new System.Drawing.Point(13, 124);
            this.pBoxVisa.Name = "pBoxVisa";
            this.pBoxVisa.Size = new System.Drawing.Size(116, 86);
            this.pBoxVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxVisa.TabIndex = 0;
            this.pBoxVisa.TabStop = false;
            this.pBoxVisa.Click += new System.EventHandler(this.pBoxVisa_Click);
            // 
            // panelActiveVisa
            // 
            this.panelActiveVisa.BackColor = System.Drawing.Color.Black;
            this.panelActiveVisa.Location = new System.Drawing.Point(8, 118);
            this.panelActiveVisa.Name = "panelActiveVisa";
            this.panelActiveVisa.Size = new System.Drawing.Size(125, 100);
            this.panelActiveVisa.TabIndex = 28;
            this.panelActiveVisa.Visible = false;
            // 
            // panelActiveMC
            // 
            this.panelActiveMC.BackColor = System.Drawing.Color.Black;
            this.panelActiveMC.Location = new System.Drawing.Point(135, 118);
            this.panelActiveMC.Name = "panelActiveMC";
            this.panelActiveMC.Size = new System.Drawing.Size(173, 100);
            this.panelActiveMC.TabIndex = 29;
            this.panelActiveMC.Visible = false;
            // 
            // panelActiveAE
            // 
            this.panelActiveAE.BackColor = System.Drawing.Color.Black;
            this.panelActiveAE.Location = new System.Drawing.Point(311, 118);
            this.panelActiveAE.Name = "panelActiveAE";
            this.panelActiveAE.Size = new System.Drawing.Size(109, 100);
            this.panelActiveAE.TabIndex = 30;
            this.panelActiveAE.Visible = false;
            // 
            // panelCambio
            // 
            this.panelCambio.Controls.Add(this.panelCambioDash);
            this.panelCambio.Controls.Add(this.btnCancelarDash);
            this.panelCambio.Controls.Add(this.pictureBoxWarning);
            this.panelCambio.Controls.Add(this.btnAceptar);
            this.panelCambio.Controls.Add(this.lblCambio);
            this.panelCambio.Location = new System.Drawing.Point(77, 12);
            this.panelCambio.Name = "panelCambio";
            this.panelCambio.Size = new System.Drawing.Size(1182, 745);
            this.panelCambio.TabIndex = 31;
            this.panelCambio.Visible = false;
            this.panelCambio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCambio_Paint);
            // 
            // panelCambioDash
            // 
            this.panelCambioDash.Controls.Add(this.label9);
            this.panelCambioDash.Controls.Add(this.listDineroEnCaja);
            this.panelCambioDash.Controls.Add(this.button13);
            this.panelCambioDash.Controls.Add(this.button14);
            this.panelCambioDash.Controls.Add(this.listCambio);
            this.panelCambioDash.Controls.Add(this.groupBox4);
            this.panelCambioDash.Controls.Add(this.groupBox5);
            this.panelCambioDash.Controls.Add(this.label7);
            this.panelCambioDash.Controls.Add(this.textBoxCambio);
            this.panelCambioDash.Location = new System.Drawing.Point(91, 82);
            this.panelCambioDash.Name = "panelCambioDash";
            this.panelCambioDash.Size = new System.Drawing.Size(1031, 558);
            this.panelCambioDash.TabIndex = 30;
            this.panelCambioDash.Visible = false;
            this.panelCambioDash.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCambioDash_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "DINERO EN CAJA";
            // 
            // listDineroEnCaja
            // 
            this.listDineroEnCaja.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listDineroEnCaja.AllowColumnReorder = true;
            this.listDineroEnCaja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listDineroEnCaja.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listDineroEnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDineroEnCaja.FullRowSelect = true;
            this.listDineroEnCaja.GridLines = true;
            this.listDineroEnCaja.Location = new System.Drawing.Point(46, 48);
            this.listDineroEnCaja.MultiSelect = false;
            this.listDineroEnCaja.Name = "listDineroEnCaja";
            this.listDineroEnCaja.Size = new System.Drawing.Size(267, 422);
            this.listDineroEnCaja.TabIndex = 45;
            this.listDineroEnCaja.UseCompatibleStateImageBehavior = false;
            this.listDineroEnCaja.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NUM";
            this.columnHeader2.Width = 54;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EFECTIVO";
            this.columnHeader3.Width = 204;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button13.Location = new System.Drawing.Point(863, 461);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 56);
            this.button13.TabIndex = 43;
            this.button13.Text = "QUITAR";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(391, 451);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 66);
            this.button14.TabIndex = 44;
            this.button14.Text = "C";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // listCambio
            // 
            this.listCambio.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listCambio.AllowColumnReorder = true;
            this.listCambio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.VALOR});
            this.listCambio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCambio.FullRowSelect = true;
            this.listCambio.GridLines = true;
            this.listCambio.Location = new System.Drawing.Point(707, 24);
            this.listCambio.MultiSelect = false;
            this.listCambio.Name = "listCambio";
            this.listCambio.Size = new System.Drawing.Size(267, 422);
            this.listCambio.TabIndex = 42;
            this.listCambio.UseCompatibleStateImageBehavior = false;
            this.listCambio.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NUM";
            this.columnHeader1.Width = 54;
            // 
            // VALOR
            // 
            this.VALOR.Text = "EFECTIVO";
            this.VALOR.Width = 204;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(390, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 174);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monedas";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button3.Location = new System.Drawing.Point(6, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 56);
            this.button3.TabIndex = 7;
            this.button3.Text = "$1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.Location = new System.Drawing.Point(176, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "$0.50";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button5.Location = new System.Drawing.Point(176, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "$2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button6.Location = new System.Drawing.Point(92, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 56);
            this.button6.TabIndex = 4;
            this.button6.Text = "$5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button7.Location = new System.Drawing.Point(5, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 56);
            this.button7.TabIndex = 3;
            this.button7.Text = "$10";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(390, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 164);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BILLETES";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button8.Location = new System.Drawing.Point(176, 89);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 56);
            this.button8.TabIndex = 7;
            this.button8.Text = "$500";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button9.Location = new System.Drawing.Point(5, 89);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 56);
            this.button9.TabIndex = 6;
            this.button9.Text = "$200";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button10.Location = new System.Drawing.Point(176, 27);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 56);
            this.button10.TabIndex = 5;
            this.button10.Text = "$100";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button11.Location = new System.Drawing.Point(92, 27);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(81, 56);
            this.button11.TabIndex = 4;
            this.button11.Text = "$50";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button12.Location = new System.Drawing.Point(5, 27);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(81, 56);
            this.button12.TabIndex = 3;
            this.button12.Text = "$20";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "SELECCIONA EL CAMBIO";
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.Enabled = false;
            this.textBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCambio.Location = new System.Drawing.Point(383, 54);
            this.textBoxCambio.Multiline = true;
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.Size = new System.Drawing.Size(282, 49);
            this.textBoxCambio.TabIndex = 38;
            this.textBoxCambio.Text = "0";
            this.textBoxCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancelarDash
            // 
            this.btnCancelarDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDash.Location = new System.Drawing.Point(137, 646);
            this.btnCancelarDash.Name = "btnCancelarDash";
            this.btnCancelarDash.Size = new System.Drawing.Size(186, 66);
            this.btnCancelarDash.TabIndex = 31;
            this.btnCancelarDash.Text = "CANCELAR";
            this.btnCancelarDash.UseVisualStyleBackColor = true;
            this.btnCancelarDash.Visible = false;
            this.btnCancelarDash.Click += new System.EventHandler(this.btnCancelarDash_Click);
            // 
            // pictureBoxWarning
            // 
            this.pictureBoxWarning.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWarning.Image")));
            this.pictureBoxWarning.Location = new System.Drawing.Point(370, 114);
            this.pictureBoxWarning.Name = "pictureBoxWarning";
            this.pictureBoxWarning.Size = new System.Drawing.Size(155, 132);
            this.pictureBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWarning.TabIndex = 29;
            this.pictureBoxWarning.TabStop = false;
            this.pictureBoxWarning.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(879, 646);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(186, 66);
            this.btnAceptar.TabIndex = 28;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCambio.Location = new System.Drawing.Point(365, 50);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(0, 29);
            this.lblCambio.TabIndex = 1;
            this.lblCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(97, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 130);
            this.button2.TabIndex = 12;
            this.button2.Text = "PRE CORTE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelRefresco
            // 
            this.panelRefresco.Controls.Add(this.label8);
            this.panelRefresco.Location = new System.Drawing.Point(874, 741);
            this.panelRefresco.Name = "panelRefresco";
            this.panelRefresco.Size = new System.Drawing.Size(664, 466);
            this.panelRefresco.TabIndex = 14;
            this.panelRefresco.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(378, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "SELECCIONE EL REFRESCO DE EL COMBO";
            // 
            // BtnCorte
            // 
            this.BtnCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnCorte.Location = new System.Drawing.Point(564, 13);
            this.BtnCorte.Name = "BtnCorte";
            this.BtnCorte.Size = new System.Drawing.Size(130, 130);
            this.BtnCorte.TabIndex = 32;
            this.BtnCorte.Text = "Corte Caja";
            this.BtnCorte.UseVisualStyleBackColor = true;
            this.BtnCorte.Click += new System.EventHandler(this.BtnCorte_Click);
            // 
            // FormTomaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 766);
            this.ControlBox = false;
            this.Controls.Add(this.panelCambio);
            this.Controls.Add(this.BtnCorte);
            this.Controls.Add(this.panelTarjeta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelRefresco);
            this.Controls.Add(this.panelPago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitarProd);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaPed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTomaOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormTomaOrden_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPago.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTarjeta.ResumeLayout(false);
            this.panelTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAmerican)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMasterCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVisa)).EndInit();
            this.panelCambio.ResumeLayout(false);
            this.panelCambio.PerformLayout();
            this.panelCambioDash.ResumeLayout(false);
            this.panelCambioDash.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).EndInit();
            this.panelRefresco.ResumeLayout(false);
            this.panelRefresco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

*/
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTomaOrden));
            this.button1 = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnQuitarProd = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.COSTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaPed = new System.Windows.Forms.ListView();
            this.NUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PRODUCTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.lbPago = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPorPagar = new System.Windows.Forms.Label();
            this.panelCambio = new System.Windows.Forms.Panel();
            this.btnCancelarDash = new System.Windows.Forms.Button();
            this.pictureBoxWarning = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCambio = new System.Windows.Forms.Label();
            this.panelCambioDash = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.listDineroEnCaja = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.listCambio = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VALOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCambio = new System.Windows.Forms.TextBox();
            this.panelTarjeta = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.tarjeta = new System.Windows.Forms.Button();
            this.btnCancelarTarjeta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pBAmerican = new System.Windows.Forms.PictureBox();
            this.pBMasterCard = new System.Windows.Forms.PictureBox();
            this.pBoxVisa = new System.Windows.Forms.PictureBox();
            this.panelActiveVisa = new System.Windows.Forms.Panel();
            this.panelActiveMC = new System.Windows.Forms.Panel();
            this.panelActiveAE = new System.Windows.Forms.Panel();
            this.panelExtras = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panelMonedasT = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.textBoxMonedas = new System.Windows.Forms.TextBox();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.tipoPagoLabel = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPagoTarjeta = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelRefresco = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCorte = new System.Windows.Forms.Button();
            this.panelDenominaciones = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBillete500 = new System.Windows.Forms.Button();
            this.btnBillete200 = new System.Windows.Forms.Button();
            this.btnBillete100 = new System.Windows.Forms.Button();
            this.btnBillete50 = new System.Windows.Forms.Button();
            this.btnBillete20 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMoneda1 = new System.Windows.Forms.Button();
            this.btnMoneda50c = new System.Windows.Forms.Button();
            this.btnMoneda2 = new System.Windows.Forms.Button();
            this.btnMoneda5 = new System.Windows.Forms.Button();
            this.btnMoneda10 = new System.Windows.Forms.Button();
            this.panelMonedas = new System.Windows.Forms.Panel();
            this.btnPagoDiferido = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.textboxDineroCa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.panelCorte = new System.Windows.Forms.Panel();
            this.txtVerCorte = new System.Windows.Forms.TextBox();
            this.btnCorteAceptar = new System.Windows.Forms.Button();
            this.panelCuadreCaja = new System.Windows.Forms.Panel();
            this.labelRestantePagarDiferidoMensaje = new System.Windows.Forms.Label();
            this.labelRestanteDiferido = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelTotalPagarDiferido = new System.Windows.Forms.Label();
            this.labelTotalPagarDiferidoMensaje = new System.Windows.Forms.Label();
            this.btnPagarDiferido = new System.Windows.Forms.Button();
            this.panelTarjetaCuadre = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnOkCuadreTarjeta = new System.Windows.Forms.Button();
            this.textBoxTarjetaCuadre = new System.Windows.Forms.TextBox();
            this.btn6CuadreTarjeta = new System.Windows.Forms.Button();
            this.btn5CuadreTarjeta = new System.Windows.Forms.Button();
            this.btn4CuadreTarjeta = new System.Windows.Forms.Button();
            this.btn3CuadreTarjeta = new System.Windows.Forms.Button();
            this.btn2CuadreTarjeta = new System.Windows.Forms.Button();
            this.btncCuadreTarjeta = new System.Windows.Forms.Button();
            this.btn0CuadreTarjeta = new System.Windows.Forms.Button();
            this.btn7CuadreTarjeta = new System.Windows.Forms.Button();
            this.btn9CuadreTarjeta = new System.Windows.Forms.Button();
            this.btn8CuadreTarjeta = new System.Windows.Forms.Button();
            this.btn1CuadreTarjeta = new System.Windows.Forms.Button();
            this.labelTotalCuadre = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelTarjetaCuadre = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelEfectivoCuadre = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.listViewCuadreCaja = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelEfectivoCuadre = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxCuadreIndique = new System.Windows.Forms.TextBox();
            this.btn6cuadre = new System.Windows.Forms.Button();
            this.btn5cuadre = new System.Windows.Forms.Button();
            this.btn4cuadre = new System.Windows.Forms.Button();
            this.btn3cuadre = new System.Windows.Forms.Button();
            this.btn2cuadre = new System.Windows.Forms.Button();
            this.btnCCuadre = new System.Windows.Forms.Button();
            this.btn0cuadre = new System.Windows.Forms.Button();
            this.btn7cuadre = new System.Windows.Forms.Button();
            this.btn9cuadre = new System.Windows.Forms.Button();
            this.btn8cuadre = new System.Windows.Forms.Button();
            this.btn1cuadre = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnMoneda1Cuadre = new System.Windows.Forms.Button();
            this.btnMoneda5cCuadre = new System.Windows.Forms.Button();
            this.btnMoneda2Cuadre = new System.Windows.Forms.Button();
            this.btnMonedas5Cuadre = new System.Windows.Forms.Button();
            this.btnMoneda10Cuadre = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnBillete500Cuadre = new System.Windows.Forms.Button();
            this.btnBillete200Cuadre = new System.Windows.Forms.Button();
            this.btnBillete100Cuadre = new System.Windows.Forms.Button();
            this.btnBillete50Cuadre = new System.Windows.Forms.Button();
            this.btnBillete20Cuadre = new System.Windows.Forms.Button();
            this.btnTarjetaCuadre = new System.Windows.Forms.Button();
            this.btnEfectivoCuadre = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCancelarCuadre = new System.Windows.Forms.Button();
            this.btnCajaCuadre = new System.Windows.Forms.Button();
            this.btnCierreDia = new System.Windows.Forms.Button();
            this.panelResumenDatos = new System.Windows.Forms.Panel();
            this.textBoxResumen = new System.Windows.Forms.TextBox();
            this.btnAceptarCierreDia = new System.Windows.Forms.Button();
            this.button77 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button30 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.panelCriticos = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tblInv = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv_ini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mermas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventario_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCriticos = new System.Windows.Forms.ComboBox();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.panelConttra = new System.Windows.Forms.Panel();
            this.panelTec = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.panelAutorizacion = new System.Windows.Forms.Panel();
            this.btnAceptarAuto = new System.Windows.Forms.Button();
            this.btnCancelarAuto = new System.Windows.Forms.Button();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelCambio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).BeginInit();
            this.panelCambioDash.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panelTarjeta.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAmerican)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMasterCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVisa)).BeginInit();
            this.panelExtras.SuspendLayout();
            this.panelMonedasT.SuspendLayout();
            this.panelRefresco.SuspendLayout();
            this.panelDenominaciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelMonedas.SuspendLayout();
            this.panelCorte.SuspendLayout();
            this.panelCuadreCaja.SuspendLayout();
            this.panelTarjetaCuadre.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panelEfectivoCuadre.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panelResumenDatos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelCriticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInv)).BeginInit();
            this.panelConttra.SuspendLayout();
            this.panelTec.SuspendLayout();
            this.panelAutorizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(1007, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 130);
            this.button1.TabIndex = 8;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(795, 307);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(71, 20);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "combos";
            // 
            // btnQuitarProd
            // 
            this.btnQuitarProd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnQuitarProd.FlatAppearance.BorderSize = 5;
            this.btnQuitarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnQuitarProd.Location = new System.Drawing.Point(557, 624);
            this.btnQuitarProd.Name = "btnQuitarProd";
            this.btnQuitarProd.Size = new System.Drawing.Size(130, 130);
            this.btnQuitarProd.TabIndex = 4;
            this.btnQuitarProd.Text = "QUITAR PRODUCTO";
            this.btnQuitarProd.UseVisualStyleBackColor = true;
            this.btnQuitarProd.Click += new System.EventHandler(this.btnQuitarProd_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPagar.Location = new System.Drawing.Point(1005, 627);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(130, 130);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(1006, 628);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 130);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // COSTO
            // 
            this.COSTO.Text = "COSTO";
            this.COSTO.Width = 96;
            // 
            // listaPed
            // 
            this.listaPed.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listaPed.AllowColumnReorder = true;
            this.listaPed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NUM,
            this.PRODUCTO,
            this.COSTO});
            this.listaPed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listaPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPed.FullRowSelect = true;
            this.listaPed.GridLines = true;
            this.listaPed.Location = new System.Drawing.Point(97, 149);
            this.listaPed.MultiSelect = false;
            this.listaPed.Name = "listaPed";
            this.listaPed.Size = new System.Drawing.Size(457, 472);
            this.listaPed.TabIndex = 1;
            this.listaPed.UseCompatibleStateImageBehavior = false;
            this.listaPed.View = System.Windows.Forms.View.Details;
            // 
            // NUM
            // 
            this.NUM.Text = "NUM";
            this.NUM.Width = 55;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.Text = "PRODUCTO";
            this.PRODUCTO.Width = 302;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(560, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 288);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "POR PAGAR";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.Location = new System.Drawing.Point(266, 12);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(29, 20);
            this.lbSubTotal.TabIndex = 3;
            this.lbSubTotal.Text = "$0";
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPago.Location = new System.Drawing.Point(266, 44);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(29, 20);
            this.lbPago.TabIndex = 4;
            this.lbPago.Text = "$0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbPorPagar);
            this.panel2.Controls.Add(this.lbPago);
            this.panel2.Controls.Add(this.lbSubTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(97, 624);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 129);
            this.panel2.TabIndex = 4;
            // 
            // lbPorPagar
            // 
            this.lbPorPagar.AutoSize = true;
            this.lbPorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorPagar.Location = new System.Drawing.Point(266, 74);
            this.lbPorPagar.Name = "lbPorPagar";
            this.lbPorPagar.Size = new System.Drawing.Size(29, 20);
            this.lbPorPagar.TabIndex = 5;
            this.lbPorPagar.Text = "$0";
            // 
            // panelCambio
            // 
            this.panelCambio.Controls.Add(this.btnCancelarDash);
            this.panelCambio.Controls.Add(this.pictureBoxWarning);
            this.panelCambio.Controls.Add(this.btnAceptar);
            this.panelCambio.Controls.Add(this.lblCambio);
            this.panelCambio.Location = new System.Drawing.Point(26, 6);
            this.panelCambio.Name = "panelCambio";
            this.panelCambio.Size = new System.Drawing.Size(1231, 755);
            this.panelCambio.TabIndex = 31;
            this.panelCambio.Visible = false;
            this.panelCambio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCambio_Paint);
            // 
            // btnCancelarDash
            // 
            this.btnCancelarDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDash.Location = new System.Drawing.Point(256, 644);
            this.btnCancelarDash.Name = "btnCancelarDash";
            this.btnCancelarDash.Size = new System.Drawing.Size(186, 66);
            this.btnCancelarDash.TabIndex = 31;
            this.btnCancelarDash.Text = "CANCELAR";
            this.btnCancelarDash.UseVisualStyleBackColor = true;
            this.btnCancelarDash.Visible = false;
            this.btnCancelarDash.Click += new System.EventHandler(this.btnCancelarDash_Click);
            // 
            // pictureBoxWarning
            // 
            this.pictureBoxWarning.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWarning.Image")));
            this.pictureBoxWarning.Location = new System.Drawing.Point(546, 192);
            this.pictureBoxWarning.Name = "pictureBoxWarning";
            this.pictureBoxWarning.Size = new System.Drawing.Size(367, 347);
            this.pictureBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWarning.TabIndex = 29;
            this.pictureBoxWarning.TabStop = false;
            this.pictureBoxWarning.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(783, 644);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(186, 66);
            this.btnAceptar.TabIndex = 28;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCambio.Location = new System.Drawing.Point(478, 50);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(0, 29);
            this.lblCambio.TabIndex = 1;
            this.lblCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCambioDash
            // 
            this.panelCambioDash.Controls.Add(this.label9);
            this.panelCambioDash.Controls.Add(this.listDineroEnCaja);
            this.panelCambioDash.Controls.Add(this.button13);
            this.panelCambioDash.Controls.Add(this.button14);
            this.panelCambioDash.Controls.Add(this.listCambio);
            this.panelCambioDash.Controls.Add(this.groupBox4);
            this.panelCambioDash.Controls.Add(this.groupBox5);
            this.panelCambioDash.Controls.Add(this.label7);
            this.panelCambioDash.Controls.Add(this.textBoxCambio);
            this.panelCambioDash.Location = new System.Drawing.Point(1176, 491);
            this.panelCambioDash.Name = "panelCambioDash";
            this.panelCambioDash.Size = new System.Drawing.Size(1026, 519);
            this.panelCambioDash.TabIndex = 30;
            this.panelCambioDash.Visible = false;
            this.panelCambioDash.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCambioDash_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "DINERO EN CAJA";
            this.label9.Visible = false;
            // 
            // listDineroEnCaja
            // 
            this.listDineroEnCaja.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listDineroEnCaja.AllowColumnReorder = true;
            this.listDineroEnCaja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listDineroEnCaja.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listDineroEnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDineroEnCaja.FullRowSelect = true;
            this.listDineroEnCaja.GridLines = true;
            this.listDineroEnCaja.Location = new System.Drawing.Point(46, 48);
            this.listDineroEnCaja.MultiSelect = false;
            this.listDineroEnCaja.Name = "listDineroEnCaja";
            this.listDineroEnCaja.Size = new System.Drawing.Size(267, 422);
            this.listDineroEnCaja.TabIndex = 45;
            this.listDineroEnCaja.UseCompatibleStateImageBehavior = false;
            this.listDineroEnCaja.View = System.Windows.Forms.View.Details;
            this.listDineroEnCaja.Visible = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NUM";
            this.columnHeader2.Width = 54;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "EFECTIVO";
            this.columnHeader3.Width = 204;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button13.Location = new System.Drawing.Point(863, 461);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 56);
            this.button13.TabIndex = 43;
            this.button13.Text = "QUITAR";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(391, 451);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 66);
            this.button14.TabIndex = 44;
            this.button14.Text = "C";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // listCambio
            // 
            this.listCambio.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listCambio.AllowColumnReorder = true;
            this.listCambio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.VALOR});
            this.listCambio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCambio.FullRowSelect = true;
            this.listCambio.GridLines = true;
            this.listCambio.Location = new System.Drawing.Point(707, 24);
            this.listCambio.MultiSelect = false;
            this.listCambio.Name = "listCambio";
            this.listCambio.Size = new System.Drawing.Size(267, 422);
            this.listCambio.TabIndex = 42;
            this.listCambio.UseCompatibleStateImageBehavior = false;
            this.listCambio.View = System.Windows.Forms.View.Details;
            this.listCambio.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NUM";
            this.columnHeader1.Width = 54;
            // 
            // VALOR
            // 
            this.VALOR.Text = "EFECTIVO";
            this.VALOR.Width = 204;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(390, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 174);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Monedas";
            this.groupBox4.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button3.Location = new System.Drawing.Point(6, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 56);
            this.button3.TabIndex = 7;
            this.button3.Text = "$1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.Location = new System.Drawing.Point(176, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "$0.50";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button5.Location = new System.Drawing.Point(176, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "$2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button6.Location = new System.Drawing.Point(92, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 56);
            this.button6.TabIndex = 4;
            this.button6.Text = "$5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button7.Location = new System.Drawing.Point(5, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 56);
            this.button7.TabIndex = 3;
            this.button7.Text = "$10";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(390, 109);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 164);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BILLETES";
            this.groupBox5.Visible = false;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button8.Location = new System.Drawing.Point(176, 89);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 56);
            this.button8.TabIndex = 7;
            this.button8.Text = "$500";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button9.Location = new System.Drawing.Point(5, 89);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 56);
            this.button9.TabIndex = 6;
            this.button9.Text = "$200";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button10.Location = new System.Drawing.Point(176, 27);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 56);
            this.button10.TabIndex = 5;
            this.button10.Text = "$100";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button11.Location = new System.Drawing.Point(92, 27);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(81, 56);
            this.button11.TabIndex = 4;
            this.button11.Text = "$50";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button12.Location = new System.Drawing.Point(5, 27);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(81, 56);
            this.button12.TabIndex = 3;
            this.button12.Text = "$20";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "SELECCIONA EL CAMBIO";
            this.label7.Visible = false;
            // 
            // textBoxCambio
            // 
            this.textBoxCambio.Enabled = false;
            this.textBoxCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCambio.Location = new System.Drawing.Point(383, 54);
            this.textBoxCambio.Multiline = true;
            this.textBoxCambio.Name = "textBoxCambio";
            this.textBoxCambio.Size = new System.Drawing.Size(282, 49);
            this.textBoxCambio.TabIndex = 38;
            this.textBoxCambio.Text = "0";
            this.textBoxCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCambio.Visible = false;
            // 
            // panelTarjeta
            // 
            this.panelTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTarjeta.Controls.Add(this.label10);
            this.panelTarjeta.Controls.Add(this.label6);
            this.panelTarjeta.Controls.Add(this.panel5);
            this.panelTarjeta.Controls.Add(this.tarjeta);
            this.panelTarjeta.Controls.Add(this.btnCancelarTarjeta);
            this.panelTarjeta.Controls.Add(this.label5);
            this.panelTarjeta.Controls.Add(this.pBAmerican);
            this.panelTarjeta.Controls.Add(this.pBMasterCard);
            this.panelTarjeta.Controls.Add(this.pBoxVisa);
            this.panelTarjeta.Controls.Add(this.panelActiveVisa);
            this.panelTarjeta.Controls.Add(this.panelActiveMC);
            this.panelTarjeta.Controls.Add(this.panelActiveAE);
            this.panelTarjeta.Location = new System.Drawing.Point(23, 6);
            this.panelTarjeta.Name = "panelTarjeta";
            this.panelTarjeta.Size = new System.Drawing.Size(1247, 755);
            this.panelTarjeta.TabIndex = 13;
            this.panelTarjeta.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(419, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(425, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Selecciona la compañia de la tarjeta con la que van a pagar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(413, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ingresa los ultimos 4 digitos de la tarjeta en la parte frontal";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button15);
            this.panel5.Controls.Add(this.txtTarjeta);
            this.panel5.Controls.Add(this.button17);
            this.panel5.Controls.Add(this.button18);
            this.panel5.Controls.Add(this.button19);
            this.panel5.Controls.Add(this.button20);
            this.panel5.Controls.Add(this.button21);
            this.panel5.Controls.Add(this.button22);
            this.panel5.Controls.Add(this.button23);
            this.panel5.Controls.Add(this.button24);
            this.panel5.Controls.Add(this.button25);
            this.panel5.Controls.Add(this.button26);
            this.panel5.Location = new System.Drawing.Point(472, 243);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 389);
            this.panel5.TabIndex = 34;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(10, 288);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 66);
            this.button15.TabIndex = 24;
            this.button15.Text = "C";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Enabled = false;
            this.txtTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeta.Location = new System.Drawing.Point(9, 10);
            this.txtTarjeta.MaxLength = 4;
            this.txtTarjeta.Multiline = true;
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(282, 49);
            this.txtTarjeta.TabIndex = 23;
            this.txtTarjeta.Text = "0";
            this.txtTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(105, 288);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(90, 66);
            this.button17.TabIndex = 22;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btnNumeroTarjeta_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(9, 213);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(90, 66);
            this.button18.TabIndex = 21;
            this.button18.Text = "1";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.btnNumeroTarjeta_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(105, 213);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(90, 66);
            this.button19.TabIndex = 20;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.btnNumeroTarjeta_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(201, 213);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(90, 66);
            this.button20.TabIndex = 19;
            this.button20.Text = "3";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.btnNumeroTarjeta_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(9, 141);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(90, 66);
            this.button21.TabIndex = 18;
            this.button21.Text = "4";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.btnNumeroTarjeta_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(105, 141);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(90, 66);
            this.button22.TabIndex = 17;
            this.button22.Text = "5";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.btnNumeroTarjeta_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(201, 141);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(90, 66);
            this.button23.TabIndex = 16;
            this.button23.Text = "6";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.btnNumeroTarjeta_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(9, 69);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(90, 66);
            this.button24.TabIndex = 15;
            this.button24.Text = "7";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.btnNumeroTarjeta_Click);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(105, 69);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(90, 66);
            this.button25.TabIndex = 14;
            this.button25.Text = "8";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.btnNumeroTarjeta_Click);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(201, 69);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(90, 66);
            this.button26.TabIndex = 13;
            this.button26.Text = "9";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.btnNumeroTarjeta_Click);
            // 
            // tarjeta
            // 
            this.tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarjeta.Location = new System.Drawing.Point(661, 641);
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.Size = new System.Drawing.Size(204, 66);
            this.tarjeta.TabIndex = 33;
            this.tarjeta.Text = "ACEPTAR";
            this.tarjeta.UseVisualStyleBackColor = true;
            this.tarjeta.Click += new System.EventHandler(this.tarjeta_Click);
            // 
            // btnCancelarTarjeta
            // 
            this.btnCancelarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTarjeta.Location = new System.Drawing.Point(387, 641);
            this.btnCancelarTarjeta.Name = "btnCancelarTarjeta";
            this.btnCancelarTarjeta.Size = new System.Drawing.Size(186, 66);
            this.btnCancelarTarjeta.TabIndex = 26;
            this.btnCancelarTarjeta.Text = "CANCELAR";
            this.btnCancelarTarjeta.UseVisualStyleBackColor = true;
            this.btnCancelarTarjeta.Click += new System.EventHandler(this.btnCancelarTarjeta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // pBAmerican
            // 
            this.pBAmerican.Image = global::WindowsFormsApplication1.Properties.Resources.american;
            this.pBAmerican.Location = new System.Drawing.Point(732, 119);
            this.pBAmerican.Name = "pBAmerican";
            this.pBAmerican.Size = new System.Drawing.Size(94, 86);
            this.pBAmerican.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBAmerican.TabIndex = 2;
            this.pBAmerican.TabStop = false;
            this.pBAmerican.Visible = false;
            this.pBAmerican.Click += new System.EventHandler(this.pBAmerican_Click);
            // 
            // pBMasterCard
            // 
            this.pBMasterCard.Image = global::WindowsFormsApplication1.Properties.Resources.mastercard;
            this.pBMasterCard.Location = new System.Drawing.Point(559, 119);
            this.pBMasterCard.Name = "pBMasterCard";
            this.pBMasterCard.Size = new System.Drawing.Size(153, 86);
            this.pBMasterCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMasterCard.TabIndex = 1;
            this.pBMasterCard.TabStop = false;
            this.pBMasterCard.Click += new System.EventHandler(this.pBMasterCard_Click);
            // 
            // pBoxVisa
            // 
            this.pBoxVisa.Image = global::WindowsFormsApplication1.Properties.Resources.visa;
            this.pBoxVisa.Location = new System.Drawing.Point(428, 119);
            this.pBoxVisa.Name = "pBoxVisa";
            this.pBoxVisa.Size = new System.Drawing.Size(116, 86);
            this.pBoxVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxVisa.TabIndex = 0;
            this.pBoxVisa.TabStop = false;
            this.pBoxVisa.Click += new System.EventHandler(this.pBoxVisa_Click);
            // 
            // panelActiveVisa
            // 
            this.panelActiveVisa.BackColor = System.Drawing.Color.Black;
            this.panelActiveVisa.Location = new System.Drawing.Point(423, 113);
            this.panelActiveVisa.Name = "panelActiveVisa";
            this.panelActiveVisa.Size = new System.Drawing.Size(125, 100);
            this.panelActiveVisa.TabIndex = 28;
            this.panelActiveVisa.Visible = false;
            // 
            // panelActiveMC
            // 
            this.panelActiveMC.BackColor = System.Drawing.Color.Black;
            this.panelActiveMC.Location = new System.Drawing.Point(550, 113);
            this.panelActiveMC.Name = "panelActiveMC";
            this.panelActiveMC.Size = new System.Drawing.Size(173, 100);
            this.panelActiveMC.TabIndex = 29;
            this.panelActiveMC.Visible = false;
            // 
            // panelActiveAE
            // 
            this.panelActiveAE.BackColor = System.Drawing.Color.Black;
            this.panelActiveAE.Location = new System.Drawing.Point(726, 113);
            this.panelActiveAE.Name = "panelActiveAE";
            this.panelActiveAE.Size = new System.Drawing.Size(109, 100);
            this.panelActiveAE.TabIndex = 30;
            this.panelActiveAE.Visible = false;
            // 
            // panelExtras
            // 
            this.panelExtras.AutoScroll = true;
            this.panelExtras.Controls.Add(this.label11);
            this.panelExtras.Location = new System.Drawing.Point(558, 148);
            this.panelExtras.Name = "panelExtras";
            this.panelExtras.Size = new System.Drawing.Size(582, 472);
            this.panelExtras.TabIndex = 47;
            this.panelExtras.Visible = false;
            this.panelExtras.Paint += new System.Windows.Forms.PaintEventHandler(this.panelExtras_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(195, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Complementos";
            // 
            // panelMonedasT
            // 
            this.panelMonedasT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMonedasT.Controls.Add(this.button16);
            this.panelMonedasT.Controls.Add(this.btnEnter);
            this.panelMonedasT.Controls.Add(this.textBoxMonedas);
            this.panelMonedasT.Controls.Add(this.btnAcept);
            this.panelMonedasT.Controls.Add(this.btnBorrar);
            this.panelMonedasT.Controls.Add(this.textBoxCantidad);
            this.panelMonedasT.Controls.Add(this.label4);
            this.panelMonedasT.Controls.Add(this.lblTipoPago);
            this.panelMonedasT.Controls.Add(this.tipoPagoLabel);
            this.panelMonedasT.Controls.Add(this.btn0);
            this.panelMonedasT.Controls.Add(this.btnPagoTarjeta);
            this.panelMonedasT.Controls.Add(this.btn1);
            this.panelMonedasT.Controls.Add(this.btn2);
            this.panelMonedasT.Controls.Add(this.btn3);
            this.panelMonedasT.Controls.Add(this.btn4);
            this.panelMonedasT.Controls.Add(this.btn5);
            this.panelMonedasT.Controls.Add(this.btn6);
            this.panelMonedasT.Controls.Add(this.btn7);
            this.panelMonedasT.Controls.Add(this.btn8);
            this.panelMonedasT.Controls.Add(this.btn9);
            this.panelMonedasT.Location = new System.Drawing.Point(1273, 210);
            this.panelMonedasT.Name = "panelMonedasT";
            this.panelMonedasT.Size = new System.Drawing.Size(586, 867);
            this.panelMonedasT.TabIndex = 10;
            this.panelMonedasT.Visible = false;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(22, 396);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 66);
            this.button16.TabIndex = 49;
            this.button16.Text = "C";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click_2);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(214, 395);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(90, 66);
            this.btnEnter.TabIndex = 48;
            this.btnEnter.Text = ">>";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // textBoxMonedas
            // 
            this.textBoxMonedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxMonedas.Location = new System.Drawing.Point(310, 175);
            this.textBoxMonedas.MaxLength = 2;
            this.textBoxMonedas.Name = "textBoxMonedas";
            this.textBoxMonedas.Size = new System.Drawing.Size(256, 31);
            this.textBoxMonedas.TabIndex = 47;
            this.textBoxMonedas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAcept
            // 
            this.btnAcept.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcept.Location = new System.Drawing.Point(447, 400);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(125, 66);
            this.btnAcept.TabIndex = 46;
            this.btnAcept.Text = "Pagar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnPagarCa_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(449, 255);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(119, 66);
            this.btnBorrar.TabIndex = 45;
            this.btnBorrar.Text = "Volver a empezar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnC_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(181, 74);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(223, 31);
            this.textBoxCantidad.TabIndex = 29;
            this.textBoxCantidad.Text = "$0";
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Selecciona la cantidad de monedas a ingresar";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(449, 40);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(45, 13);
            this.lblTipoPago.TabIndex = 10;
            this.lblTipoPago.Text = "efectivo";
            // 
            // tipoPagoLabel
            // 
            this.tipoPagoLabel.AutoSize = true;
            this.tipoPagoLabel.Location = new System.Drawing.Point(430, 17);
            this.tipoPagoLabel.Name = "tipoPagoLabel";
            this.tipoPagoLabel.Size = new System.Drawing.Size(83, 13);
            this.tipoPagoLabel.TabIndex = 9;
            this.tipoPagoLabel.Text = "TIPO DE PAGO";
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(119, 395);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(90, 66);
            this.btn0.TabIndex = 22;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnPagoTarjeta
            // 
            this.btnPagoTarjeta.Location = new System.Drawing.Point(171, 3);
            this.btnPagoTarjeta.Name = "btnPagoTarjeta";
            this.btnPagoTarjeta.Size = new System.Drawing.Size(242, 63);
            this.btnPagoTarjeta.TabIndex = 1;
            this.btnPagoTarjeta.Text = "PAGO CON TARJETA";
            this.btnPagoTarjeta.UseVisualStyleBackColor = true;
            this.btnPagoTarjeta.Click += new System.EventHandler(this.btnPagoTarjeta_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(22, 317);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 66);
            this.btn1.TabIndex = 21;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(118, 317);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 66);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(214, 317);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 66);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(22, 245);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(90, 66);
            this.btn4.TabIndex = 18;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(118, 245);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(90, 66);
            this.btn5.TabIndex = 17;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(214, 245);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(90, 66);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(22, 173);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(90, 66);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(118, 173);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(90, 66);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(214, 173);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(90, 66);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(97, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 130);
            this.button2.TabIndex = 12;
            this.button2.Text = "SUBTOTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelRefresco
            // 
            this.panelRefresco.Controls.Add(this.label8);
            this.panelRefresco.Location = new System.Drawing.Point(558, 151);
            this.panelRefresco.Name = "panelRefresco";
            this.panelRefresco.Size = new System.Drawing.Size(582, 472);
            this.panelRefresco.TabIndex = 14;
            this.panelRefresco.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(378, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "SELECCIONE EL REFRESCO DE EL COMBO";
            // 
            // BtnCorte
            // 
            this.BtnCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnCorte.Location = new System.Drawing.Point(403, 13);
            this.BtnCorte.Name = "BtnCorte";
            this.BtnCorte.Size = new System.Drawing.Size(130, 130);
            this.BtnCorte.TabIndex = 32;
            this.BtnCorte.Text = "RETIRO";
            this.BtnCorte.UseVisualStyleBackColor = true;
            this.BtnCorte.Click += new System.EventHandler(this.BtnCorte_Click);
            // 
            // panelDenominaciones
            // 
            this.panelDenominaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDenominaciones.Controls.Add(this.groupBox2);
            this.panelDenominaciones.Controls.Add(this.groupBox3);
            this.panelDenominaciones.Location = new System.Drawing.Point(557, 147);
            this.panelDenominaciones.Name = "panelDenominaciones";
            this.panelDenominaciones.Size = new System.Drawing.Size(586, 472);
            this.panelDenominaciones.TabIndex = 48;
            this.panelDenominaciones.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBillete500);
            this.groupBox2.Controls.Add(this.btnBillete200);
            this.groupBox2.Controls.Add(this.btnBillete100);
            this.groupBox2.Controls.Add(this.btnBillete50);
            this.groupBox2.Controls.Add(this.btnBillete20);
            this.groupBox2.Location = new System.Drawing.Point(11, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BILLETES";
            // 
            // btnBillete500
            // 
            this.btnBillete500.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillete500.Location = new System.Drawing.Point(431, 103);
            this.btnBillete500.Name = "btnBillete500";
            this.btnBillete500.Size = new System.Drawing.Size(126, 79);
            this.btnBillete500.TabIndex = 7;
            this.btnBillete500.Text = "$500";
            this.btnBillete500.UseVisualStyleBackColor = true;
            this.btnBillete500.Click += new System.EventHandler(this.btnBillete500_Click);
            // 
            // btnBillete200
            // 
            this.btnBillete200.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillete200.Location = new System.Drawing.Point(14, 114);
            this.btnBillete200.Name = "btnBillete200";
            this.btnBillete200.Size = new System.Drawing.Size(126, 79);
            this.btnBillete200.TabIndex = 6;
            this.btnBillete200.Text = "$200";
            this.btnBillete200.UseVisualStyleBackColor = true;
            this.btnBillete200.Click += new System.EventHandler(this.btnBillete200_Click);
            // 
            // btnBillete100
            // 
            this.btnBillete100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillete100.Location = new System.Drawing.Point(431, 18);
            this.btnBillete100.Name = "btnBillete100";
            this.btnBillete100.Size = new System.Drawing.Size(126, 79);
            this.btnBillete100.TabIndex = 5;
            this.btnBillete100.Text = "$100";
            this.btnBillete100.UseVisualStyleBackColor = true;
            this.btnBillete100.Click += new System.EventHandler(this.btnBillete100_Click);
            // 
            // btnBillete50
            // 
            this.btnBillete50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillete50.Location = new System.Drawing.Point(240, 65);
            this.btnBillete50.Name = "btnBillete50";
            this.btnBillete50.Size = new System.Drawing.Size(126, 79);
            this.btnBillete50.TabIndex = 4;
            this.btnBillete50.Text = "$50";
            this.btnBillete50.UseVisualStyleBackColor = true;
            this.btnBillete50.Click += new System.EventHandler(this.btnBillete50_Click);
            // 
            // btnBillete20
            // 
            this.btnBillete20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillete20.Location = new System.Drawing.Point(14, 18);
            this.btnBillete20.Name = "btnBillete20";
            this.btnBillete20.Size = new System.Drawing.Size(126, 79);
            this.btnBillete20.TabIndex = 3;
            this.btnBillete20.Text = "$20";
            this.btnBillete20.UseVisualStyleBackColor = true;
            this.btnBillete20.Click += new System.EventHandler(this.btnBillete20_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMoneda1);
            this.groupBox3.Controls.Add(this.btnMoneda50c);
            this.groupBox3.Controls.Add(this.btnMoneda2);
            this.groupBox3.Controls.Add(this.btnMoneda5);
            this.groupBox3.Controls.Add(this.btnMoneda10);
            this.groupBox3.Location = new System.Drawing.Point(10, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 185);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monedas";
            // 
            // btnMoneda1
            // 
            this.btnMoneda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneda1.Location = new System.Drawing.Point(22, 100);
            this.btnMoneda1.Name = "btnMoneda1";
            this.btnMoneda1.Size = new System.Drawing.Size(126, 79);
            this.btnMoneda1.TabIndex = 7;
            this.btnMoneda1.Text = "$1";
            this.btnMoneda1.UseVisualStyleBackColor = true;
            this.btnMoneda1.Click += new System.EventHandler(this.btnMoneda1_Click);
            // 
            // btnMoneda50c
            // 
            this.btnMoneda50c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneda50c.Location = new System.Drawing.Point(432, 98);
            this.btnMoneda50c.Name = "btnMoneda50c";
            this.btnMoneda50c.Size = new System.Drawing.Size(126, 79);
            this.btnMoneda50c.TabIndex = 6;
            this.btnMoneda50c.Text = "$0.50";
            this.btnMoneda50c.UseVisualStyleBackColor = true;
            this.btnMoneda50c.Click += new System.EventHandler(this.btnMoneda50c_Click);
            // 
            // btnMoneda2
            // 
            this.btnMoneda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneda2.Location = new System.Drawing.Point(432, 13);
            this.btnMoneda2.Name = "btnMoneda2";
            this.btnMoneda2.Size = new System.Drawing.Size(126, 79);
            this.btnMoneda2.TabIndex = 5;
            this.btnMoneda2.Text = "$2";
            this.btnMoneda2.UseVisualStyleBackColor = true;
            this.btnMoneda2.Click += new System.EventHandler(this.btnMoneda2_Click);
            // 
            // btnMoneda5
            // 
            this.btnMoneda5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneda5.Location = new System.Drawing.Point(248, 47);
            this.btnMoneda5.Name = "btnMoneda5";
            this.btnMoneda5.Size = new System.Drawing.Size(126, 79);
            this.btnMoneda5.TabIndex = 4;
            this.btnMoneda5.Text = "$5";
            this.btnMoneda5.UseVisualStyleBackColor = true;
            this.btnMoneda5.Click += new System.EventHandler(this.btnMoneda5_Click);
            // 
            // btnMoneda10
            // 
            this.btnMoneda10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneda10.Location = new System.Drawing.Point(22, 16);
            this.btnMoneda10.Name = "btnMoneda10";
            this.btnMoneda10.Size = new System.Drawing.Size(126, 79);
            this.btnMoneda10.TabIndex = 3;
            this.btnMoneda10.Text = "$10";
            this.btnMoneda10.UseVisualStyleBackColor = true;
            this.btnMoneda10.Click += new System.EventHandler(this.btnMoneda10_Click);
            // 
            // panelMonedas
            // 
            this.panelMonedas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMonedas.Controls.Add(this.btnPagoDiferido);
            this.panelMonedas.Controls.Add(this.button27);
            this.panelMonedas.Controls.Add(this.button28);
            this.panelMonedas.Controls.Add(this.button29);
            this.panelMonedas.Controls.Add(this.textboxDineroCa);
            this.panelMonedas.Controls.Add(this.label12);
            this.panelMonedas.Controls.Add(this.button31);
            this.panelMonedas.Controls.Add(this.button32);
            this.panelMonedas.Controls.Add(this.button33);
            this.panelMonedas.Controls.Add(this.button34);
            this.panelMonedas.Controls.Add(this.button35);
            this.panelMonedas.Controls.Add(this.button36);
            this.panelMonedas.Controls.Add(this.button37);
            this.panelMonedas.Controls.Add(this.button38);
            this.panelMonedas.Controls.Add(this.button39);
            this.panelMonedas.Controls.Add(this.button40);
            this.panelMonedas.Controls.Add(this.button41);
            this.panelMonedas.Location = new System.Drawing.Point(556, 149);
            this.panelMonedas.Name = "panelMonedas";
            this.panelMonedas.Size = new System.Drawing.Size(586, 474);
            this.panelMonedas.TabIndex = 50;
            this.panelMonedas.Visible = false;
            // 
            // btnPagoDiferido
            // 
            this.btnPagoDiferido.Location = new System.Drawing.Point(24, 5);
            this.btnPagoDiferido.Name = "btnPagoDiferido";
            this.btnPagoDiferido.Size = new System.Drawing.Size(242, 63);
            this.btnPagoDiferido.TabIndex = 50;
            this.btnPagoDiferido.Text = "PAGO DIFERIDO";
            this.btnPagoDiferido.UseVisualStyleBackColor = true;
            this.btnPagoDiferido.Click += new System.EventHandler(this.btnPagoDiferido_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(154, 378);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(90, 66);
            this.button27.TabIndex = 49;
            this.button27.Text = "C";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click_1);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(345, 376);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(90, 66);
            this.button28.TabIndex = 48;
            this.button28.Text = ".";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(448, 378);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(130, 66);
            this.button29.TabIndex = 46;
            this.button29.Text = "OK";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.btnPagarCa_Click);
            // 
            // textboxDineroCa
            // 
            this.textboxDineroCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDineroCa.Location = new System.Drawing.Point(181, 74);
            this.textboxDineroCa.Name = "textboxDineroCa";
            this.textboxDineroCa.Size = new System.Drawing.Size(223, 31);
            this.textboxDineroCa.TabIndex = 29;
            this.textboxDineroCa.Text = "0";
            this.textboxDineroCa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(162, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ingresa la cantidad pagada";
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(250, 378);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(90, 66);
            this.button31.TabIndex = 22;
            this.button31.Text = "0";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(331, 5);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(242, 63);
            this.button32.TabIndex = 1;
            this.button32.Text = "PAGO CON TARJETA";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.btnPagoTarjeta_Click);
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(153, 300);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(90, 66);
            this.button33.TabIndex = 21;
            this.button33.Text = "1";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // button34
            // 
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.Location = new System.Drawing.Point(249, 300);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(90, 66);
            this.button34.TabIndex = 20;
            this.button34.Text = "2";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.Location = new System.Drawing.Point(345, 300);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(90, 66);
            this.button35.TabIndex = 19;
            this.button35.Text = "3";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // button36
            // 
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.Location = new System.Drawing.Point(153, 228);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(90, 66);
            this.button36.TabIndex = 18;
            this.button36.Text = "4";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // button37
            // 
            this.button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.Location = new System.Drawing.Point(249, 228);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(90, 66);
            this.button37.TabIndex = 17;
            this.button37.Text = "5";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // button38
            // 
            this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.Location = new System.Drawing.Point(345, 228);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(90, 66);
            this.button38.TabIndex = 16;
            this.button38.Text = "6";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // button39
            // 
            this.button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.Location = new System.Drawing.Point(153, 156);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(90, 66);
            this.button39.TabIndex = 15;
            this.button39.Text = "7";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // button40
            // 
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.Location = new System.Drawing.Point(249, 156);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(90, 66);
            this.button40.TabIndex = 14;
            this.button40.Text = "8";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // button41
            // 
            this.button41.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button41.Location = new System.Drawing.Point(345, 156);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(90, 66);
            this.button41.TabIndex = 13;
            this.button41.Text = "9";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.btnNumeroC_Click);
            // 
            // panelCorte
            // 
            this.panelCorte.Controls.Add(this.txtVerCorte);
            this.panelCorte.Controls.Add(this.btnCorteAceptar);
            this.panelCorte.Location = new System.Drawing.Point(3, 9);
            this.panelCorte.Name = "panelCorte";
            this.panelCorte.Size = new System.Drawing.Size(1292, 757);
            this.panelCorte.TabIndex = 37;
            this.panelCorte.Visible = false;
            this.panelCorte.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCorte_Paint);
            // 
            // txtVerCorte
            // 
            this.txtVerCorte.Location = new System.Drawing.Point(475, 134);
            this.txtVerCorte.Multiline = true;
            this.txtVerCorte.Name = "txtVerCorte";
            this.txtVerCorte.Size = new System.Drawing.Size(315, 418);
            this.txtVerCorte.TabIndex = 2;
            this.txtVerCorte.TextChanged += new System.EventHandler(this.txtVerCorte_TextChanged);
            // 
            // btnCorteAceptar
            // 
            this.btnCorteAceptar.Location = new System.Drawing.Point(519, 585);
            this.btnCorteAceptar.Name = "btnCorteAceptar";
            this.btnCorteAceptar.Size = new System.Drawing.Size(208, 57);
            this.btnCorteAceptar.TabIndex = 1;
            this.btnCorteAceptar.Text = "ACEPTAR";
            this.btnCorteAceptar.UseVisualStyleBackColor = true;
            this.btnCorteAceptar.Click += new System.EventHandler(this.btnCorteAceptar_Click);
            // 
            // panelCuadreCaja
            // 
            this.panelCuadreCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCuadreCaja.Controls.Add(this.labelRestantePagarDiferidoMensaje);
            this.panelCuadreCaja.Controls.Add(this.labelRestanteDiferido);
            this.panelCuadreCaja.Controls.Add(this.label21);
            this.panelCuadreCaja.Controls.Add(this.labelTotalPagarDiferido);
            this.panelCuadreCaja.Controls.Add(this.labelTotalPagarDiferidoMensaje);
            this.panelCuadreCaja.Controls.Add(this.btnPagarDiferido);
            this.panelCuadreCaja.Controls.Add(this.panelTarjetaCuadre);
            this.panelCuadreCaja.Controls.Add(this.labelTotalCuadre);
            this.panelCuadreCaja.Controls.Add(this.label17);
            this.panelCuadreCaja.Controls.Add(this.labelTarjetaCuadre);
            this.panelCuadreCaja.Controls.Add(this.label18);
            this.panelCuadreCaja.Controls.Add(this.labelEfectivoCuadre);
            this.panelCuadreCaja.Controls.Add(this.label16);
            this.panelCuadreCaja.Controls.Add(this.listViewCuadreCaja);
            this.panelCuadreCaja.Controls.Add(this.panelEfectivoCuadre);
            this.panelCuadreCaja.Controls.Add(this.btnTarjetaCuadre);
            this.panelCuadreCaja.Controls.Add(this.btnEfectivoCuadre);
            this.panelCuadreCaja.Controls.Add(this.btnQuitar);
            this.panelCuadreCaja.Controls.Add(this.btnCancelarCuadre);
            this.panelCuadreCaja.Controls.Add(this.btnCajaCuadre);
            this.panelCuadreCaja.Location = new System.Drawing.Point(16, 9);
            this.panelCuadreCaja.Name = "panelCuadreCaja";
            this.panelCuadreCaja.Size = new System.Drawing.Size(1245, 737);
            this.panelCuadreCaja.TabIndex = 53;
            this.panelCuadreCaja.Visible = false;
            this.panelCuadreCaja.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCuadreCaja_Paint);
            // 
            // labelRestantePagarDiferidoMensaje
            // 
            this.labelRestantePagarDiferidoMensaje.AutoSize = true;
            this.labelRestantePagarDiferidoMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelRestantePagarDiferidoMensaje.Location = new System.Drawing.Point(842, 79);
            this.labelRestantePagarDiferidoMensaje.Name = "labelRestantePagarDiferidoMensaje";
            this.labelRestantePagarDiferidoMensaje.Size = new System.Drawing.Size(143, 29);
            this.labelRestantePagarDiferidoMensaje.TabIndex = 49;
            this.labelRestantePagarDiferidoMensaje.Text = "RESTANTE";
            this.labelRestantePagarDiferidoMensaje.Visible = false;
            // 
            // labelRestanteDiferido
            // 
            this.labelRestanteDiferido.AutoSize = true;
            this.labelRestanteDiferido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelRestanteDiferido.Location = new System.Drawing.Point(1063, 79);
            this.labelRestanteDiferido.Name = "labelRestanteDiferido";
            this.labelRestanteDiferido.Size = new System.Drawing.Size(26, 29);
            this.labelRestanteDiferido.TabIndex = 48;
            this.labelRestanteDiferido.Text = "0";
            this.labelRestanteDiferido.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label21.Location = new System.Drawing.Point(842, 607);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 29);
            this.label21.TabIndex = 47;
            // 
            // labelTotalPagarDiferido
            // 
            this.labelTotalPagarDiferido.AutoSize = true;
            this.labelTotalPagarDiferido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTotalPagarDiferido.Location = new System.Drawing.Point(1063, 48);
            this.labelTotalPagarDiferido.Name = "labelTotalPagarDiferido";
            this.labelTotalPagarDiferido.Size = new System.Drawing.Size(26, 29);
            this.labelTotalPagarDiferido.TabIndex = 46;
            this.labelTotalPagarDiferido.Text = "0";
            this.labelTotalPagarDiferido.Visible = false;
            // 
            // labelTotalPagarDiferidoMensaje
            // 
            this.labelTotalPagarDiferidoMensaje.AutoSize = true;
            this.labelTotalPagarDiferidoMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTotalPagarDiferidoMensaje.Location = new System.Drawing.Point(837, 50);
            this.labelTotalPagarDiferidoMensaje.Name = "labelTotalPagarDiferidoMensaje";
            this.labelTotalPagarDiferidoMensaje.Size = new System.Drawing.Size(200, 29);
            this.labelTotalPagarDiferidoMensaje.TabIndex = 45;
            this.labelTotalPagarDiferidoMensaje.Text = "TOTAL A PAGAR";
            this.labelTotalPagarDiferidoMensaje.Visible = false;
            // 
            // btnPagarDiferido
            // 
            this.btnPagarDiferido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPagarDiferido.Location = new System.Drawing.Point(842, 618);
            this.btnPagarDiferido.Name = "btnPagarDiferido";
            this.btnPagarDiferido.Size = new System.Drawing.Size(252, 64);
            this.btnPagarDiferido.TabIndex = 44;
            this.btnPagarDiferido.Text = "Pagar";
            this.btnPagarDiferido.UseVisualStyleBackColor = true;
            this.btnPagarDiferido.Visible = false;
            this.btnPagarDiferido.Click += new System.EventHandler(this.btnPagarCa_Click);
            // 
            // panelTarjetaCuadre
            // 
            this.panelTarjetaCuadre.BackColor = System.Drawing.SystemColors.Control;
            this.panelTarjetaCuadre.Controls.Add(this.groupBox9);
            this.panelTarjetaCuadre.Location = new System.Drawing.Point(156, 142);
            this.panelTarjetaCuadre.Name = "panelTarjetaCuadre";
            this.panelTarjetaCuadre.Size = new System.Drawing.Size(677, 452);
            this.panelTarjetaCuadre.TabIndex = 38;
            this.panelTarjetaCuadre.Visible = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnOkCuadreTarjeta);
            this.groupBox9.Controls.Add(this.textBoxTarjetaCuadre);
            this.groupBox9.Controls.Add(this.btn6CuadreTarjeta);
            this.groupBox9.Controls.Add(this.btn5CuadreTarjeta);
            this.groupBox9.Controls.Add(this.btn4CuadreTarjeta);
            this.groupBox9.Controls.Add(this.btn3CuadreTarjeta);
            this.groupBox9.Controls.Add(this.btn2CuadreTarjeta);
            this.groupBox9.Controls.Add(this.btncCuadreTarjeta);
            this.groupBox9.Controls.Add(this.btn0CuadreTarjeta);
            this.groupBox9.Controls.Add(this.btn7CuadreTarjeta);
            this.groupBox9.Controls.Add(this.btn9CuadreTarjeta);
            this.groupBox9.Controls.Add(this.btn8CuadreTarjeta);
            this.groupBox9.Controls.Add(this.btn1CuadreTarjeta);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox9.Location = new System.Drawing.Point(181, 31);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(326, 391);
            this.groupBox9.TabIndex = 37;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Indica cuanto dinero de tarjeta";
            // 
            // btnOkCuadreTarjeta
            // 
            this.btnOkCuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkCuadreTarjeta.Location = new System.Drawing.Point(213, 311);
            this.btnOkCuadreTarjeta.Name = "btnOkCuadreTarjeta";
            this.btnOkCuadreTarjeta.Size = new System.Drawing.Size(80, 56);
            this.btnOkCuadreTarjeta.TabIndex = 42;
            this.btnOkCuadreTarjeta.Text = "OK";
            this.btnOkCuadreTarjeta.UseVisualStyleBackColor = true;
            this.btnOkCuadreTarjeta.Click += new System.EventHandler(this.btnOkCuadreTarjeta_Click);
            // 
            // textBoxTarjetaCuadre
            // 
            this.textBoxTarjetaCuadre.Enabled = false;
            this.textBoxTarjetaCuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTarjetaCuadre.Location = new System.Drawing.Point(23, 70);
            this.textBoxTarjetaCuadre.Multiline = true;
            this.textBoxTarjetaCuadre.Name = "textBoxTarjetaCuadre";
            this.textBoxTarjetaCuadre.Size = new System.Drawing.Size(282, 49);
            this.textBoxTarjetaCuadre.TabIndex = 38;
            this.textBoxTarjetaCuadre.Text = "0";
            this.textBoxTarjetaCuadre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn6CuadreTarjeta
            // 
            this.btn6CuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn6CuadreTarjeta.Location = new System.Drawing.Point(212, 186);
            this.btn6CuadreTarjeta.Name = "btn6CuadreTarjeta";
            this.btn6CuadreTarjeta.Size = new System.Drawing.Size(81, 56);
            this.btn6CuadreTarjeta.TabIndex = 12;
            this.btn6CuadreTarjeta.Text = "6";
            this.btn6CuadreTarjeta.UseVisualStyleBackColor = true;
            this.btn6CuadreTarjeta.Click += new System.EventHandler(this.btnTarjetaCuadreClic);
            // 
            // btn5CuadreTarjeta
            // 
            this.btn5CuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn5CuadreTarjeta.Location = new System.Drawing.Point(125, 186);
            this.btn5CuadreTarjeta.Name = "btn5CuadreTarjeta";
            this.btn5CuadreTarjeta.Size = new System.Drawing.Size(81, 56);
            this.btn5CuadreTarjeta.TabIndex = 11;
            this.btn5CuadreTarjeta.Text = "5";
            this.btn5CuadreTarjeta.UseVisualStyleBackColor = true;
            this.btn5CuadreTarjeta.Click += new System.EventHandler(this.btnTarjetaCuadreClic);
            // 
            // btn4CuadreTarjeta
            // 
            this.btn4CuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn4CuadreTarjeta.Location = new System.Drawing.Point(38, 186);
            this.btn4CuadreTarjeta.Name = "btn4CuadreTarjeta";
            this.btn4CuadreTarjeta.Size = new System.Drawing.Size(81, 56);
            this.btn4CuadreTarjeta.TabIndex = 10;
            this.btn4CuadreTarjeta.Text = "4";
            this.btn4CuadreTarjeta.UseVisualStyleBackColor = true;
            this.btn4CuadreTarjeta.Click += new System.EventHandler(this.btnTarjetaCuadreClic);
            // 
            // btn3CuadreTarjeta
            // 
            this.btn3CuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn3CuadreTarjeta.Location = new System.Drawing.Point(212, 247);
            this.btn3CuadreTarjeta.Name = "btn3CuadreTarjeta";
            this.btn3CuadreTarjeta.Size = new System.Drawing.Size(81, 56);
            this.btn3CuadreTarjeta.TabIndex = 9;
            this.btn3CuadreTarjeta.Text = "3";
            this.btn3CuadreTarjeta.UseVisualStyleBackColor = true;
            this.btn3CuadreTarjeta.Click += new System.EventHandler(this.btnTarjetaCuadreClic);
            // 
            // btn2CuadreTarjeta
            // 
            this.btn2CuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn2CuadreTarjeta.Location = new System.Drawing.Point(125, 247);
            this.btn2CuadreTarjeta.Name = "btn2CuadreTarjeta";
            this.btn2CuadreTarjeta.Size = new System.Drawing.Size(81, 56);
            this.btn2CuadreTarjeta.TabIndex = 8;
            this.btn2CuadreTarjeta.Text = "2";
            this.btn2CuadreTarjeta.UseVisualStyleBackColor = true;
            this.btn2CuadreTarjeta.Click += new System.EventHandler(this.btnTarjetaCuadreClic);
            // 
            // btncCuadreTarjeta
            // 
            this.btncCuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncCuadreTarjeta.Location = new System.Drawing.Point(38, 308);
            this.btncCuadreTarjeta.Name = "btncCuadreTarjeta";
            this.btncCuadreTarjeta.Size = new System.Drawing.Size(81, 58);
            this.btncCuadreTarjeta.TabIndex = 26;
            this.btncCuadreTarjeta.Text = "C";
            this.btncCuadreTarjeta.UseVisualStyleBackColor = true;
            this.btncCuadreTarjeta.Click += new System.EventHandler(this.btncCuadreTarjeta_Click);
            // 
            // btn0CuadreTarjeta
            // 
            this.btn0CuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn0CuadreTarjeta.Location = new System.Drawing.Point(125, 310);
            this.btn0CuadreTarjeta.Name = "btn0CuadreTarjeta";
            this.btn0CuadreTarjeta.Size = new System.Drawing.Size(81, 56);
            this.btn0CuadreTarjeta.TabIndex = 7;
            this.btn0CuadreTarjeta.Text = "0";
            this.btn0CuadreTarjeta.UseVisualStyleBackColor = true;
            this.btn0CuadreTarjeta.Click += new System.EventHandler(this.btnTarjetaCuadreClic);
            // 
            // btn7CuadreTarjeta
            // 
            this.btn7CuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn7CuadreTarjeta.Location = new System.Drawing.Point(38, 124);
            this.btn7CuadreTarjeta.Name = "btn7CuadreTarjeta";
            this.btn7CuadreTarjeta.Size = new System.Drawing.Size(81, 56);
            this.btn7CuadreTarjeta.TabIndex = 6;
            this.btn7CuadreTarjeta.Text = "7";
            this.btn7CuadreTarjeta.UseVisualStyleBackColor = true;
            this.btn7CuadreTarjeta.Click += new System.EventHandler(this.btnTarjetaCuadreClic);
            // 
            // btn9CuadreTarjeta
            // 
            this.btn9CuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn9CuadreTarjeta.Location = new System.Drawing.Point(212, 124);
            this.btn9CuadreTarjeta.Name = "btn9CuadreTarjeta";
            this.btn9CuadreTarjeta.Size = new System.Drawing.Size(81, 56);
            this.btn9CuadreTarjeta.TabIndex = 5;
            this.btn9CuadreTarjeta.Text = "9";
            this.btn9CuadreTarjeta.UseVisualStyleBackColor = true;
            this.btn9CuadreTarjeta.Click += new System.EventHandler(this.btnTarjetaCuadreClic);
            // 
            // btn8CuadreTarjeta
            // 
            this.btn8CuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn8CuadreTarjeta.Location = new System.Drawing.Point(125, 124);
            this.btn8CuadreTarjeta.Name = "btn8CuadreTarjeta";
            this.btn8CuadreTarjeta.Size = new System.Drawing.Size(81, 56);
            this.btn8CuadreTarjeta.TabIndex = 4;
            this.btn8CuadreTarjeta.Text = "8";
            this.btn8CuadreTarjeta.UseVisualStyleBackColor = true;
            this.btn8CuadreTarjeta.Click += new System.EventHandler(this.btnTarjetaCuadreClic);
            // 
            // btn1CuadreTarjeta
            // 
            this.btn1CuadreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn1CuadreTarjeta.Location = new System.Drawing.Point(38, 247);
            this.btn1CuadreTarjeta.Name = "btn1CuadreTarjeta";
            this.btn1CuadreTarjeta.Size = new System.Drawing.Size(81, 56);
            this.btn1CuadreTarjeta.TabIndex = 3;
            this.btn1CuadreTarjeta.Text = "1";
            this.btn1CuadreTarjeta.UseVisualStyleBackColor = true;
            this.btn1CuadreTarjeta.Click += new System.EventHandler(this.btnTarjetaCuadreClic);
            // 
            // labelTotalCuadre
            // 
            this.labelTotalCuadre.AutoSize = true;
            this.labelTotalCuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTotalCuadre.Location = new System.Drawing.Point(1080, 566);
            this.labelTotalCuadre.Name = "labelTotalCuadre";
            this.labelTotalCuadre.Size = new System.Drawing.Size(26, 29);
            this.labelTotalCuadre.TabIndex = 43;
            this.labelTotalCuadre.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label17.Location = new System.Drawing.Point(842, 566);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 29);
            this.label17.TabIndex = 42;
            this.label17.Text = "TOTAL";
            // 
            // labelTarjetaCuadre
            // 
            this.labelTarjetaCuadre.AutoSize = true;
            this.labelTarjetaCuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTarjetaCuadre.Location = new System.Drawing.Point(1080, 537);
            this.labelTarjetaCuadre.Name = "labelTarjetaCuadre";
            this.labelTarjetaCuadre.Size = new System.Drawing.Size(26, 29);
            this.labelTarjetaCuadre.TabIndex = 41;
            this.labelTarjetaCuadre.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label18.Location = new System.Drawing.Point(842, 537);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(219, 29);
            this.label18.TabIndex = 40;
            this.label18.Text = "DINERO TARJETA";
            // 
            // labelEfectivoCuadre
            // 
            this.labelEfectivoCuadre.AutoSize = true;
            this.labelEfectivoCuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelEfectivoCuadre.Location = new System.Drawing.Point(1080, 505);
            this.labelEfectivoCuadre.Name = "labelEfectivoCuadre";
            this.labelEfectivoCuadre.Size = new System.Drawing.Size(26, 29);
            this.labelEfectivoCuadre.TabIndex = 39;
            this.labelEfectivoCuadre.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label16.Location = new System.Drawing.Point(842, 505);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(232, 29);
            this.label16.TabIndex = 38;
            this.label16.Text = "DINERO EFECTIVO";
            // 
            // listViewCuadreCaja
            // 
            this.listViewCuadreCaja.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewCuadreCaja.AllowColumnReorder = true;
            this.listViewCuadreCaja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader6});
            this.listViewCuadreCaja.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listViewCuadreCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCuadreCaja.FullRowSelect = true;
            this.listViewCuadreCaja.GridLines = true;
            this.listViewCuadreCaja.Location = new System.Drawing.Point(842, 142);
            this.listViewCuadreCaja.MultiSelect = false;
            this.listViewCuadreCaja.Name = "listViewCuadreCaja";
            this.listViewCuadreCaja.Size = new System.Drawing.Size(344, 352);
            this.listViewCuadreCaja.TabIndex = 37;
            this.listViewCuadreCaja.UseCompatibleStateImageBehavior = false;
            this.listViewCuadreCaja.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 1;
            this.columnHeader5.Text = "CANTIDAD";
            this.columnHeader5.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 0;
            this.columnHeader4.Text = "TIPO";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TOTAL";
            this.columnHeader6.Width = 110;
            // 
            // panelEfectivoCuadre
            // 
            this.panelEfectivoCuadre.BackColor = System.Drawing.SystemColors.Control;
            this.panelEfectivoCuadre.Controls.Add(this.groupBox8);
            this.panelEfectivoCuadre.Controls.Add(this.groupBox6);
            this.panelEfectivoCuadre.Controls.Add(this.groupBox7);
            this.panelEfectivoCuadre.Location = new System.Drawing.Point(158, 142);
            this.panelEfectivoCuadre.Name = "panelEfectivoCuadre";
            this.panelEfectivoCuadre.Size = new System.Drawing.Size(678, 451);
            this.panelEfectivoCuadre.TabIndex = 36;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxCuadreIndique);
            this.groupBox8.Controls.Add(this.btn6cuadre);
            this.groupBox8.Controls.Add(this.btn5cuadre);
            this.groupBox8.Controls.Add(this.btn4cuadre);
            this.groupBox8.Controls.Add(this.btn3cuadre);
            this.groupBox8.Controls.Add(this.btn2cuadre);
            this.groupBox8.Controls.Add(this.btnCCuadre);
            this.groupBox8.Controls.Add(this.btn0cuadre);
            this.groupBox8.Controls.Add(this.btn7cuadre);
            this.groupBox8.Controls.Add(this.btn9cuadre);
            this.groupBox8.Controls.Add(this.btn8cuadre);
            this.groupBox8.Controls.Add(this.btn1cuadre);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox8.Location = new System.Drawing.Point(27, 40);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(326, 391);
            this.groupBox8.TabIndex = 37;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Indica cuanto de cada denominación";
            // 
            // textBoxCuadreIndique
            // 
            this.textBoxCuadreIndique.Enabled = false;
            this.textBoxCuadreIndique.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCuadreIndique.Location = new System.Drawing.Point(23, 70);
            this.textBoxCuadreIndique.Multiline = true;
            this.textBoxCuadreIndique.Name = "textBoxCuadreIndique";
            this.textBoxCuadreIndique.Size = new System.Drawing.Size(282, 49);
            this.textBoxCuadreIndique.TabIndex = 38;
            this.textBoxCuadreIndique.Text = "0";
            this.textBoxCuadreIndique.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn6cuadre
            // 
            this.btn6cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn6cuadre.Location = new System.Drawing.Point(212, 186);
            this.btn6cuadre.Name = "btn6cuadre";
            this.btn6cuadre.Size = new System.Drawing.Size(81, 56);
            this.btn6cuadre.TabIndex = 12;
            this.btn6cuadre.Text = "6";
            this.btn6cuadre.UseVisualStyleBackColor = true;
            this.btn6cuadre.Click += new System.EventHandler(this.btnNumeroCuadre);
            // 
            // btn5cuadre
            // 
            this.btn5cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn5cuadre.Location = new System.Drawing.Point(125, 186);
            this.btn5cuadre.Name = "btn5cuadre";
            this.btn5cuadre.Size = new System.Drawing.Size(81, 56);
            this.btn5cuadre.TabIndex = 11;
            this.btn5cuadre.Text = "5";
            this.btn5cuadre.UseVisualStyleBackColor = true;
            this.btn5cuadre.Click += new System.EventHandler(this.btnNumeroCuadre);
            // 
            // btn4cuadre
            // 
            this.btn4cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn4cuadre.Location = new System.Drawing.Point(38, 186);
            this.btn4cuadre.Name = "btn4cuadre";
            this.btn4cuadre.Size = new System.Drawing.Size(81, 56);
            this.btn4cuadre.TabIndex = 10;
            this.btn4cuadre.Text = "4";
            this.btn4cuadre.UseVisualStyleBackColor = true;
            this.btn4cuadre.Click += new System.EventHandler(this.btnNumeroCuadre);
            // 
            // btn3cuadre
            // 
            this.btn3cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn3cuadre.Location = new System.Drawing.Point(212, 247);
            this.btn3cuadre.Name = "btn3cuadre";
            this.btn3cuadre.Size = new System.Drawing.Size(81, 56);
            this.btn3cuadre.TabIndex = 9;
            this.btn3cuadre.Text = "3";
            this.btn3cuadre.UseVisualStyleBackColor = true;
            this.btn3cuadre.Click += new System.EventHandler(this.btnNumeroCuadre);
            // 
            // btn2cuadre
            // 
            this.btn2cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn2cuadre.Location = new System.Drawing.Point(125, 247);
            this.btn2cuadre.Name = "btn2cuadre";
            this.btn2cuadre.Size = new System.Drawing.Size(81, 56);
            this.btn2cuadre.TabIndex = 8;
            this.btn2cuadre.Text = "2";
            this.btn2cuadre.UseVisualStyleBackColor = true;
            this.btn2cuadre.Click += new System.EventHandler(this.btnNumeroCuadre);
            // 
            // btnCCuadre
            // 
            this.btnCCuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCuadre.Location = new System.Drawing.Point(38, 308);
            this.btnCCuadre.Name = "btnCCuadre";
            this.btnCCuadre.Size = new System.Drawing.Size(81, 58);
            this.btnCCuadre.TabIndex = 26;
            this.btnCCuadre.Text = "C";
            this.btnCCuadre.UseVisualStyleBackColor = true;
            this.btnCCuadre.Click += new System.EventHandler(this.btnCCuadre_Click);
            // 
            // btn0cuadre
            // 
            this.btn0cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn0cuadre.Location = new System.Drawing.Point(125, 310);
            this.btn0cuadre.Name = "btn0cuadre";
            this.btn0cuadre.Size = new System.Drawing.Size(81, 56);
            this.btn0cuadre.TabIndex = 7;
            this.btn0cuadre.Text = "0";
            this.btn0cuadre.UseVisualStyleBackColor = true;
            this.btn0cuadre.Click += new System.EventHandler(this.btnNumeroCuadre);
            // 
            // btn7cuadre
            // 
            this.btn7cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn7cuadre.Location = new System.Drawing.Point(38, 124);
            this.btn7cuadre.Name = "btn7cuadre";
            this.btn7cuadre.Size = new System.Drawing.Size(81, 56);
            this.btn7cuadre.TabIndex = 6;
            this.btn7cuadre.Text = "7";
            this.btn7cuadre.UseVisualStyleBackColor = true;
            this.btn7cuadre.Click += new System.EventHandler(this.btnNumeroCuadre);
            // 
            // btn9cuadre
            // 
            this.btn9cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn9cuadre.Location = new System.Drawing.Point(212, 124);
            this.btn9cuadre.Name = "btn9cuadre";
            this.btn9cuadre.Size = new System.Drawing.Size(81, 56);
            this.btn9cuadre.TabIndex = 5;
            this.btn9cuadre.Text = "9";
            this.btn9cuadre.UseVisualStyleBackColor = true;
            this.btn9cuadre.Click += new System.EventHandler(this.btnNumeroCuadre);
            // 
            // btn8cuadre
            // 
            this.btn8cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn8cuadre.Location = new System.Drawing.Point(125, 124);
            this.btn8cuadre.Name = "btn8cuadre";
            this.btn8cuadre.Size = new System.Drawing.Size(81, 56);
            this.btn8cuadre.TabIndex = 4;
            this.btn8cuadre.Text = "8";
            this.btn8cuadre.UseVisualStyleBackColor = true;
            this.btn8cuadre.Click += new System.EventHandler(this.btnNumeroCuadre);
            // 
            // btn1cuadre
            // 
            this.btn1cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn1cuadre.Location = new System.Drawing.Point(38, 247);
            this.btn1cuadre.Name = "btn1cuadre";
            this.btn1cuadre.Size = new System.Drawing.Size(81, 56);
            this.btn1cuadre.TabIndex = 3;
            this.btn1cuadre.Text = "1";
            this.btn1cuadre.UseVisualStyleBackColor = true;
            this.btn1cuadre.Click += new System.EventHandler(this.btnNumeroCuadre);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnMoneda1Cuadre);
            this.groupBox6.Controls.Add(this.btnMoneda5cCuadre);
            this.groupBox6.Controls.Add(this.btnMoneda2Cuadre);
            this.groupBox6.Controls.Add(this.btnMonedas5Cuadre);
            this.groupBox6.Controls.Add(this.btnMoneda10Cuadre);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(369, 257);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(264, 174);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Monedas";
            // 
            // btnMoneda1Cuadre
            // 
            this.btnMoneda1Cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMoneda1Cuadre.Location = new System.Drawing.Point(4, 96);
            this.btnMoneda1Cuadre.Name = "btnMoneda1Cuadre";
            this.btnMoneda1Cuadre.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda1Cuadre.TabIndex = 7;
            this.btnMoneda1Cuadre.Text = "$1";
            this.btnMoneda1Cuadre.UseVisualStyleBackColor = true;
            this.btnMoneda1Cuadre.Click += new System.EventHandler(this.btnCantidadDenominacionCuadre);
            // 
            // btnMoneda5cCuadre
            // 
            this.btnMoneda5cCuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMoneda5cCuadre.Location = new System.Drawing.Point(176, 96);
            this.btnMoneda5cCuadre.Name = "btnMoneda5cCuadre";
            this.btnMoneda5cCuadre.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda5cCuadre.TabIndex = 6;
            this.btnMoneda5cCuadre.Text = "$0.50";
            this.btnMoneda5cCuadre.UseVisualStyleBackColor = true;
            this.btnMoneda5cCuadre.Click += new System.EventHandler(this.btnCantidadDenominacionCuadre);
            // 
            // btnMoneda2Cuadre
            // 
            this.btnMoneda2Cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMoneda2Cuadre.Location = new System.Drawing.Point(176, 37);
            this.btnMoneda2Cuadre.Name = "btnMoneda2Cuadre";
            this.btnMoneda2Cuadre.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda2Cuadre.TabIndex = 5;
            this.btnMoneda2Cuadre.Text = "$2";
            this.btnMoneda2Cuadre.UseVisualStyleBackColor = true;
            this.btnMoneda2Cuadre.Click += new System.EventHandler(this.btnCantidadDenominacionCuadre);
            // 
            // btnMonedas5Cuadre
            // 
            this.btnMonedas5Cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMonedas5Cuadre.Location = new System.Drawing.Point(92, 37);
            this.btnMonedas5Cuadre.Name = "btnMonedas5Cuadre";
            this.btnMonedas5Cuadre.Size = new System.Drawing.Size(81, 56);
            this.btnMonedas5Cuadre.TabIndex = 4;
            this.btnMonedas5Cuadre.Text = "$5";
            this.btnMonedas5Cuadre.UseVisualStyleBackColor = true;
            this.btnMonedas5Cuadre.Click += new System.EventHandler(this.btnCantidadDenominacionCuadre);
            // 
            // btnMoneda10Cuadre
            // 
            this.btnMoneda10Cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMoneda10Cuadre.Location = new System.Drawing.Point(5, 37);
            this.btnMoneda10Cuadre.Name = "btnMoneda10Cuadre";
            this.btnMoneda10Cuadre.Size = new System.Drawing.Size(81, 56);
            this.btnMoneda10Cuadre.TabIndex = 3;
            this.btnMoneda10Cuadre.Text = "$10";
            this.btnMoneda10Cuadre.UseVisualStyleBackColor = true;
            this.btnMoneda10Cuadre.Click += new System.EventHandler(this.btnCantidadDenominacionCuadre);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnBillete500Cuadre);
            this.groupBox7.Controls.Add(this.btnBillete200Cuadre);
            this.groupBox7.Controls.Add(this.btnBillete100Cuadre);
            this.groupBox7.Controls.Add(this.btnBillete50Cuadre);
            this.groupBox7.Controls.Add(this.btnBillete20Cuadre);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(370, 69);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(264, 164);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "BILLETES";
            // 
            // btnBillete500Cuadre
            // 
            this.btnBillete500Cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBillete500Cuadre.Location = new System.Drawing.Point(176, 89);
            this.btnBillete500Cuadre.Name = "btnBillete500Cuadre";
            this.btnBillete500Cuadre.Size = new System.Drawing.Size(81, 56);
            this.btnBillete500Cuadre.TabIndex = 7;
            this.btnBillete500Cuadre.Text = "$500";
            this.btnBillete500Cuadre.UseVisualStyleBackColor = true;
            this.btnBillete500Cuadre.Click += new System.EventHandler(this.btnCantidadDenominacionCuadre);
            // 
            // btnBillete200Cuadre
            // 
            this.btnBillete200Cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBillete200Cuadre.Location = new System.Drawing.Point(5, 89);
            this.btnBillete200Cuadre.Name = "btnBillete200Cuadre";
            this.btnBillete200Cuadre.Size = new System.Drawing.Size(81, 56);
            this.btnBillete200Cuadre.TabIndex = 6;
            this.btnBillete200Cuadre.Text = "$200";
            this.btnBillete200Cuadre.UseVisualStyleBackColor = true;
            this.btnBillete200Cuadre.Click += new System.EventHandler(this.btnCantidadDenominacionCuadre);
            // 
            // btnBillete100Cuadre
            // 
            this.btnBillete100Cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBillete100Cuadre.Location = new System.Drawing.Point(176, 27);
            this.btnBillete100Cuadre.Name = "btnBillete100Cuadre";
            this.btnBillete100Cuadre.Size = new System.Drawing.Size(81, 56);
            this.btnBillete100Cuadre.TabIndex = 5;
            this.btnBillete100Cuadre.Text = "$100";
            this.btnBillete100Cuadre.UseVisualStyleBackColor = true;
            this.btnBillete100Cuadre.Click += new System.EventHandler(this.btnCantidadDenominacionCuadre);
            // 
            // btnBillete50Cuadre
            // 
            this.btnBillete50Cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBillete50Cuadre.Location = new System.Drawing.Point(92, 27);
            this.btnBillete50Cuadre.Name = "btnBillete50Cuadre";
            this.btnBillete50Cuadre.Size = new System.Drawing.Size(81, 56);
            this.btnBillete50Cuadre.TabIndex = 4;
            this.btnBillete50Cuadre.Text = "$50";
            this.btnBillete50Cuadre.UseVisualStyleBackColor = true;
            this.btnBillete50Cuadre.Click += new System.EventHandler(this.btnCantidadDenominacionCuadre);
            // 
            // btnBillete20Cuadre
            // 
            this.btnBillete20Cuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBillete20Cuadre.Location = new System.Drawing.Point(5, 27);
            this.btnBillete20Cuadre.Name = "btnBillete20Cuadre";
            this.btnBillete20Cuadre.Size = new System.Drawing.Size(81, 56);
            this.btnBillete20Cuadre.TabIndex = 3;
            this.btnBillete20Cuadre.Text = "$20";
            this.btnBillete20Cuadre.UseVisualStyleBackColor = true;
            this.btnBillete20Cuadre.Click += new System.EventHandler(this.btnCantidadDenominacionCuadre);
            // 
            // btnTarjetaCuadre
            // 
            this.btnTarjetaCuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjetaCuadre.Location = new System.Drawing.Point(350, 93);
            this.btnTarjetaCuadre.Name = "btnTarjetaCuadre";
            this.btnTarjetaCuadre.Size = new System.Drawing.Size(186, 44);
            this.btnTarjetaCuadre.TabIndex = 34;
            this.btnTarjetaCuadre.Text = "TARJETA";
            this.btnTarjetaCuadre.UseVisualStyleBackColor = true;
            this.btnTarjetaCuadre.Click += new System.EventHandler(this.btnTarjetaCuadre_Click);
            // 
            // btnEfectivoCuadre
            // 
            this.btnEfectivoCuadre.Enabled = false;
            this.btnEfectivoCuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfectivoCuadre.Location = new System.Drawing.Point(158, 93);
            this.btnEfectivoCuadre.Name = "btnEfectivoCuadre";
            this.btnEfectivoCuadre.Size = new System.Drawing.Size(186, 44);
            this.btnEfectivoCuadre.TabIndex = 33;
            this.btnEfectivoCuadre.Text = "EFECTIVO";
            this.btnEfectivoCuadre.UseVisualStyleBackColor = true;
            this.btnEfectivoCuadre.Click += new System.EventHandler(this.btnEfectivoCuadre_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnQuitar.Location = new System.Drawing.Point(158, 633);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(112, 56);
            this.btnQuitar.TabIndex = 8;
            this.btnQuitar.Text = "QUITAR";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCancelarCuadre
            // 
            this.btnCancelarCuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCuadre.Location = new System.Drawing.Point(539, 35);
            this.btnCancelarCuadre.Name = "btnCancelarCuadre";
            this.btnCancelarCuadre.Size = new System.Drawing.Size(186, 44);
            this.btnCancelarCuadre.TabIndex = 29;
            this.btnCancelarCuadre.Text = "CANCELAR";
            this.btnCancelarCuadre.UseVisualStyleBackColor = true;
            this.btnCancelarCuadre.Click += new System.EventHandler(this.btnCancelarCuadre_Click);
            // 
            // btnCajaCuadre
            // 
            this.btnCajaCuadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajaCuadre.Location = new System.Drawing.Point(842, 618);
            this.btnCajaCuadre.Name = "btnCajaCuadre";
            this.btnCajaCuadre.Size = new System.Drawing.Size(252, 64);
            this.btnCajaCuadre.TabIndex = 25;
            this.btnCajaCuadre.Text = "Esto es lo que tengo";
            this.btnCajaCuadre.UseVisualStyleBackColor = true;
            this.btnCajaCuadre.Click += new System.EventHandler(this.btnCajaCuadre_Click);
            // 
            // btnCierreDia
            // 
            this.btnCierreDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCierreDia.Location = new System.Drawing.Point(705, 12);
            this.btnCierreDia.Name = "btnCierreDia";
            this.btnCierreDia.Size = new System.Drawing.Size(130, 130);
            this.btnCierreDia.TabIndex = 54;
            this.btnCierreDia.Text = "CIERRE DEL DÍA";
            this.btnCierreDia.UseVisualStyleBackColor = true;
            this.btnCierreDia.Click += new System.EventHandler(this.btnCierreDia_Click);
            // 
            // panelResumenDatos
            // 
            this.panelResumenDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResumenDatos.Controls.Add(this.textBoxResumen);
            this.panelResumenDatos.Controls.Add(this.btnAceptarCierreDia);
            this.panelResumenDatos.Controls.Add(this.button77);
            this.panelResumenDatos.Location = new System.Drawing.Point(10, 1);
            this.panelResumenDatos.Name = "panelResumenDatos";
            this.panelResumenDatos.Size = new System.Drawing.Size(1267, 754);
            this.panelResumenDatos.TabIndex = 54;
            this.panelResumenDatos.Visible = false;
            // 
            // textBoxResumen
            // 
            this.textBoxResumen.Location = new System.Drawing.Point(475, 66);
            this.textBoxResumen.Multiline = true;
            this.textBoxResumen.Name = "textBoxResumen";
            this.textBoxResumen.Size = new System.Drawing.Size(315, 615);
            this.textBoxResumen.TabIndex = 30;
            // 
            // btnAceptarCierreDia
            // 
            this.btnAceptarCierreDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAceptarCierreDia.Location = new System.Drawing.Point(559, 687);
            this.btnAceptarCierreDia.Name = "btnAceptarCierreDia";
            this.btnAceptarCierreDia.Size = new System.Drawing.Size(141, 56);
            this.btnAceptarCierreDia.TabIndex = 8;
            this.btnAceptarCierreDia.Text = "ACEPTAR";
            this.btnAceptarCierreDia.UseVisualStyleBackColor = true;
            this.btnAceptarCierreDia.Click += new System.EventHandler(this.button76_Click);
            // 
            // button77
            // 
            this.button77.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button77.Location = new System.Drawing.Point(540, 12);
            this.button77.Name = "button77";
            this.button77.Size = new System.Drawing.Size(186, 44);
            this.button77.TabIndex = 29;
            this.button77.Text = "CANCELAR";
            this.button77.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button30);
            this.panel3.Controls.Add(this.button42);
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1267, 751);
            this.panel3.TabIndex = 55;
            this.panel3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(475, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 574);
            this.textBox1.TabIndex = 30;
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button30.Location = new System.Drawing.Point(562, 647);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(141, 56);
            this.button30.TabIndex = 8;
            this.button30.Text = "ACEPTAR";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button42
            // 
            this.button42.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button42.Location = new System.Drawing.Point(539, 15);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(186, 44);
            this.button42.TabIndex = 29;
            this.button42.Text = "CANCELAR";
            this.button42.UseVisualStyleBackColor = true;
            // 
            // panelCriticos
            // 
            this.panelCriticos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCriticos.Controls.Add(this.dateTimePicker2);
            this.panelCriticos.Controls.Add(this.dtInicio);
            this.panelCriticos.Controls.Add(this.label19);
            this.panelCriticos.Controls.Add(this.label20);
            this.panelCriticos.Controls.Add(this.tblInv);
            this.panelCriticos.Controls.Add(this.cmbCriticos);
            this.panelCriticos.Controls.Add(this.button43);
            this.panelCriticos.Controls.Add(this.button44);
            this.panelCriticos.Location = new System.Drawing.Point(7, 5);
            this.panelCriticos.Name = "panelCriticos";
            this.panelCriticos.Size = new System.Drawing.Size(1167, 750);
            this.panelCriticos.TabIndex = 34;
            this.panelCriticos.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(234, 233);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 56;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(15, 233);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(231, 201);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 17);
            this.label19.TabIndex = 54;
            this.label19.Text = "Fecha final";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(15, 205);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 17);
            this.label20.TabIndex = 53;
            this.label20.Text = "Fecha inicio";
            // 
            // tblInv
            // 
            this.tblInv.AllowUserToAddRows = false;
            this.tblInv.AllowUserToDeleteRows = false;
            this.tblInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.dataGridViewTextBoxColumn1,
            this.Inv_ini,
            this.unidad,
            this.Entradas,
            this.Salidas,
            this.Mermas,
            this.Inventario_Final,
            this.minimo,
            this.maximo});
            this.tblInv.Location = new System.Drawing.Point(8, 258);
            this.tblInv.Name = "tblInv";
            this.tblInv.ReadOnly = true;
            this.tblInv.Size = new System.Drawing.Size(1149, 200);
            this.tblInv.TabIndex = 52;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 115;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // Inv_ini
            // 
            this.Inv_ini.HeaderText = "Inventario Inicial";
            this.Inv_ini.Name = "Inv_ini";
            this.Inv_ini.ReadOnly = true;
            this.Inv_ini.Width = 120;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad de medida";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            this.unidad.Width = 130;
            // 
            // Entradas
            // 
            this.Entradas.HeaderText = "Entradas";
            this.Entradas.Name = "Entradas";
            this.Entradas.ReadOnly = true;
            this.Entradas.Width = 90;
            // 
            // Salidas
            // 
            this.Salidas.HeaderText = "Salidas";
            this.Salidas.Name = "Salidas";
            this.Salidas.ReadOnly = true;
            this.Salidas.Width = 90;
            // 
            // Mermas
            // 
            this.Mermas.HeaderText = "Mermas";
            this.Mermas.Name = "Mermas";
            this.Mermas.ReadOnly = true;
            this.Mermas.Width = 90;
            // 
            // Inventario_Final
            // 
            this.Inventario_Final.HeaderText = "Inventario Final";
            this.Inventario_Final.Name = "Inventario_Final";
            this.Inventario_Final.ReadOnly = true;
            this.Inventario_Final.Width = 130;
            // 
            // minimo
            // 
            this.minimo.HeaderText = "Minimo";
            this.minimo.Name = "minimo";
            this.minimo.ReadOnly = true;
            this.minimo.Width = 90;
            // 
            // maximo
            // 
            this.maximo.HeaderText = "Maximo";
            this.maximo.Name = "maximo";
            this.maximo.ReadOnly = true;
            this.maximo.Width = 90;
            // 
            // cmbCriticos
            // 
            this.cmbCriticos.FormattingEnabled = true;
            this.cmbCriticos.Location = new System.Drawing.Point(938, 233);
            this.cmbCriticos.Name = "cmbCriticos";
            this.cmbCriticos.Size = new System.Drawing.Size(203, 21);
            this.cmbCriticos.TabIndex = 51;
            this.cmbCriticos.Text = "CRITICOS";
            this.cmbCriticos.SelectedIndexChanged += new System.EventHandler(this.cmbCriticos_SelectedIndexChanged);
            // 
            // button43
            // 
            this.button43.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button43.Location = new System.Drawing.Point(437, 60);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(186, 44);
            this.button43.TabIndex = 29;
            this.button43.Text = "CANCELAR";
            this.button43.UseVisualStyleBackColor = true;
            this.button43.Click += new System.EventHandler(this.button43_Click);
            // 
            // button44
            // 
            this.button44.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button44.Location = new System.Drawing.Point(423, 582);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(186, 66);
            this.button44.TabIndex = 25;
            this.button44.Text = "OK";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click);
            // 
            // panelConttra
            // 
            this.panelConttra.Controls.Add(this.panelTec);
            this.panelConttra.Controls.Add(this.panelAutorizacion);
            this.panelConttra.Location = new System.Drawing.Point(7, 14);
            this.panelConttra.Name = "panelConttra";
            this.panelConttra.Size = new System.Drawing.Size(1148, 750);
            this.panelConttra.TabIndex = 31;
            this.panelConttra.Visible = false;
            // 
            // panelTec
            // 
            this.panelTec.Controls.Add(this.btnEntrar);
            this.panelTec.Controls.Add(this.btnC);
            this.panelTec.Controls.Add(this.btnNum0);
            this.panelTec.Controls.Add(this.btnNum9);
            this.panelTec.Controls.Add(this.btnNum8);
            this.panelTec.Controls.Add(this.btnNum7);
            this.panelTec.Controls.Add(this.btnNum6);
            this.panelTec.Controls.Add(this.btn);
            this.panelTec.Controls.Add(this.btnNum4);
            this.panelTec.Controls.Add(this.btnNum3);
            this.panelTec.Controls.Add(this.btnNum2);
            this.panelTec.Controls.Add(this.btnNum1);
            this.panelTec.Location = new System.Drawing.Point(387, 243);
            this.panelTec.Name = "panelTec";
            this.panelTec.Size = new System.Drawing.Size(356, 478);
            this.panelTec.TabIndex = 54;
            this.panelTec.Visible = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(69, 395);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(203, 70);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnAceptarAuto_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(232, 310);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 70);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click_2);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(41, 310);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(75, 70);
            this.btnNum0.TabIndex = 9;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.agregarNumeroTecladoContra);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(232, 217);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(75, 70);
            this.btnNum9.TabIndex = 8;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.agregarNumeroTecladoContra);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(135, 217);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(75, 70);
            this.btnNum8.TabIndex = 7;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.agregarNumeroTecladoContra);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(41, 217);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(75, 70);
            this.btnNum7.TabIndex = 6;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.agregarNumeroTecladoContra);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(232, 128);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(75, 70);
            this.btnNum6.TabIndex = 5;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.agregarNumeroTecladoContra);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(135, 128);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 70);
            this.btn.TabIndex = 4;
            this.btn.Text = "5";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.agregarNumeroTecladoContra);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(41, 128);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(75, 70);
            this.btnNum4.TabIndex = 3;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.agregarNumeroTecladoContra);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(232, 37);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(75, 70);
            this.btnNum3.TabIndex = 2;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.agregarNumeroTecladoContra);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(135, 37);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(75, 70);
            this.btnNum2.TabIndex = 1;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.agregarNumeroTecladoContra);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(41, 37);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(75, 70);
            this.btnNum1.TabIndex = 0;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.agregarNumeroTecladoContra);
            // 
            // panelAutorizacion
            // 
            this.panelAutorizacion.Controls.Add(this.btnAceptarAuto);
            this.panelAutorizacion.Controls.Add(this.btnCancelarAuto);
            this.panelAutorizacion.Controls.Add(this.txtContra);
            this.panelAutorizacion.Controls.Add(this.label15);
            this.panelAutorizacion.Location = new System.Drawing.Point(385, 13);
            this.panelAutorizacion.Name = "panelAutorizacion";
            this.panelAutorizacion.Size = new System.Drawing.Size(378, 215);
            this.panelAutorizacion.TabIndex = 53;
            this.panelAutorizacion.Visible = false;
            // 
            // btnAceptarAuto
            // 
            this.btnAceptarAuto.Location = new System.Drawing.Point(231, 126);
            this.btnAceptarAuto.Name = "btnAceptarAuto";
            this.btnAceptarAuto.Size = new System.Drawing.Size(127, 66);
            this.btnAceptarAuto.TabIndex = 3;
            this.btnAceptarAuto.Text = "ACEPTAR";
            this.btnAceptarAuto.UseVisualStyleBackColor = true;
            this.btnAceptarAuto.Click += new System.EventHandler(this.btnAceptarAuto_Click);
            // 
            // btnCancelarAuto
            // 
            this.btnCancelarAuto.Location = new System.Drawing.Point(23, 126);
            this.btnCancelarAuto.Name = "btnCancelarAuto";
            this.btnCancelarAuto.Size = new System.Drawing.Size(127, 66);
            this.btnCancelarAuto.TabIndex = 2;
            this.btnCancelarAuto.Text = "CANCELAR";
            this.btnCancelarAuto.UseVisualStyleBackColor = true;
            this.btnCancelarAuto.Click += new System.EventHandler(this.btnCancelarAuto_Click);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(42, 80);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(295, 20);
            this.txtContra.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(68, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(250, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "NECESITA AUTORIZACION PARA ESTA ACCION";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoScroll = true;
            this.groupBox1.Location = new System.Drawing.Point(560, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "Familias";
            // 
            // FormTomaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 766);
            this.ControlBox = false;
            this.Controls.Add(this.panelCuadreCaja);
            this.Controls.Add(this.panelTarjeta);
            this.Controls.Add(this.panelCambio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelCambioDash);
            this.Controls.Add(this.panelConttra);
            this.Controls.Add(this.panelRefresco);
            this.Controls.Add(this.panelCriticos);
            this.Controls.Add(this.panelMonedas);
            this.Controls.Add(this.panelResumenDatos);
            this.Controls.Add(this.panelMonedasT);
            this.Controls.Add(this.panelExtras);
            this.Controls.Add(this.panelDenominaciones);
            this.Controls.Add(this.panelCorte);
            this.Controls.Add(this.BtnCorte);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuitarProd);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaPed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCierreDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTomaOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormTomaOrden_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCambio.ResumeLayout(false);
            this.panelCambio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).EndInit();
            this.panelCambioDash.ResumeLayout(false);
            this.panelCambioDash.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panelTarjeta.ResumeLayout(false);
            this.panelTarjeta.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBAmerican)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMasterCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVisa)).EndInit();
            this.panelExtras.ResumeLayout(false);
            this.panelExtras.PerformLayout();
            this.panelMonedasT.ResumeLayout(false);
            this.panelMonedasT.PerformLayout();
            this.panelRefresco.ResumeLayout(false);
            this.panelRefresco.PerformLayout();
            this.panelDenominaciones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panelMonedas.ResumeLayout(false);
            this.panelMonedas.PerformLayout();
            this.panelCorte.ResumeLayout(false);
            this.panelCorte.PerformLayout();
            this.panelCuadreCaja.ResumeLayout(false);
            this.panelCuadreCaja.PerformLayout();
            this.panelTarjetaCuadre.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panelEfectivoCuadre.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panelResumenDatos.ResumeLayout(false);
            this.panelResumenDatos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelCriticos.ResumeLayout(false);
            this.panelCriticos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInv)).EndInit();
            this.panelConttra.ResumeLayout(false);
            this.panelTec.ResumeLayout(false);
            this.panelAutorizacion.ResumeLayout(false);
            this.panelAutorizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnQuitarProd;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ColumnHeader COSTO;
        private System.Windows.Forms.ListView listaPed;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label lbPago;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPorPagar;
        private System.Windows.Forms.Panel panelMonedasT;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.ColumnHeader NUM;
        private System.Windows.Forms.ColumnHeader PRODUCTO;
        private System.Windows.Forms.Panel panelCambio;
        private System.Windows.Forms.PictureBox pictureBoxWarning;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelRefresco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCorte;
        private System.Windows.Forms.Panel panelCambioDash;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ListView listCambio;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader VALOR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCambio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listDineroEnCaja;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnCancelarDash;
        private System.Windows.Forms.Panel panelExtras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelDenominaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBillete500;
        private System.Windows.Forms.Button btnBillete200;
        private System.Windows.Forms.Button btnBillete100;
        private System.Windows.Forms.Button btnBillete50;
        private System.Windows.Forms.Button btnBillete20;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label tipoPagoLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMoneda1;
        private System.Windows.Forms.Button btnMoneda50c;
        private System.Windows.Forms.Button btnMoneda2;
        private System.Windows.Forms.Button btnMoneda5;
        private System.Windows.Forms.Button btnMoneda10;
        private System.Windows.Forms.Button btnPagoTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Panel panelActiveAE;
        private System.Windows.Forms.Panel panelActiveMC;
        private System.Windows.Forms.Panel panelActiveVisa;
        private System.Windows.Forms.PictureBox pBoxVisa;
        private System.Windows.Forms.PictureBox pBMasterCard;
        private System.Windows.Forms.PictureBox pBAmerican;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelarTarjeta;
        private System.Windows.Forms.Button tarjeta;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelTarjeta;
        private System.Windows.Forms.TextBox textBoxMonedas;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel panelMonedas;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.TextBox textboxDineroCa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Panel panelCorte;
        private System.Windows.Forms.Button btnCorteAceptar;
        private System.Windows.Forms.TextBox txtVerCorte;
        private System.Windows.Forms.Panel panelCuadreCaja;
        private System.Windows.Forms.ListView listViewCuadreCaja;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panelEfectivoCuadre;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnMoneda1Cuadre;
        private System.Windows.Forms.Button btnMoneda5cCuadre;
        private System.Windows.Forms.Button btnMoneda2Cuadre;
        private System.Windows.Forms.Button btnMonedas5Cuadre;
        private System.Windows.Forms.Button btnMoneda10Cuadre;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnBillete500Cuadre;
        private System.Windows.Forms.Button btnBillete200Cuadre;
        private System.Windows.Forms.Button btnBillete100Cuadre;
        private System.Windows.Forms.Button btnBillete50Cuadre;
        private System.Windows.Forms.Button btnBillete20Cuadre;
        private System.Windows.Forms.Button btnTarjetaCuadre;
        private System.Windows.Forms.Button btnEfectivoCuadre;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCancelarCuadre;
        private System.Windows.Forms.Button btnCCuadre;
        private System.Windows.Forms.Button btnCajaCuadre;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBoxCuadreIndique;
        private System.Windows.Forms.Button btn6cuadre;
        private System.Windows.Forms.Button btn5cuadre;
        private System.Windows.Forms.Button btn4cuadre;
        private System.Windows.Forms.Button btn3cuadre;
        private System.Windows.Forms.Button btn2cuadre;
        private System.Windows.Forms.Button btn0cuadre;
        private System.Windows.Forms.Button btn7cuadre;
        private System.Windows.Forms.Button btn9cuadre;
        private System.Windows.Forms.Button btn8cuadre;
        private System.Windows.Forms.Button btn1cuadre;
        private System.Windows.Forms.Label labelEfectivoCuadre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelTarjetaCuadre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelTotalCuadre;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCierreDia;
        private System.Windows.Forms.Panel panelResumenDatos;
        private System.Windows.Forms.Button btnAceptarCierreDia;
        private System.Windows.Forms.Button button77;
        private System.Windows.Forms.TextBox textBoxResumen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Panel panelCriticos;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView tblInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_ini;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mermas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario_Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximo;
        private System.Windows.Forms.ComboBox cmbCriticos;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Panel panelConttra;
        private System.Windows.Forms.Panel panelTec;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Panel panelAutorizacion;
        private System.Windows.Forms.Button btnAceptarAuto;
        private System.Windows.Forms.Button btnCancelarAuto;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Panel groupBox1;
        private System.Windows.Forms.Button btnPagoDiferido;
        private System.Windows.Forms.Panel panelTarjetaCuadre;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnOkCuadreTarjeta;
        private System.Windows.Forms.TextBox textBoxTarjetaCuadre;
        private System.Windows.Forms.Button btn6CuadreTarjeta;
        private System.Windows.Forms.Button btn5CuadreTarjeta;
        private System.Windows.Forms.Button btn4CuadreTarjeta;
        private System.Windows.Forms.Button btn3CuadreTarjeta;
        private System.Windows.Forms.Button btn2CuadreTarjeta;
        private System.Windows.Forms.Button btncCuadreTarjeta;
        private System.Windows.Forms.Button btn0CuadreTarjeta;
        private System.Windows.Forms.Button btn7CuadreTarjeta;
        private System.Windows.Forms.Button btn9CuadreTarjeta;
        private System.Windows.Forms.Button btn8CuadreTarjeta;
        private System.Windows.Forms.Button btn1CuadreTarjeta;
        private System.Windows.Forms.Button btnPagarDiferido;
        private System.Windows.Forms.Label labelRestantePagarDiferidoMensaje;
        private System.Windows.Forms.Label labelRestanteDiferido;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelTotalPagarDiferido;
        private System.Windows.Forms.Label labelTotalPagarDiferidoMensaje;
    }
}