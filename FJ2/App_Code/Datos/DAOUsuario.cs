using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

}