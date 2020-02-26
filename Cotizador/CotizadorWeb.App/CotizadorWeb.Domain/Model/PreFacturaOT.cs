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
    
    public partial class PreFacturaOT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PreFacturaOT()
        {
            this.FacturaReparacion = new HashSet<FacturaReparacion>();
            this.DetalleDescuentoXProntoPAgo = new HashSet<DetalleDescuentoXProntoPAgo>();
            this.DetallePreFacturaOT = new HashSet<DetallePreFacturaOT>();
        }
    
        public int IdPreFacturaOT { get; set; }
        public Nullable<int> IdOrdenTrabajo { get; set; }
        public Nullable<int> IdSegmento { get; set; }
        public Nullable<int> IdSerie { get; set; }
        public string Consecutivo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> TasaParalelo { get; set; }
        public string TipoPago { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> IdVendedor { get; set; }
        public string TipoMoneda { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaReparacion> FacturaReparacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleDescuentoXProntoPAgo> DetalleDescuentoXProntoPAgo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePreFacturaOT> DetallePreFacturaOT { get; set; }
        public virtual OrdenTrabajo OrdenTrabajo { get; set; }
    }
}
