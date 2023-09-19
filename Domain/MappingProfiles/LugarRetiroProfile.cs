using AutoMapper;
using Domain.DTO;
using Domain.Entiti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE.Catalogos.Services.Infrastructure.MappingProfiles
{
    public class LugarRetiroProfile : Profile
    {
        public LugarRetiroProfile()
        {
            CreateMap<LugarRetiro, LugarRetiroDTO>()
                .ReverseMap();

        }
    }
}
