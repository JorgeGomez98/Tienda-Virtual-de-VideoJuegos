using System.Linq;

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

    public Administrador loginAdmin(Administrador administrador)
    {
        return new Mapeo().admin.Where(y => y.Nickname.ToUpper().Equals(administrador.Nickname.ToUpper()) && y.Contraseña.Equals(administrador.Contraseña)).FirstOrDefault();
        //return new Mapeo().user.FirstOrDefault();

    }

    public Moderador loginModerador(Moderador moderador)
    {
        return new Mapeo().mod.Where(z => z.Nickname.ToUpper().Equals(moderador.Nickname.ToUpper()) && z.Contraseña.Equals(moderador.Contraseña)).FirstOrDefault();
        //return new Mapeo().user.FirstOrDefault();

    }
}