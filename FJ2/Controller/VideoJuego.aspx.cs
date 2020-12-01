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
        /*
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
        */
        if (Session["user"] != null)
        {
            
            int id_juego = int.Parse(Session["IdVideoJuego"].ToString());
            int id_usuario = int.Parse(Session["id_usuario"].ToString());



            Biblioteca validar = new DAOBiblioteca().obtenerVideojuego( id_juego , id_usuario);
            if(validar != null)
            {
                Videojuego informacion = new DAOVideojuego().obtenerVideojuegoInformacion(id_juego);
                TB_nombreJ.Text = informacion.Nom_juego.ToString();
                TB_descripcion.Text = informacion.Descripcion.ToString();
                TB_Categoria.Text = informacion.Categoria.ToString();
                I_Perfil.ImageUrl = informacion.Imagen.ToString();

                L_Carrito.Text = (new DAOBiblioteca().cantidadbilioteca(id_usuario).ToString());
                B_Comprar.Visible = false;
                // B_Deseados.Visible = false;
            }
            else
            {
                Videojuego informacion = new DAOVideojuego().obtenerVideojuegoInformacion(id_juego);
                TB_nombreJ.Text = informacion.Nom_juego.ToString();
                TB_descripcion.Text = informacion.Descripcion.ToString();
                TB_Categoria.Text = informacion.Categoria.ToString();
                I_Perfil.ImageUrl = informacion.Imagen.ToString();

                L_Carrito.Text = (new DAOBiblioteca().cantidadbilioteca(id_usuario).ToString());
                B_Comprar.Visible = true;
                L_Cantidad.Visible = true;
                TB_Cantidad.Visible = true;
                //B_Deseados.Visible = true;
            }

        }
        else
        {
            int id_juego = int.Parse(Session["IdVideoJuego"].ToString());
            Videojuego informacion = new DAOVideojuego().obtenerVideojuegoInformacion(id_juego);
            TB_nombreJ.Text = informacion.Nom_juego.ToString();
            TB_descripcion.Text = informacion.Descripcion.ToString();
            TB_Categoria.Text = informacion.Categoria.ToString();
            I_Perfil.ImageUrl = informacion.Imagen.ToString();
            L_Carrito.Text = "0";
            B_Comprar.Visible = false;
            L_Cantidad.Visible = false;
            TB_Cantidad.Visible = false;
            //B_Deseados.Visible = false;
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
        if (Session["user"] != null && ((Usuario)Session["user"]).Id_rol == 1)
        {
            ClientScriptManager cm = this.ClientScript;
            bool entero = validarEntero(TB_Cantidad.Text);
            if (entero == true)
            {
                int cantidadPedida = int.Parse(TB_Cantidad.Text);
                if(cantidadPedida < 0)
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No se permiten números negativos');</script>");
                    return;
                }
                else if(cantidadPedida <1)
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese una cantidad para comprar');</script>");
                    return;
                }else if (cantidadPedida > 10)
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No está permitido adquirir más de 10 juegos');</script>");
                    return;
                }
                else
                {
                    int id_juego = int.Parse(Session["IdVideoJuego"].ToString());
                    int id_usuario = int.Parse(Session["id_usuario"].ToString());
                    Videojuego añadir = new DAOVideojuego().agragarjuego(id_juego);
                    if (cantidadPedida > añadir.Cantidad)
                    {
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Cantidad excede a la disponible');</script>");
                        return;
                    }
                    else
                    {
                        new DAOBiblioteca().agregarBiblioteca(añadir, id_usuario, cantidadPedida);
                        Response.Redirect("Catalogo.aspx");
                    }
                    //añadir.Cantidad = 1;
                    /*new DAOBiblioteca().agregarBiblioteca(añadir, id_usuario);
                    Response.Redirect("Catalogo.aspx");*/
                }

            }
            else
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ingrese un valor válido');</script>");
                return;
            }

            
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
      
        

    }

    private bool validarEntero(string num)
    {
        try
        {
            Int32.Parse(num);
            return true;
        }
        catch
        {
            return false;
        }
    }

    protected void BTdenuncia_Click(object sender, EventArgs e)
    {
        Response.Redirect("Denuncias.aspx");

    }
}