using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
[Serializable]
[Table("usuario", Schema = "fj2")]
public class Usuario
{
    [Key]
    [Column("id_usuario")]
    public int Id_usuario { get; set; }

    [Column("nombre")]
    public string Nombre { get; set; }

    [Column("nickname")]
    public string Nickname { get; set; }

    [Column("contraseña")]
    public string Contraseña { get; set; }

    [Column("id_rol")]
    public int Id_rol { get; set; }

    [Column("correo")]
    public string Correo { get; set; }

    /*[NotMapped]
    public string NombreRol { get; set; }*/
}
