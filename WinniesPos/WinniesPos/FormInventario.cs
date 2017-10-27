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
using WindowsFormsApplication1.Clases.Datos;
using System.Drawing.Printing;
using System.Configuration;
using System.Globalization;

namespace WindowsFormsApplication1

{

    public partial class FormInventario : Form
    {
        int poc;
        int pos;
        BaseDatos cnn;
        decimal entt;
        int reff;
        int cantidadReq;
        string ingredienteReq;
        string medida;
        IList<InventarioIng> listaInventario;
        IList<Ingredientes> listaIngredientes;
        IList<Critico> lCriticos;
        IList<TipoCritico> listatiposCriticos;
        IList<InventarioIng> listaBajos;
        public FormInventario()
        
        {
            InitializeComponent();
            BtnDel.Enabled = false;
            BtnMod.Enabled = false;
            cnn = new BaseDatos();
        }
        void limpiar()
        {
            BtnDel.Enabled = false;
            BtnMod.Enabled = false;
            txtProd.Text = "";
            txtPresentacion.Text = "";
            txtInvIni.Text = "";
            txtMerma.Text = "";
            txtPrestamo.Text = "";
            txtCort.Text = "";
            txtEntradas.Text = "";
            txtPzV.Text = "";
            txtDif.Text = "";
            txtInvFin.Text = "";
        }
        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string prod, pres, invInic, Merm, Prestamos, cort, entr, Pzv, dif, invfin;
            prod = txtProd.Text;
            pres = txtPresentacion.Text;
            invInic = txtInvIni.Text;
            Merm = txtMerma.Text;
            Prestamos = txtPrestamo.Text;
            cort = txtCort.Text;
            entr = txtEntradas.Text;
            Pzv = txtPzV.Text;
            dif = txtDif.Text;
            invfin = txtInvFin.Text;
            tblInv.Rows.Add(prod, pres, invInic, Merm, Prestamos, cort, entr, Pzv, dif, invfin);
            limpiar();
            BtnDel.Enabled = false;
            BtnMod.Enabled = false;

        }

        private void tblInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            poc = tblInv.CurrentRow.Index;
            string nombre,unidad,entradas,mermas,min,max;
            nombre = tblInv[1, poc].Value.ToString();
            unidad = tblInv[3, poc].Value.ToString();
            entradas = tblInv[4, poc].Value.ToString();
            mermas = tblInv[6, poc].Value.ToString();
            min = tblInv[8, poc].Value.ToString();
            max = tblInv[9, poc].Value.ToString();
            if ((nombre != "" )&&(unidad !="")&&(entradas != "") && (mermas != "") && (min != "") && (max != ""))
            {
                txtProd.Text = nombre;
                txtPresentacion.Text = unidad;
                txtMinimo.Text = min;
                txtMaximo.Text = max;
                txtEntradas.Text = entradas;
                txtMerma.Text = mermas;
                 BtnMod.Enabled = true;
                btnPedido.Enabled = true;
            }
            
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            limpiar();
            BtnAdd.Enabled = true;

        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            string prod;
            int idIngrediente,merm,entr;
            prod = txtProd.Text;
            merm = Convert.ToInt32(txtMerma.Text);
            entr = Convert.ToInt32(txtEntradas.Text);
           Ingredientes seleccionadoI = listaIngredientes.Where(ingre => ingre.descripcion == prod).FirstOrDefault();

            idIngrediente = Convert.ToInt32(seleccionadoI.idIngrediente);
            InventarioIng seleccionado = listaInventario.Where(ingre => ingre.idIngrediente == seleccionadoI.idIngrediente).FirstOrDefault();
            //idIngrediente = Convert.ToString(tblInv[10, poc].Value);
            
            
           
            int idInv = seleccionado.idInventario;

            if(cnn.actualizarInventario(seleccionado.inventarioInicial, merm, entr,seleccionado.salidas, idInv))
            {
                MessageBox.Show("Inventario actualizado");
                int final = seleccionado.inventarioInicial + entr - seleccionado.salidas - merm;
                tblInv[4, poc].Value = txtEntradas.Text;
                tblInv[6, poc].Value = txtMerma.Text;
                tblInv[7, poc].Value = final.ToString(); 
            }

