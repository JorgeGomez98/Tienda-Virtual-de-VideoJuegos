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
    private int id_videojuego,id,cantidad,id_estado;
    private string nombre_estado, nom_juego, descripcion;
    private string imagen;
    private double precio;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
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
    [Column("cantidad")]
    public int Cantidad { get => cantidad; set => cantidad = value; }
    [NotMapped]
    public int Id_estado { get => id_estado; set => id_estado = value; }
    [NotMapped]
    public string Nombre_estado { get => nombre_estado; set => nombre_estado = value; }
    [NotMapped]
    public string Nom_juego { get => nom_juego; set => nom_juego = value; }
    [NotMapped]
    public string Descripcion { get => descripcion; set => descripcion = value; }
    [NotMapped]
    public double Precio { get => precio; set => precio = value; }
    [NotMapped]
    public string Imagen { get => imagen; set => imagen = value; }

    
}