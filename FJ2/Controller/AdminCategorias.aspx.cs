using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_AdminCategorias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null && ((Usuario)Session["user"]).Id_rol == 1)
        {
            Session["user"] = null;
            Response.Redirect("Login.aspx");
        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Categorias categorias = new Categorias();
        categorias.Categoria = TB_Categoria.Text;

        new DAOCategoria().insertarCategoria(categorias);
        Response.Redirect("AdminCategorias.aspx");
    }

    protected void GV_Categorias_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow ddl = GV_Categorias.Rows[e.RowIndex];
        e.NewValues[4] = double.Parse(e.NewValues[4].ToString());
        //e.NewValues.Insert(5, "Id", e.OldValues);

    }
}