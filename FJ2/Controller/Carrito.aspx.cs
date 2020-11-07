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
        if ((List<Videojuego>)Session["Carrito"]==null)
        {
            L_Mensaje.Text = "No hay juegos agregados a compra";
        }
        else
        {
            GV_Carrito.DataSource = (List<Videojuego>)Session["Carrito"];
            GV_Carrito.DataBind();
        }
        
    }
}