<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2b.aspx.cs" Inherits="TP2_GRUPO_11.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1>Resumen</h1>
        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
        <br /><br />
        <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
        <br /><br />
        <asp:Label ID="lblZona" runat="server" Text="Zona:"></asp:Label>
        <br /><br /> <br /><br />
        <asp:Label ID="lblTemas" runat="server" Text="Los Temas Elegidos Son:"></asp:Label>
        <br /><br />
        </div>
    </form>
</body>
</html>
