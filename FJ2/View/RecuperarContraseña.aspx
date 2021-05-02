<%@ Page Title="Recuperar Contraseña" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/RecuperarContraseña.aspx.cs" Inherits="View_RecuperarContraseña" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css">
        .auto-style1{
            width: 100%;
        }
        .auto-style9 {
            text-align: center;
            width: 25%;
            background: #D52228;
        }
        .auto-style10 {
            width: 25%;
        }

        .auto-style11 {
            width: 25%;
            text-align: right;
            background: #D52228;
        }

        .auto-style12 {
            width: 25%;
            text-align: left;
            background: #D52228;
        }

    </style>
    <div>
            <table cellpadding="0" cellspacing="0" class="auto-style1">
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style9" colspan="2">
                &nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style9" colspan="2">
                <asp:Label ID="L_TITULO" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Text="RECUPERAR CONTRASEÑA"></asp:Label>
            </td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                <asp:Label ID="L_ContraNueva" runat="server" Font-Bold="True" ForeColor="White" Text="Nueva contraseña:"></asp:Label>
                <br />
            </td>
            <td class="auto-style12">
                <asp:TextBox ID="TB_NuevaContra" runat="server" Width="60%" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_NuevaContra" runat="server" ControlToValidate="TB_NuevaContra" ErrorMessage="*" ForeColor="White" ValidationGroup="BT_Cambiar"></asp:RequiredFieldValidator>
                <br />
&nbsp;&nbsp;&nbsp;
                </td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                <asp:Label ID="L_RepetirContra" runat="server" Font-Bold="True" ForeColor="White" Text="Repita su contraseña:"></asp:Label>
                <br />
            </td>
            <td class="auto-style12">
                <asp:TextBox ID="TB_RepetirContra" runat="server" Width="60%" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFV_RepetirContra" runat="server" ControlToValidate="TB_RepetirContra" ErrorMessage="*" ForeColor="White" ValidationGroup="BT_Cambiar"></asp:RequiredFieldValidator>
                <br />
&nbsp;&nbsp;&nbsp;
                </td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                <asp:Label ID="L_ContraNoCoinciden" runat="server" Font-Bold="False" Font-Size="Large" ForeColor="White"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:Button ID="BT_CambiarContra" runat="server" BackColor="#D52228" BorderColor="White" BorderWidth="3px" Font-Bold="True" Font-Size="Medium" ForeColor="White" Text="CAMBIAR CONTRASEÑA" Width="90%" OnClick="BT_CambiarContra_Click" ValidationGroup="BT_Cambiar" />
            </td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
    </table>
        </div>
</asp:Content>

