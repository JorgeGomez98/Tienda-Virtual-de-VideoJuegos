using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Reporte : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        CRV_Factura.Visible = false;
        L_Mensaje.Visible = false;
    }

    protected void B_Generar_Click(object sender, EventArgs e)
    {
        if(TB_Factura.Text == null)
        {
            L_Mensaje.Visible = true;
            L_Mensaje.Text = "Ingrese el número de la factura para visualizar";
        }
        else
        {
            L_Mensaje.Visible = false;
            int factura = int.Parse(TB_Factura.Text);
            CRS_Factura.ReportDocument.SetDataSource(generarFactura(factura));
            CRV_Factura.ReportSource = CRS_Factura;
            CRV_Factura.Visible = true;
        }
        
    }

    protected SuministroInformacion generarFactura(int facturaId)
    {
        SuministroInformacion informe = new SuministroInformacion();
        Pedido factura = new DAOCarrito().obtenerFactura(facturaId);

        DataTable datosFinal = informe.Factura;
        DataRow fila;

        foreach (var item in factura.Compras)
        {
            fila = datosFinal.NewRow();
            fila["No"] = factura.Id_pedido;
            fila["Fecha"] = factura.Fecha;
            fila["NombreCliente"] = factura.Nickname;
            fila["Videojuego"] = item.NombreJuego;
            fila["Cantidad"] = item.Cantidad;
            fila["ValorUnitario"] = item.ValorUnitario;
            datosFinal.Rows.Add(fila);
        }
        return informe;
    }
}