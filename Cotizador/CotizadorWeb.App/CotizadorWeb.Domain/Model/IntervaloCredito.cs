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
    
    public partial class IntervaloCredito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IntervaloCredito()
        {
            this.RequisitoIntervalo = new HashSet<RequisitoIntervalo>();
        }
    
        public int IdIntervaloCredito { get; set; }
        public Nullable<decimal> MontoDesde { get; set; }
        public Nullable<decimal> MontoHasta { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<bool> Global { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequisitoIntervalo> RequisitoIntervalo { get; set; }
    }
}