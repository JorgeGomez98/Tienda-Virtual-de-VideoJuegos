using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_DenunciasAdministrador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null && ((Usuario)Session["user"]).Id_rol == 3)
        {

        }
        else
        {
            Session["user"] = null;
            Response.Redirect("Login.aspx");
        }

     }
}