using System;
using System.Collections.Generic;

namespace wablumedik.Models;

public partial class ProductosCategoria
{
    public int Id { get; set; }

    public int? ProductoId { get; set; }

    public int? CategoriaId { get; set; }

    public virtual Categoria? Categoria { get; set; }

    public virtual Producto? Producto { get; set; }
}
