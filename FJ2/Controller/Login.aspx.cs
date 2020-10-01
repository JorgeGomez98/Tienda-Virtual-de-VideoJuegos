using System;
using System.Web.UI.WebControls;

public partial class View_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LN_principal_Authenticate(object sender, AuthenticateEventArgs e)
    {
        Moderador moderador = new Moderador();
        moderador.Nickname = LN_principal.UserName;
        moderador.Contraseña = LN_principal.Password;

        moderador = new DAOUsuario().loginModerador(moderador);
        if (moderador == null)
        {
            ((Label)LN_principal.FindControl("L_Mensaje")).Text = "Usuario o clave incorrecto";
        }
        else
        {
            Response.Redirect("Crude.aspx");
        }
        /*Administrador administrador = new Administrador();
        administrador.Nickname = LN_principal.UserName;
        administrador.Contraseña = LN_principal.Password;

        administrador = new DAOUsuario().loginAdmin(administrador);
        if (administrador == null)
        {
            ((Label)LN_principal.FindControl("L_Mensaje")).Text = "Usuario o clave incorrecto";
        }
        else
        {
            Response.Redirect("Crude.aspx");
        }*/


        /*Usuario usuario = new Usuario();
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
        }*/

        /*Administrador administrador = new Administrador();
        administrador.Nickname = LN_principal.UserName;
        administrador.Contraseña = LN_principal.Password;        

        administrador = new DAOUsuario().loginAdmin(administrador);
        
        if(administrador == null)
        {
            Moderador moderador = new Moderador();

            moderador.Nickname = LN_principal.UserName;
            moderador.Contraseña = LN_principal.Password;

            moderador = new DAOUsuario().loginModerador(moderador);

            if (moderador== null)
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
                    Response.Redirect("CrudeUsuario.aspx");
                }
                
            }
            else
            {
                Response.Redirect("CrudeModerador.aspx");
            }
        }
        else
        {
            Response.Redirect("Crude.aspx");
        }


        */
    }
}