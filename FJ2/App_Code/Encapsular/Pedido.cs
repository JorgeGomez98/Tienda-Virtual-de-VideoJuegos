using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Pedido
/// </summary>
[Serializable]
[Table("pedido", Schema = "financiero")]
public class Pedido
{
    private int id_pedido;
    private int id_usuario;
    private DateTime fecha;    
    private double valor_total;

    private string nickname;
    private string nom_videojuego;
    private List<DetallePedido> compras;

    [Key]
    [Column("id_pedido")]
    public int Id_pedido { get => id_pedido; set => id_pedido = value; }
    [Column("id_usuario")]
    public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    [Column("fecha")]
    public DateTime Fecha { get => fecha; set => fecha = value; }
    [Column("valor_total")]
    public double Valor_total { get => valor_total; set => valor_total = value; }
    [NotMapped]
    public string Nickname { get => nickname; set => nickname = value; }
    [NotMapped]
    public string Nom_videojuego { get => nom_videojuego; set => nom_videojuego = value; }
    [NotMapped]
    public List<DetallePedido> Compras { get => compras; set => compras = value; }
}