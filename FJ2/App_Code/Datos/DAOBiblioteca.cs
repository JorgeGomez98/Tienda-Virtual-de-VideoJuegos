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
            agregar.Cantidad = juego.Cantidad;
            db.lib.Add(agregar);
            db.SaveChanges();
        }

    }

  
    public int cantidadbilioteca(int UsuarioId)
    {
        using (var db = new Mapeo())
        {


            return db.lib.Where(x => x.Id_usuario == UsuarioId).Count();
        }

    }
}