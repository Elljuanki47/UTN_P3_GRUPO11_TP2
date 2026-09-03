using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_11
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    
        
        protected void lnkRojo_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Red;
        }
        protected void lnkAzul_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Blue;
        }
        protected void lnkVerde_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Green;
        }
    }
}
