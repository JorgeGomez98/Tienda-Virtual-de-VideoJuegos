<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/Reporte.aspx.cs" Inherits="View_Reporte" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 20%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="nav-justified">
    <tr>
        <td>&nbsp;</td>
        <td colspan="2" class="text-right">
            <asp:Label ID="L_Factura" runat="server" CssClass="fondoElemento" Text="No. Factura:"></asp:Label>
            <asp:TextBox ID="TB_Factura" runat="server" CssClass="fondoElemento"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="B_Generar" runat="server" CssClass="fondoElemento" OnClick="B_Generar_Click" Text="Generar" />
        </td>
    </tr>
    <tr>
        <td class="auto-style10" colspan="2">

        </td>
        <td colspan="2">
            <CR:CrystalReportViewer ID="CRV_Factura" runat="server" AutoDataBind="True" EnableDatabaseLogonPrompt="False" EnableParameterPrompt="False" GroupTreeImagesFolderUrl="" Height="50px" ReportSourceID="CRS_Factura" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="350px" HasRefreshButton="True" />
            <CR:CrystalReportSource ID="CRS_Factura" runat="server">
                <Report FileName="~\Reportes\Factura.rpt">
                </Report>
            </CR:CrystalReportSource>
        </td>
        
    </tr>
    <tr>
        <td class="auto-style10" colspan="2">

            &nbsp;</td>
        <td colspan="2">
            <asp:Label ID="L_Mensaje" runat="server" CssClass="fondoElemento" ForeColor="Red"></asp:Label>
        </td>
        
    </tr>
</table>
</asp:Content>

