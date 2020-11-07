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
        int id_juego = int.Parse(Session["IdVideoJuego"].ToString());
        List<Videojuego> informacion = new DAOVideojuego().obtenerVideojuegoInformacion(id_juego);
        TB_nombreJ.Text = informacion[0].Nom_juego.ToString();
        TB_descripcion.Text = informacion[0].Descripcion.ToString();
        TB_Categoria.Text = informacion[0].Categoria.ToString();
        I_Perfil.ImageUrl = informacion[0].Imagen.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Usuario usuario = new Usuario();
        Videojuego videojuego = new Videojuego();
        usuario.Id_usuario = ((Usuario)Session["user"]).Id_usuario;
    }

    protected void IB_ADcarrito_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Carrito.aspx");
    }

    protected void btn_volver_Click(object sender, EventArgs e)
    {
        Response.Redirect("Catalogo.aspx");

        //Session["IdVideoJuego"] = null;
    }
}