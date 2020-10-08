<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Login.aspx.cs" Inherits="View_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../App_Themes/Images.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="espacioTablaslaterales" >&nbsp;</td>
                <td class="espacioTablaCentral">
                    &nbsp;</td>
                <td class="espacioTablaslaterales">&nbsp;</td>
            </tr>
            <tr>
                <td class="espacioTablaslaterales" >&nbsp;</td>
                <td class="espacioTablaCentral">
                    <asp:Login ID="LN_principal" runat="server" CssClass="fondoElemento">
                    </asp:Login>
                </td>
                <td class="espacioTablaslaterales">&nbsp;</td>
            </tr>
            <tr>
                <td class="espacioTablaslaterales" style="font-family: 'Aldo the Apache'; color: #FFFFFF">&nbsp;</td>
                <td class="espacioTablaCentral">
                    &nbsp;</td>
                <td class="espacioTablaslaterales">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
