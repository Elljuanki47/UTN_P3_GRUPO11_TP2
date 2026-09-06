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
            int subtotalAccesorios = 0;

            foreach(ListItem accesorio in cblAccesorios.Items)
            {
                if (accesorio.Selected)
                {
                    subtotalAccesorios += Convert.ToInt32(accesorio.Value);
                }
            }

            lblSubtotalAccesorios.Text = "Subtotal Accesorios: $" + subtotalAccesorios;
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
    }
}﻿
