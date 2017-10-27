using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reportes : System.Web.UI.Page
{
    public void Page_Load(object sender, EventArgs e)
    {

    }

    protected void bntSalir_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
    protected void list1SelectedChanged(object sender, EventArgs e)
    {

    }
    protected void listSucurChanged(object sender, EventArgs e)
    {

    }
    public void bntGenerar_Click(object sender, EventArgs e)
    {
        string fecha1 = txtFecha1.Text;
        string fecha2 = txtFecha2.Text;
        int indexrep = list1.SelectedIndex;
        int indexsuc = Convert.ToInt32(dropTiendas.SelectedValue);
        BaseDatos cnn = new BaseDatos();
        gridReportes.DataSource = cnn.generarReporte(indexrep, indexsuc, fecha1, fecha2);
        gridReportes.DataBind();
        updTankDetail.Update();
    }


    public void CargaDatos(String s, SqlConnection cnn, int tabla)
    {
        //ClientScript.RegisterStartupScript(GetType(), "id", "reporte()", true);
        string parametros = "[{ y: 6 }," +
                            "{ y: 10 }," +
                            "{ y: 14 }," +
                            "{ y: 12 }," +
                            "{ y: 19 }," +
                            "{ y: 14 }," +
                            "{ y: 26 }," +
                            "{ y: 10 }," +
                            "{ y: 22 }]";

        ScriptManager.RegisterStartupScript(this, GetType(), "reporte", "reporte("+parametros+");", true);

    }

    protected void Chart1_Load(object sender, EventArgs e)
    {

    }
}

