<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/AdminCategorias.aspx.cs" Inherits="View_AdminCategorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            text-align: right;
        }
        .auto-style10 {
            text-align: center;
        }
    .auto-style11 {
        height: 28px;
        text-align: center;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style9">
                <asp:Label ID="L_NuevaCat" runat="server" CssClass="fuenteNegra" Text="Nueva categoría:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="fondoElemento"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style11">
                <asp:Label ID="L_Mensaje" runat="server" CssClass="fondoElemento" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style10">
                <asp:Button ID="Button1" runat="server" CssClass="fondoElemento" Text="Button" />
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10" colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Categoria">
                    <Columns>
                        <asp:BoundField DataField="Id_categoria" HeaderText="Id_categoria" SortExpression="Id_categoria" Visible="False" />
                        <asp:BoundField DataField="Categoria" HeaderText="Categoria" SortExpression="Categoria" />
                        <asp:CommandField HeaderText="Eliminar" ShowDeleteButton="True" />
                        <asp:CommandField EditText="Actualizar" HeaderText="Editar" ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Categoria" runat="server" DataObjectTypeName="Categorias" DeleteMethod="deleteCategoria" SelectMethod="obtenerCategoriasTabla" TypeName="DAOCategoria" UpdateMethod="updateCategoria"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

