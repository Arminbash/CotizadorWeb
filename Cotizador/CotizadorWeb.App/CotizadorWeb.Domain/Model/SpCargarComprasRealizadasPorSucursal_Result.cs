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
    
    public partial class SpCargarComprasRealizadasPorSucursal_Result
    {
        public int IdCompra { get; set; }
        public Nullable<int> IdSerie { get; set; }
        public string Consecutivo { get; set; }
        public string Factura { get; set; }
        public Nullable<System.DateTime> FechaCompra { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public string TipoPago { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> RealizadaPor { get; set; }
        public Nullable<int> IngresadoPor { get; set; }
        public string Moneda { get; set; }
        public string SerieConsecutivo { get; set; }
        public string Estado { get; set; }
        public Nullable<int> Plazo { get; set; }
        public string Regimen { get; set; }
    }
}
