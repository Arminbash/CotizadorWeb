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
    
    public partial class Margen
    {
        public int IdMargen { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<decimal> MargenBase { get; set; }
        public Nullable<decimal> DescuentoMaximo { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
