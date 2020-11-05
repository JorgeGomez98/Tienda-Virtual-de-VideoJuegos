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
            <td class="auto-style9" colspan="2">
                <asp:Label ID="L_NuevaCat" runat="server" CssClass="fuenteNegra" Text="Nueva categoría:"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TB_Categoria" runat="server" CssClass="fondoElemento"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="4" class="auto-style11">
                <asp:Label ID="L_Mensaje" runat="server" CssClass="fondoElemento" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="4" class="auto-style10">
                <asp:Button ID="B_Agregar" runat="server" CssClass="fondoElemento" Text="Agregar" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="4" class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style10" colspan="2">
                <asp:GridView ID="GV_Categorias" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Categoria" AllowPaging="True" DataKeyNames="Id_categoria" CellPadding="4" CssClass="fondoElemento" ForeColor="#333333" GridLines="None" >
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Id_categoria" HeaderText="Id_categoria" SortExpression="Id_categoria" Visible="False" />
                        <asp:BoundField DataField="Categoria" HeaderText="Categoria" SortExpression="Categoria" />
                        <asp:CommandField HeaderText="Eliminar" ShowDeleteButton="True" />
                        <asp:CommandField EditText="Actualizar" HeaderText="Editar" ShowEditButton="True" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ODS_Categoria" runat="server" DataObjectTypeName="Categorias" DeleteMethod="deleteCategoria" SelectMethod="obtenerCategoriasTabla" TypeName="DAOCategoria" UpdateMethod="updateCategoria" InsertMethod="insertarCategoria"></asp:ObjectDataSource>
            </td>
            <td class="auto-style10">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

