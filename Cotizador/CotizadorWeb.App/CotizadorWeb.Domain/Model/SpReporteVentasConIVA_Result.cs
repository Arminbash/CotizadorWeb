//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CotizadorWeb.Domain.Model
{
    using System;
    
    public partial class SpReporteVentasConIVA_Result
    {
        public string NoDocumento { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public string RealizadaPor { get; set; }
        public string Cliente { get; set; }
        public string TipoPago { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
