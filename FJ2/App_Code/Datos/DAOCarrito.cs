using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Descripción breve de DAOCarrito
/// </summary>
public class DAOCarrito
{
    public ClientScriptManager ClientScript { get; private set; }

    /*
* Movimientos de factura
* 
*/
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

    public void agregarPedido(int id_usuario,double total , List<DetallePedido> detalles)
    {
        DateTime hoy = DateTime.Now;
        hoy = Convert.ToDateTime(hoy.ToString("yyyy/MM/dd"));
        Pedido pedido = new Pedido();
        pedido.Id_usuario =id_usuario;
        pedido.Valor_total = total;
        pedido.Fecha = hoy;
        //new DAOCarrito().agregarDetallePedido(pedido);

        using (var db = new Mapeo())
        {
            db.ped.Add(pedido);
            db.SaveChanges();
        }
        
    }



    /*
     * Movimientos de visualización
     */

    public List<Biblioteca> obtenerProductosCarrito(int userId)
    {
        List<Biblioteca> lista = new List<Biblioteca>();
        using (var db = new Mapeo())
        {
            lista = (from uu in db.lib
                    join video in db.videojuego on uu.Id_videojuego equals video.Id_videojuego
                    join estado in db.estado on video.Id_estadoV equals estado.Id_estadoV
                    
                    where uu.Id_usuario == userId && uu.Poseido == false 

                    select new
                    {
                        uu,
                        video,
                        estado
                    }).ToList().Select(m => new Biblioteca

                    {
                        Id=m.uu.Id,
                        Id_videojuego = m.uu.Id_videojuego,
                        Nom_juego=m.video.Nom_juego,
                        Nombre_estado=m.estado.Descripcion,
                        Descripcion=m.video.Descripcion,
                        //Cantidad=m.uu.Cantidad,
                        Imagen=m.video.Imagen,
                        Precio=m.video.Precio
                    }).ToList();
        }

        return lista;

    }

    public List<Biblioteca> compraProductoCarrito(int userId)
    {
        List<Biblioteca> lista = new List<Biblioteca>();
        using (var db = new Mapeo())
        {
            lista = (from uu in db.lib
                     join video in db.videojuego on uu.Id_videojuego equals video.Id_videojuego
                     join estado in db.estado on video.Id_estadoV equals estado.Id_estadoV

                     where uu.Id_usuario == userId && uu.Poseido == false

                     select new
                     {
                         uu,
                         video,
                         estado
                     }).ToList().Select(m => new Biblioteca

                     {
                         Id = m.uu.Id,
                         Id_videojuego = m.uu.Id_videojuego,
                         Nom_juego = m.video.Nom_juego,
                         Nombre_estado = m.estado.Descripcion,
                         Descripcion = m.video.Descripcion,
                         //Cantidad=m.uu.Cantidad,
                         Poseido = true,
                         Imagen = m.video.Imagen,
                         Precio = m.video.Precio
                     }).ToList();
        }

        return lista;

    }

    

    public void deleteJuego(Biblioteca videojuegos)
    {
        using (var db = new Mapeo())
        {
            //Biblioteca biblioteca = new Biblioteca();
            //biblioteca.Id_videojuego = videojuegos.Id_videojuego;
            Biblioteca biblioteca = db.lib.Where(x => x.Id == videojuegos.Id).First();
            //Videojuego juego = db.videojuego.Where(x => x.Id_videojuego == videojuegos.Id_videojuego).First();
            db.lib.Remove(biblioteca);
            db.SaveChanges();
        }
    }

    public void updateCompra(Biblioteca juego , int id_usuario)
    {
        ClientScriptManager cm = this.ClientScript;
        using (var db = new Mapeo())
        {
            Biblioteca juegoAnterior = db.lib.Where(x => x.Id == juego.Id).First();
            juegoAnterior.Id_videojuego = juego.Id_videojuego;
            Videojuego disponible = consultaDisponible(juegoAnterior.Id_videojuego);
            if (disponible.Cantidad == 0)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Uno de los artículos ya no se encuentra disponible');</script>");
                return;
            }
            else
            {
                juegoAnterior.Id = juego.Id;
                juegoAnterior.Id_usuario = id_usuario;
                juegoAnterior.Favorito = juego.Favorito;
                juegoAnterior.Deseado = juego.Deseado;
                juegoAnterior.Poseido = true;
                juegoAnterior.Nom_juego = juego.Nom_juego;
                juegoAnterior.Nombre_estado = juego.Nombre_estado;
                juegoAnterior.Descripcion = juego.Descripcion;
                juegoAnterior.Precio = juego.Precio;
                juegoAnterior.Imagen = juego.Imagen;
                db.lib.Attach(juegoAnterior);

                //Actualización de stock
                Videojuego juegoDisponible = db.videojuego.Where(x => x.Id_videojuego == juegoAnterior.Id_videojuego).First();
                juegoDisponible.Cantidad = juegoDisponible.Cantidad - 1;
                new DAOVideojuego().updateVideojuego(juegoDisponible);

                var entry = db.Entry(juegoAnterior);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
            
        }
    }

    private Videojuego consultaDisponible(int id_videojuego)
    {
        using (var db = new Mapeo())
        {
             return (from v in db.videojuego
                    where v.Id_videojuego == id_videojuego

                    select new
                    {
                        v
                    }).ToList().Select(m => new Videojuego
                    {
                        
                        Cantidad = m.v.Cantidad
                        

                    }).First();
            
        }
        
    }
}