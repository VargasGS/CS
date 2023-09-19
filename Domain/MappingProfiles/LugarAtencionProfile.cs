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
    public class LugarAtencionProfile : Profile
    {
        public LugarAtencionProfile()
        {
            CreateMap<LugarAtencion, LugarAtencionDTO>()
                .ReverseMap();

        }
    }
}
