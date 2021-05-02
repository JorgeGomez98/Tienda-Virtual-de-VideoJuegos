using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de token
/// </summary>
/// 
[Serializable]
[Table("token_recuperacion", Schema = "seguridad")]
public class token
{
    private int id;
    private int userId;
    private string tokenGenerado;
    private DateTime creacion;
    private DateTime vigencia;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("user_id")]
    public int UserId { get => userId; set => userId = value; }
    [Column("token")]
    public string TokenGenerado { get => tokenGenerado; set => tokenGenerado = value; }
    [Column("fecha_creacion")]
    public DateTime Creacion { get => creacion; set => creacion = value; }
    [Column("fecha_vigencia")]
    public DateTime Vigencia { get => vigencia; set => vigencia = value; }

}