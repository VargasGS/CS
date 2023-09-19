using Domain.Interfaces.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CS.Controllers
{
    [Route("lugarretiro")]
    [ApiController]
    public class LugarRetiroController : ControllerBase
    {
        protected readonly ILugarRetiroService service;

        public LugarRetiroController(ILugarRetiroService service) : base()
        {
            this.service = service;
        }

        [HttpGet]
        [Route("listLugarRetiro")]
        public async Task<IActionResult> listLugarRetiro()
        {
            var ListadoLugarRetiro= await service.getAllLugarRetiro();
            return Ok(ListadoLugarRetiro);
        }
    }
}
