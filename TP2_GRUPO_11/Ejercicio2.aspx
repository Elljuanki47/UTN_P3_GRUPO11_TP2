<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP2_GRUPO_11.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:&nbsp;
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Apellido:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Ciudad:"></asp:Label>

            <asp:DropDownList ID="ddlCiudad" runat="server" style="margin-left: 17px;">
                <asp:ListItem Value="zona norte" Selected="True"> Gral. Pacheco </asp:ListItem>
                <asp:ListItem Value="zona oeste"> San Miguel </asp:ListItem>
                <asp:ListItem Value="zona sur"> Boedo </asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Temas:"></asp:Label>
        </p>
        <asp:CheckBox ID="chkCiencias" runat="server" style="margin-left: 60px;" Text="Ciencias" />
        <p>
            <asp:CheckBox ID="chkLiteratura" runat="server" style="margin-left: 60px;" Text="Literatura"/>
        </p>
        <asp:CheckBox ID="chkHistoria" runat="server" style="margin-left: 60px;" Text="Historia"/>

        <p>
            <asp:Button ID="btnResumen" runat="server" Text="Ver Resumen" 
                OnClick="btnResumen_Click"/>
        </p>
    </form>
</body>
</html>
