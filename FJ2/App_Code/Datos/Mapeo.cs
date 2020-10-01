using System.Data.Entity;

/// <summary>
/// Descripción breve de Mapeo
/// </summary>
public class Mapeo : DbContext
{
    static Mapeo()
    {
        Database.SetInitializer<Mapeo>(null);
    }

    public Mapeo() : base("name=bd_inicial")
    {

    }

    public DbSet<Usuario> user { get; set; }
    public DbSet<Administrador> admin { get; set; }
    public DbSet<Moderador> mod { get; set; }
    public DbSet<Rol> rol { get; set; }
    


    protected override void OnModelCreating(DbModelBuilder builder)
    {
        builder.HasDefaultSchema("public");

        base.OnModelCreating(builder);
    }
}