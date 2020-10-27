using System;
using System.Collections.Generic;
using System.Drawing;
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
        
        String Ccontraseña;
        Usuario usuario = new Usuario();
        usuario.Nickname = TB_Nick.Text;
        usuario.Contraseña = TB_Contraseña.Text;
        usuario.Correo = TB_Correo.Text;
        Ccontraseña = TB_Ccontraseña.Text;
        usuario.Id_rol = 1;
        Usuario validacion = new DAOUsuario().ValidacionUsuario(usuario);
        LB_mensaje.ForeColor = Color.Red;
        if (TB_Nick==null || TB_Correo==null || TB_Contraseña==null || TB_Ccontraseña ==null)
        {
            LB_mensaje.Text = "Por favor llene todos los campos";
            return;
        }
        if (usuario.Contraseña != Ccontraseña)
        {
           
            LB_mensaje.Text = "La Contraseña no coincide";
            TB_Contraseña.Text = string.Empty;
            TB_Ccontraseña.Text = string.Empty;

        } else if (validacion == null)
        {
            new DAOUsuario().insertUsuario(usuario);
            Response.Redirect("Login.aspx");
        }
        if (validacion != null)
        {
            if (validacion.Nickname == usuario.Nickname)
            {
                
                LB_mensaje.Text = "ya existe un Nickname registrado";
                TB_Nick.Text = string.Empty;
                TB_Contraseña.Text = string.Empty;
                TB_Correo.Text = string.Empty;
            }
            else if (validacion.Correo == usuario.Correo)
            {
                
                LB_mensaje.Text = "ya existe un Correo registrado";
                TB_Nick.Text = string.Empty;
                TB_Contraseña.Text = string.Empty;
                TB_Correo.Text = string.Empty;

            }
        }
         
    }
    protected void BT_inicioSesion_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

}