<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_GRUPO_11.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Ingrese nombre del producto:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProducto1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Cantidad"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 24px; margin-bottom: 0px" Width="201px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Ingrese  nombre del producto:"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtProducto2" runat="server" style="margin-left: 8px"></asp:TextBox>
        &nbsp;<asp:Label ID="Label3" runat="server" Font-Bold="False" Text="Cantidad"></asp:Label>
            <asp:TextBox ID="txtCantidad2" runat="server" OnTextChanged="TextBox2_TextChanged" style="margin-left: 29px" Width="199px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Tabla" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
