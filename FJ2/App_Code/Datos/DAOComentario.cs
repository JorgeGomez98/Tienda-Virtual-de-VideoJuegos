using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOComentario
/// </summary>
public class DAOComentario
{
    public void agregarComentario(Comentario comentario)
    {
        using (var db = new Mapeo())
        {
            db.comentario.Add(comentario);
          
            db.SaveChanges();
        }
    }
    public List<Comentario> obtenerComentario(int id_videojuego)
    {

        using (var db = new Mapeo())
        {
            return (from comentario in db.comentario
                    join usuario in db.user on comentario.Id_usuario equals usuario.Id_usuario
                    join juego in db.videojuego on comentario.Id_videojuego equals juego.Id_videojuego where juego.Id_videojuego == id_videojuego

                    select new
                    {
                       comentario,
                       usuario,
                       juego

                    }).ToList().Select(m => new Comentario
                    {
                        Id_usuario = m.usuario.Id_usuario,
                        Nickname = m.usuario.Nickname, 
                        Id_videojuego = m.juego.Id_videojuego,
                        Mensaje = m.comentario.Mensaje,
                       
                    }).ToList();
        }

    }
    public Comentario ValidacionComentario(Comentario comentario)
    {
        return new Mapeo().comentario.Where(x => x.Mensaje.Trim().ToUpper().Contains(comentario.Mensaje.Trim().ToUpper())).FirstOrDefault();
    }

}