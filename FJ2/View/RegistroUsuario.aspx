<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/RegistroUsuario.aspx.cs" Inherits="View_RegistroUsuario" %>

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
        .auto-style2 {
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            font-family: Prototype;
            font-size: 34px;
            color: #FFFFFF;
            text-align: right;
        }
        .auto-style5 {
            height: 23px;
            font-family: Prototype;
            font-size: 34px;
            color: #FFFFFF;
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" colspan="4"></td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style4">NickName: </td>
            <td class="auto-style2">
                <asp:TextBox ID="TB_Nick" runat="server" CssClass="fondoElemento"></asp:TextBox>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="4"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">Correo:</td>
            <td class="auto-style2">
                <asp:TextBox ID="TB_Correo" runat="server" CssClass="fondoElemento"></asp:TextBox>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">Contraseña: </td>
            <td class="auto-style2">
                <asp:TextBox ID="TB_Contraseña" runat="server" CssClass="fondoElemento" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td class="auto-style5" colspan="3">Confirmar Contraseña:<asp:TextBox ID="TB_Ccontraseña" runat="server" CssClass="fondoElemento" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="2">
                <asp:Button ID="BT_Registro" runat="server" CssClass="fondoElemento" OnClick="Button1_Click" Text="Registrar" />
                
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
    </table>
        <asp:Label ID="LB_mensaje" Text="" CssClass="fondoElemento" runat="server" />
    </form>
</body>
</html>
