using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Denuncias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        
        
    }

    protected void BTenviar_Click(object sender, EventArgs e)
    {
        int id_usuario = int.Parse(Session["id_usuario"].ToString());

        Denuncias denuncias = new Denuncias();
        denuncias.Mensaje = TBmensaje.Text;
        denuncias.Id_usuario = id_usuario;
        denuncias.Id_estadodenucnia = 2;
        new DAODenuncia().insertarDenuncia(denuncias);
        Response.Redirect("Videojuego.aspx");
    }
}