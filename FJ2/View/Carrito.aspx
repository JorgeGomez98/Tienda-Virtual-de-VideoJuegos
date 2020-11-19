<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Carrito.aspx.cs" Inherits="View_Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 25%;
        }
        .auto-style11 {
            width: 25%;
            height: 28px;
        }
        .auto-style12 {
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td>
                
                    <asp:GridView ID="GV_Carrito" runat="server" CssClass="fondoElemento" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataSourceID="ODSCarro" DataKeyNames="Id">
                        <alternatingrowstyle backcolor="White" />
                        <columns>
                        <asp:BoundField DataField="Nombre_estado" HeaderText="Estado" SortExpression="Nombre_estado" />
                        <asp:BoundField DataField="Nom_juego" HeaderText="Nombre" SortExpression="Nom_juego" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                        <asp:TemplateField HeaderText="Imagen" SortExpression="Imagen">

                            <ItemTemplate>
                                <asp:Image ID="Label1" runat="server" Width="30%"  ImageUrl='<%# Bind("Imagen") %>'></asp:Image>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField HeaderText="Retirar de compra" ShowDeleteButton="True" />
                        <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                    </columns>
                        <editrowstyle backcolor="#2461BF" />
                        <footerstyle backcolor="#507CD1" font-bold="True" forecolor="White" />
                        <headerstyle backcolor="#507CD1" font-bold="True" forecolor="White" />
                        <pagerstyle backcolor="#2461BF" forecolor="White" horizontalalign="Center" />
                        <rowstyle backcolor="#EFF3FB" />
                        <selectedrowstyle backcolor="#D1DDF1" font-bold="True" forecolor="#333333" />
                        <sortedascendingcellstyle backcolor="#F5F7FB" />
                        <sortedascendingheaderstyle backcolor="#6D95E1" />
                        <sorteddescendingcellstyle backcolor="#E9EBEF" />
                        <sorteddescendingheaderstyle backcolor="#4870BE" />
                    </asp:GridView>
                
                <asp:ObjectDataSource ID="ODSCarro" runat="server" DataObjectTypeName="Biblioteca" DeleteMethod="deleteJuego" SelectMethod="obtenerProductosCarrito" TypeName="DAOCarrito">
                    <SelectParameters>
                        <asp:SessionParameter Name="userId" SessionField="id_usuario" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12">
                <asp:Label ID="L_Mensaje" runat="server" CssClass="fuenteGris"></asp:Label>
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td>
                <asp:Button ID="B_Comprar" runat="server" CssClass="fondoElemento" OnClick="B_Comprar_Click" Text="Comprar" AutoPostBack="true" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

