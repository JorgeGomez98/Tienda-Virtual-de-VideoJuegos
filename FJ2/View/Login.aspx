<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Login.aspx.cs" Inherits="View_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link href="../App_Themes/Images.css" rel="stylesheet" type="text/css" />
    </head>
<body>
    
    <form id="form1" runat="server">
    
    <table class="fondoImagenLogin">
        <tr>
            <td class="espacioTablaslaterales">
                <br />
                
            </td>
            <td class="espacioTablaCentral" style="position: relative">
                <asp:Login ID="LN_principal" runat="server" CssClass="fondoElemento" Height="235px" Width="481px" OnAuthenticate="LN_principal_Authenticate" >
                    <LayoutTemplate>
                        <table style="border-collapse:collapse;">
                            <tr>
                                <td>
                                    <table  style="height:235px;width:481px;">
                                        <tr>
                                            <td  colspan="2">Iniciar sesión</td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre de usuario:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="UserName" runat="server" CssClass="fondoElemento" Height="32px" Width="135px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." ValidationGroup="LN_principal">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td >
                                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="fondoElemento" Height="32px" Width="135px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="La contraseña es obligatoria." ToolTip="La contraseña es obligatoria." ValidationGroup="LN_principal">*</asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:CheckBox ID="RememberMe" runat="server" Text="Recordármelo la próxima vez." />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td  colspan="2" style="color:Red;">
                                                <asp:Label ID="L_Mensaje" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td  colspan="2">
                                                <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Inicio de sesión" ValidationGroup="LN_principal" CssClass="fondoElemento" />
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
    </table>
    
    </form>
    
    </body>
</html>
