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
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="L_Filtro" runat="server" Text="Filtro:" CssClass="fuenteNegra"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_Filtro" runat="server" DataSourceID="ODS_Categoria" DataTextField="Categoria" DataValueField="Id_categoria" CssClass="fondoElemento" AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:ImageButton ID="IB_IrCarrito" runat="server" ImageUrl="~/Imagenes/IconosSistema/CarritoGeneral.png" OnClick="IB_IrCarrito_Click" Width="10%" />
                            <asp:Label ID="L_Carrito" runat="server" CssClass="fuenteGris" ForeColor="Red" Text="0"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                <asp:DataList ID="DL_Catalogo" runat="server" Width="80%" CellPadding="4" ForeColor="#333333" DataSourceID="ODS_Catalogo" DataKeyField="Id_videojuego" OnItemCommand="DL_Catalogo_ItemCommand" >
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style4" rowspan="6">
                                    <asp:Image ID="I_Juego" runat="server" Width="70%" ImageUrl='<%# Eval("Imagen") %>'/>
                                </td>
                                <td class="auto-style5" colspan="4">
                                    <asp:Label ID="L_Nombre" runat="server" Text='<%# Eval("Nom_juego") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6" colspan="2">
                                    <asp:Label ID="L_GeneroVideojuego" runat="server" CssClass="fuenteGris" Text="Género:"></asp:Label>
                                </td>
                                <td colspan="2">
                                    <asp:Label ID="L_Genero" runat="server" CssClass="fuenteGris" Text='<%# Eval("Categoria") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6" colspan="2">
                                    <asp:Label ID="L_PrecioVideojuego" runat="server" CssClass="fuenteGris" Text="Precio:"></asp:Label>
                                </td>
                                <td colspan="2">
                                    <asp:Label ID="L_Precio" runat="server" CssClass="fuenteGris" Text='<%# Eval("Precio") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6" colspan="2">
                                    <asp:Label ID="L_CantidadVideojuego" runat="server" CssClass="fuenteGris" Text="Cantidad:"></asp:Label>
                                </td>
                                <td colspan="2">
                                    <asp:Label ID="L_Cantidad" runat="server" CssClass="fuenteGris" Text='<%# Eval("Cantidad") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6" colspan="2">
                                    <asp:Label ID="L_DescripcionVideojuego" runat="server" CssClass="fuenteGris" Text="Descripción:" Visible="False"></asp:Label>
                                </td>
                                <td colspan="2">
                                    <asp:Label ID="L_Descripcion" runat="server" CssClass="fuenteGris" Text='<%# Eval("Descripcion") %>' Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Deseados" runat="server" CssClass="fondoElemento" Text="Deseados" OnClick="B_Deseados_Click" />
                                </td>
                                <td class="auto-style6">&nbsp;</td>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Info" runat="server" CommandArgument='<%# Eval("Id_videojuego") %>' CssClass="fondoElemento" Text="Información" CommandName="Información" />
                                </td>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Comprar" runat="server" CssClass="fondoElemento" Text="Comprar" CommandArgument='<%# Eval("Id_videojuego") %>'/>
                                   <!-- <asp:ImageButton ID="IB_Comprar" runat="server" CommandArgument='<% Eval("Id_videojuego") %>' ImageUrl="~/Imagenes/IconosSistema/icono-anadir-al-carrito.jpg" Width="10%" /> -->
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <asp:ObjectDataSource ID="ODS_Catalogo" runat="server" SelectMethod="obtenerCatalogo" TypeName="DAOVideojuego">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DDL_Filtro" DefaultValue="0" Name="id_categoria" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ODS_Categoria" runat="server" SelectMethod="obtenerCategorias" TypeName="DAOCategoria"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

