using System;
using System.Collections.Generic;
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
}