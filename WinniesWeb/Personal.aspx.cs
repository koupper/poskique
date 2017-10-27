using System;
using System.Collections.Generic;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        btnGuardar.Visible = true;
        btnLimpiar.Visible = true;
        btnEditar.Visible = false;
    }
    protected void bntSalir_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
    protected void bntGenerar_Click(object sender, EventArgs e)
    {
        BaseDatos cnn = new BaseDatos();
        btnLimpiar.Visible = false;
        btnGuardar.Visible = false;
        btnEditar.Visible = true;
        DataRow row = xGridPersonal.GetDataRow(xGridPersonal.FocusedRowIndex);
        txtCodigo.Text = row[0].ToString();
        txtCodigo.Enabled = false;
        txtNombre.Text = row[1].ToString();
        txtApellido.Text = row[2].ToString();
        txtContrasena.Text = row[3].ToString();
        dropEditar.SelectedValue = row[4].ToString();
        chkActivo.Checked = Convert.ToBoolean(row[5]);
        List<datos> lista = new List<datos>();
        lista = cnn.obtenerPermisos(Convert.ToInt32(row[0]));
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            for (int p = 0; p < lista.Count; p++)
            {
                if (lista[p].permiso == Convert.ToInt32(CheckBoxList1.Items[i].Value))
                    CheckBoxList1.Items[i].Selected = true;
                else
                    CheckBoxList1.Items[i].Selected = false;
            }
        }
        
    }
    
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        bool activo;
        if (chkActivo.Checked == true)
        {
            activo = true;
        }else
        {
            activo = false;
        }
        BaseDatos cnn = new BaseDatos();
        lblInfo.Text = cnn.agregarPersonal(Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(dropEditar.SelectedValue), txtContrasena.Text, txtNombre.Text, txtApellido.Text, activo);
        for (int i=0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
            {
                cnn.agregarPermisos(i, Convert.ToInt32(txtCodigo.Text));
            }
        }
    }

    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtApellido.Text = "";
        txtCodigo.Text = "";
        txtContrasena.Text = "";
        txtNombre.Text = "";
        dropEditar.SelectedIndex = 0;
        chkActivo.Checked = false;
    }


    protected void btnEditar_Click(object sender, EventArgs e)
    {
        int activo;
        if (chkActivo.Checked == true)
        {
            activo = 1;
        }
        else
        {
            activo = 0;
        }
        BaseDatos cnn = new BaseDatos();
        lblInfo.Text = cnn.editarPersonal(Convert.ToInt32(txtCodigo.Text), Convert.ToInt32(dropEditar.SelectedValue), txtContrasena.Text, txtNombre.Text, txtApellido.Text, activo);
        Response.Redirect("Personal.aspx");
    }
}