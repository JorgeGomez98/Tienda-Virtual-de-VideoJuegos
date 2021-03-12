using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Comentario
/// </summary>
/// [Serializable]
[Table("comentario", Schema = "GST")]
public class Comentario
{
    private int id_videojuego;
    private int id_usuario;
    private string mensaje;
    private string nickname;

    [Column("id_videojuego")]
    public int Id_videojuego { get => id_videojuego; set => id_videojuego = value; }
    [Column("id_usuario")]
    public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    [Key]
    [Column("mensaje")]
    public string Mensaje { get => mensaje; set => mensaje = value; }
    [NotMapped]
    public string Nickname { get => nickname; set => nickname = value; }

}