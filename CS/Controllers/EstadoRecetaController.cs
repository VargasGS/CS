using Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS.Controllers
{
    [Route("estadoreceta")]
    [ApiController]
    public class EstadoRecetaController : ControllerBase
    {
        protected readonly IEstadoRecetaService service;

        public EstadoRecetaController(IEstadoRecetaService service) : base()
        {
            this.service = service;
        }

        [HttpGet]
        [Route("listEstadoReceta")]
        public async Task<IActionResult> listEstadoReceta()
        {
            var ListadoEstadoDocumento = await service.getAllEstadoReceta();
            return Ok(ListadoEstadoDocumento);
        }

    }
}
