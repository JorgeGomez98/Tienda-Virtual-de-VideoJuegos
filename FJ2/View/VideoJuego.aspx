<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/VideoJuego.aspx.cs" Inherits="View_VideoJuego" %>

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

        .auto-style14 {
            text-align: right;
            width: 146px;
            font-family: Prototype;
            font-size: 20px;
        }

        .auto-style16 {
            font-size: 20px;
            font-family: Prototype;
            color: black;
        }

        .auto-style18 {
            text-align: right;
            height: 52px;
        }

        .auto-style20 {
            height: 10%;
        }

        .auto-style21 {
            width: 20%;
        }
    .auto-style22 {
        width: 33%;
        text-align: center;
    }
        .auto-style23 {
            text-align: left;
            width: 97%;
        }
        .auto-style25 {
            text-align: center;
            width: 50%;
            height: 18px;
        }
        .auto-style26 {
            text-align: center;
            width: 146px;
            height: 18px;
        }
        .auto-style27 {
            text-align: right;
            width: 97%;
            height: 18px;
        }
    </style>
<link href="../App_Themes/Fuentes.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style21">
                &nbsp;</td>
            <td class="auto-style5">
                <asp:Image ID="I_Carrito" runat="server" ImageUrl="~/Imagenes/IconosSistema/ircarrito.png" Width="15%" />
                <asp:Label ID="L_Carrito" runat="server" CssClass="fuenteNegra" Text="0" ForeColor="Red"></asp:Label>
            </td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style11" colspan="6">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" rowspan="7" colspan="3">
                <asp:Image ID="I_Perfil" runat="server" Width="350px" />
            </td>
            <td class="auto-style14" colspan="2">
                Nombre:</td>
            <td colspan="2">
                <asp:TextBox ID="TB_nombreJ" runat="server" CssClass="auto-style16" Height="43px" ReadOnly="True" Width="400px" Enabled="False"></asp:TextBox>
            </td>
            <td colspan="2" class="auto-style21">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14" colspan="2">
                Descripción:</td>
            <td colspan="2">
                <asp:TextBox ID="TB_descripcion" runat="server" CssClass="auto-style16" Height="115px" ReadOnly="True" TextMode="MultiLine" Width="424px" Enabled="False"></asp:TextBox>
               
            </td>
            <td colspan="2" class="auto-style21">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14" colspan="2">
                &nbsp;</td>
            <td colspan="4">
                &nbsp;</td>
        </tr>
           <tr>
            <td class="auto-style14" colspan="2">
                Categoría:</td>
            <td colspan="2">
                <asp:TextBox ID="TB_Categoria" runat="server" CssClass="fondoElemento" Width="400px" Enabled="False"></asp:TextBox>
            </td>
            <td colspan="2" class="auto-style21">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18" colspan="6"></td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="L_Cantidad" runat="server" CssClass="fondoElemento" Text="Cantidad:"></asp:Label>
            </td>
            <td class="auto-style23" colspan="2">
                <asp:TextBox ID="TB_Cantidad" runat="server" CssClass="fondoElemento" Width="400px"></asp:TextBox>
            </td>
            <td class="auto-style21" colspan="2">
                &nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="7">
                <table class="nav-justified">
                    <tr>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style22">
                <asp:Button ID="BTdenuncia" runat="server" CssClass="fondoElemento" OnClick="BTdenuncia_Click" Text="Denunciar" Width="70%" />
                        </td>
                        <td class="auto-style22">
                <asp:Button ID="btn_volver" runat="server" CssClass="fondoElemento" Text="Volver" OnClick="btn_volver_Click" CausesValidation="false" Width="70%" />
                        </td>
                        <td class="auto-style22">
                <asp:Button ID="B_Comprar" runat="server" CssClass="fondoElemento" Text="Agregar al Carrito" OnClick="B_Comprar_Click" Width="70%" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style22">&nbsp;</td>
                        <td class="auto-style22">
                            &nbsp;</td>
                        <td class="auto-style22">&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style20" colspan="9">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
            <td class="auto-style7" colspan="6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="3"></td>
            <td class="auto-style7" colspan="6">
            </td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="9">

                <asp:Label ID="LB_alerta" runat="server" CssClass="fondoElemento"></asp:Label>
                <asp:TextBox ID="TB_comentario" Width =" 50%" runat="server" CssClass="fondoElemento"></asp:TextBox>
                <asp:Button ID="BT_EnviarComentario" runat="server" CssClass="fondoElemento" OnClick="BT_EnviarComentario_Click" Text="Enviar" />
            </td>

                &nbsp;</td>

        </tr>
        <tr>
            <td class="auto-style25" colspan="3">
                </td>
            <td class="auto-style26" colspan="2">
                </td>
            <td class="auto-style27" colspan="4">
                </td>
        </tr>
        <tr>
            <td class="text-center" colspan="9">
              
                <asp:Panel ID="PN" runat="server">
                    <asp:GridView ID="GD_comentarios" runat="server" AutoGenerateColumns="False" DataSourceID="ODScomentario">
                        <Columns>
                            <asp:BoundField DataField="Nickname" HeaderText="Nickname" SortExpression="Nickname" />
                            <asp:BoundField DataField="Mensaje" HeaderText="Mensaje" SortExpression="Mensaje" />
                        </Columns>
                    </asp:GridView>
                    <asp:ObjectDataSource ID="ODScomentario" runat="server" SelectMethod="obtenerComentario" TypeName="DAOComentario">
                        <SelectParameters>
                            <asp:SessionParameter DefaultValue="0" Name="id_videojuego" SessionField="idVideojuego" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </asp:Panel>
              
            </td>
        </tr>
    </table>
</asp:Content>


