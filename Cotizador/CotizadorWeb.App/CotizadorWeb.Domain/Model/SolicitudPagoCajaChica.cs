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
    
    public partial class SolicitudPagoCajaChica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolicitudPagoCajaChica()
        {
            this.DetalleSolicitudPagoReciboCajaChica = new HashSet<DetalleSolicitudPagoReciboCajaChica>();
            this.ReciboCajaChica = new HashSet<ReciboCajaChica>();
        }
    
        public int IdSolicitudPagoCajaChica { get; set; }
        public Nullable<int> IdEmpleadoSolicita { get; set; }
        public Nullable<int> IdAsignacionCajaChica { get; set; }
        public Nullable<int> IdUnidad { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<int> IdBeneficiario { get; set; }
        public string TipoBeneficiario { get; set; }
        public string NombreBeneficiario { get; set; }
        public string CedulaRuc { get; set; }
        public string ObservacionGasto { get; set; }
        public Nullable<System.DateTime> FechaElaboracion { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string Estado { get; set; }
        public Nullable<int> IdEmpleadoAprueba { get; set; }
        public Nullable<System.DateTime> FechaAprobacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleSolicitudPagoReciboCajaChica> DetalleSolicitudPagoReciboCajaChica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReciboCajaChica> ReciboCajaChica { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
