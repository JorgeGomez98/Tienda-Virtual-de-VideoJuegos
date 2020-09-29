using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LN_principal_Authenticate(object sender, AuthenticateEventArgs e)
    {
        Usuario usuario = new Usuario();
        usuario.Nickname = LN_principal.UserName;
        usuario.Contraseña = LN_principal.Password;

        usuario = new DAOUsuario().login(usuario);
        if(usuario == null)
        {
            ((Label)LN_principal.FindControl("L_Mensaje")).Text = "Usuario o clave incorrecto";
        }
        else
        {
            Response.Redirect("Crude.aspx");
        }
    }
}