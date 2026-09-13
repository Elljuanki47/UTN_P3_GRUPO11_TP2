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
            if (!IsPostBack)
            {
                lblNombre.Text = "Nombre: " + Request.QueryString["Nom"];
                lblApellido.Text = "Apellido: " + Request.QueryString["Ape"];
                lblZona.Text = "Zona: " + Request.QueryString["Zona"];

                lblTemas.Text = "Los temas elegidos son:<br />";

                foreach (string tema in Request.QueryString["Temas"].Split(','))
                {
                    lblTemas.Text += tema + "<br />";

                }
            }
        }

        protected void btnResumen_Click(object sender, EventArgs e)
        {

        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2.aspx");
        }
    }

}
