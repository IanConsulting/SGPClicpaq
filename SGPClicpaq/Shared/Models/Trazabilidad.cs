using System;
using System.Collections.Generic;

namespace SGPClicpaq.Shared.Models
{
    public partial class Trazabilidad
    {
        public decimal Codtraz { get; set; }
        public string Descrip { get; set; } = null!;
        public decimal Auto { get; set; }
        public decimal Web { get; set; }
        public decimal Desp { get; set; }
        public decimal Envi { get; set; }
        public decimal Hrut { get; set; }
        public decimal Rrto { get; set; }
        public decimal Rece { get; set; }
        public decimal Rcob { get; set; }
        public decimal Fin { get; set; }
        public string Descweb { get; set; } = null!;
        public decimal Color { get; set; }
        public decimal Trazaact { get; set; }
        public decimal Actua { get; set; }
        public decimal? Quad { get; set; }
        public decimal? Observ { get; set; }
        public decimal Usuario { get; set; }
        public DateTime Fechahora { get; set; }
    }
}
