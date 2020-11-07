<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/VideoJuego.aspx.cs" Inherits="View_VideoJuego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            text-align: center;
            width: 50%;
        }
        .auto-style5 {
            width: 50%;
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
        .auto-style14 {
            text-align: right;
            width: 146px;
            font-family: Prototype;
            font-size: 20px;
        }
        .auto-style20 {
            height: 10%;
        }
        .auto-style21 {
            text-align: right;
            font-family: Prototype;
            font-size: 20px;
        }
        .auto-style22 {
            text-align: left;
            font-family: Prototype;
            font-size: 20px;
        }
        .auto-style23 {
            height: 20px;
        }
    </style>
<link href="../App_Themes/Fuentes.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">
                <asp:Image ID="I_Carrito" runat="server" ImageUrl="~/Imagenes/IconosSistema/ircarrito.png" Width="5%" />
                <asp:Label ID="L_Carrito" runat="server" CssClass="fuenteNegra" Text="0" ForeColor="Red"></asp:Label>
            </td>
            <td class="auto-style11" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" rowspan="11">
                <asp:Image ID="I_Juego" runat="server" Width="60%" />
            </td>
            <td class="auto-style22" colspan="2">
                <asp:Label ID="L_Nombre" runat="server" CssClass="fuenteNegra"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">
                <asp:Label ID="Label2" runat="server" Text="Descripción:"></asp:Label>
            </td>
            <td class="auto-style22">
                <asp:Label ID="L_Descripcion" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style22" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">
                <asp:Label ID="Label3" runat="server" Text="Categoría:"></asp:Label>
            </td>
            <td class="auto-style22">
                <asp:Label ID="L_Categoria" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style21" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">
                <asp:Label ID="Label4" runat="server" Text="Cantidad:"></asp:Label>
            </td>
            <td class="auto-style22">
                <asp:Label ID="L_Cantidad" runat="server" BorderStyle="None"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style21" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">
                Precio:</td>
            <td class="auto-style22">
                <asp:Label ID="L_Precio" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Button ID="B_Deseados" runat="server" CssClass="fondoElemento" Text="Deseados" />
            </td>
            <td class="text-right">
                <asp:Button ID="B_Comprar" runat="server" CssClass="fondoElemento" OnClick="B_Comprar_Click" Text="Comprar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style23" colspan="3"></td>
        </tr>
        </table>
</asp:Content>


