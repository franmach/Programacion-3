using System;
using System.Collections.Generic;

namespace practico8AccesoADatos.Models;

public partial class Pelicula
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public int Anio { get; set; }

    public int Calificacion { get; set; }

    public virtual ICollection<Copia> Copia { get; set; } = new List<Copia>();
}
