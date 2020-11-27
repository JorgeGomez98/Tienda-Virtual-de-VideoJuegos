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
        .auto-style10 {
            text-align: right;
            width: 181px;
        }
        .auto-style11 {
            width: 12%;
        }
        .auto-style12 {
            width: 5%;
        }
    </style>
    <link href="../App_Themes/Fuentes.css" rel="stylesheet" type="text/css" />

    <link href="../Content/bootstrap.min.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table class="auto-style1">
        <tr>
            <td>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style10">
                            &nbsp;</td>
                        <td class="text-right">
                            <asp:Label ID="L_Filtro" runat="server" Text="Categoría: " CssClass="fuenteNegra"></asp:Label>
                        </td>
                        <td class="auto-style12">
                            &nbsp;</td>
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
                        <td class="auto-style10">
                            &nbsp;</td>
                        <td class="text-right">
                            &nbsp;</td>
                        <td class="auto-style12">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style10">
                            &nbsp;</td>
                        <td class="text-right">
                            <asp:Label ID="Label1" runat="server" CssClass="fuenteNegra" Text="Plataforma: "></asp:Label>
                        </td>
                        <td class="auto-style12">
                            &nbsp;</td>
                        <td>
                            <asp:DropDownList ID="DDL_FiltroPlataforma" runat="server" DataSourceID="ODS_Plataforma" DataTextField="PlataformaJuego" DataValueField="Id_plataforma" CssClass="fondoElemento" AutoPostBack="True">
                            </asp:DropDownList>
                            <asp:ObjectDataSource ID="ODS_Plataforma" runat="server" SelectMethod="obtenerPlataforma" TypeName="DAOPlataforma"></asp:ObjectDataSource>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style10">
                            &nbsp;</td>
                        <td class="text-right">
                            &nbsp;</td>
                        <td class="auto-style12">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style11">
                            &nbsp;</td>
                        <td colspan="3" class="newFondo">
                <asp:DataList ID="DL_Catalogo" runat="server" Width="100%" CellPadding="4" ForeColor="Black" DataSourceID="ODS_Catalogo" DataKeyField="Id_videojuego" OnItemCommand="DL_Catalogo_ItemCommand" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" GridLines="Horizontal"  >
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style4" rowspan="5">
                                    <asp:Image ID="I_Juego" runat="server" Width="70%" ImageUrl='<%# Eval("Imagen") %>'/>
                                </td>
                                <td class="auto-style5" colspan="3">
                                    <asp:Label ID="L_Nombre" runat="server" Text='<%# Eval("Nom_juego") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6" colspan="2">
                                    <asp:Label ID="L_GeneroVideojuego" runat="server" CssClass="fuenteGris" Text="Género:"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="L_Genero" runat="server" CssClass="fuenteGris" Text='<%# Eval("Categoria") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style6" colspan="2">
                                    <asp:Label ID="L_PrecioVideojuego" runat="server" CssClass="fuenteGris" Text="Precio:"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="L_Precio" runat="server" CssClass="fuenteGris" Text='<%# Eval("Precio") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                
                                <td class="auto-style6" colspan="2">
                                    <asp:Label ID="L_PlataformaVideojuego" runat="server" CssClass="fuenteGris" Text="Plataforma:"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="L_Plataforma" runat="server" CssClass="fuenteGris" Text='<%# Eval("Plataforma") %>'></asp:Label>
                                </td>
                                
                            </tr>
                            <tr>
                                <td class="auto-style6">
                                    &nbsp;</td>
                                <td class="auto-style6">
                                    &nbsp;</td>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Info" runat="server" CommandArgument='<%# Eval("Id_videojuego") %>' CommandName="Información" CssClass="fondoElemento" Text="Información" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <asp:ObjectDataSource ID="ODS_Catalogo" runat="server" SelectMethod="obtenerCatalogo" TypeName="DAOVideojuego">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DDL_Filtro" DefaultValue="0" Name="id_categoria" PropertyName="SelectedValue" Type="Int32" />
                        <asp:ControlParameter ControlID="DDL_FiltroPlataforma" DefaultValue="0" Name="id_plataforma" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ODS_Categoria" runat="server" SelectMethod="obtenerCategorias" TypeName="DAOCategoria"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
        
</asp:Content>

