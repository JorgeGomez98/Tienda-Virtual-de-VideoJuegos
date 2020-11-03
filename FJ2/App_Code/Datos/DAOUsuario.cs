using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
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

    public bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        try
        {
            // Normalize the domain
            email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                  RegexOptions.None, TimeSpan.FromMilliseconds(200));

            // Examines the domain part of the email and normalizes it.
            string DomainMapper(Match match)
            {
                // Use IdnMapping class to convert Unicode domain names.
                var idn = new IdnMapping();

                // Pull out and process domain name (throws ArgumentException on invalid)
                string domainName = idn.GetAscii(match.Groups[2].Value);

                return match.Groups[1].Value + domainName;
            }
        }
        catch (RegexMatchTimeoutException e)
        {
            return false;
        }
        catch (ArgumentException e)
        {
            return false;
        }

        try
        {
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }
        catch (RegexMatchTimeoutException)
        {
            return false;
        }
    }

    public List<Usuario> obtenerUsuarioTabla()
    {
        return new Mapeo().user.OrderBy(x => x.Nickname).ToList<Usuario>();
    }

    public List<Usuario> obtenerUsuario()
    {
        using (var db = new Mapeo())
        {
            return (from u in db.user
                    join r in db.rol on u.Id_rol equals r.Id_rol
                    select new
                    {
                        u,
                        r.Descripcion
                    }).ToList().Select(m => new Usuario
                    {
                        Id_usuario = m.u.Id_usuario,
                        Id_rol = m.u.Id_rol,
                        Imagen = m.u.Imagen,
                        Nickname = m.u.Nickname,
                        NombreRol = m.Descripcion,
                        Nombre = m.u.Nombre,
                        Correo = m.u.Correo,
                    }).OrderBy(x => x.Nickname).ToList();
        }
    }

    public void deleteUsuario(Usuario usuarios)
    {
        using (var db = new Mapeo())
        {
            Usuario usuario = db.user.Where(x => x.Id_usuario == usuarios.Id_usuario).First();
            db.user.Remove(usuario);
            db.SaveChanges();
        }
    }
}