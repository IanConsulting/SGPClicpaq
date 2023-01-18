using System;
using System.Collections.Generic;

namespace SGPClicpaq.Shared.Models
{
    public partial class Movil
    {
        public decimal Codmovi { get; set; }
        public string Dominio { get; set; } = null!;
        public string Titular { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Chasis { get; set; } = null!;
        public string Motor { get; set; } = null!;
        public DateTime Venci { get; set; }
        public decimal Control { get; set; }
        public decimal Año { get; set; }
        public DateTime Fecalta { get; set; }
        public string Observ { get; set; } = null!;
        public decimal Sinuso { get; set; }
        public decimal Usuario { get; set; }
        public DateTime Fechahora { get; set; }
    }
}
