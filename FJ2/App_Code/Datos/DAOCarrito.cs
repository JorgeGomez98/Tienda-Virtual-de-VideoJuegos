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

    public List<Videojuego> obtenerProductosCarrito(int userId)
    {
        using (var db = new Mapeo())
        {
            return (from uu in db.lib
                    join video in db.videojuego on uu.Id_videojuego equals video.Id_videojuego
                    join estado in db.estado on video.Id_estadoV equals estado.Id_estadoV
                    where uu.Id_usuario == userId

                    select new
                    {
                        uu,
                        video,
                        estado
                    }).ToList().Select(m => new Videojuego

                    {
                        Id_videojuego = m.uu.Id,
                        Nom_juego=m.video.Nom_juego,
                        Nombre_estado=m.estado.Descripcion,
                        Descripcion=m.video.Descripcion,
                        Cantidad=m.uu.Cantidad,
                        Imagen=m.video.Imagen,
                        Precio=m.video.Precio
                    }).ToList();
        }

    }

    public List<DetallePedido> productosVendidosPorFecha(DateTime fechaInicio, DateTime fechaFin)
    {
        using (var db = new Mapeo())
        {
            return (from p in db.ped
                    join dp in db.detPed on p.Id_pedido equals dp.Id_pedido
                    join v in db.videojuego on dp.Id_videojuego equals v.Id_videojuego
                    where p.Fecha >= fechaInicio && p.Fecha <= fechaFin

                    select new
                    {
                        v,
                        dp
                    }).ToList().Select(m => new DetallePedido
                    {
                        NombreJuego = m.v.Nom_juego,
                        Cantidad = m.dp.Cantidad,
                        Id_videojuego = m.dp.Id_videojuego

                    }).ToList();
        }
    }
}