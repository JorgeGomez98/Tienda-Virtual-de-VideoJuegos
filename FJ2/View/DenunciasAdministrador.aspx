<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/DenunciasAdministrador.aspx.cs" Inherits="View_DenunciasAdministrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id_denuncia,id_videojuego,id_usuario" DataSourceID="ObjectDataSource1" Width="1172px">
        <Columns>
            <asp:BoundField DataField="Nombre_usuario" ReadOnly="true" HeaderText="Nombre_usuario" SortExpression="Nombre_usuario" />
            <asp:BoundField DataField="Mensaje" ReadOnly="true" HeaderText="Mensaje" SortExpression="Mensaje" />
            <asp:BoundField DataField="Nombre_videojuego" ReadOnly="true" HeaderText="Nombre_videojuego" SortExpression="Nombre_videojuego" />
            <asp:BoundField DataField="Nombre_estado" ReadOnly="true" HeaderText="Nombre_estado" SortExpression="Nombre_estado" />
            <asp:BoundField DataField="Id_estadodenucnia" HeaderText="Id_estadodenucnia" SortExpression="Id_estadodenucnia" />
            <asp:CommandField ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Denuncias" SelectMethod="obtenerDenuncias" TypeName="DAODenuncia" UpdateMethod="actualizarDenuncia"></asp:ObjectDataSource>
    

</asp:Content>

