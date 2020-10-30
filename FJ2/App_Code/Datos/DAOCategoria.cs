using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOCategoria
/// </summary>
public class DAOCategoria
{
    public List<Categorias> obtenerCategoriasTabla()
    {
        return new Mapeo().cat.OrderBy(x => x.Categoria).ToList<Categorias>();
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

    public void insertarCategoria(Categorias categorias)
    {
        using (var db = new Mapeo())
        {
            db.cat.Add(categorias);
            db.SaveChanges();
        }
    }

    public void deleteCategoria(Categorias categorias)
    {
        using (var db = new Mapeo())
        {
            Categorias categoria = db.cat.Where(x => x.Id_categoria == categorias.Id_categoria).First();
            db.cat.Remove(categoria);
            db.SaveChanges();
        }
    }

    public void updateCategoria(Categorias categorias)
    {
        using (var db = new Mapeo())
        {
            Categorias catAnterior = db.cat.Where(x => x.Id_categoria == categorias.Id_categoria).First();
            catAnterior.Categoria = categorias.Categoria;
            db.cat.Attach(catAnterior);

            var entry = db.Entry(catAnterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}