using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Descripción breve de Moderador
/// </summary>
[Serializable]
[Table("moderador", Schema = "fj2")]
public class Moderador
{
    private int id_moderador;
    private string nombre;
    private string nickname;
    private string contraseña;
    private int id_rol;
    private string correo;

    [Key]
    [Column("id_moderador")]
    public int Id_moderador { get => id_moderador; set => id_moderador = value; }
    [Column("nombre")]
    public string Nombre { get => nombre; set => nombre = value; }
    [Column("nickname")]
    public string Nickname { get => nickname; set => nickname = value; }
    [Column("constraseña")]
    public string Contraseña { get => contraseña; set => contraseña = value; }
    [Column("id_rol")]
    public int Id_rol { get => id_rol; set => id_rol = value; }
    [Column("correo")]
    public string Correo { get => correo; set => correo = value; }
    
}