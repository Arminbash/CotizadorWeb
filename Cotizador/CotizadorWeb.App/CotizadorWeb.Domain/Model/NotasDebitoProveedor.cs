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
    
    public partial class NotasDebitoProveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NotasDebitoProveedor()
        {
            this.DetalleNotasDebitoProveedor = new HashSet<DetalleNotasDebitoProveedor>();
        }
    
        public int IdNotasDebitoProveedor { get; set; }
        public Nullable<int> IdEmpleadoSolicita { get; set; }
        public Nullable<int> IdEmpleadoAprueba { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdSerie { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public string Consecutivo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaNotaDebito { get; set; }
        public Nullable<System.DateTime> FechaAprobacion { get; set; }
        public string Proveedor { get; set; }
        public string Moneda { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public string SerieConsecutivo { get; set; }
        public Nullable<decimal> Tasa { get; set; }
        public string NumNotaDebito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleNotasDebitoProveedor> DetalleNotasDebitoProveedor { get; set; }
    }
}
