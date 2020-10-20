using System;
using System.Web.UI.WebControls;

public partial class View_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        Usuario usuario = new Usuario();
        usuario.Nickname = Login1.UserName;
        usuario.Contraseña = Login1.Password;

        usuario = new DAOUsuario().login(usuario);
        if (usuario == null)
        {
            ((Label)Login1.FindControl("L_Mensaje")).Text = "Usuario o clave incorrecto";
            Session["user"] = null;
        }
        else
        {
            Session["user"] = usuario;
            
            Response.Redirect("Perfil.aspx");
        }
    }

    protected void B_Registrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroUsuario.aspx");
    }
}