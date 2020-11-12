using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOCarrito
/// </summary>
public class DAOCarrito
{
    public Pedido obtenerFactura(int noFactura)
    {
        
            Pedido pedido = new Pedido();
            using (var db = new Mapeo())
            {
                pedido = (from p in db.ped
                          join u in db.user on p.Id_usuario equals u.Id_usuario
                          where p.Id_pedido == noFactura

                          select new
                          {
                              p,
                              u,


                          }).ToList().Select(m => new Pedido
                          {
                              Fecha = m.p.Fecha,
                              Id_pedido = m.p.Id_pedido,
                              Nickname = m.u.Nickname,
                              Id_usuario = m.p.Id_usuario,
                              Valor_total = m.p.Valor_total,

                          }).FirstOrDefault();
            }
            pedido.Compras = obtenerDetalleFactura(pedido.Id_pedido);
            return pedido;
            
        
    }

    public List<DetallePedido> obtenerDetalleFactura(int pedidoId)
    {
        using (var db = new Mapeo())
        {
            return (from dp in db.detPed
                    join v in db.videojuego on dp.Id_videojuego equals v.Id_videojuego
                    where dp.Id_pedido == pedidoId

                    select new
                    {
                        v,
                        dp


                    }).ToList().Select(m => new DetallePedido
                    {
                        NombreJuego = m.v.Nom_juego,
                        Cantidad = m.dp.Cantidad,
                        ValorUnitario = m.dp.ValorUnitario

                    }).ToList();
        }
    }
}