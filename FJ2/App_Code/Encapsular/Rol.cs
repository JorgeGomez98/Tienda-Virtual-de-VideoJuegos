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
[Table("rol", Schema = "GST")]
public class Rol
{
    [Key]
    [Column("id_rol")]
    public int Id_rol { get; set; }

    [Column("descripcion")]
    public string Descripcion { get; set; }
}