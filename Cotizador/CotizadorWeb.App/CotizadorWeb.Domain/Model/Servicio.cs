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
    
    public partial class Servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicio()
        {
            this.DetalleCotizacionV = new HashSet<DetalleCotizacionV>();
        }
    
        public int IdServicio { get; set; }
        public string CodigoAlterno { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Factor { get; set; }
        public Nullable<decimal> FactorMin { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCotizacionV> DetalleCotizacionV { get; set; }
    }
}