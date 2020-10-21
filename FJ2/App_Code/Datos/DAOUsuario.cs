using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOUsuario
/// </summary>

public class DAOUsuario
{
    public Usuario login(Usuario usuario)
    {
        return new Mapeo().user.Where(x => x.Nickname.ToUpper().Equals(usuario.Nickname.ToUpper()) && x.Contraseña.Equals(usuario.Contraseña)).FirstOrDefault();
        //return new Mapeo().user.FirstOrDefault();
    }
    public void insertUsuario(Usuario usuario)
    {
        using (var db = new Mapeo())
        {
            db.user.Add(usuario);
            db.SaveChanges();
        }
    }
    public Usuario ValidacionUsuario(Usuario usuario)
    {
        return new Mapeo().user.Where(x => x.Nickname.Trim().ToUpper().Contains(usuario.Nickname.Trim().ToUpper())|| x.Correo.Trim().ToUpper().Contains(usuario.Correo.Trim().ToUpper())).FirstOrDefault();
    }

    public void updateUsuario(Usuario usuario)
    {
        using (var db = new Mapeo())
        {
            Usuario usuarioAnterior = db.user.Where(x => x.Id_usuario == usuario.Id_usuario).First();
            usuarioAnterior.Correo = usuario.Correo;
            usuarioAnterior.Nombre = usuario.Nombre;
            usuarioAnterior.Nickname = usuario.Nickname;
            usuarioAnterior.Imagen = usuario.Imagen;
       
            db.user.Attach(usuarioAnterior);

            var entry = db.Entry(usuarioAnterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
/*
    public Usuario obtenerUsuario(Usuario usuario)
    {
        return new Mapeo().user.Where(;
    }*/

}