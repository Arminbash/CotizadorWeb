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
    
    public partial class DetalleReversionDocumento
    {
        public int IdDetalleReversion { get; set; }
        public Nullable<int> IdReversion { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> CantidadDuplicada { get; set; }
        public Nullable<decimal> CPP { get; set; }
        public Nullable<decimal> CP { get; set; }
        public Nullable<decimal> CPEP { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual ReversionDocumento ReversionDocumento { get; set; }
    }
}
