<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/DenunciaUsuario.aspx.cs" Inherits="View_DenunciaUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ODSDenunciasUsuario">
        <Columns>
            <asp:BoundField DataField="Id_denuncia" HeaderText="Id_denuncia" SortExpression="Id_denuncia" />
            <asp:BoundField DataField="Mensaje" HeaderText="Mensaje" SortExpression="Mensaje" />
            <asp:BoundField DataField="Nombre_usuario" HeaderText="Nombre_usuario" SortExpression="Nombre_usuario" />
            <asp:BoundField DataField="Nombre_estado" HeaderText="Nombre_estado" SortExpression="Nombre_estado" />
            <asp:BoundField DataField="Nombre_videojuego" HeaderText="Nombre_videojuego" SortExpression="Nombre_videojuego" />
        </Columns>
    </asp:GridView>
<asp:ObjectDataSource ID="ODSDenunciasUsuario" runat="server" SelectMethod="obtenerDenunciasUsuario" TypeName="DAODenuncia">
    <SelectParameters>
        <asp:SessionParameter DefaultValue="0" Name="id_usuario" SessionField="id_usuario" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>
</asp:Content>

