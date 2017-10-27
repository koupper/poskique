using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bntAceptar_Click(object sender, EventArgs e)
    {
        try
        {
            DataSetTableAdapters.QueriesTableAdapter obj = new DataSetTableAdapters.QueriesTableAdapter();
            String NombreUsuario = obj.Login(Convert.ToInt32(txtUser.Text), txtPass.Text).ToString();
            if (!NombreUsuario.Equals(""))
            {
                Response.Redirect("Reportes.aspx");
            }
        }
        catch
        {
            lblBien.Text = "No Hubo Suerte";
        }
    }
}