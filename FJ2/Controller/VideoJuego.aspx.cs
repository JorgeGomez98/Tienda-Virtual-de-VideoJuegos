using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_VideoJuego : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            I_Juego.ImageUrl = ((Videojuego)Session["game"]).Imagen;
            L_Nombre.Text = ((Videojuego)Session["game"]).Nom_juego;
            L_Descripcion.Text = ((Videojuego)Session["game"]).Descripcion;
            L_Categoria.Text = ((Videojuego)Session["game"]).Categoria;
            L_Cantidad.Text = ((Videojuego)Session["game"]).Cantidad.ToString();
            L_Precio.Text = ((Videojuego)Session["game"]).Precio.ToString();
        }
    }

    protected void IB_ADcarrito_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Carrito.aspx");
    }

    protected void B_Comprar_Click(object sender, EventArgs e)
    {
        Usuario usuario = new Usuario();
        Videojuego videojuego = new Videojuego();
        usuario.Id_usuario = ((Usuario)Session["user"]).Id_usuario;
    }
}