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
    
    public partial class TotalLiquidacionCompra
    {
        public int IdTotalLiquidacionCompra { get; set; }
        public Nullable<int> IdDetalleCompra { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> PorcentajeDAI { get; set; }
        public Nullable<decimal> PorcentajeISC { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual DetalleCompra DetalleCompra { get; set; }
    }
}
