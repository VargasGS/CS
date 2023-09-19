using System;
using System.Collections.Generic;

namespace Domain.DTO;

public  class LugarAtencionDTO
{
    public int IdAtencion{ get; set; }

    public string? NombreLugar { get; set; }

    public virtual ICollection<ActivacionRecetaDTO> ActivacionReceta { get; set; } = new List<ActivacionRecetaDTO>();
}
