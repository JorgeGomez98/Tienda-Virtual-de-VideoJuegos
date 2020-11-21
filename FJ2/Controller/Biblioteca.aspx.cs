using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Biblioteca : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void DL_Biblioteca_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName.Equals("Información"))
        {
            Session["IdVideoJuego"] = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("VideoJuego.aspx");
        }
        else
        {
            Videojuego game = new Videojuego();
            DL_Biblioteca.SelectedIndex = e.Item.ItemIndex;
            game.Precio = int.Parse(((Label)DL_Biblioteca.SelectedItem.FindControl("L_Precio")).Text);
            game.Nom_juego = ((Label)DL_Biblioteca.SelectedItem.FindControl("L_Nombre")).Text;
            game.Id_videojuego = int.Parse(e.CommandArgument.ToString());
            game.Imagen = ((Image)DL_Biblioteca.SelectedItem.FindControl("I_Juego")).ImageUrl;
            game.Cantidad = int.Parse(((Label)DL_Biblioteca.SelectedItem.FindControl("L_Cantidad")).Text);
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

    protected void B_Informacion_Click(object sender, EventArgs e)
    {
        Response.Redirect("Videojuego.aspx");
    }
}