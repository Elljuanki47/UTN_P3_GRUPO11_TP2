using System;
using System.Web.UI;

namespace TP2_GRUPO_11
{
    public partial class Ejercicio4Error : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReintentar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio4.aspx");
        }
    }
}