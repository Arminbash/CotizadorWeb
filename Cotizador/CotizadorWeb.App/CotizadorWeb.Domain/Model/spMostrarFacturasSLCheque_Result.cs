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
    
    public partial class spMostrarFacturasSLCheque_Result
    {
        public Nullable<int> IdFactura { get; set; }
        public Nullable<int> idConfirma { get; set; }
        public string NoFactura { get; set; }
        public string Consecutivo { get; set; }
        public string Moneda { get; set; }
        public Nullable<decimal> TotalApagar { get; set; }
        public Nullable<int> DiasRestantes { get; set; }
        public Nullable<int> DiasVencidos { get; set; }
        public Nullable<System.DateTime> FechaFactura { get; set; }
        public Nullable<System.DateTime> FechaConfirmar { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
    }
}
