using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_RecuperarContraseña : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString.Count > 0)
        {
            token token = new DAOSeguridad().getTokenByToken(Request.QueryString[0]);

            if (token == null)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token es invalido. Genere uno nuevo');window.location=\"Iniciar_Sesion_MINO.aspx\"</script>");
            else if (token.Vigencia < DateTime.Now)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token esta vencido. Genere uno nuevo');window.location=\"Iniciar_Sesion_MINO.aspx\"</script>");
            else
                Session["user_id"] = token.UserId;
        }

        else
            Response.Redirect("Login.aspx");
    }

    protected void BT_CambiarContra_Click(object sender, EventArgs e)
    {
        Usuario usuario = new Usuario();
        DAOUsuario dao = new DAOUsuario();
        Usuario validarContra = dao.getContraByUser(TB_NuevaContra.Text);
        if (validarContra != null)
        {
            L_ContraNoCoinciden.Text = "Contraseña igual a la anterior";
        }
        else if (TB_NuevaContra.Text == TB_RepetirContra.Text)
        {
            usuario.Id_usuario = int.Parse(Session["user_id"].ToString());
            usuario.Contraseña = TB_RepetirContra.Text;

            {
                new DAOSeguridad().updateClave(usuario);

                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Su contraseña fue actualizada');window.location=\"Login.aspx\"</script>");
            }
        }
        else
        {
            L_ContraNoCoinciden.Text = "Las contraseñas no coinciden";
        }
    }
}