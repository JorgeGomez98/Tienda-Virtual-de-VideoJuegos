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
[Table("detalle_pedido", Schema = "financiero")]
public class DetallePedido
{
    private int id;
    private int id_pedido;
    private int id_videojuego;
    private int cantidad;
    private double valorUnitario;
    private double valorTotal;

    private string nombreJuego;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("id_pedido")]
    public int Id_pedido { get => id_pedido; set => id_pedido = value; }
    [Column("id_videojuego")]
    public int Id_videojuego { get => id_videojuego; set => id_videojuego = value; }
    [Column("cantidad")]
    public int Cantidad { get => cantidad; set => cantidad = value; }
    [Column("precio_unitario")]
    public double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
    [Column("precio_total")]
    public double ValorTotal { get => valorTotal; set => valorTotal = value; }
    [NotMapped]
    public string NombreJuego { get => nombreJuego; set => nombreJuego = value; }
}