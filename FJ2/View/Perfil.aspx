<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Perfil.aspx.cs" Inherits="View_Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            text-align: center;
            width: 50%;
        }
        .auto-style5 {
            width: 50%;
        }
        .auto-style6 {
            text-align: right;
            width: 202px;
        }
        .auto-style7 {
            text-align: center;
            height: 23px;
        }
        .auto-style8 {
            text-align: center;
            width: 25%;
        }
        .auto-style9 {
            text-align: right;
            height: 38px;
        }
        .auto-style11 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">
                <asp:FileUpload ID="FU_ImagenPerfil" runat="server" />
            </td>
            <td class="auto-style6">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" rowspan="6">
                <asp:Image ID="I_Perfil" runat="server" Width="60%" />
            </td>
            <td class="auto-style6">
                <asp:Label ID="L_Nickname" runat="server" Text="Nickname:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TB_Nickname" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="L_Nombre" runat="server" Text="Nombre real:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TB_Nombre" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="L_Correo" runat="server" Text="Correo:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TB_Correo" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="2"></td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="3">
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="B_ImagenPerfil" runat="server" Text="Cargar imagen" OnClick="B_ImagenPerfil_Click" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="B_Editar" runat="server" OnClick="B_Editar_Click" Text="Editar" />
            </td>
            <td class="auto-style8">
                <asp:Button ID="B_Guardar" runat="server" Text="Guardar" Visible="False" />
            </td>
        </tr>
    </table>
</asp:Content>

