<%@ Page Title="Recuperar Contraseña" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/GenerarToken.aspx.cs" Inherits="View_GenerarToken" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="L_User_Name" runat="server" Text="Digite su usuario o correo electronico: "></asp:Label>
                        <asp:TextBox ID="TB_User_Name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="B_Recuperar" runat="server" OnClick="B_Recuperar_Click" Text="Recuperar" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="L_Mensaje" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>

