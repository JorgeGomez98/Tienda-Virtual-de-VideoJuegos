using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Plataforma
/// </summary>
[Serializable]
[Table("plataforma", Schema = "fj2")]
public class Plataforma
{
    private int id_plataforma;
    private string plataformaJuego;

    [Key]
    [Column("id_plataforma")]
    public int Id_plataforma { get => id_plataforma; set => id_plataforma = value; }

    [Column("plataforma")]
    public string PlataformaJuego { get => plataformaJuego; set => plataformaJuego = value; }



}