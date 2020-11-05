using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Biblioteca
/// </summary>
[Serializable]
[Table("biblioteca", Schema = "fj2")]
public class Biblioteca
{
    private bool favorito;
    private bool deseado;
    private bool poseido;
    private int id_usuario;
    private int id_videojuego;   

    [Key]
    [Column("favorito")]
    public bool Favorito { get => favorito; set => favorito = value; }
    [Column("deseado")]
    public bool Deseado { get => deseado; set => deseado = value; }
    [Column("id_usuario")]
    public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    [Column("id_videojuego")]
    public int Id_videojuego { get => id_videojuego; set => id_videojuego = value; }
    [Column("poseido")]
    public bool Poseido { get => poseido; set => poseido = value; }
}