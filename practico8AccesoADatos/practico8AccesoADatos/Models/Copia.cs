using System;
using System.Collections.Generic;

namespace practico8AccesoADatos.Models;

public partial class Copia
{
    public int Id { get; set; }

    public int IdPelicula { get; set; }

    public bool Deteriorada { get; set; }

    public string? Formato { get; set; }

    public double PrecioAlquiler { get; set; }

    public virtual ICollection<Alquilere> Alquileres { get; set; } = new List<Alquilere>();

    public virtual Pelicula IdPeliculaNavigation { get; set; } = null!;
}
