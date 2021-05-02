using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOSeguridad
/// </summary>
public class DAOSeguridad
{
    public void insertarToken(token token)
    {
        using (var db = new Mapeo())
        {
            db.token.Add(token);
            db.SaveChanges();
        }
    }

    public token getTokenByUser(int userId)
    {
        return new Mapeo().token.Where(x => x.UserId == userId && x.Vigencia > DateTime.Now).FirstOrDefault();
    }

    public token getTokenByToken(string token)
    {
        return new Mapeo().token.Where(x => x.TokenGenerado == token).FirstOrDefault();
    }

    public void updateClave(Usuario usuario)
    {
        using (var db = new Mapeo())
        {
            Usuario usuarioAnterior = db.user.Where(x => x.Id_usuario == usuario.Id_usuario).First();
            usuarioAnterior.Contraseña = usuario.Contraseña;

            db.user.Attach(usuarioAnterior);

            var entry = db.Entry(usuarioAnterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}