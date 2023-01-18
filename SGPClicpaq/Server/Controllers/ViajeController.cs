using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGPClicpaq.Server.Context;
using SGPClicpaq.Shared.Models;
using System;

namespace SGPClicpaq.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViajeController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            Respuesta<Viaje> oRespuesta = new();

            try
            {
                using IANContext db = new();

                var lst = db.Viajes
                    .Where(x => x.Id == id)
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

        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Viaje>> oRespuesta = new();

            try
            {
                using IANContext db = new();

                var lst = db.Viajes.ToList();
                oRespuesta.Exito = 1;
                oRespuesta.List = lst;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpPost]
        public IActionResult Add(Viaje model)
        {
            Respuesta<Viaje> oRespuesta = new();

            try
            {
                using IANContext db = new();

                Viaje oViaje = new();
                oViaje.Guias = model.Guias;
                oViaje.ZonaDestino = model.ZonaDestino;
                oViaje.Observaciones = model.Observaciones;
                oViaje.ObservCargado = model.ObservCargado;
                oViaje.Chofer = model.Chofer;
                oViaje.Unidad = model.Unidad;
                oViaje.FechaViaje = model.FechaViaje;
                oViaje.Sucursal = model.Sucursal;
                oViaje.TimeCargando = model.TimeCargando;
                oViaje.TimeEnCamion = model.TimeEnCamion;
                oViaje.TimeGenerado = model.TimeGenerado;
                oViaje.TimeSaleCamion = model.TimeSaleCamion;
                oViaje.TimeAprobado = model.TimeAprobado;
                oViaje.TimeEntregado = model.TimeEntregado;
                oViaje.TotalGuias = model.TotalGuias;
                oViaje.TotalBultos = model.TotalBultos;
                oViaje.TotalVolumen = model.TotalVolumen;
                oViaje.TotalPeso = model.TotalPeso;
                oViaje.Estado = model.Estado;
                oViaje.Transporte = model.Transporte;
                oViaje.Kilometros = model.Kilometros;
                oViaje.TotalImporte = model.TotalImporte;

                db.Viajes.Add(oViaje);
                db.SaveChanges();
                oRespuesta.List = oViaje;
                oRespuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            Console.WriteLine(oRespuesta.List.Id);
            return Ok(oRespuesta);
        }

        [HttpPut]
        public IActionResult Edit(Viaje model)
        {
            Respuesta<Viaje> oRespuesta = new();

            try
            {
                using IANContext db = new();

                Viaje oViaje = db.Viajes.Find(model.Id);
                oViaje.Guias = model.Guias;
                oViaje.ZonaDestino = model.ZonaDestino;
                oViaje.ObservCargado = model.ObservCargado;
                oViaje.Observaciones = model.Observaciones;
                oViaje.Chofer = model.Chofer;
                oViaje.Unidad = model.Unidad;
                oViaje.FechaViaje = model.FechaViaje;
                oViaje.Sucursal = model.Sucursal;
                oViaje.TimeCargando = model.TimeCargando;
                oViaje.TimeEnCamion = model.TimeEnCamion;
                oViaje.TimeGenerado = model.TimeGenerado;
                oViaje.TimeSaleCamion = model.TimeSaleCamion;
                oViaje.TimeAprobado = model.TimeAprobado;
                oViaje.TimeEntregado = model.TimeEntregado;
                oViaje.TotalGuias = model.TotalGuias;
                oViaje.TotalBultos = model.TotalBultos;
                oViaje.TotalVolumen = model.TotalVolumen;
                oViaje.TotalPeso = model.TotalPeso;
                oViaje.Estado = model.Estado;
                oViaje.Transporte = model.Transporte;
                oViaje.Kilometros = model.Kilometros;
                oViaje.TotalImporte = model.TotalImporte;

                db.Entry(oViaje).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                oRespuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            Respuesta<Viaje> oRespuesta = new();
            try
            {
                using IANContext db = new();

                Viaje oViaje = db.Viajes.Find(Id);
                db.Remove(oViaje);
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
