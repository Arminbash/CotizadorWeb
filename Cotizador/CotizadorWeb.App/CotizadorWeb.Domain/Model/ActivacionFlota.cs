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
    
    public partial class ActivacionFlota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActivacionFlota()
        {
            this.DetalleActivacionFlota = new HashSet<DetalleActivacionFlota>();
        }
    
        public int IdActivacionFlota { get; set; }
        public string Observacion { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleActivacionFlota> DetalleActivacionFlota { get; set; }
    }
}
