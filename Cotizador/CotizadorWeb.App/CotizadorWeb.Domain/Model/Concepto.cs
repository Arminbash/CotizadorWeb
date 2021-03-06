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
    
    public partial class Concepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Concepto()
        {
            this.Aplicacion = new HashSet<Aplicacion>();
        }
    
        public int IdConcepto { get; set; }
        public string NombreConcepto { get; set; }
        public string DescripcionConcepto { get; set; }
        public string TipoConcepto { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<bool> SujetoRetencion { get; set; }
        public string SubTipo { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aplicacion> Aplicacion { get; set; }
    }
}
