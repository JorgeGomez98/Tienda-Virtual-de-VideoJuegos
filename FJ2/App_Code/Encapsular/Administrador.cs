using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Administrador
/// </summary>

[Serializable]
[Table("administrador", Schema = "fj2")]
public class Administrador
{
    private int id_administrador;
    private string nombre;
    private string nickname;
    private string contraseña;
    private int id_rol;
    private string correo;

    [Key]
    [Column("id_administrador")]
    public int Id_administrador { get => id_administrador; set => id_administrador = value; }
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