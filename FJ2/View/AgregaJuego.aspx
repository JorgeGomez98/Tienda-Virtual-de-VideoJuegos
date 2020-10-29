<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/AgregaJuego.aspx.cs" Inherits="View_AgregaJuego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <style type="text/css">
        .auto-style4 {
            text-align: center;
            width: 50%;
        }
        .auto-style5 {
            width: 50%;
        }
        .auto-style7 {
            text-align: center;
            height: 23px;
        }
        .auto-style8 {
            text-align: center;
            width: 25%;
        }
        .auto-style9 {
            text-align: right;
            height: 38px;
        }
        .auto-style11 {
            text-align: right;
        }
    .auto-style13 {
        text-align: center;
        width: 146px;
    }
        .auto-style14 {
            text-align: right;
            width: 146px;
            font-family: Prototype;
            font-size: 20px;
        }
        .auto-style15 {
            text-align: justify;
            width: 146px;
            font-family: Prototype;
            font-size: 20px;
        }
        .auto-style16 {
            font-size: 20px;
            font-family: Prototype;
            color: black;
        }
        .auto-style17 {
            font-family: Prototype;
            font-size: 20px;
        }
    </style>
<link href="../App_Themes/Fuentes.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style11" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" rowspan="6">
                <asp:Image ID="I_Perfil" runat="server" Width="60%" />
            </td>
            <td class="auto-style14">
                Nombre</td>
            <td>
                <asp:TextBox ID="TB_nombreJ" runat="server" CssClass="auto-style16" Height="43px" Width="400px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                Descripción</td>
            <td colspan="2">
                <asp:TextBox ID="TB_descripcion" runat="server" CssClass="auto-style16" Height="115px" ReadOnly="True" TextMode="MultiLine" Width="424px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style17">Categoria</td>
            <td class="auto-style7" colspan="2">
                <asp:TextBox ID="TB_categoria" runat="server" CssClass="auto-style16" Height="172px" ReadOnly="True" TextMode="MultiLine" Width="427px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style7" colspan="3">
            </td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style13">
                &nbsp;</td>
            <td class="auto-style8" colspan="2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

