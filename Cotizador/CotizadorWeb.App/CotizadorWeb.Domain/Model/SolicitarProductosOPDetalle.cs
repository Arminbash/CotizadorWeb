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
    
    public partial class SolicitarProductosOPDetalle
    {
        public int IdSolicitarProductosOPDetalle { get; set; }
        public Nullable<int> IdSolicitarProductosOP { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual SolicitarProductosOP SolicitarProductosOP { get; set; }
    }
}
