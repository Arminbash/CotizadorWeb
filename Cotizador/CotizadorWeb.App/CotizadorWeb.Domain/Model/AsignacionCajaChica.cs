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
    
    public partial class AsignacionCajaChica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AsignacionCajaChica()
        {
            this.AsignarMontoCajaChica = new HashSet<AsignarMontoCajaChica>();
            this.ReciboCajaChica = new HashSet<ReciboCajaChica>();
        }
    
        public int IdAsignacionCajaChica { get; set; }
        public Nullable<int> IdCaja { get; set; }
        public Nullable<int> IdEmpleadoAsigna { get; set; }
        public Nullable<System.DateTime> FechaAsignacion { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual Caja Caja { get; set; }
        public virtual Empleado Empleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsignarMontoCajaChica> AsignarMontoCajaChica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReciboCajaChica> ReciboCajaChica { get; set; }
    }
}
