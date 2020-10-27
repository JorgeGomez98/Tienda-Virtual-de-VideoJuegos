<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Catalogo.aspx.cs" Inherits="View_Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style4 {
            width: 210px;
        }
        .auto-style5 {
            font-size: 20px;
            font-family: Prototype;
            color: black;
            text-align: center;
        }
        .auto-style6 {
            text-align: right;
        }
    </style>
    <link href="../App_Themes/Fuentes.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:DataList ID="DataList1" runat="server" Width="80%" CellPadding="4" ForeColor="#333333">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style4" rowspan="5">
                                    <asp:Image ID="Image1" runat="server" Width="70%" />
                                </td>
                                <td class="auto-style5" colspan="2">
                                    <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">
                                    <asp:Label ID="L_GeneroVideojuego" runat="server" CssClass="fuenteGris" Text="Género:"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="L_Genero" runat="server" CssClass="fuenteGris"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">
                                    <asp:Label ID="L_PrecioVideojuego" runat="server" CssClass="fuenteGris" Text="Precio:"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="L_Precio" runat="server" CssClass="fuenteGris"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">
                                    <asp:Label ID="L_CantidadVideojuego" runat="server" CssClass="fuenteGris" Text="Cantidad:"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="L_Cantidad" runat="server" CssClass="fuenteGris"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Deseados" runat="server" CssClass="fondoElemento" Text="Deseados" OnClick="B_Deseados_Click" />
                                </td>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Comprar" runat="server" CssClass="fondoElemento" Text="Comprar" OnClick="B_Comprar_Click" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>

