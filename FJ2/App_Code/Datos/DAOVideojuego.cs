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
                        Id_categoría = m.v.Id_categoría,
                        Precio = m.v.Precio,
                        DescripcionV = m.Descripcion,
                        Cantidad = m.v.Cantidad,

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

    

    public List<Categorias> obtenerCategorias()
    {
        List<Categorias> lista = new Mapeo().cat.ToList();
        Categorias categorias = new Categorias();
        categorias.Id_categoria = 0;
        categorias.Categoria = "--Seleccione--";
        lista.Add(categorias);
        return lista.OrderBy(x => x.Id_categoria).ToList();

    }
}