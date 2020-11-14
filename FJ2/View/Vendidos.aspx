<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Vendidos.aspx.cs" Inherits="View_Vendidos" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 25%;
        }
    .auto-style11 {
        width: 25%;
        text-align: right;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td class="auto-style10">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                <asp:Label ID="Label1" runat="server" CssClass="fondoElemento" Text="Fecha inicio:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TB_FechaInicio" runat="server" CssClass="fondoElemento" TextMode="DateTimeLocal"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style10">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                <asp:Label ID="Label2" runat="server" CssClass="fondoElemento" Text="Fecha fin:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TB_FechaFin" runat="server" CssClass="fondoElemento" TextMode="DateTimeLocal"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>
                <asp:Button ID="B_Buscar" runat="server" CssClass="fondoElemento" OnClick="B_Buscar_Click" Text="Buscar" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="text-center" colspan="2">
                <asp:Label ID="L_Mensaje" runat="server" CssClass="fondoElemento" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td colspan="2">
                <CR:CrystalReportViewer ID="CRV_Videojuegos" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" HasRefreshButton="True" Height="50px" ReportSourceID="CRS_Videojuego" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="350px" Visible="False" EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False" />
                <CR:CrystalReportSource ID="CRS_Videojuego" runat="server">
                    <Report FileName="~/Reportes/VideojuegoRangoFechas.rpt">
                    </Report>
                </CR:CrystalReportSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

