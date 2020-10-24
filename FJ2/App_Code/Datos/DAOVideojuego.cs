using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOVideojuego
/// </summary>
public class DAOVideojuego
{
    public List <Videojuego> obtenerVideojuego()
    {
        using (var db = new Mapeo())
        {
            //v = videojuego
            //e= estado
            return (from v in db.videojuego
                    join e in db.estado on v.Id_estadoV equals e.Id_estadoV
                    //where ((p.CategoriaId == categoriaId) || (categoriaId == 0))
                    select new
                    {
                        v,
                        e.Descripcion

                    }).Select(m => new Videojuego
                    {
                        Id_videojuego = m.v.Id_videojuego,
                        Nom_juego = m.v.Nom_juego,
                        Categoría = m.v.Categoría,
                        Precio = m.v.Precio,
                        DescripcionV = m.Descripcion,
                        Cantidad = m.v.Cantidad,

                    }).OrderBy(x => x.Nom_juego).ToList();
        }
         
    }

    
}