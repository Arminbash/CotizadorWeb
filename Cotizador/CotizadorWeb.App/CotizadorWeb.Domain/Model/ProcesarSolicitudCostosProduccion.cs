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
    
    public partial class ProcesarSolicitudCostosProduccion
    {
        public int IdProcesarSolicitudCostosProduccion { get; set; }
        public Nullable<int> IdSolicitud { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Observacion { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> GastosIndirectos { get; set; }
        public Nullable<decimal> CostoTotal { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public string Estado { get; set; }
    
        public virtual SolicitudCostosProduccion SolicitudCostosProduccion { get; set; }
    }
}