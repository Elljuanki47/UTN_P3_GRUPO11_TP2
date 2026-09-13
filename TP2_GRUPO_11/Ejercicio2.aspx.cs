using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            bool tieneTema = false;
            foreach (ListItem item in cblTemas.Items)
            {
                if (item.Selected) tieneTema = true;
            }

            if (txtNombre.Text.Trim() == "" || TextBox1.Text.Trim() == "" || !tieneTema)
            {
                lblError.Text = "Por favor, complete nombre, apellido y seleccione al menos un tema.";
                return;
            }

            lblError.Text = ""; 

            List<string> temas = new List<string>();
            foreach (ListItem item in cblTemas.Items)
            {
                if (item.Selected)
                {
                    temas.Add(item.Value);
                }
            }
            string temasParam = string.Join(",", temas);
            Response.Redirect("Ejercicio2b.aspx?Nom=" + txtNombre.Text + "&Ape=" + TextBox1.Text + "&Zona=" + ddlCiudad.SelectedValue + "&Temas=" + Server.UrlEncode(temasParam));

        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
        
            txtNombre.Text = "";
            TextBox1.Text = "";

            lblError.Text = "";

            cblTemas.ClearSelection();

            ddlCiudad.SelectedIndex = 0;
        }
}
}
