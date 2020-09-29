using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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

    protected override void OnModelCreating(DbModelBuilder builder)
    {
        builder.HasDefaultSchema("public");

        base.OnModelCreating(builder);
    }
}