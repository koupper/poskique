using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inventarios : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        // llenar datagrid de inventarios
        BaseDatos cnn = new BaseDatos();
        gridExistencias.DataSource = cnn.consultarInverntaio("0");
        gridExistencias.DataBind();
        updTankDetail.Update();

        // llenar dropdown list de tiendas

        dropTiendas.DataSource = cnn.consultarTiendas();
        dropTiendas.DataTextField = "nombre";
        dropTiendas.DataValueField = "id_tienda";
        dropTiendas.DataBind();
        panelTiendas.Update();


    }

    protected void grid_Select(object sender, EventArgs e)
    {
        try
        {
            GridViewRow row = gridExistencias.SelectedRow;
            string nombre = row.Cells[2].Text;
        //    txtNombre.Text = nombre;
        }
        catch (Exception ex)
        {
          //  txtNombre.Text = ex.ToString();
        }
    }

    protected void bntSalir_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void btnExistencia_Click(object sender, EventArgs e)
    {

    }
}