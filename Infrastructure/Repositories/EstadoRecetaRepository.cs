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
    public class EstadoRecetaRepository : IEstadoRecetaRepository
    {
        private readonly CoopesaludActivacionRecetaContext contextoBD;

        public EstadoRecetaRepository(CoopesaludActivacionRecetaContext contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        public async Task<IEnumerable<EstadoReceta>> getAllEstadoReceta()
        {
            try
            {
                IEnumerable<EstadoReceta> query = contextoBD.EstadoReceta;
                return query;
            }
            catch (Exception)
            {

                throw;
            }
          
        }

    }
}
