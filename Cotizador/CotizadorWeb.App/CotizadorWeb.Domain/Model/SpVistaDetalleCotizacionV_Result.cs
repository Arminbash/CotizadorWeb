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
    
    public partial class SpVistaDetalleCotizacionV_Result
    {
        public int IdDetalleCotizacionV { get; set; }
        public Nullable<int> IdCotizacion { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public Nullable<decimal> FactorCantidad { get; set; }
        public Nullable<decimal> CostoUnitario { get; set; }
        public Nullable<decimal> FactorDescuento { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<int> IdServicio { get; set; }
        public Nullable<int> IdCombo { get; set; }
        public string CodigoAlterno { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
