using Domain.Entiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Infrastructure
{
    public interface ILugarRetiroRepository
    {
        Task<IEnumerable<LugarRetiro>> getAllLugarRetiro();
    }
}
