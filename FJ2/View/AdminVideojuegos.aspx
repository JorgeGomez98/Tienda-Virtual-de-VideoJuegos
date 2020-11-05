<%@ Page Title="" Language="C#" MasterPageFile="~/View/PagPrincipal.master" AutoEventWireup="true" CodeFile="~/Controller/AdminVideojuegos.cs" Inherits="View_AgregaJuego" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <style type="text/css">
        .auto-style4 {
            text-align: center;
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
        .auto-style11 {
            text-align: right;
        }
        .auto-style14 {
            text-align: right;
            width: 146px;
            font-family: Prototype;
            font-size: 20px;
        }
        .auto-style17 {
            font-family: Prototype;
            font-size: 20px;
        }
            .auto-style19 {
                text-align: center;
                font-size: 20px;
                font-family: Prototype;
                color: black;
                position: center;
                background-color: transparent;
            }
    .auto-style20 {
        height: 10%;
    }
    .auto-style21 {
        text-align: center;
    }
            .auto-style23 {
                text-align: right;
                font-family: Prototype;
                font-size: 20px;
            }
    </style>
<link href="../App_Themes/Fuentes.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:FileUpload ID="FU_Imagen" runat="server" CssClass="fondoElemento" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4" rowspan="10">
                <asp:Image ID="I_Videojuego" runat="server" Width="60%" />
            </td>
            <td class="auto-style14">
                <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TB_Nombre" runat="server" CssClass="auto-style19" Width="370px"></asp:TextBox>
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
                <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TB_descripcion" runat="server" CssClass="fondoElemento" Height="115px" TextMode="MultiLine" Width="424px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label1" runat="server" Text="Categoría:"></asp:Label>
            </td>
            <td colspan="2">
                <asp:DropDownList ID="DDL_Categorias" runat="server" CssClass="fondoElemento" DataSourceID="ODS_Categorias" DataTextField="Categoria" DataValueField="Id_categoria">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style23" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label4" runat="server" Text="Precio:"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TB_Precio" runat="server" CssClass="fondoElemento" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style23" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="Label5" runat="server" Text="Cantidad:"></asp:Label>
            </td>
            <td colspan="2">
                <asp:TextBox ID="TB_Cantidad" runat="server" CssClass="fondoElemento" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style21" colspan="3">
                <asp:Label ID="L_Mensaje" runat="server" CssClass="fondoElemento" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style17" colspan="3">
                <asp:Button ID="B_Agregar" runat="server" OnClick="B_Agregar_Click" Text="Agregar" CssClass="fondoElemento" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style7" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20" colspan="4"></td>
        </tr>
        <tr>
            <td class="auto-style7" colspan="4">
                <asp:GridView ID="GV_Juegos" runat="server" AutoGenerateColumns="False" DataSourceID="ODS_Videojuego" CssClass="fondoElemento" DataKeyNames="Id_videojuego" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Id_videojuego" HeaderText="Id_videojuego" SortExpression="Id_videojuego" Visible="False" />
                        <asp:BoundField DataField="Nom_juego" HeaderText="Nombre" SortExpression="Nom_juego" />
                        <asp:BoundField DataField="Id_categoría" HeaderText="Id_categoría" SortExpression="Id_categoría" Visible="False" />
                        <asp:BoundField DataField="Precio" HeaderText="Precio" SortExpression="Precio" />
                        <asp:BoundField DataField="Id_estadoV" HeaderText="Id_estadoV" SortExpression="Id_estadoV" Visible="False" />
                        <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
                        <asp:BoundField DataField="Imagen" HeaderText="Imagen" SortExpression="Imagen" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                        <asp:BoundField DataField="DescripcionV" HeaderText="Estado" SortExpression="DescripcionV" />
                        <asp:BoundField DataField="Categoria" HeaderText="Categoria" SortExpression="Categoria" />
                        <asp:CommandField HeaderText="Eliminar" ShowDeleteButton="True" />
                        <asp:CommandField EditText="Actualizar" HeaderText="Editar" ShowEditButton="True" />
                        <asp:ImageField DataImageUrlField="Imagen" DataImageUrlFormatString="~/Imagenes/ImagenesJuegos/{0}" HeaderText="Image">
                        </asp:ImageField>
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
                <asp:ObjectDataSource ID="ODS_Videojuego" runat="server" DataObjectTypeName="Videojuego" DeleteMethod="deleteJuego" SelectMethod="obtenerVideojuegoTabla" TypeName="DAOVideojuego" UpdateMethod="updateVideojuego" InsertMethod="insertJuego"></asp:ObjectDataSource>
                </td>
        </tr>
        <tr>
            <td class="auto-style21" colspan="4">
                <asp:ObjectDataSource ID="ODS_Categorias" runat="server" SelectMethod="obtenerCategorias" TypeName="DAOCategoria"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

