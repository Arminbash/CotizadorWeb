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
    
    public partial class Sp_CargarFacturasEnCobranza_Result
    {
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdFactura { get; set; }
        public string Consecutivo { get; set; }
        public string NombreCliente { get; set; }
        public string CedulaCliente { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public string Mes { get; set; }
        public string Año { get; set; }
        public Nullable<int> Plazo { get; set; }
        public Nullable<int> DiasDePlazo { get; set; }
        public Nullable<int> CriterioCobranza { get; set; }
        public Nullable<decimal> MontoTotal { get; set; }
        public Nullable<decimal> MontoPendiente { get; set; }
    }
}
