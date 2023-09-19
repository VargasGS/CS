using Domain.DTO;
using System;
using System.Collections.Generic;

namespace Domain.DTO;

public  class ActivacionRecetaDTO
{
    public int IdReceta { get; set; }

    public string LugarReceta { get; set; } = null!;

    public string Cedula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime? FechaRegistroComprobante { get; set; }

    public DateTime? FechaAtencion { get; set; }

    public int? IdLugarRetiro { get; set; }

    public int? IdEstadoReceta { get; set; }

    public virtual EstadoRecetaDTO? IdEstadoRecetaNavigation { get; set; }

    public virtual LugarRetiroDTO? IdLugarRetiroNavigation { get; set; }
}
