using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOVideojuego
/// </summary>
public class DAOVideojuego
{
    public List<Videojuego> obtenerVideojuegoTabla()
    {
        return new Mapeo().videojuego.OrderBy(x => x.Nom_juego).ToList<Videojuego>();
    }

    public List <Videojuego> obtenerVideojuego()
    {
        
            using (var db = new Mapeo())
            {
                return (from v in db.videojuego
                        join c in db.cat on v.Id_categoría equals c.Id_categoria
                        join e in db.estado on v.Id_estadoV equals e.Id_estadoV
                        select new
                        {
                            v,
                            e.Descripcion,
                            c.Categoria
                        }).ToList().Select(m => new Videojuego
                        {
                            Id_estadoV = m.v.Id_estadoV,
                            Id_videojuego = m.v.Id_videojuego,
                            Id_categoría = m.v.Id_categoría,
                            Imagen = m.v.Imagen,
                            Nom_juego = m.v.Nom_juego,
                            DescripcionV = m.Descripcion,
                            Descripcion = m.v.Descripcion,
                            Categoria = m.Categoria,
                            Precio = m.v.Precio,
                            Cantidad = m.v.Cantidad
                        }).OrderBy(x => x.Nom_juego).ToList();
            }
         
    }
    
    public List<Videojuego> obtenerCatalogo(int id_categoria)
    {

        using (var db = new Mapeo())
        {
            return (from v in db.videojuego
                    join c in db.cat on v.Id_categoría equals c.Id_categoria
                    join e in db.estado on v.Id_estadoV equals e.Id_estadoV
                    where ((v.Id_categoría == id_categoria) || (id_categoria == 0))
                    select new
                    {
                        v,
                        e.Descripcion,
                        c.Categoria
                    }).ToList().Select(m => new Videojuego
                    {
                        Id_estadoV = m.v.Id_estadoV,
                        Id_videojuego = m.v.Id_videojuego,
                        Id_categoría = m.v.Id_categoría,
                        Imagen = m.v.Imagen,
                        Nom_juego = m.v.Nom_juego,
                        DescripcionV = m.Descripcion,
                        Descripcion = m.v.Descripcion,
                        Categoria = m.Categoria,
                        Precio = m.v.Precio,
                        Cantidad = m.v.Cantidad
                    }).OrderBy(x => x.Nom_juego).ToList();
        }

    }
    
    public void insertJuego(Videojuego juego)
    {
        using (var db = new Mapeo())
        {
            db.videojuego.Add(juego);
            db.SaveChanges();
        }
    }

    public void updateVideojuego(Videojuego juego)
    {
        using (var db = new Mapeo())
        {
            Videojuego juegoAnterior = db.videojuego.Where(x => x.Id_videojuego == juego.Id_videojuego).First();
            juegoAnterior.Descripcion = juego.Descripcion;
            db.videojuego.Attach(juegoAnterior);

            var entry = db.Entry(juegoAnterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }

    public void deleteJuego(Videojuego juego)
    {
        using (var db = new Mapeo())
        {
            Videojuego videoJuego = db.videojuego.Where(x => x.Id_videojuego == juego.Id_videojuego).First();
            db.videojuego.Remove(videoJuego);
            db.SaveChanges();
        }
    }

    public Videojuego ValidacionVideojuego(Videojuego videoJuego)
    {
        return new Mapeo().videojuego.Where(x => x.Nom_juego.Trim().ToUpper().Contains(videoJuego.Nom_juego.Trim().ToUpper()) || x.Descripcion.Trim().ToUpper().Contains(videoJuego.Descripcion.Trim().ToUpper())).FirstOrDefault();
    }
}