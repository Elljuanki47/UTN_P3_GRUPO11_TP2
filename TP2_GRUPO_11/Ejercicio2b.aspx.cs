using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_11
{
    public partial class Ejercicio2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text += " " + Request.QueryString["Nom"];
            lblApellido.Text += " " + Request.QueryString["Ape"];
            lblZona.Text += " " + Request.QueryString["Zona"];
            foreach(string tema in Request.QueryString["Temas"].Split(','))
            {
                lblTemas.Text += "<br />" + tema;
            }
        }
    }

}
