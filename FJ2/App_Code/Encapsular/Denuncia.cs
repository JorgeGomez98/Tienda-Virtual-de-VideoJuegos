using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Categoria
/// </summary>
[Serializable]
[Table("denuncia", Schema = "fj2")]
public class Denuncias
{
    private int id_denuncia;
    private int id_estadodenucnia;
    private string mensaje;
    private int id_usuario;

    [Key]
    [Column("id_denuncia")]
    public int Id_denuncia { get => id_denuncia; set => id_denuncia = value; }
    [Column("id_estadoDenuncia")]
    public int Id_estadodenucnia { get => id_estadodenucnia; set => id_estadodenucnia = value; }
    [Column("mensaje")]
    public string Mensaje { get => mensaje; set => mensaje = value; }
    [Column("id_usuario")]
    public int Id_usuario { get => id_usuario; set => id_usuario = value; }

}