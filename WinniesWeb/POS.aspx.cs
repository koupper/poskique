using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class POS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFamilias_Click(object sender, EventArgs e)
    {

    }

    protected void btnIngredientes_Click(object sender, EventArgs e)
    {

    }

    protected void gridFamilias_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Extraer datos del grid
        GridViewRow row = gridFamilias.SelectedRow;
        txtFamilia.Text = row.Cells[2].Text;
        txtID.Text = row.Cells[1].Text;
        btnActualizar.Visible = true;
        btnNuevo.Visible = false;
    }

    protected void bntActualizar_Click(object sender, EventArgs e)
    {
        //Actualizar familias
        BaseDatos cnn = new BaseDatos();
        lblInfo.Text = cnn.editarFamilias(txtFamilia.Text, Convert.ToInt32(txtID.Text));
        gridFamilias.SelectedIndex = -1;
        btnActualizar.Visible = false;
        btnNuevo.Visible = true;
        txtFamilia.Text = "";
        txtID.Text = "";
        updTankDetail.Update();

    }

    protected void bntNuevo_Click(object sender, EventArgs e)
    {
        //Nueva familia
        BaseDatos cnn = new BaseDatos();
        lblInfo.Text = cnn.agregarFamilia(txtFamilia.Text);
    }

    protected void bntGenerar_Click(object sender, EventArgs e)
    {
        // llenar datagrid de familias
        BaseDatos cnn = new BaseDatos();
        gridFamilias.DataSource = cnn.consultarFamilias();
        gridFamilias.DataBind();
    }

    protected void bntSalir_Click(object sender, EventArgs e)
    {

    }
}