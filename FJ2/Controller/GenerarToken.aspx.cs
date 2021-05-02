using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_GenerarToken : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_Recuperar_Click(object sender, EventArgs e)
    {
        Usuario usuario = new DAOUsuario().getUserByUserName(TB_User_Name.Text);

        if (usuario != null)
        {
            token validarToken = new DAOSeguridad().getTokenByUser(usuario.Id_usuario);

            token token = new token();
            token.Creacion = DateTime.Now;
            token.UserId = usuario.Id_usuario;
            token.Vigencia = DateTime.Now.AddHours(2);

            token.TokenGenerado = encriptar(JsonConvert.SerializeObject(token));
            new DAOSeguridad().insertarToken(token);

            new DAOUsuario().getCorreoByCorreos(usuario.Correo);

            correo correo = new correo();
            string mensaje = "Su link de acceso es: " + "http://localhost:54634/View/RecuperarContraseña.aspx?" + token.TokenGenerado;
            correo.enviarCorreo(usuario.Correo, token.TokenGenerado, mensaje);

            L_Mensaje.Text = "Su nueva contraseña ha sido enviada a su correo";
        }
    }

    private string encriptar(string input)
    {
        SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashedBytes = provider.ComputeHash(inputBytes);

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < hashedBytes.Length; i++)
            output.Append(hashedBytes[i].ToString("x2").ToLower());

        return output.ToString();
    }
}