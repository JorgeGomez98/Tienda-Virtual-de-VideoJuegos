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
                iniciar.Visible = true;
                registrar.Visible = true;
                btn_cerrarusuario.Visible = false;
                // Response.Redirect("Login.aspx");
            }
            else
            {

                iniciar.Visible = false;
                registrar.Visible = false;
                btn_cerrarusuario.Visible = true;
                //menu();
            }
            menu();
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
        catalogo.Visible = true;
        M_Admin.Visible = false;
       
        M_Usuario.Visible = false;
    }

    private void rolUsuario()
    {
        catalogo.Visible = true;
        M_Admin.Visible = false;
       
        M_Usuario.Visible = true;
    }

 

    private void rolAdmin()
    {
        catalogo.Visible = false;
        M_Admin.Visible = true;
     
        M_Usuario.Visible = false;
    }
    
    protected void btn_cerrarusuario_Click1(object sender, EventArgs e)
    {
        Session["user"] = null;
        Response.Redirect("Catalogo.aspx");
    }
}
