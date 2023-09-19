using System;
using System.Collections.Generic;

namespace Domain.DTO;

public class EstadoRecetaDTO
{
    public int IdEstadoReceta { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<ActivacionRecetaDTO> ActivacionReceta { get; set; } = new List<ActivacionRecetaDTO>();
}
