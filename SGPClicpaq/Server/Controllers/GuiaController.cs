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
    public class GuiaController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            Respuesta<Guium> oRespuesta = new();

            try
            {
                using CLPContext db = new();

                var lst = db.Guia
                    .Where(x => x.Guia == id)
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

        

        //[HttpPost]
        //public IActionResult Add(Guium model)
        //{
        //    Respuesta<Guium> oRespuesta = new();

        //    try
        //    {
        //        using CLPContext db = new();

        //        Guium oGuia = new()
        //        {
        //            Guia = model.Guia,
        //            Cae = model.Cae,
        //            AclD = model.AclD,
        //            AclR = model.AclR,
        //            Adicional = model.Adicional,
        //            Aforado = model.Aforado,
        //            AnuCob = model.AnuCob,
        //            Anula = model.Anula,
        //            Bulto = model.Bulto,
        //            BultoT = model.BultoT,
        //            Caevto = model.Caevto,
        //            Canti = model.Canti,
        //            CliD = model.CliD,
        //            CliR = model.CliR,
        //            DirD = model.DirD,
        //            DirR = model.DirR,
        //            DomD = model.DomD,
        //            DomR = model.DomR,
        //            CuiD = model.CuiD,
        //            EmailD = model.EmailD,
        //            EmailR = model.EmailR,
        //            IvaD = model.IvaD,
        //            IvaR = model.IvaR,
        //            LocD = model.LocD,
        //            LocR = model.LocR,
        //            NomD = model.NomD,
        //            NomR = model.NomR,
        //            NumD = model.NumD,
        //            NumR = model.NumR,
        //            PosD = model.PosD,
        //            PosR = model.PosR,
        //            TelD = model.TelD,
        //            TelR = model.TelR,
        //            Cobrado = model.Cobrado,
        //            ZonD = model.ZonD,
        //            Seguro = model.Seguro,
        //            Subtot = model.Subtot,
        //            Subtot1 = model.Subtot1,
        //            Sucfac = model.Sucfac,
        //            Cobranza = model.Cobranza,
        //            Codclie = model.Codclie,
        //            Codempr = model.Codempr,
        //            Codpres = model.Codpres,
        //            Codserv = model.Codserv,
        //            Codtran = model.Codtran,
        //            CuiR = model.CuiR,
        //            Estado = model.Estado,
        //            Facprove = model.Facprove,
        //            Factura = model.Factura,
        //            ZonR = model.ZonR,
        //            Fecha = model.Fecha,
        //            Fechahora = model.Fechahora,
        //            Gestion = model.Gestion,
        //            Idsucursal = model.Idsucursal,
        //            Iva = model.Iva,
        //            Magnitud = model.Magnitud,
        //            Numfac = model.Numfac,
        //            OblPre = model.OblPre,
        //            OblTra = model.OblTra,
        //            Observ = model.Observ,
        //            Perib = model.Perib,
        //            Peso = model.Peso,
        //            PesoT = model.PesoT,
        //            Rendrto = model.Rendrto,
        //            Tipfac = model.Tipfac,
        //            Total = model.Total,
        //            Trancos = model.Trancos,
        //            Ubicacion = model.Ubicacion,
        //            Usuario = model.Usuario,
        //            Valdec = model.Valdec,
        //            Venta = model.Venta,
        //            Volumen = model.Volumen,
        //            VolumenT = model.VolumenT,
        //            Vtacli = model.Vtacli,
        //        };
        //        db.Guia.Add(oGuia);
        //        db.SaveChanges();
        //        oRespuesta.Exito = 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        oRespuesta.Mensaje = ex.Message;
        //    }
        //    return Ok(oRespuesta);
        //}

        //[HttpPut]
        //public IActionResult Edit(Guium model)
        //{
        //    Respuesta<Guium> oRespuesta = new();

        //    try
        //    {
        //        using CLPContext db = new();

        //        Guium oGuia = db.Guia.Find(model.Guia);

        //        oGuia.Guia = model.Guia;
        //        oGuia.Cae = model.Cae;
        //        oGuia.AclD = model.AclD;
        //        oGuia.AclR = model.AclR;
        //        oGuia.Adicional = model.Adicional;
        //        oGuia.Aforado = model.Aforado;
        //        oGuia.AnuCob = model.AnuCob;
        //        oGuia.Anula = model.Anula;
        //        oGuia.Bulto = model.Bulto;
        //        oGuia.BultoT = model.BultoT;
        //        oGuia.Caevto = model.Caevto;
        //        oGuia.Canti = model.Canti;
        //        oGuia.CliD = model.CliD;
        //        oGuia.CliR = model.CliR;
        //        oGuia.DirD = model.DirD;
        //        oGuia.DirR = model.DirR;
        //        oGuia.DomD = model.DomD;
        //        oGuia.DomR = model.DomR;
        //        oGuia.CuiD = model.CuiD;
        //        oGuia.EmailD = model.EmailD;
        //        oGuia.EmailR = model.EmailR;
        //        oGuia.IvaD = model.IvaD;
        //        oGuia.IvaR = model.IvaR;
        //        oGuia.LocD = model.LocD;
        //        oGuia.LocR = model.LocR;
        //        oGuia.NomD = model.NomD;
        //        oGuia.NomR = model.NomR;
        //        oGuia.NumD = model.NumD;
        //        oGuia.NumR = model.NumR;
        //        oGuia.PosD = model.PosD;
        //        oGuia.PosR = model.PosR;
        //        oGuia.TelD = model.TelD;
        //        oGuia.TelR = model.TelR;
        //        oGuia.Cobrado = model.Cobrado;
        //        oGuia.ZonD = model.ZonD;
        //        oGuia.Seguro = model.Seguro;
        //        oGuia.Subtot = model.Subtot;
        //        oGuia.Subtot1 = model.Subtot1;
        //        oGuia.Sucfac = model.Sucfac;
        //        oGuia.Cobranza = model.Cobranza;
        //        oGuia.Codclie = model.Codclie;
        //        oGuia.Codempr = model.Codempr;
        //        oGuia.Codpres = model.Codpres;
        //        oGuia.Codserv = model.Codserv;
        //        oGuia.Codtran = model.Codtran;
        //        oGuia.CuiR = model.CuiR;
        //        oGuia.Estado = model.Estado;
        //        oGuia.Facprove = model.Facprove;
        //        oGuia.Factura = model.Factura;
        //        oGuia.ZonR = model.ZonR;
        //        oGuia.Fecha = model.Fecha;
        //        oGuia.Fechahora = model.Fechahora;
        //        oGuia.Gestion = model.Gestion;
        //        oGuia.Idsucursal = model.Idsucursal;
        //        oGuia.Iva = model.Iva;
        //        oGuia.Magnitud = model.Magnitud;
        //        oGuia.Numfac = model.Numfac;
        //        oGuia.OblPre = model.OblPre;
        //        oGuia.OblTra = model.OblTra;
        //        oGuia.Observ = model.Observ;
        //        oGuia.Perib = model.Perib;
        //        oGuia.Peso = model.Peso;
        //        oGuia.PesoT = model.PesoT;
        //        oGuia.Rendrto = model.Rendrto;
        //        oGuia.Tipfac = model.Tipfac;
        //        oGuia.Total = model.Total;
        //        oGuia.Trancos = model.Trancos;
        //        oGuia.Ubicacion = model.Ubicacion;
        //        oGuia.Usuario = model.Usuario;
        //        oGuia.Valdec = model.Valdec;
        //        oGuia.Venta = model.Venta;
        //        oGuia.Volumen = model.Volumen;
        //        oGuia.VolumenT = model.VolumenT;
        //        oGuia.Vtacli = model.Vtacli;

        //        db.Entry(oGuia).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //        db.SaveChanges();
        //        oRespuesta.Exito = 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        oRespuesta.Mensaje = ex.Message;
        //    }
        //    return Ok(oRespuesta);
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int Id)
        //{
        //    Respuesta<Guium> oRespuesta = new();
        //    try
        //    {
        //        using CLPContext db = new();

        //        Guium oGuia = db.Guia.Find(Id);
        //        db.Remove(oGuia);
        //        db.SaveChanges();
        //        oRespuesta.Exito = 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        oRespuesta.Mensaje = ex.Message;

        //    }
        //    return Ok(oRespuesta);
        //}

    }
}
