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
        width: 146px;
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
    .auto-style13 {
        text-align: center;
        width: 146px;
    }
    </style>
<link href="../App_Themes/Fuentes.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">
                <asp:FileUpload ID="FU_ImagenPerfil" runat="server" CssClass="fuenteNegra" />
            </td>
            <td class="auto-style11" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" rowspan="6">
                <asp:Image ID="I_Perfil" runat="server" Width="60%" />
                <asp:Label ID="L_Imagen" runat="server"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Label ID="L_Nickname" runat="server" Text="Nickname:" CssClass="fuenteNegra"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TB_Nickname" runat="server" ReadOnly="True" CssClass="fuenteNegra"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="L_Nombre" runat="server" Text="Nombre real:" CssClass="fuenteNegra"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TB_Nombre" runat="server" ReadOnly="True" CssClass="fuenteNegra"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Label ID="L_Correo" runat="server" Text="Correo:" CssClass="fuenteNegra"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TB_Correo" runat="server" ReadOnly="True" CssClass="fuenteNegra"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="3"></td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="B_ImagenPerfil" runat="server" Text="Cargar imagen" CssClass="fuenteNegra"/>
            </td>
            <td class="auto-style13">
                <asp:Button ID="B_Editar" runat="server" OnClick="B_Editar_Click" Text="Editar" CssClass="fuenteNegra" />
            </td>
            <td class="auto-style8" colspan="2">
                <asp:Button ID="B_Guardar" runat="server" Text="Guardar" Visible="False" OnClick="B_Guardar_Click" CssClass="fuenteNegra" />
            </td>
        </tr>
    </table>
</asp:Content>

