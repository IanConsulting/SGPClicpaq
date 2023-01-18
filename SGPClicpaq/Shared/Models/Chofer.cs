using System;
using System.Collections.Generic;

namespace SGPClicpaq.Shared.Models
{
    public partial class Chofer
    {
        public decimal Legajo { get; set; }
        public string Apellido { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal Nrodoc { get; set; }
        public string Direccion { get; set; } = null!;
        public decimal Cpostal { get; set; }
        public decimal Codloca { get; set; }
        public string Codprov { get; set; } = null!;
        public decimal Codpais { get; set; }
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Observ { get; set; } = null!;
        public decimal Usuario { get; set; }
        public DateTime Fechahora { get; set; }
    }
}
