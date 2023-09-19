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
    public class LugarRetiroService : ILugarRetiroService
    {

        public readonly IMapper _mapper;
        public readonly ILugarRetiroRepository _lugarRetiroRepository;


        public LugarRetiroService(ILugarRetiroRepository lugarRetiroRepository, IMapper mapper) : base()
        {
            this._lugarRetiroRepository = lugarRetiroRepository;
            this._mapper = mapper;

        }
        public async Task<IEnumerable<LugarRetiroDTO>> getAllLugarRetiro()
        {
            var entity = await _lugarRetiroRepository.getAllLugarRetiro();
            return _mapper.Map<IEnumerable<LugarRetiroDTO>>(entity);

        }
    }
}
