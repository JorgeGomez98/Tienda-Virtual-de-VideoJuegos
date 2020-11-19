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
        if (Session["user"] != null)
        {
            int id_juego = int.Parse(Session["IdVideoJuego"].ToString());
            List<Videojuego> informacion = new DAOVideojuego().obtenerVideojuegoInformacion(id_juego);
            TB_nombreJ.Text = informacion[0].Nom_juego.ToString();
            TB_descripcion.Text = informacion[0].Descripcion.ToString();
            TB_Categoria.Text = informacion[0].Categoria.ToString();
            I_Perfil.ImageUrl = informacion[0].Imagen.ToString();
            int id_usuario = int.Parse(Session["id_usuario"].ToString());
            L_Carrito.Text = (new DAOBiblioteca().cantidadbilioteca(id_usuario).ToString());
            B_Comprar.Visible = true;
            B_Deseados.Visible = true;
        }
        else
        {
            int id_juego = int.Parse(Session["IdVideoJuego"].ToString());
            List<Videojuego> informacion = new DAOVideojuego().obtenerVideojuegoInformacion(id_juego);
            TB_nombreJ.Text = informacion[0].Nom_juego.ToString();
            TB_descripcion.Text = informacion[0].Descripcion.ToString();
            TB_Categoria.Text = informacion[0].Categoria.ToString();
            I_Perfil.ImageUrl = informacion[0].Imagen.ToString();
            L_Carrito.Text = "0";
            B_Comprar.Visible = false;
            B_Deseados.Visible = false;
        }
        

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

    protected void B_Comprar_Click(object sender, EventArgs e)
    {
        if (Session["user"] != null && ((Usuario)Session["user"]).Id_rol == 1 || ((Usuario)Session["user"]).Id_rol == 2)
        {
            int id_juego = int.Parse(Session["IdVideoJuego"].ToString());
            int id_usuario = int.Parse(Session["id_usuario"].ToString());
            Videojuego añadir = new DAOVideojuego().agragarjuego(id_juego);
            //añadir.Cantidad = int.Parse(TB_Cantidad.Text);
            new DAOBiblioteca().agregarBiblioteca(añadir, id_usuario);
            Response.Redirect("Catalogo.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
      

    }

    protected void BTdenuncia_Click(object sender, EventArgs e)
    {
        Response.Redirect("Denuncias.aspx");

    }
}