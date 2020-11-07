using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_PagPrincipal : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.AppRelativeVirtualPath.Contains("Login.aspx"))
        {
            if (Session["user"] == null)
            {
                sinRol();
                // Response.Redirect("Login.aspx");
            }
            else
            {
                iniciar.Visible = false;
                registrar.Visible = false;
                menu();
            }
            //menu();
        }
        else
        {
            sinRol();
        }
    }



    private void menu()
    {
        if (Session["user"] != null)
        {
            switch (((Usuario)Session["user"]).Id_rol)
            {
                case 1:
                    rolUsuario();
                    break;
                case 2:
                    rolModerador();
                    break;
                case 3:
                    rolAdmin();
                    break;
                default:
                    sinRol();
                    break;
            }
        }
        else
        {
            sinRol();
        }
    }

    private void sinRol()
    {
        
        M_Admin.Visible = false;
        M_Moderador.Visible = false;
        M_Usuario.Visible = false;
    }

    private void rolUsuario()
    {
        M_Admin.Visible = false;
        M_Moderador.Visible = false;
        M_Usuario.Visible = true;
    }

    private void rolModerador()
    {
        
        M_Usuario.Visible = true;
        M_Admin.Visible = false;
        M_Moderador.Visible = true;
    }

    private void rolAdmin()
    {
        M_Admin.Visible = true;
        M_Moderador.Visible = true;
        M_Usuario.Visible = true;
    }





    protected void btn_cerrarusuario_Click1(object sender, EventArgs e)
    {
        Session["user"] = null;
    }
}
