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
    
    public partial class SolicitudCostosProduccionDetalle
    {
        public int IdSolicitudCostosProduccionDetalle { get; set; }
        public Nullable<int> IdSolicitudCostosProduccion { get; set; }
        public Nullable<int> IdDetalle { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> CantidadHoras { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> porcentaje { get; set; }
        public string Tipo { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual SolicitudCostosProduccion SolicitudCostosProduccion { get; set; }
    }
}