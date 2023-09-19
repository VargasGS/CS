using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Application
{
    public interface ILugarAtencionService
    {
        Task<IEnumerable<LugarAtencionDTO>> getAllLugarAtencion();
    }
}
