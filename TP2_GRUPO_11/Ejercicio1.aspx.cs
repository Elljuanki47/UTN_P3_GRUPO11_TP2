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
            tblProductos.Rows.Clear();

            TableRow encabezado = new TableRow();

            encabezado.Cells.Add(new TableCell());
            encabezado.Cells[0].Text = "Producto";

            encabezado.Cells.Add(new TableCell());
            encabezado.Cells[1].Text = "Cantidad";

            tblProductos.Rows.Add(encabezado);

            TableRow fila1 = new TableRow();

            fila1.Cells.Add(new TableCell());
            fila1.Cells[0].Text = txtProducto1.Text;

            fila1.Cells.Add(new TableCell());
            fila1.Cells[1].Text = TextBox1.Text;

            tblProductos.Rows.Add(fila1);

            TableRow fila2 = new TableRow();

            fila2.Cells.Add(new TableCell());
            fila2.Cells[0].Text = txtProducto2.Text;

            fila2.Cells.Add(new TableCell());
            fila2.Cells[1].Text = txtCantidad2.Text;

            tblProductos.Rows.Add(fila2);

            TableRow filaTotal = new TableRow();

            filaTotal.Cells.Add(new TableCell());
            filaTotal.Cells[0].Text = "Total";

            filaTotal.Cells.Add(new TableCell());
            filaTotal.Cells[1].Text = (int.Parse(TextBox1.Text) + int.Parse(txtCantidad2.Text)).ToString();

            tblProductos.Rows.Add(filaTotal);
        }
    }
    }
    