﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_AgregaJuego : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

            Videojuego videojuego = new Videojuego();
            videojuego.Id_categoría = int.Parse(DDL_Categorias.SelectedValue);
            videojuego.Imagen = "~\\Imagenes\\ImagenesJuegos" + "\\" + nombreArchivo;
            videojuego.Nom_juego = TB_Nombre.Text;
            videojuego.Descripcion = TB_descripcion.Text;
            videojuego.Id_estadoV = 1;
            //usuario.Precio = Double.Parse(TB_Precio.Text);

            new DAOVideojuego().insertJuego(videojuego);
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
}