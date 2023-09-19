using System;
using System.Collections.Generic;

namespace Domain.Entiti;

public  class EstadoReceta
{
    public int IdEstadoReceta { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<ActivacionReceta> ActivacionReceta { get; set; } = new List<ActivacionReceta>();
}
