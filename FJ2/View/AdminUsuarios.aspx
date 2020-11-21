<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/AdminUsuarios.aspx.cs" Inherits="View_AdminUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../App_Themes/Fuentes.css" rel="stylesheet" type="text/css" />
<style type="text/css">
    .auto-style9 {
        text-align: right;
        height: 42px;
        width: 350px;
    }
    .auto-style10 {
        height: 42px;
    }
    .auto-style11 {
        width: 350px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="nav-justified">
    <tr>
        <td class="auto-style9">
            <asp:Label ID="Label1" runat="server" CssClass="fuenteNegra" Text="Buscar nickname:"></asp:Label>
        </td>
        <td class="auto-style10">
            <asp:TextBox ID="TB_Usuario" runat="server" CssClass="fondoElemento"></asp:TextBox>
        </td>
        
        <td class="auto-style10">
            <asp:Button ID="B_Buscar" runat="server" CssClass="fondoElemento" OnClick="B_Buscar_Click" Text="Buscar" />
        </td>
        
    </tr>
    <tr>
        <td colspan="3">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style11">
            &nbsp;</td>
        <td colspan="2">
            <asp:GridView ID="GV_Usuarios" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ODS_Usuarios" ForeColor="#333333" GridLines="None" DataKeyNames="Id_usuario" CssClass="fondoElemento" Width="50%">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Id_usuario" HeaderText="Id_usuario" SortExpression="Id_usuario" Visible="False" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Nickname" HeaderText="Nickname" SortExpression="Nickname" />
                    <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" SortExpression="Contraseña" Visible="False" />
                    <asp:BoundField DataField="Id_rol" HeaderText="Id_rol" SortExpression="Id_rol" />
                    <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                    <asp:BoundField DataField="Imagen" HeaderText="Imagen" SortExpression="Imagen" Visible="False" />
                    <asp:BoundField DataField="NombreRol" HeaderText="Rol" SortExpression="NombreRol" />
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
            <asp:ObjectDataSource ID="ODS_Usuarios" runat="server" DataObjectTypeName="Usuario" DeleteMethod="deleteUsuario" InsertMethod="insertUsuario" SelectMethod="obtenerUsuario" TypeName="DAOUsuario" UpdateMethod="updateUsuario"></asp:ObjectDataSource>
        </td>
    </tr>
</table>

</asp:Content>

