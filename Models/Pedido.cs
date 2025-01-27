using System;
using System.Collections.Generic;

namespace wablumedik.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public int? ClienteId { get; set; }

    public DateTime? FechaPedido { get; set; }

    public decimal Total { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<DetallesPedido> DetallesPedidos { get; set; } = new List<DetallesPedido>();
}
