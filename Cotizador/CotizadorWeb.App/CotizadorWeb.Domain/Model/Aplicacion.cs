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
    
    public partial class Aplicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aplicacion()
        {
            this.AplicacionEmpleado = new HashSet<AplicacionEmpleado>();
        }
    
        public int IdAplicacion { get; set; }
        public Nullable<int> IdConcepto { get; set; }
        public Nullable<decimal> MontoAplicacion { get; set; }
        public string Periodo { get; set; }
        public string TipoMoneda { get; set; }
        public string TipoAplicacion { get; set; }
        public string Periodo2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AplicacionEmpleado> AplicacionEmpleado { get; set; }
        public virtual Concepto Concepto { get; set; }
    }
}