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
    
    public partial class CatalogoConcepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatalogoConcepto()
        {
            this.DetalleNotasDebito = new HashSet<DetalleNotasDebito>();
        }
    
        public int IdCatalogoConcepto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<bool> Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleNotasDebito> DetalleNotasDebito { get; set; }
    }
}