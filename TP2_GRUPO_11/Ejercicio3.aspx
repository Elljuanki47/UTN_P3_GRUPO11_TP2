<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP2_GRUPO_11.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:LinkButton ID="lnkRojo" runat="server" OnClick="lnkRojo_Click">Rojo</asp:LinkButton>
        <br /><br />
        <asp:LinkButton ID="lnkAzul" runat="server" OnClick="lnkAzul_Click">Azul</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="lnkVerde" runat="server" OnClick="lnkAzul_Click">Verde</asp:LinkButton>
    </form>
</body>
</html>
