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
        .auto-style5 {
            height: 23px;
            font-family: Prototype;
            font-size: 34px;
            color: #FFFFFF;
            text-align: center;
        }
        .auto-style6 {
            text-align: center;
        }
        .auto-style7 {
            height: 23px;
            font-family: Prototype;
            font-size: 34px;
            color: #FFFFFF;
            text-align: right;
        }
        .auto-style8 {
            height: 23px;
            font-family: Prototype;
            font-size: 34px;
            color: #FFFFFF;
            text-align: left;
        }
        .auto-style9 {
            height: 23px;
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style9" colspan="3">
                <asp:ImageButton ID="IB_Fj2" runat="server" ImageUrl="~/Imagenes/ImagenesSistema/logo.png" OnClick="IB_Fj2_Click" Width="35%" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style7">NickName: </td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_Nick" runat="server" CssClass="fondoElemento"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="3"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style7">Correo:</td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_Correo" runat="server" CssClass="fondoElemento" TextMode="Email"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style7">Contraseña: </td>
            <td class="auto-style8">
                <asp:TextBox ID="TB_Contraseña" runat="server" CssClass="fondoElemento" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td></td>
            <td class="auto-style7">Confirmar Contraseña:</td>
            <td class="auto-style8"><asp:TextBox ID="TB_Ccontraseña" runat="server" CssClass="fondoElemento" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="2">
                <asp:Button ID="BT_Registro" runat="server" CssClass="fondoElemento" OnClick="Button1_Click" Text="Registrar" />
                
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5" colspan="2">
                ¿Ya estás registrado?:
                <asp:Button ID="BT_inicioSesion" runat="server" CssClass="fondoElemento" OnClick="BT_inicioSesion_Click" Text="Inicia sesion" />
                
                <asp:Button ID="BT_Vcatalogo" runat="server" CssClass="fondoElemento" OnClick="BT_Vcatalogo_Click" Text="Atrás" />
                
            </td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
    </table>
        <div class="auto-style6">
        <asp:Label ID="LB_mensaje" Text="" CssClass="fondoElemento" runat="server" />
        </div>
    </form>
</body>
</html>
