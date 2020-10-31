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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Categorias categorias = new Categorias();
        categorias.Categoria = TB_Categoria.Text;

        new DAOCategoria().insertarCategoria(categorias);
    }
}