            limpiar();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            tblInv.Rows.RemoveAt(poc);
        }
        

        private void FormInventario_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            listaInventario = cnn.consultarInventario();
            listaIngredientes = cnn.consultarIngredientes();
            lCriticos = cnn.consultarCriticos();
            listatiposCriticos = cnn.consultarTiposCriticos();
            cmbCriticos.Items.Clear();
            foreach (TipoCritico selec in listatiposCriticos)
            {
                
                cmbCriticos.Items.Add(selec.descripcion.ToString());
            }
            foreach (Ingredientes comboIng in listaIngredientes)
            {
                cmbProducto.Items.Add(comboIng.descripcion.ToString());

            }
            foreach (Ingredientes ing in listaIngredientes)
            {
                cmbTodos.Items.Add(ing.descripcion.ToString());
            }
            
            foreach (InventarioIng ingrediente in listaInventario)
            {
                dtInicio.Value = Convert.ToDateTime(ingrediente.fecha);
                string fecha, invInic, entradas, salidas, mermas, invFin,min,max;
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
                //tblInv.Rows.Add(fecha, producto, invInic, unidadM, entradas, salidas, mermas, invFin,min,max);
            }
            //string idTienda = ConfigurationManager.AppSettings["id_tienda"];

            //using (DataTable dt = cnn.consultarInventario(Convert.ToInt32(idTienda)))
            //{
            //    tblInv.DataSource = dt;
            //}
            //BtnDel.Enabled = false;
            //BtnMod.Enabled = false;
            //btnPedido.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
            this.Dispose();
        }

        private void txtEntradas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEntradas_Click(object sender, EventArgs e)
        {
            reff = 7;
            panelTec.Visible = true;
            
            
        }
        public void teclado() {
            panelTec.Visible = true;
            
        }
        private void button14_Click(object sender, EventArgs e)
        {
            panelTec.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + "1";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + "1";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + "1";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + "1";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + "1";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + "1";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + "1";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + "1";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + "1";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + "1";
                    break;
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2,pos].Value = anterior + "1";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "1";
                    break;
                default:
                    break;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + "2";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + "2";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + "2";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + "2";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + "2";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + "2";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + "2";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + "2";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + "2";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + "2";
                    break;
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "2";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "2";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "2";
                    break;
                default:
                    break;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + "3";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + "3";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + "3";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + "3";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + "3";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + "3";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + "3";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + "3";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + "3";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + "3";
                    break;
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "3";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "3";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "3";
                    break;
                default:
                    break;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + "4";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + "4";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + "4";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + "4";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + "4";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + "4";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + "4";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + "4";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + "4";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + "4";
                    break;
                case 11:
                    // txtCantidadPed.Text = txtCantidadPed.Text + "4";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "4";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "4";
                    break;
                default:
                    break;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + "5";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + "5";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + "5";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + "5";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + "5";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + "5";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + "5";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + "5";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + "5";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + "5";
                    break;
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "5";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "5";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "5";
                    break;
                default:
                    break;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + "6";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + "6";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + "6";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + "6";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + "6";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + "6";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + "6";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + "6";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + "6";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + "6";
                    break;
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "6";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "6";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "6";
                    break;
                default:
                    break;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + "7";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + "7";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + "7";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + "7";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + "7";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + "7";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + "7";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + "7";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + "7";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + "7";
                    break;
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "7";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "7";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "7";
                    break;
                default:
                    break;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + "8";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + "8";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + "8";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + "8";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + "8";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + "8";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + "8";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + "8";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + "8";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + "8";
                    break;
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "8";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "8";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "8";
                    break;
                default:
                    break;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + "9";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + "9";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + "9";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + "9";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + "9";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + "9";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + "9";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + "9";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + "9";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + "9";
                    break;
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "9";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "9";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "9";
                    break;
                default:
                    break;
            }
            }

        private void btn0_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + "0";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + "0";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + "0";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + "0";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + "0";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + "0";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + "0";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + "0";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + "0";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + "0";
                    break;
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "0";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "0";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "0";
                    break;
                default:
                    break;
            }
            }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = txtProd.Text + ".";
                    break;
                case 2:
                    txtPresentacion.Text = txtPresentacion.Text + ".";
                    break;
                case 3:
                    txtInvIni.Text = txtInvIni.Text + ".";
                    break;
                case 4:
                    txtMerma.Text = txtMerma.Text + ".";
                    break;
                case 5:
                    txtPrestamo.Text = txtPrestamo.Text + ".";
                    break;
                case 6:
                    txtCort.Text = txtCort.Text + ".";
                    break;
                case 7:
                    txtEntradas.Text = txtEntradas.Text + ".";
                    break;
                case 8:
                    txtPzV.Text = txtPzV.Text + ".";
                    break;
                case 9:
                    txtDif.Text = txtDif.Text + ".";
                    break;
                case 10:
                    txtInvFin.Text = txtInvFin.Text + ".";
                    break;
                case 11:
                    // txtCantidadPed.Text = txtCantidadPed.Text + ".";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + ".";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + ".";
                    break;
                default:
                    break;
            }
            }

        private void C_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 1:
                    txtProd.Text = "";
                    break;
                case 2:
                    txtPresentacion.Text =  "";
                    break;
                case 3:
                    txtInvIni.Text =  "";
                    break;
                case 4:
                    txtMerma.Text =  "";
                    break;
                case 5:
                    txtPrestamo.Text =  "";
                    break;
                case 6:
                    txtCort.Text = "";
                    break;
                case 7:
                    txtEntradas.Text = "";
                    break;
                case 8:
                    txtPzV.Text =  "";
                    break;
                case 9:
                    txtDif.Text =  "";
                    break;
                case 10:
                    txtInvFin.Text = "";
                    break;
                case 11:
                    //txtCantidadPed.Text = "";
                    string anterior = tablaBajos[pos,2].Value.ToString();
                    tablaBajos[2,pos].Value ="";
                    break;
                case 12:
                    txtCantidadpedir.Text =  "";
                    break;
                default:
                    break;
            }
            }

        private void tblInv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProd_Click(object sender, EventArgs e)
        {
            reff = 1;
            panelTec.Visible = true;

        }

        private void txtPresentacion_Click(object sender, EventArgs e)
        {
            reff = 2;
            panelTec.Visible = true;
        }

        private void txtInvIni_Click(object sender, EventArgs e)
        {
            reff = 3;
            panelTec.Visible = true;
        }

        private void txtMerma_Click(object sender, EventArgs e)
        {
            reff = 4;
            panelTec.Visible = true;
        }

        private void txtPrestamo_Click(object sender, EventArgs e)
        {
            reff = 5;
            panelTec.Visible = true;
        }

        private void txtCort_Click(object sender, EventArgs e)
        {
            reff = 6;
            panelTec.Visible = true;
        }

        private void txtPzV_Click(object sender, EventArgs e)
        {
            reff = 8;
            panelTec.Visible = true;
        }

        private void txtDif_Click(object sender, EventArgs e)
        {
            reff = 9;
            panelTec.Visible = true;
        }

        private void txtInvFin_Click(object sender, EventArgs e)
        {
            reff = 10;
            panelTec.Visible = true;
        }

        private void lbIngrediente_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelCantidad.Visible = true;
           // panelTec.Visible = true;
            listaBajos = listaInventario.Where(bajo => bajo.inventarioFinal <= bajo.minimo).ToList();
            foreach (InventarioIng inv in listaBajos)
            {
                int prom = inv.maximo/2;
                Ingredientes local = listaIngredientes.Where(selec => selec.idIngrediente == inv.idIngrediente).FirstOrDefault();
                if (local != null)
                {
                    tablaBajos.Rows.Add(local.descripcion.ToString(), local.unidadMedida.ToString(), prom.ToString());
                }
            }
            //reff = 11;
        }

        private void txtCantidadPed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPzV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadPed_Click(object sender, EventArgs e)
        {
            //reff = 11;
            panelTec.Visible = true;
        }

        private void btnCancelarCant_Click(object sender, EventArgs e)
        {
            panelCantidad.Visible = false;
            paneltec2.Visible = false;
        }

        private void btnConfirCant_Click(object sender, EventArgs e)
        {
            if (cmbTodos.Text != "" || reff == 12)
            {
                cantidadReq = Convert.ToInt32(txtCantidadpedir.Text);
                ingredienteReq = cmbTodos.Text;
                lbCantidad.Text = cantidadReq.ToString();
                lbIngrediente.Text = ingredienteReq;
                Ingredientes faltante = listaIngredientes.Where(falta => falta.descripcion == ingredienteReq).FirstOrDefault();
                lbMedida.Text = faltante.unidadMedida.ToString();
                InventarioIng localInv = listaInventario.Where(inv => inv.idIngrediente == faltante.idIngrediente).FirstOrDefault();
                if (cantidadReq <= localInv.maximo)
                {
                    panelCantidad.Visible = false;
                    panelTec.Visible = false;
                    panelConfirma.Visible = true;
                }
                else
                {
                    MessageBox.Show("POR FAVOR INGRESE UNA CANTIDAD MENOR AL MAXIMO DEL PRODUCTO");
                }

            }
            else
            { 
                if (tablaBajos[2, pos].Value.ToString() != "")
                {
                    string localstr = tablaBajos[2, pos].Value.ToString();
                    cantidadReq = Convert.ToInt32(localstr);
                    ingredienteReq = tablaBajos[0, pos].Value.ToString();
                    lbCantidad.Text = cantidadReq.ToString();
                    lbIngrediente.Text = ingredienteReq;
                    Ingredientes faltante = listaIngredientes.Where(falta => falta.descripcion == ingredienteReq).FirstOrDefault();
                    lbMedida.Text = faltante.unidadMedida.ToString();
                    InventarioIng localInv = listaInventario.Where(inv => inv.idIngrediente == faltante.idIngrediente).FirstOrDefault();
                    if (cantidadReq <= localInv.maximo)
                    {
                        panelCantidad.Visible = false;
                        panelTec.Visible = false;
                        panelConfirma.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("POR FAVOR INGRESE UNA CANTIDAD MENOR AL MAXIMO DEL PRODUCTO");
                    }

                }
            }
        }

        private void btnCancelarSeg_Click(object sender, EventArgs e)
        {
            panelConfirma.Visible = false;
        }

        private void btnConfirSeg_Click(object sender, EventArgs e)
        {
            string idTienda = ConfigurationManager.AppSettings["id_tienda"];
            string codigoEmpleado = ConfigurationManager.AppSettings["codigo_trabajador"];
            Ingredientes faltante = listaIngredientes.Where(falta => falta.descripcion == ingredienteReq).FirstOrDefault();
            if (cnn.mandarPedido(Convert.ToInt32(faltante.idIngrediente), cantidadReq, Convert.ToInt32(idTienda),Convert.ToInt32(codigoEmpleado)))
            {
                panelConfirma.Visible = false;
                //txtCantidadPed.Text = "";
                MessageBox.Show("SUMINISTROS PEDIDOS");
            }
            else
            {
                MessageBox.Show("por favor repita el proceso, de insistir el problema contactenos");
            }
        }

        private void panelConfirma_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cmbCriticos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cmbCriticos.Text;
            tblInv.Rows.Clear();
            TipoCritico tipoLocal = listatiposCriticos.Where(tipo => tipo.descripcion == select).FirstOrDefault();
            IList<Critico> listaLocal = lCriticos.Where(tipo => tipo.idTipoCritico == tipoLocal.idTipoCritico).ToList();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pos= tablaBajos.CurrentRow.Index;

        }

        private void tablaBajos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = tablaBajos.CurrentRow.Index;
            reff = 11;
            paneltec2.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //carga todos los ingredientes a la comboBox
            Ingredientes localIng = listaIngredientes.Where(ingre => ingre.descripcion == cmbTodos.Text).FirstOrDefault();
            if (localIng != null)
            {
                InventarioIng localInv = listaInventario.Where(inv => inv.idIngrediente == localIng.idIngrediente).FirstOrDefault();

                lbUM.Text = localIng.unidadMedida;
                txtCantidadpedir.Text = (localInv.maximo / 2).ToString();
            }
        }

        private void lbCantidadpedir_Click(object sender, EventArgs e)
        {
            reff = 12;
            paneltec2.Visible = true;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            switch (reff) {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "1";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "1";
                    break;
                default:
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "2";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "2";
                    break;
                default:
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "3";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "3";
                    break;
                default:
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "4";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "4";
                    break;
                default:
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "5";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "5";
                    break;
                default:
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "6";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "6";
                    break;
                default:
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "7";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "7";
                    break;
                default:
                    break;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "8";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "8";
                    break;
                default:
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "9";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "9";
                    break;
                default:
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + "0";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + "0";
                    break;
                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value = anterior + ".";
                    break;
                case 12:
                    txtCantidadpedir.Text = txtCantidadpedir.Text + ".";
                    break;
                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    string anterior = tablaBajos[2, pos].Value.ToString();
                    tablaBajos[2, pos].Value =  "";
                    break;
                case 12:
                    txtCantidadpedir.Text =  "";
                    break;
                default:
                    break;
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            switch (reff)
            {
                case 11:
                    //txtCantidadPed.Text = txtCantidadPed.Text + "1";
                    paneltec2.Visible = false;
                    break;
                case 12:
                    paneltec2.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
