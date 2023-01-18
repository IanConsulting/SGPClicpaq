using System;
using System.Collections.Generic;

namespace SGPClicpaq.Shared.Models
{
    public partial class Transporte
    {
        public string Codtran { get; set; } = null!;
        public string Descrip { get; set; } = null!;
        public string Contacto { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public decimal Cpostal { get; set; }
        public decimal Codloca { get; set; }
        public string Codprov { get; set; } = null!;
        public decimal Codpais { get; set; }
        public string Horario { get; set; } = null!;
        public decimal Tipiva { get; set; }
        public string Cuit { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Observ { get; set; } = null!;
        public decimal ObDes { get; set; }
        public decimal ObFc { get; set; }
        public decimal EmiEti { get; set; }
        public decimal Noconso { get; set; }
        public decimal Cobranza { get; set; }
        public decimal Prioridad { get; set; }
        public decimal MinPes { get; set; }
        public decimal MaxPes { get; set; }
        public decimal MinVol { get; set; }
        public decimal MaxVol { get; set; }
        public decimal Domguia { get; set; }
        public decimal Reqcomp { get; set; }
        public decimal Canbul { get; set; }
        public string Web { get; set; } = null!;
        public decimal Despa { get; set; }
        public decimal Despacha { get; set; }
        public string Ctacte { get; set; } = null!;
        public string Seguimiento { get; set; } = null!;
        public decimal Trazaauto { get; set; }
        public decimal Transoft { get; set; }
        public string Descweb { get; set; } = null!;
        public decimal RetCen { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public decimal ReqRc { get; set; }
        public string Ubicacion { get; set; } = null!;
        public decimal GuiaHr { get; set; }
        public decimal MultPes { get; set; }
        public decimal MultVol { get; set; }
        public decimal Usuario { get; set; }
        public DateTime Fechahora { get; set; }
    }
}
