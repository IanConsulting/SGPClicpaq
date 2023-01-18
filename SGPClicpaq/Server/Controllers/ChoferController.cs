﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGPClicpaq.Server.Context;
using SGPClicpaq.Shared.Models;
using System;

namespace SGPClicpaq.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoferController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Chofer>> oRespuesta = new();

            try
            {
                using CLPContext db = new();

                var lst = db.Chofers.ToList();
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
