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
    
    public partial class DetalleDescuentoXProntoPAgo
    {
        public int IdDetalleDescuentoxPronto { get; set; }
        public Nullable<int> IdDescuentoxPronto { get; set; }
        public Nullable<int> IdPreFacturaOT { get; set; }
        public Nullable<int> IdPrefacturaPV { get; set; }
        public Nullable<int> IdFactura { get; set; }
    
        public virtual DescuentoxProntoPago DescuentoxProntoPago { get; set; }
        public virtual Factura Factura { get; set; }
        public virtual PreFacturaOT PreFacturaOT { get; set; }
    }
}
