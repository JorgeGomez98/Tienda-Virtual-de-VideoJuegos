using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Vendidos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null && ((Usuario)Session["user"]).Id_rol == 1)
        {
            Session["user"] = null;
            Response.Redirect("Login.aspx");
        }
        L_Mensaje.Visible = false;
    }

    protected void B_Buscar_Click(object sender, EventArgs e)
    {
        if (TB_FechaInicio.Text == null || TB_FechaFin.Text == null)
        {
            L_Mensaje.Visible = true;
            L_Mensaje.Text = "Por favor ingrese todos los campos para visualizar";
        }
        else
        {
            L_Mensaje.Visible = false;
            CRS_Videojuego.ReportDocument.SetDataSource(obtenerInformacion());
            CRV_Videojuegos.ReportSource = CRS_Videojuego;
            CRV_Videojuegos.Visible = true;
        }
        
        
    }

    protected SuministroInformacion obtenerInformacion()
    {
        SuministroInformacion informe = new SuministroInformacion();
        DateTime fechaInicio = DateTime.Parse(TB_FechaInicio.Text);
        DateTime fechaFin = DateTime.Parse(TB_FechaFin.Text);
        List<Videojuego> listaVideojuegos = new List<Videojuego>();

        List<DetallePedido> lista = new DAOCarrito().productosVendidosPorFecha(fechaInicio, fechaFin);
        var prod = lista.GroupBy(x => (x.NombreJuego)).Select(grp => grp.ToList()).ToList();

        foreach (var item in prod)
        {
            List<DetallePedido> detalle = item;
            Videojuego nuevo = new Videojuego();
            nuevo.Nom_juego = detalle.First().NombreJuego;
            nuevo.Cantidad = detalle.Sum(x => x.Cantidad);
            nuevo.Id_videojuego = detalle.First().Id_videojuego;
            nuevo.Precio = detalle.Average(x => x.ValorUnitario);
            listaVideojuegos.Add(nuevo);
        }

        DataTable datosFinal = informe.MensualProductos;
        DataRow fila;

        foreach (var item in listaVideojuegos)
        {
            fila = datosFinal.NewRow();
            fila["Id_videojuego"] = item.Id_videojuego;
            fila["Videojuego"] = item.Nom_juego;
            fila["Cantidad"] = item.Cantidad;
            datosFinal.Rows.Add(fila);
        }
        return informe;
        
    }

}