using System;
using System.Collections.Generic;

namespace Domain.Entiti;

public  class ActivacionReceta
{
    public int IdReceta { get; set; }

    public string LugarReceta { get; set; } = null!;

    public string Cedula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime? FechaRegistroComprobante { get; set; }

    public DateTime? FechaAtencion { get; set; }

    public int? IdLugarRetiro { get; set; }

    public int? IdEstadoReceta { get; set; }

    public virtual EstadoReceta? IdEstadoRecetaNavigation { get; set; }

    public virtual LugarRetiro? IdLugarRetiroNavigation { get; set; }
}
