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
    
    public partial class VersionAplicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VersionAplicacion()
        {
            this.AplicacionBusqueda = new HashSet<AplicacionBusqueda>();
        }
    
        public int IdVersion { get; set; }
        public Nullable<int> IdModelo { get; set; }
        public string Version { get; set; }
        public Nullable<int> FechaInicio { get; set; }
        public Nullable<int> FechaFin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AplicacionBusqueda> AplicacionBusqueda { get; set; }
        public virtual ModeloAplicacion ModeloAplicacion { get; set; }
    }
}
