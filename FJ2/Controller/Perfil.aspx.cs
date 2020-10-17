using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Perfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_ImagenPerfil_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        string nombreArchivo = System.IO.Path.GetFileName(FU_ImagenPerfil.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FU_ImagenPerfil.PostedFile.FileName);

        string saveLocation = Server.MapPath("~\\Imagenes") + "\\" + nombreArchivo;

        if (!(extension.Equals(".jpg") || extension.Equals(".gif") || extension.Equals(".JPEG") || extension.Equals(".png")))
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
            FU_ImagenPerfil.PostedFile.SaveAs(saveLocation);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");

            Usuario usuario = new Usuario();
            usuario.Imagen = "~\\FJ2" + "\\" + nombreArchivo;
            usuario.Nombre = TB_Nombre.Text;
            //usuario.Precio = Double.Parse(TB_Precio.Text);

            new DAOUsuario().insertUsuario(usuario);
        }
        catch (Exception exc)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Error: ');</script>");
            return;
        }
    }

    protected void B_Editar_Click(object sender, EventArgs e)
    {
        TB_Nickname.ReadOnly = false;
        TB_Nombre.ReadOnly = false;
        TB_Correo.ReadOnly = false;
        B_Guardar.Visible = true;
        B_Editar.Visible = false;
    }
}