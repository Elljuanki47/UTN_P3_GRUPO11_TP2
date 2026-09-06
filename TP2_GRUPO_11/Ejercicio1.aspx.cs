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
            encabezado.Height = 35;

            encabezado.Cells.Add(new TableCell());
            encabezado.Cells[0].Text = "PRODUCTO";
            encabezado.Cells[0].Width = 170;
            encabezado.Cells[0].HorizontalAlign = HorizontalAlign.Center;

            encabezado.Cells.Add(new TableCell());
            encabezado.Cells[1].Text = "CANTIDAD";
            encabezado.Cells[1].Width = 100;
            encabezado.Cells[1].HorizontalAlign = HorizontalAlign.Center;

            tblProductos.Rows.Add(encabezado);

            TableRow fila1 = new TableRow();

            fila1.Cells.Add(new TableCell());
            fila1.Cells[0].Text = txtProducto1.Text;

            fila1.Cells.Add(new TableCell());
            fila1.Cells[1].Text = txtCantidad1.Text;

            tblProductos.Rows.Add(fila1);

            fila1.Height = 30;
            fila1.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            fila1.Cells[1].HorizontalAlign = HorizontalAlign.Center;

            TableRow fila2 = new TableRow();

            fila2.Cells.Add(new TableCell());
            fila2.Cells[0].Text = txtProducto2.Text;

            fila2.Cells.Add(new TableCell());
            fila2.Cells[1].Text = txtCantidad2.Text;

            tblProductos.Rows.Add(fila2);

            fila2.Height = 30;
            fila2.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            fila2.Cells[1].HorizontalAlign = HorizontalAlign.Center;

            TableRow filaTotal = new TableRow();

            filaTotal.BackColor = System.Drawing.Color.LightCyan;
            filaTotal.Font.Bold = true;

            filaTotal.Cells.Add(new TableCell());
            filaTotal.Cells[0].Text = "Total";

            filaTotal.Cells.Add(new TableCell());
            filaTotal.Cells[1].Text = (int.Parse(txtCantidad1.Text) + int.Parse(txtCantidad2.Text)).ToString();

            tblProductos.Rows.Add(filaTotal);

            filaTotal.Height = 30;
            filaTotal.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            filaTotal.Cells[1].HorizontalAlign = HorizontalAlign.Center;
        }
        protected void btnVaciar_Click(object sender, EventArgs e)
        {
            txtProducto1.Text = "";
            txtCantidad1.Text = "";
            txtProducto2.Text = "";
            txtCantidad2.Text = "";
        }
    }
 }
    