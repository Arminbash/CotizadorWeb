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
    
    public partial class sp_DatosNotaDebitoProveedorXId_Result
    {
        public int IdNotasDebitoProveedor { get; set; }
        public string Consecutivo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public string Proveedor { get; set; }
        public Nullable<System.DateTime> FechaAprobacion { get; set; }
        public string Observacion { get; set; }
        public string Solicita { get; set; }
        public string CedulaIngreso { get; set; }
        public string Aprueba { get; set; }
        public string CedulaAprueba { get; set; }
        public string RUC { get; set; }
        public string Simbolo { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Iva { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> TotalPagar { get; set; }
    }
}
