using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

[Serializable]
[Table("videojuego", Schema = "fj2")]
public class Videojuego
{
    private int id_videojuego;
    private int id_estadoV;
    private int id_categoría;
    private string nom_juego;    
    private double precio;    
    private string descripcionV;    
    private string descripcion;
    private string categoria;
    private int cantidad;
    private string imagen;
    private string nombre_estado;


    private string plataforma;


    


    [Key]
    [Column("id_videojuego")]
    public int Id_videojuego { get => id_videojuego; set => id_videojuego = value; }
    [Column("nom_juego")]
    public string Nom_juego { get => nom_juego; set => nom_juego = value; }
    [Column("id_categoria")]
    public int Id_categoría { get => id_categoría; set => id_categoría = value; }
    [Column("precio")]
    public double Precio { get => precio; set => precio = value; }
    [Column("id_estadoV")]
    public int Id_estadoV { get => id_estadoV; set => id_estadoV = value; }
    [Column("cantidad")]
    public int Cantidad { get => cantidad; set => cantidad = value; }
    [Column("imagen")]
    public string Imagen { get => imagen; set => imagen = value; }    
    [Column("descripcion")]
    public string Descripcion { get => descripcion; set => descripcion = value; }
    [NotMapped]
    public string DescripcionV { get => descripcionV; set => descripcionV = value; }
    [NotMapped]
    public string Categoria { get => categoria; set => categoria = value; }
    [NotMapped]
    public string Nombre_estado { get => nombre_estado; set => nombre_estado = value; }


    [NotMapped]
    public string Plataforma { get => plataforma; set => plataforma = value; }


    


    public static implicit operator Videojuego(string v)
    {
        throw new NotImplementedException();
    }
}
