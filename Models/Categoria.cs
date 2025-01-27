using System;
using System.Collections.Generic;

namespace wablumedik.Models;

public partial class Categoria
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<ProductosCategoria> ProductosCategoria { get; set; } = new List<ProductosCategoria>();
}
