using InjecaoDependencia.API.Models;
using InjecaoDependencia.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependencia.API.Controllers
{
    [ApiController]
    [Route("api/injecaoDepencia")]
    public class InjecaoDependenciaController : ControllerBase
    {
        private readonly ObjetoDI _obejtoDI;
        private readonly TesteService _testeService;

        public InjecaoDependenciaController(ObjetoDI obejtoDI, TesteService testeService)
        {
            _obejtoDI = obejtoDI;
            _testeService = testeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _obejtoDI.Contador++;

            return Ok(new
            {
                Contador = _obejtoDI.Contador,
                ContadorDoService = _testeService.ObterContador()
            });
        }
    }
}
