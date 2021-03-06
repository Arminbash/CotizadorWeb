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
    
    public partial class SolicitudCostosProduccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolicitudCostosProduccion()
        {
            this.IngresoOrdenProduccion = new HashSet<IngresoOrdenProduccion>();
            this.ProcesarSolicitudCostosProduccion = new HashSet<ProcesarSolicitudCostosProduccion>();
            this.SolicitudCostosProduccionDetalle = new HashSet<SolicitudCostosProduccionDetalle>();
        }
    
        public int IdSolicitudCostosProduccion { get; set; }
        public Nullable<int> IdSerie { get; set; }
        public string Consecutivo { get; set; }
        public Nullable<int> IdOrdenProduccion { get; set; }
        public Nullable<int> IdEmpleadoSolicita { get; set; }
        public string ObservacionSolicita { get; set; }
        public Nullable<System.DateTime> FechaSolicita { get; set; }
        public Nullable<int> IdEmpleadoProcesa { get; set; }
        public string ObservacionProcesa { get; set; }
        public Nullable<System.DateTime> FechaProcesa { get; set; }
        public string Estado { get; set; }
        public string SerieConsecutivo { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngresoOrdenProduccion> IngresoOrdenProduccion { get; set; }
        public virtual OrdenProduccion OrdenProduccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcesarSolicitudCostosProduccion> ProcesarSolicitudCostosProduccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitudCostosProduccionDetalle> SolicitudCostosProduccionDetalle { get; set; }
    }
}
