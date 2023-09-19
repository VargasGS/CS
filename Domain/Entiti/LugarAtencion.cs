using System;
using System.Collections.Generic;

namespace Domain.Entiti;

public  class LugarAtencion
{
    public int IdAtencion { get; set; }

    public string? NombreLugar { get; set; }

    public virtual ICollection<ActivacionReceta> ActivacionReceta { get; set; } = new List<ActivacionReceta>();
}
