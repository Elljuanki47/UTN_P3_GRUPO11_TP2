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
            lnkRojo.ForeColor = System.Drawing.Color.Red;
            lnkAzul.ForeColor = System.Drawing.Color.Black;
            lnkVerde.ForeColor = System.Drawing.Color.Black;
        }
        protected void lnkAzul_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Blue;
            lnkRojo.ForeColor = System.Drawing.Color.Black;
            lnkAzul.ForeColor = System.Drawing.Color.Blue;
            lnkVerde.ForeColor = System.Drawing.Color.Black;
        }
        protected void lnkVerde_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Green;
            lnkRojo.ForeColor = System.Drawing.Color.Black;
            lnkAzul.ForeColor = System.Drawing.Color.Black;
            lnkVerde.ForeColor = System.Drawing.Color.Green;
        }
    }
}
