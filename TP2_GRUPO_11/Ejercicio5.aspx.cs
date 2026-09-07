using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_11
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcularAccesorios_Click(object sender, EventArgs e)
        {
            decimal subtotalAccesorios = 0;

            foreach (ListItem accesorio in cblAccesorios.Items)
            {
                if (accesorio.Selected)
                {
                    subtotalAccesorios += Convert.ToDecimal(accesorio.Value, System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            lblSubtotalAccesorios.Text = "Subtotal Accesorios: " + subtotalAccesorios.ToString("N2") + " $";
        }

        protected void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            decimal precioMemoria = Convert.ToDecimal(ddlMemoria.SelectedValue);
            decimal precioAccesorios = 0;

            foreach (ListItem accesorio in cblAccesorios.Items)
            {
                if (accesorio.Selected)
                {
                    precioAccesorios += Convert.ToDecimal(accesorio.Value, System.Globalization.CultureInfo.InvariantCulture);
                }
            }

            decimal precioFinal = precioMemoria + precioAccesorios;

            lblPrecioFinal.Text = "El Precio final es de " + precioFinal.ToString("N2") + " $";
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            ddlMemoria.SelectedIndex = 0;
            cblAccesorios.ClearSelection();
            lblSubtotalAccesorios.Text = "";
            lblPrecioFinal.Text = "";
        }
    }
}