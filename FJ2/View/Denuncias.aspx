<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Denuncias.aspx.cs" Inherits="View_Denuncias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
           
            width: 50%;
            text-align: center;
        }
        .auto-style12 {
            margin-left: 0;
            margin-bottom: 0;
        }
        .auto-style13 {
            width: 100%;
            height: 220px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style13">
        <tr>
            <td class="auto-style10">
                <asp:Label ID="LBmensaje" runat="server" CssClass="fondoElemento" Height="10%" Text="Danos tu motivo de denuncia" Width="50%"></asp:Label>
            </td>
            <td class="fondoElemento">
                <asp:TextBox ID="TBmensaje" runat="server" CssClass="auto-style12" Height ="100%" Width="80%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">
                &nbsp;</td>
            <td>
                <asp:Button ID="BTenviar" runat="server" CssClass="fondoElemento" Text="Enviar" OnClick="BTenviar_Click" />
            </td>
        </tr>
        </table>
</asp:Content>

