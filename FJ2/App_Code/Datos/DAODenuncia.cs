using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAODenuncia
/// </summary>
public class DAODenuncia
{
    public void insertarDenuncia(Denuncias denuncias)
    {
       
        
        using (var db = new Mapeo())
            {
                db.Denuncias.Add(denuncias);
                db.SaveChanges();
            }
        
    }
    
    public List<Denuncias> obtenerDenuncias()
    {

        using (var db = new Mapeo())
        {
            return (from denuncia in db.Denuncias
                    join estado in db.estadoDenuncias on denuncia.Id_estadodenucnia equals estado.Id_estadoD
                    join persona in db.user on denuncia.Id_usuario equals persona.Id_usuario
                    join juego in db.videojuego on denuncia.Id_videojuego equals juego.Id_videojuego
                    select new
                    {
                        denuncia,
                        estado,
                        persona,
                        juego
                    }).ToList().Select(m => new Denuncias
                    {
                        Id_denuncia = m.denuncia.Id_denuncia,
                        Id_videojuego = m.denuncia.Id_videojuego,
                        Id_estadodenucnia = m.denuncia.Id_estadodenucnia,
                        Mensaje = m.denuncia.Mensaje,
                        Id_usuario = m.denuncia.Id_usuario,
                        Nombre_usuario=m.persona.Nombre,
                        Nombre_estado=m.estado.Descripcion,
                        Nombre_videojuego=m.juego.Nom_juego

                    }).ToList();
        }

    }
    public List<EstadoDenuncia> obtenerEstado()
    {

        using (var db = new Mapeo())
        {
            return (from estado in db.estadoDenuncias
                  
                    select new
                    {   
                        estado,                  
                    }).ToList().Select(m => new EstadoDenuncia
                    {
                       Id_estadoD = m.estado.Id_estadoD,                 
                        Descripcion = m.estado.Descripcion

                    }).ToList();
        }

    }

    public void actualizarDenuncia(Denuncias denuncia)
    {
        using (var db = new Mapeo())
        {
            db.Denuncias.Attach(denuncia);

            var entry = db.Entry(denuncia);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}