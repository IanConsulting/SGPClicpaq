using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGPClicpaq.Server.Context;
using SGPClicpaq.Shared.Models;

namespace SGPClicpaq.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrazabilidadController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Trazabilidad>> oRespuesta = new();

            try
            {
                using CLPContext db = new();

                var lst = db.Trazabilidads.ToList();
                oRespuesta.Exito = 1;
                oRespuesta.List = lst;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpGet("{Codtraz:decimal}")]
        public IActionResult Get(decimal Codtraz)
        {
            Respuesta<Trazabilidad> oRespuesta = new();

            try
            {
                using CLPContext db = new();

                var lst = db.Trazabilidads
                    .Where(x => x.Codtraz == Codtraz)
                    .First();
                oRespuesta.Exito = 1;
                oRespuesta.List = lst;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }
    }
}
