<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Biblioteca.aspx.cs" Inherits="View_Biblioteca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:DataList ID="DataList1" runat="server" Width="80%" CellPadding="4" ForeColor="#333333" DataSourceID="ODS_Catalogo" DataKeyField="Id_videojuego">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style4" rowspan="5">
                                    <asp:Image ID="Image1" runat="server" Width="70%" ImageUrl='<%# Eval("Imagen") %>'/>
                                </td>
                                <td class="auto-style5" colspan="3">
                                    <asp:Label ID="L_Nombre" runat="server" Text='<%# Eval("Nom_juego") %>' CssClass="fuenteNegra"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-left">
                                    <asp:Label ID="L_GeneroVideojuego" runat="server" CssClass="fuenteGris" Text="Género:"></asp:Label>
                                </td>
                                <td colspan="2">
                                    <asp:Label ID="L_Genero" runat="server" CssClass="fuenteGris" Text='<%# Eval("Categoria") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-left">
                                    <asp:Label ID="L_CantidadVideojuego" runat="server" CssClass="fuenteGris" Text="Cantidad:"></asp:Label>
                                </td>
                                <td colspan="2">
                                    <asp:Label ID="L_Cantidad" runat="server" CssClass="fuenteGris" Text='<%# Eval("Cantidad") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-left" colspan="3">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Favoritos" runat="server" CssClass="fondoElemento" Text="Favoritos" OnClick="B_Deseados_Click" />
                                </td>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Vender" runat="server" CssClass="fondoElemento" Text="Vender" OnClick="B_Comprar_Click" />
                                </td>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Cambiar" runat="server" CssClass="fondoElemento" Text="Cambiar" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
                <asp:ObjectDataSource ID="ODS_Catalogo" runat="server" SelectMethod="obtenerCatalogo" TypeName="DAOVideojuego">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DDL_Filtro" DefaultValue="0" Name="id_categoria" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

