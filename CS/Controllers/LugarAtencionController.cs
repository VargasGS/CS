using Domain.Interfaces.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CS.Controllers
{
    [Route("lugaratencion")]
    [ApiController]
    public class LugarAtencionController : ControllerBase
    {
        protected readonly ILugarAtencionService service;

        public LugarAtencionController(ILugarAtencionService service) : base()
        {
            this.service = service;
        }

        [HttpGet]
        [Route("listLugarAtencion")]
        public async Task<IActionResult> listLugarAtencion()
        {
            var ListadoLugarAtencion = await service.getAllLugarAtencion();
            return Ok(ListadoLugarAtencion);
        }
    }
}
