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
    
    public partial class SucursalDepartamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SucursalDepartamento()
        {
            this.FacturaReparacion = new HashSet<FacturaReparacion>();
            this.UbicacionEmpleado = new HashSet<UbicacionEmpleado>();
        }
    
        public int IdSucursalDepartamento { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaReparacion> FacturaReparacion { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionEmpleado> UbicacionEmpleado { get; set; }
    }
}
