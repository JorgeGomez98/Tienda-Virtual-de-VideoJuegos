using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Rol
/// </summary>}
[Serializable]
[Table("rol", Schema = "fj2")]
public class Rol
{
    private int id_rol;
    private string descripcion;

    [Key]
    [Column("id_rol")]
    public int Id_rol { get => id_rol; set => id_rol = value; }
    [Column("descripcion")]
    public string Descripcion { get => descripcion; set => descripcion = value; }

}