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
        .auto-style3 {
            width: 16%;
            height: 42%;
        }
        .auto-style4 {
            width: 68%;
            height: 42%;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" ></td>
                <td class="auto-style4">
                    <asp:ImageButton ID="IB_Fj2" runat="server" ImageUrl="~/Imagenes/ImagenesSistema/logo.png" OnClick="IB_Fj2_Click" Width="50%" />
                    </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="espacioTablaslaterales" >&nbsp;</td>
                <td class="espacioTablaCentral">
                    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
                        <LayoutTemplate>
                            <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                                <tr>
                                    <td>
                                        <table cellpadding="0">
                                            <tr>
                                                <td align="center" class="fondoElemento" colspan="2">Iniciar sesión</td>
                                            </tr>
                                            <tr>
                                                <td align="center" class="fondoElemento" colspan="2">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="fondoElemento">
                                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre de usuario:</asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="UserName" runat="server" CssClass="fondoElemento"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="fondoElemento" colspan="2">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="fondoElemento">
                                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="Password" runat="server" CssClass="fondoElemento" TextMode="Password"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="La contraseña es obligatoria." ToolTip="La contraseña es obligatoria." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" class="fondoElemento" colspan="2">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="fondoElemento" colspan="2">
                                                    <asp:CheckBox ID="RememberMe" runat="server" Text="Recordármelo la próxima vez." />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" class="fondoElemento" colspan="2" style="color:Red;">
                                                    <asp:Label ID="L_Mensaje" runat="server"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="fondoElemento" colspan="2">
                                                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" CssClass="fondoElemento" Text="Inicio de sesión" ValidationGroup="Login1" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="fondoElemento" colspan="2">&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td class="fondoElemento" colspan="2">
                                                    <asp:Button ID="B_Registrar" runat="server" CssClass="fondoElemento" OnClick="B_Registrar_Click" Text="Registrar" />
                                                    <asp:Button ID="BT_Vcatalogo" runat="server" CssClass="fondoElemento" OnClick="Button1_Click" Text="Atrás" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
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
