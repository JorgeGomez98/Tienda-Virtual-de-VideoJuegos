<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Biblioteca.aspx.cs" Inherits="View_Biblioteca" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 10%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="auto-style10" rowspan="4">&nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td rowspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right">
                            <asp:Label ID="L_Filtro" runat="server" Text="Filtro:" CssClass="fuenteNegra"></asp:Label>
                        </td>
            <td>
                            <asp:DropDownList ID="DDL_Filtro" runat="server" DataSourceID="ODS_Categoria" DataTextField="Categoria" DataValueField="Id_categoria" CssClass="fondoElemento" AutoPostBack="True">
                            </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ObjectDataSource ID="ODS_Catalogo" runat="server" SelectMethod="obtenerCatalogo" TypeName="DAOVideojuego">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DDL_Filtro" DefaultValue="0" Name="id_categoria" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ODS_Categoria" runat="server" SelectMethod="obtenerCategorias" TypeName="DAOCategoria"></asp:ObjectDataSource>
                <asp:DataList ID="DataList1" runat="server" Width="75%" CellPadding="4" ForeColor="Black" DataSourceID="ODS_Biblioteca" DataKeyField="Id_videojuego" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" GridLines="Horizontal">
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <ItemTemplate>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style4" rowspan="5">
                                    <asp:Image ID="Image1" runat="server" Width="30%" ImageUrl='<%# Eval("Imagen") %>'/>
                                </td>
                                <td class="auto-style5" colspan="3">
                                    <asp:Label ID="L_Nombre" runat="server" Text='<%# Eval("Nom_juego") %>' CssClass="fuenteNegra"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-left">
                                    &nbsp;</td>
                                <td colspan="2">
                                    &nbsp;</td>
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
                                <td class="text-left" colspan="3">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Favoritos" runat="server" CssClass="fondoElemento" Text="Favoritos"  />
                                </td>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Vender" runat="server" CssClass="fondoElemento" Text="Vender" Visible="False" />
                                </td>
                                <td class="auto-style6">
                                    <asp:Button ID="B_Cambiar" runat="server" CssClass="fondoElemento" Text="Cambiar" Visible="False" />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
                <asp:ObjectDataSource ID="ODS_Biblioteca" runat="server" SelectMethod="obtenerBiblioteca" TypeName="DAOBiblioteca">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DDL_Filtro" DefaultValue="0" Name="id_categoria" PropertyName="SelectedValue" Type="Int32" />
                        <asp:SessionParameter Name="id_usuario" SessionField="id_usuario" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                </td>
        </tr>
    </table>
</asp:Content>

