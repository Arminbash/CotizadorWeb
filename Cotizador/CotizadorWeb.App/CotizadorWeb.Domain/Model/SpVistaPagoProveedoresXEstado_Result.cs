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
    
    public partial class SpVistaPagoProveedoresXEstado_Result
    {
        public Nullable<int> IdFactura { get; set; }
        public Nullable<int> IdPago { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string Ruc { get; set; }
        public string NoFactura { get; set; }
        public string ConsecutivoFactura { get; set; }
        public Nullable<System.DateTime> FechaFactura { get; set; }
        public Nullable<System.DateTime> FechaPago { get; set; }
        public string TipoMoneda { get; set; }
        public string Estado { get; set; }
        public Nullable<decimal> TotalFactura { get; set; }
        public string Tipo { get; set; }
        public Nullable<System.DateTime> FechaConfirma { get; set; }
        public Nullable<int> IdConfirma { get; set; }
        public Nullable<int> DiasRestantes { get; set; }
        public string EstadoPago { get; set; }
        public Nullable<int> DiasVencidos { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
    }
}
