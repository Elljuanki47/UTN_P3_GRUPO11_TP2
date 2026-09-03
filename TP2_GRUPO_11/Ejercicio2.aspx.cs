using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_11
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResumen_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2b.aspx?Nom=" + txtNombre.Text + "&Ape=" + TextBox1.Text + "&Zona=" + ddlCiudad.SelectedValue);
        }
    }
}