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
    
    public partial class DetalleCotizacionCompra
    {
        public int IdDetalleCotizacionCompra { get; set; }
        public Nullable<int> IdCotizacionCompra { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Total { get; set; }
    
        public virtual CotizacionCompra CotizacionCompra { get; set; }
    }
}