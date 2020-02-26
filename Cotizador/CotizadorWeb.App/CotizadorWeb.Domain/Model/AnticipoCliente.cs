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
    
    public partial class AnticipoCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnticipoCliente()
        {
            this.DetalleAnticipoCliente = new HashSet<DetalleAnticipoCliente>();
        }
    
        public int IdAnticipoCliente { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdSerie { get; set; }
        public string Consecutivo { get; set; }
        public Nullable<System.DateTime> FechaAnticipo { get; set; }
        public string Observacion { get; set; }
        public Nullable<decimal> MontoAnticipo { get; set; }
        public string TipoMoneda { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleAnticipoCliente> DetalleAnticipoCliente { get; set; }
    }
}