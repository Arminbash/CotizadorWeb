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
    
    public partial class ProcesamientoCreditoCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcesamientoCreditoCliente()
        {
            this.RequisitosProcesamiento = new HashSet<RequisitosProcesamiento>();
        }
    
        public int IdProcesamientoCreditoCliente { get; set; }
        public Nullable<int> Plazo { get; set; }
        public string Estado { get; set; }
        public Nullable<int> IdRecibido { get; set; }
        public Nullable<int> IdAprobadoPor { get; set; }
        public Nullable<int> IdSolicitudCredito { get; set; }
        public Nullable<System.DateTime> FechaAprobacion { get; set; }
        public Nullable<decimal> Monto { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Empleado Empleado1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequisitosProcesamiento> RequisitosProcesamiento { get; set; }
        public virtual SolicitudCredito SolicitudCredito { get; set; }
    }
}
