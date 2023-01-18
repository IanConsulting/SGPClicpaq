using System;
using System.Collections.Generic;

namespace SGPClicpaq.Shared.Models
{
    public partial class Guium
    {
        public int Guia { get; set; }
        public string Codempr { get; set; } = null!;
        public string Tipfac { get; set; } = null!;
        public decimal Sucfac { get; set; }
        public decimal Numfac { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Anula { get; set; }
        public decimal Codclie { get; set; }
        public decimal Venta { get; set; }
        public decimal CliR { get; set; }
        public string NomR { get; set; } = null!;
        public string DomR { get; set; } = null!;
        public decimal PosR { get; set; }
        public decimal IvaR { get; set; }
        public decimal CuiR { get; set; }
        public string TelR { get; set; } = null!;
        public decimal CliD { get; set; }
        public string NomD { get; set; } = null!;
        public string DomD { get; set; } = null!;
        public decimal PosD { get; set; }
        public decimal IvaD { get; set; }
        public decimal CuiD { get; set; }
        public string TelD { get; set; } = null!;
        public decimal Codserv { get; set; }
        public string Codpres { get; set; } = null!;
        public decimal Valdec { get; set; }
        public decimal Cobranza { get; set; }
        public decimal Bulto { get; set; }
        public decimal Volumen { get; set; }
        public decimal Peso { get; set; }
        public decimal Aforado { get; set; }
        public decimal BultoT { get; set; }
        public decimal VolumenT { get; set; }
        public decimal PesoT { get; set; }
        public decimal Magnitud { get; set; }
        public string Codtran { get; set; } = null!;
        public string OblPre { get; set; } = null!;
        public string OblTra { get; set; } = null!;
        public decimal Subtot { get; set; }
        public decimal Seguro { get; set; }
        public decimal Gestion { get; set; }
        public decimal Adicional { get; set; }
        public decimal Trancos { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public string Observ { get; set; } = null!;
        public string Factura { get; set; } = null!;
        public string Cae { get; set; } = null!;
        public DateTime Caevto { get; set; }
        public decimal Estado { get; set; }
        public decimal LocR { get; set; }
        public decimal LocD { get; set; }
        public string ZonR { get; set; } = null!;
        public string ZonD { get; set; } = null!;
        public decimal Cobrado { get; set; }
        public decimal AnuCob { get; set; }
        public decimal Rendrto { get; set; }
        public decimal Subtot1 { get; set; }
        public decimal Perib { get; set; }
        public string Vtacli { get; set; } = null!;
        public decimal Canti { get; set; }
        public string EmailR { get; set; } = null!;
        public string EmailD { get; set; } = null!;
        public string DirD { get; set; } = null!;
        public decimal NumD { get; set; }
        public string AclD { get; set; } = null!;
        public string DirR { get; set; } = null!;
        public decimal NumR { get; set; }
        public string AclR { get; set; } = null!;
        public string Ubicacion { get; set; } = null!;
        public string Facprove { get; set; } = null!;
        public int Idsucursal { get; set; }
        public decimal Usuario { get; set; }
        public DateTime Fechahora { get; set; }
    }
}
