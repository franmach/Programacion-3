using System;
using System.Collections.Generic;

namespace practico8AccesoADatos.Models;

public partial class Alquilere
{
    public int Id { get; set; }

    public int IdCopia { get; set; }

    public int IdCliente { get; set; }

    public DateTime FechaAlquiler { get; set; }

    public DateTime FechaTope { get; set; }

    public DateTime FechaEntregada { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Copia IdCopiaNavigation { get; set; } = null!;
}
