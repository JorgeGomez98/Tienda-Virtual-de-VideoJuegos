using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOPlataforma
/// </summary>
public class DAOPlataforma
{
    public List<Plataforma> obtenerPlataformasTabla()
    {
        return new Mapeo().plat.OrderBy(x => x.PlataformaJuego).ToList<Plataforma>();
    }



    public List<Plataforma> obtenerPlataforma()
    {
        List<Plataforma> lista = new Mapeo().plat.ToList();
        Plataforma plataforma = new Plataforma();
        plataforma.Id_plataforma = 0;
        plataforma.PlataformaJuego = "--Seleccione--";
        lista.Add(plataforma);
        return lista.OrderBy(x => x.Id_plataforma).ToList();

    }

    public void insertarCategoria(Categorias categorias)
    {
        using (var db = new Mapeo())
        {
            db.cat.Add(categorias);
            db.SaveChanges();
        }
    }
}