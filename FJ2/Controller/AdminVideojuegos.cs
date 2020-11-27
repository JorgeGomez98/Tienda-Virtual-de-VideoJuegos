using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_AgregaJuego : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FU_Imagen.Visible = false;
        I_Videojuego.Visible = false;
        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Label5.Visible = false;
        TB_Cantidad.Visible = false;
        TB_Nombre.Visible = false;
        TB_descripcion.Visible = false;
        TB_Precio.Visible = false;
        B_Agregar.Visible = false;
        B_AgregarVisible.Visible = true;
        DDL_Categorias.Visible = false;
        B_Cancelar.Visible = false;
        Label6.Visible = false;
        DDL_Plataformas.Visible = false;
    }

    protected void B_Agregar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        string nombreArchivo = System.IO.Path.GetFileName(FU_Imagen.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FU_Imagen.PostedFile.FileName);

        string saveLocation = Server.MapPath("~\\Imagenes\\ImagenesJuegos") + "\\" + nombreArchivo;

        if (!(extension.Equals(".jpg") || extension.Equals(".gif") || extension.Equals(".jpeg") || extension.Equals(".png")))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido');</script>");
            return;
        }

        if (System.IO.File.Exists(saveLocation))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
            return;
        }
        try
        {
            FU_Imagen.PostedFile.SaveAs(saveLocation);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");
            /*if (TB_Nombre.Text.Equals("") || TB_descripcion.Text.Equals("") || TB_Cantidad)
            {

            }*/
            Videojuego videojuego = new Videojuego();
            videojuego.Id_categoría = int.Parse(DDL_Categorias.SelectedValue);
            videojuego.Id_plataforma = int.Parse(DDL_Plataformas.SelectedValue);
            videojuego.Imagen = "~\\Imagenes\\ImagenesJuegos" + "\\" + nombreArchivo;
            videojuego.Nom_juego = TB_Nombre.Text;
            videojuego.Descripcion = TB_descripcion.Text;
            /*if (videojuego.Nom_juego.Equals("") || videojuego.Descripcion.Equals("") || )
            {

            }*/

            videojuego.Cantidad = int.Parse(TB_Cantidad.Text);
            if(videojuego.Cantidad == 0)
            {
                videojuego.Id_estadoV = 2;
            }
            else
            {
                videojuego.Id_estadoV = 1;
            }
            videojuego.Precio = int.Parse(TB_Precio.Text);
            //usuario.Precio = Double.Parse(TB_Precio.Text);
            Videojuego validacion = new DAOVideojuego().ValidacionVideojuego(videojuego);

            if (validacion==null)
            {
                new DAOVideojuego().insertJuego(videojuego);
            } else
            {
                if (validacion.Nom_juego==videojuego.Nom_juego)
                {
                    L_Mensaje.Text = "Nombre ya registrado";
                    TB_Nombre.Text = string.Empty;
                }
                if (validacion.Descripcion == videojuego.Descripcion)
                {
                    L_Mensaje.Text = "Descripción ya ingresada";
                    TB_descripcion.Text = string.Empty;
                }
            }
            
        }
        catch (Exception)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error: ');</script>");
            return;
        }
    }

    protected void GV_Juegos_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow ddl = GV_Juegos.Rows[e.RowIndex];
        e.NewValues[4] = double.Parse(e.NewValues[4].ToString());
        //e.NewValues.Insert(5, "Id", e.OldValues);

    }

    protected void B_AgregarVisible_Click(object sender, EventArgs e)
    {
        FU_Imagen.Visible = true;
        I_Videojuego.Visible = true;
        Label1.Visible = true;
        Label2.Visible = true;
        Label3.Visible = true;
        Label4.Visible = true;
        Label5.Visible = true;
        Label6.Visible = true;
        TB_Cantidad.Visible = true;
        TB_Nombre.Visible = true;
        TB_descripcion.Visible = true;
        TB_Precio.Visible = true;
        B_Agregar.Visible = true;
        B_AgregarVisible.Visible = false;
        DDL_Categorias.Visible = true;
        B_Cancelar.Visible = true;
        DDL_Plataformas.Visible = true;

    }

    protected void B_Cancelar_Click(object sender, EventArgs e)
    {
        FU_Imagen.Visible = false;
        I_Videojuego.Visible = false;
        I_Videojuego.Visible = false;
        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Label5.Visible = false;
        Label6.Visible = false;
        TB_Cantidad.Visible = false;
        TB_Cantidad.Text = null;
        TB_Nombre.Visible = false;
        TB_Nombre.Text = null;
        TB_descripcion.Visible = false;
        TB_descripcion.Text = null;
        TB_Precio.Visible = false;
        TB_Precio.Text = null;
        B_Agregar.Visible = false;
        B_AgregarVisible.Visible = true;
        DDL_Categorias.Visible = false;
        DDL_Plataformas.Visible = false;
    }

    protected void DDL_Categorias_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList opcion = (DropDownList)sender;
        GridViewRow fila = (GridViewRow)opcion.Parent.Parent;
        int juego = int.Parse(((Label)fila.FindControl("L_Videojuego")).Text);
        int id_categoría = int.Parse(opcion.SelectedValue);
        if (id_categoría != 0)
        {
            Videojuego videojuego = new DAOVideojuego().obtenerVideojuegoInformacion(juego);
            new DAOVideojuego().updateVideojuego(videojuego, id_categoría);

            GV_Juegos.DataBind();
        }
        
    }
}