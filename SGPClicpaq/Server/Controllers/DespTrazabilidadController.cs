using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGPClicpaq.Server.Context;
using SGPClicpaq.Shared.Models;

namespace SGPClicpaq.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespTrazabilidadController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<DespTrazabilidad>> oRespuesta = new();

            try
            {
                using CLPContext db = new();

                var lst = db.DespTrazabilidads.ToList();
                oRespuesta.Exito = 1;
                oRespuesta.List = lst;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpGet("{id:decimal}")]
        public IActionResult Get(decimal id)
        {
            Respuesta<List<DespTrazabilidad>> oRespuesta = new();

            try
            {
                using CLPContext db = new();

                var lst = db.DespTrazabilidads
                    .Where(x => x.Guia == id).ToList();
                oRespuesta.Exito = 1;
                oRespuesta.List = lst;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpPut]
        public IActionResult Edit(DespTrazabilidad model)
        {
            Respuesta<DespTrazabilidad> oRespuesta = new();

            try
            {
                using CLPContext db = new();
                db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                oRespuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);
        }


    }
}
