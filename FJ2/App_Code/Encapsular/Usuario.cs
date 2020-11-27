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

    private int id_usuario;
    private string nombre;
    private string nickname;
    private string contraseña;
    private int id_rol;
    private string correo;
    private string imagen;
    private string nombreRol;

    [Key]
    [Column("id_usuario")]
    public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    
    [Column("nombre")]
    public string Nombre { get => nombre; set => nombre = value; }

    [Column("nickname")]
    public string Nickname { get => nickname; set => nickname = value; }

    [Column("contraseña")]
    public string Contraseña { get => contraseña; set => contraseña = value; }

    [Column("id_rol")]
    public int Id_rol { get => id_rol; set => id_rol = value; }

    [Column("correo")]
    public string Correo { get => correo; set => correo = value; }

    [Column("imagen")]
    public string Imagen { get => imagen; set => imagen = value; }

    [NotMapped]
    public string NombreRol { get => nombreRol; set => nombreRol = value; }

    
}
