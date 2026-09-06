<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP2_GRUPO_11.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:LinkButton ID="lnkRojo" runat="server" Font-Bold="True" ForeColor="Yellow" OnClick="lnkRojo_Click">ROJO</asp:LinkButton>
        <br/><br/>
        <asp:LinkButton ID="lnkAzul" runat="server" Font-Bold="True" ForeColor="Yellow" OnClick="lnkAzul_Click">AZUL</asp:LinkButton>
        <br/><br/>
        <asp:LinkButton ID="lnkVerde" runat="server" Font-Bold="True" ForeColor="Yellow" OnClick="lnkVerde_Click">VERDE</asp:LinkButton>
        <br/><br/>
        <asp:Label ID="lblTexto" runat="server" Text="TEXTO COLOREADO" Font-Bold="True"></asp:Label>
        <br/><br/>
    </form>
</body>
</html>
