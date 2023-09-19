using Domain.Interfaces.Infrastructure;
using Domain.Entiti;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class LugarRetiroRepository : ILugarRetiroRepository
    {
        private readonly CoopesaludActivacionRecetaContext contextoBD;

        public LugarRetiroRepository(CoopesaludActivacionRecetaContext contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        public async Task<IEnumerable<LugarRetiro>> getAllLugarRetiro()
        {
            try
            {
                IEnumerable<LugarRetiro> query = contextoBD.LugarRetiro;
                return query;
            }
            catch (Exception)
            {

                throw;
            }
          
        }

    }
}
