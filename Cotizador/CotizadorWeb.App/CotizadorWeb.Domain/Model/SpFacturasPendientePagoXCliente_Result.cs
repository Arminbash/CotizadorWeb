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
    
    public partial class SpFacturasPendientePagoXCliente_Result
    {
        public Nullable<int> IdFactura { get; set; }
        public string NoFactura { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public Nullable<int> Plazo { get; set; }
        public Nullable<System.DateTime> FechaVence { get; set; }
        public Nullable<int> DiasVencidos { get; set; }
        public string Codigo { get; set; }
        public string Cliente { get; set; }
        public string CedulaRUC { get; set; }
        public Nullable<decimal> MontoCredito { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> MontoAbonado { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public string Procedencia { get; set; }
    }
}
