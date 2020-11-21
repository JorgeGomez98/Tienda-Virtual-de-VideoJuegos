using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Descripción breve de DAOBiblioteca
/// </summary>
public class DAOBiblioteca
{
    public void insertBiblioteca(Videojuego videojuego,Usuario usuario)
    {
        Biblioteca nuevo = new Biblioteca();
        nuevo.Id_videojuego = videojuego.Id_videojuego;
        nuevo.Id_usuario = usuario.Id_usuario;
        using (var db = new Mapeo())
        {
            db.videojuego.Add(videojuego);
            db.SaveChanges();
        }
    }

    public void agregarBiblioteca(Videojuego juego, int UsuarioId)
    {
        using (var db = new Mapeo())
        {
            Biblioteca agregar = new Biblioteca();
            agregar.Id_usuario = UsuarioId;
            agregar.Id_videojuego = juego.Id_videojuego;
            //agregar.Cantidad = juego.Cantidad;
            agregar.Poseido = false;
            agregar.Deseado = false;
            db.lib.Add(agregar);
            db.SaveChanges();
        }

    }

  
    public int cantidadbilioteca(int UsuarioId)
    {
        using (var db = new Mapeo())
        {


            return db.lib.Where(x => x.Id_usuario == UsuarioId && x.Poseido == false).Count();
        }

    }

    public List<Videojuego> obtenerBiblioteca(int id_categoria,int id_usuario)
    {

        using (var db = new Mapeo())
        {
            return (from v in db.videojuego
                    join c in db.cat on v.Id_categoría equals c.Id_categoria
                    join l in db.lib on v.Id_videojuego equals l.Id_videojuego
                    where ((v.Id_categoría == id_categoria) || (id_categoria == 0) && l.Poseido == true && l.Id_usuario == id_usuario )
                    select new
                    {
                        v,
                        l,
                        c.Categoria
                    }).ToList().Select(m => new Videojuego
                    {
                        Id_videojuego = m.v.Id_videojuego,
                        Id_categoría = m.v.Id_categoría,
                        Imagen = m.v.Imagen,
                        Nom_juego = m.v.Nom_juego,
                        Descripcion = m.v.Descripcion,
                        Categoria = m.Categoria,
                        
                    }).OrderBy(x => x.Nom_juego).ToList();
        }

    }

    public Biblioteca obtenerVideojuego(int id_juego, int id_usuario)
    {
        using ( var db = new Mapeo())
        {
            return (from b in db.lib
                    join v in db.videojuego on b.Id_videojuego equals v.Id_videojuego
                    join u in db.user on b.Id_usuario equals u.Id_usuario
                    where (b.Id_usuario == id_usuario && b.Id_videojuego == id_juego)
                    select new
                    {
                        b,
                        v.Id_videojuego,
                        u.Id_usuario
                    }

                    ).ToList().Select(m => new Biblioteca
                    {
                        Id_videojuego = m.Id_videojuego,
                        Id_usuario = m.Id_usuario,
                        Poseido = m.b.Poseido,
                        Nom_juego = m.b.Nom_juego
                    }).FirstOrDefault();
        }
    }
}