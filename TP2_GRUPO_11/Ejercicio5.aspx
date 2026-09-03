<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP2_GRUPO_11.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Armado de PC</h1>

                <p>
                    <asp:Label ID="Label1" runat="server"
                        Text="Seleccione cantidad de memoria:">
                    </asp:Label>
                
                    <br />
                    <br />
                    <br />
                
                    <asp:DropDownList ID="ddlMemoria" runat="server"
                        style="margin-left: 60px;">
                        <asp:ListItem Value="200">2 GB</asp:ListItem>
                    </asp:DropDownList>
                </p>

        </div>
    </form>
</body>
</html>
