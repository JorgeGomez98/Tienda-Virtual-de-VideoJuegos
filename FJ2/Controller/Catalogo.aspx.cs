using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Catalogo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /* if (Session["user"] != null &&  ((Usuario)Session["user"]).Id_rol==1)
         {

             List<Videojuego> lista = new List<Videojuego>();
             if (!IsPostBack)
             {
                 lista = new List<Videojuego>();
                 Session["Carrito"] = lista;
             }
             else
             {
                 lista = (List<Videojuego>)Session["Carrito"];

             }

             L_Carrito.Text = lista.Count().ToString();
         }
         else
         {
             Response.Redirect("Login.aspx");
         } 
         */
        if (Session["user"] != null)
        {
            int id_usuario = int.Parse(Session["id_usuario"].ToString());
            L_Carrito.Text = (new DAOBiblioteca().cantidadbilioteca(id_usuario).ToString());
        }
        else
        {
            L_Carrito.Text = "0";
        }
        
    }

    protected void B_Deseados_Click(object sender, EventArgs e)
    {

    }

    protected void B_Info_Click(object sender, EventArgs e)
    {
        Response.Redirect("Videojuego.aspx");
        /*DL_Catalogo.SelectedIndex = e.Item.ItemIndex;
        ((Label)DL_Catalogo.SelectedItem.FindControl("L_Descripcion")).Visible = true;
        ((Label)DL_Catalogo.SelectedItem.FindControl("L_DescripcionVideojuego")).Visible = true;*/
    }

    protected void DL_Catalogo_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.Equals("Información"))
        {
            Session["IdVideoJuego"] = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("VideoJuego.aspx");
        }
        else
        {


            Videojuego game = new Videojuego();
            DL_Catalogo.SelectedIndex = e.Item.ItemIndex;
            game.Precio = int.Parse(((Label)DL_Catalogo.SelectedItem.FindControl("L_Precio")).Text);
            game.Nom_juego = ((Label)DL_Catalogo.SelectedItem.FindControl("L_Nombre")).Text;
            game.Id_videojuego = int.Parse(e.CommandArgument.ToString());
            game.Imagen = ((Image)DL_Catalogo.SelectedItem.FindControl("I_Juego")).ImageUrl;
            game.Cantidad = int.Parse(((Label)DL_Catalogo.SelectedItem.FindControl("L_Cantidad")).Text);

            List<Videojuego> lista = new List<Videojuego>();
            if (Session["Carrito"] != null)
                lista = (List<Videojuego>)Session["Carrito"];

            lista.Add(game);
            L_Carrito.Text = lista.Count().ToString();
            Session["Carrito"] = lista.OrderBy(x => x.Nom_juego).ToList();
        }
        /*Videojuego game = new Videojuego();
        DL_Catalogo.SelectedIndex = e.Item.ItemIndex;
        game.Precio = int.Parse(((Label)DL_Catalogo.SelectedItem.FindControl("L_Precio")).Text);
        game.Nom_juego = ((Label)DL_Catalogo.SelectedItem.FindControl("L_Nombre")).Text;
        game.Id_videojuego = int.Parse(e.CommandArgument.ToString());
        game.Imagen = ((Image)DL_Catalogo.SelectedItem.FindControl("I_Juego")).ImageUrl;
        game.Cantidad = int.Parse(((Label)DL_Catalogo.SelectedItem.FindControl("L_Cantidad")).Text);
        List<Videojuego> lista = new List<Videojuego>();
        if (Session["Carrito"] != null)
            lista = (List<Videojuego>)Session["Carrito"];

        lista.Add(game);
        L_Carrito.Text = lista.Count().ToString();
        Session["Carrito"] = lista.OrderBy(x => x.Nom_juego).ToList();*/
    }

    protected void IB_IrCarrito_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Carrito.aspx");
    }
}