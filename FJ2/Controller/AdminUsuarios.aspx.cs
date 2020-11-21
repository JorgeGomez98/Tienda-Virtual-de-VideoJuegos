using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_AdminUsuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_Buscar_Click(object sender, EventArgs e)
    {
        string nickname = TB_Usuario.Text;
        GV_Usuarios.DataSource = new DAOUsuario().buscaUsuario(nickname);
        GV_Usuarios.DataBind();
    }
}