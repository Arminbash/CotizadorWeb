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
    
    public partial class CosteoPromedio
    {
        public int IdCosteoPromedio { get; set; }
        public Nullable<long> IdKardex { get; set; }
        public Nullable<decimal> CosteoPromedio1 { get; set; }
    
        public virtual Kardex Kardex { get; set; }
    }
}