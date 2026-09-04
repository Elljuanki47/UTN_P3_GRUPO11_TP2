using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_GRUPO_11
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int validacionCant1, validacionCant2;

            if (txtProducto1.Text == "" || txtProducto2.Text == "" || int.Parse(txtCantidad1.Text)<0 ||
                int.Parse(txtCantidad2.Text) < 0 || !int.TryParse(txtCantidad1.Text, out validacionCant1) || !int.TryParse(txtCantidad2.Text, out validacionCant2))
            {
                lblMensaje.Text = "Por favor, ingrese los 2 productos y sus cantidades positivas antes de generar la tabla.";
                return;
            }


            tblProductos.Rows.Clear();

            TableRow encabezado = new TableRow();

            encabezado.BackColor = System.Drawing.Color.LightGray;
            encabezado.Font.Bold = true;

            encabezado.Cells.Add(new TableCell());
            encabezado.Cells[0].Text = "Producto";

            encabezado.Cells.Add(new TableCell());
            encabezado.Cells[1].Text = "Cantidad";

            tblProductos.Rows.Add(encabezado);

            TableRow fila1 = new TableRow();

            fila1.Cells.Add(new TableCell());
            fila1.Cells[0].Text = txtProducto1.Text;

            fila1.Cells.Add(new TableCell());
            fila1.Cells[1].Text = txtCantidad1.Text;

            tblProductos.Rows.Add(fila1);

            TableRow fila2 = new TableRow();

            fila2.Cells.Add(new TableCell());
            fila2.Cells[0].Text = txtProducto2.Text;

            fila2.Cells.Add(new TableCell());
            fila2.Cells[1].Text = txtCantidad2.Text;

            tblProductos.Rows.Add(fila2);

            TableRow filaTotal = new TableRow();

            filaTotal.BackColor = System.Drawing.Color.LightCyan;
            filaTotal.Font.Bold = true;

            filaTotal.Cells.Add(new TableCell());
            filaTotal.Cells[0].Text = "Total";

            filaTotal.Cells.Add(new TableCell());
            filaTotal.Cells[1].Text = (int.Parse(txtCantidad1.Text) + int.Parse(txtCantidad2.Text)).ToString();

            tblProductos.Rows.Add(filaTotal);
        }
    }
    }
    