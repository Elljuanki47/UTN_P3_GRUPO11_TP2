using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_11
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("claudio", StringComparison.OrdinalIgnoreCase) && txtClave.Text.Equals("casas", StringComparison.OrdinalIgnoreCase))
            {
                Response.Redirect("Ejercicio4b.aspx?msj=" + txtUsuario.Text);
            }
            else if(txtUsuario.Text==""&&txtClave.Text==""){
                lblIngrese.ForeColor = System.Drawing.Color.Red;
                lblIngrese.Text= "Debe ingresar un usuario y una clave";
            }
            else
            {
                Response.Redirect("Ejercicio4Error.aspx");
            }

        }


    }
}