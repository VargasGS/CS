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
    public class LugarAtencionService : ILugarAtencionService
    {

        public readonly IMapper _mapper;
        public readonly ILugarAtencionRepository _lugarAtencionRepository;


        public LugarAtencionService(ILugarAtencionRepository lugarAtencionRepository, IMapper mapper) : base()
        {
            this._lugarAtencionRepository = lugarAtencionRepository;
            this._mapper = mapper;

        }
        public async Task<IEnumerable<LugarAtencionDTO>> getAllLugarAtencion()
        {
            var entity = await _lugarAtencionRepository.getAllLugarAtencion();
            return _mapper.Map<IEnumerable<LugarAtencionDTO>>(entity);

        }
    }
}
