using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_RegistroUsuario : System.Web.UI.Page
{
    /*public bool IsValidEmail(string correo)
    {
        if (string.IsNullOrWhiteSpace(correo))
            return false;

        try
        {
            // Normalize the domain
            correo = Regex.Replace(correo, @"(@)(.+)$", DomainMapper,
                                  RegexOptions.None, TimeSpan.FromMilliseconds(200));

            // Examines the domain part of the email and normalizes it.
            string DomainMapper(Match match)
            {
                // Use IdnMapping class to convert Unicode domain names.
                var idn = new IdnMapping();

                // Pull out and process domain name (throws ArgumentException on invalid)
                string domainName = idn.GetAscii(match.Groups[2].Value);

                return match.Groups[1].Value + domainName;
            }
        }
        catch (RegexMatchTimeoutException e)
        {
            return false;
        }
        catch (ArgumentException e)
        {
            return false;
        }

        try
        {
            return Regex.IsMatch(correo,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }*/





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
        if (TB_Nick.Text == string.Empty | TB_Correo.Text == string.Empty | TB_Contraseña.Text == string.Empty | TB_Ccontraseña.Text == string.Empty)
        {
            LB_mensaje.Text = "Por favor llene todos los campos";
            
        }
        else if (usuario.Contraseña != Ccontraseña)
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