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
    public class LugarAtencionRepository : ILugarAtencionRepository
    {
        private readonly CoopesaludActivacionRecetaContext contextoBD;

        public LugarAtencionRepository(CoopesaludActivacionRecetaContext contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        public async Task<IEnumerable<LugarAtencion>> getAllLugarAtencion()
        {
            try
            {
                IEnumerable<LugarAtencion> query = contextoBD.LugarAtencion;
                return query;
            }
            catch (Exception)
            {

                throw;
            }
          
        }

    }
}
