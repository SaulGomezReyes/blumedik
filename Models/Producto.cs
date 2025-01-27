﻿using System;
using System.Collections.Generic;

namespace wablumedik.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public virtual ICollection<DetallesPedido> DetallesPedidos { get; set; } = new List<DetallesPedido>();

    public virtual ICollection<ProductosCategoria> ProductosCategoria { get; set; } = new List<ProductosCategoria>();
}
