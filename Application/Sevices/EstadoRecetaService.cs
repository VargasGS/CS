using AutoMapper;
using Domain.DTO;
using Domain.Interfaces.Application;
using Domain.Interfaces.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Sevices
{
    public class EstadoRecetaService : IEstadoRecetaService
    {

        public readonly IMapper _mapper;
        public readonly IEstadoRecetaRepository _estadoRecetaRepository;


        public EstadoRecetaService(IEstadoRecetaRepository estadoRecetaRepository, IMapper mapper) : base()
        {
            this._estadoRecetaRepository = estadoRecetaRepository;
            this._mapper = mapper;

        }
        public async Task<IEnumerable<EstadoRecetaDTO>> getAllEstadoReceta()
        {
            var entity = await _estadoRecetaRepository.getAllEstadoReceta();
            return _mapper.Map<IEnumerable<EstadoRecetaDTO>>(entity);

        }
    }
}
