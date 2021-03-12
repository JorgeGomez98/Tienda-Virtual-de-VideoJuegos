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
[Table("categoria",Schema= "GST")]
public class Categorias
{
    private int id_categoria;
    private string categoria;

    [Key]
    [Column("id_categoria")]
    public int Id_categoria { get => id_categoria; set => id_categoria = value; }
    [Column("categoria")]
    public string Categoria { get => categoria; set => categoria = value; }
}