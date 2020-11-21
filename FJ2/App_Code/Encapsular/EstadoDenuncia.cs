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
[Table("estadoDenuncia", Schema = "fj2")]
public class EstadoDenuncia
{
    private int id_estadoD;
    private string descripcion;

    [Key]
    [Column("id_estadoDenuncia")]
    public int Id_estadoD { get => id_estadoD; set => id_estadoD = value; }
    [Column("descripcion")]
    public string Descripcion { get => descripcion; set => descripcion = value; }
}