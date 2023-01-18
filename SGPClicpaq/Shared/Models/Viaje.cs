using System;
using System.Collections.Generic;

namespace SGPClicpaq.Shared.Models
{
    public partial class Viaje
    {
        public int Id { get; set; }
        public string? Guias { get; set; }
        public string? ZonaDestino { get; set; }
        public string? Unidad { get; set; }
        public decimal? Chofer { get; set; }
        public int? Sucursal { get; set; }
        public int? TotalGuias { get; set; }
        public int? TotalBultos { get; set; }
        public decimal? TotalPeso { get; set; }
        public decimal? TotalVolumen { get; set; }
        public decimal? TotalImporte { get; set; }
        public int? Kilometros { get; set; }
        public string? Transporte { get; set; }
        public string? Estado { get; set; }
        public DateTime? FechaViaje { get; set; }
        public DateTime? TimeGenerado { get; set; }
        public DateTime? TimeCargando { get; set; }
        public DateTime? TimeEnCamion { get; set; }
        public DateTime? TimeAprobado { get; set; }
        public DateTime? TimeSaleCamion { get; set; }
        public DateTime? TimeEntregado { get; set; }
        public string? Observaciones { get; set; }
        public string? ObservCargado { get; set; }
    }
}
