using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_RegistroUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        
            Usuario usuario = new Usuario();
            usuario.Nickname = TB_Nick.Text;
            usuario.Contraseña = TB_Contraseña.Text;
            usuario.Correo = TB_Correo.Text;
            usuario.Id_rol = 1; 
        //una prueba

            new DAOUsuario().insertUsuario(usuario);

            Response.Redirect("Login.aspx");
      
    }
}