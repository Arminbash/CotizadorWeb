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
    using System.Collections.Generic;
    
    public partial class DetalleProductosCotizacionOT
    {
        public int IdDetalleProductosCotizacionOT { get; set; }
        public Nullable<int> IdCotizacion { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual CotizacionOT CotizacionOT { get; set; }
    }
}
