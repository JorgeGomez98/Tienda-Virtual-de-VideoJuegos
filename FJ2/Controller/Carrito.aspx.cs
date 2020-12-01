using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Carrito : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null && ((Usuario)Session["user"]).Id_rol == 1)
        {
            if (GV_Carrito.Rows.Count == 0)
            {
                B_Comprar.Visible = false;
            }
            else
            {
                B_Comprar.Visible = true;
            }

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
        
    }
    protected void B_Comprar_Click(object sender, EventArgs e)
    {
        double valorTotal = 0;
        int id_usuario = int.Parse(Session["id_usuario"].ToString());
        //List<Biblioteca> juegos = new DAOCarrito().obtenerProductosCarrito(((Usuario)Session["user"]).Id_usuario);
        List<Biblioteca> juegos = new DAOCarrito().obtenerProductosCarrito(id_usuario);
        List<DetallePedido> detalles = new List<DetallePedido>();
        foreach (var item in juegos)
        {

            Biblioteca juego = new Biblioteca();
            DetallePedido det = new DetallePedido();
            juego = item;
            juego.Id_usuario = item.Id_usuario;
            juego.Id_videojuego = item.Id_videojuego;
            //pedido = valorTotal + juego.Precio;
            valorTotal = valorTotal + juego.Precio;
            det.Id_videojuego = juego.Id_videojuego;
            det.ValorUnitario = juego.Precio;

            det.Cantidad = juego.Cantidad;
            det.ValorTotal = det.Cantidad * det.ValorUnitario;
            det.NombreJuego = juego.Nom_juego;
            detalles.Add(det);
            bool existe = new DAOCarrito().existe(id_videojuego: juego.Id_videojuego);
            if (existe == true)
            {
                new DAOCarrito().updateCompra(juego, id_usuario);

                ClientScriptManager cm = this.ClientScript;
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Compra realizada con éxito');</script>");

            }
            else
            {
                ClientScriptManager cm = this.ClientScript;
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El artículo " + det.NombreJuego + " ya no se encuentra disponible');</script>");
                return;
            }


        }
        //new DAOCarrito().agregarDetalles(detalles);
        new DAOCarrito().agregarPedido(((Usuario)Session["user"]).Id_usuario, valorTotal);
        Pedido info = new DAOCarrito().obtenerPedido(((Usuario)Session["user"]).Id_usuario);

        foreach (var item in detalles)
        {
            item.Id_pedido = info.Id_pedido;
            new DAOCarrito().agregarDetalle(item);
        }

        GV_Carrito.DataBind();
    }



    /*protected void GV_CarritoRowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            double precio;
            precio = (double)DataBinder.Eval(e.Row.DataItem, "precio");
            if (precio > 8)
            {
                e.Row.ForeColor = System.Drawing.Color.Red;
                e.Row.BackColor = System.Drawing.Color.Yellow;
                e.Row.Font.Bold = true;
            }

        }
    }*/

}