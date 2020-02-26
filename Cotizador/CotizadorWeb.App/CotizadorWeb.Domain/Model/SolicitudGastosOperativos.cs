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
    
    public partial class SolicitudGastosOperativos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolicitudGastosOperativos()
        {
            this.AprobarGastosOperativos = new HashSet<AprobarGastosOperativos>();
            this.DetalleSolicitudGO = new HashSet<DetalleSolicitudGO>();
            this.DistribucionGastosOperativos = new HashSet<DistribucionGastosOperativos>();
        }
    
        public int IdSolicitudGastosOperativos { get; set; }
        public Nullable<int> IdSerie { get; set; }
        public string Consecutivo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<decimal> TasaCambio { get; set; }
        public string TipoMoneda { get; set; }
        public string NoFactura { get; set; }
        public Nullable<System.DateTime> FechaFactura { get; set; }
        public string TipoPago { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Estatus { get; set; }
        public string SerieConsecutivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AprobarGastosOperativos> AprobarGastosOperativos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleSolicitudGO> DetalleSolicitudGO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DistribucionGastosOperativos> DistribucionGastosOperativos { get; set; }
    }
}