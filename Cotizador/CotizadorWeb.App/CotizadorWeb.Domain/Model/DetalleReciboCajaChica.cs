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
    
    public partial class DetalleReciboCajaChica
    {
        public int IdDetalleReciboCajaChica { get; set; }
        public Nullable<int> IdReciboCajaChica { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> RetencionIR { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> IdDescripcionConceptoCaja { get; set; }
        public Nullable<decimal> RetencionIMI { get; set; }
    
        public virtual DescripcionConceptoCaja DescripcionConceptoCaja { get; set; }
        public virtual ReciboCajaChica ReciboCajaChica { get; set; }
    }
}
