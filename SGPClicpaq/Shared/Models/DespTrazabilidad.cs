using System;
using System.Collections.Generic;

namespace SGPClicpaq.Shared.Models
{
    public partial class DespTrazabilidad
    {
        public decimal Guia { get; set; }
        public string Codempr { get; set; } = null!;
        public decimal Codtraz { get; set; }
        public string Trazacli { get; set; } = null!;
        public decimal Auto { get; set; }
        public decimal? Item { get; set; }
        public decimal Estado { get; set; }
        public string Observ { get; set; } = null!;
        public decimal Usuario { get; set; }
        public DateTime Fechahora { get; set; }
    }
}
