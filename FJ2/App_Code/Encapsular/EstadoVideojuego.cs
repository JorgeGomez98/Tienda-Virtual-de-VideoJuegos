using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Estado
/// </summary>
[Serializable]
[Table("estadoVideojuego", Schema = "GST")]
public class EstadoVideojuego
{
    private int id_estadoV;
    private string descripcion;

    [Key]
    [Column("id_estadoV")]
    public int Id_estadoV { get => id_estadoV; set => id_estadoV = value; }
    [Column("descripcion")]
    public string Descripcion { get => descripcion; set => descripcion = value; }
}