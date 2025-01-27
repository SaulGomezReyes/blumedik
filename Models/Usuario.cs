using System;
using System.Collections.Generic;

namespace wablumedik.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Appaterno { get; set; } = null!;

    public string Apmaterno { get; set; } = null!;
}
