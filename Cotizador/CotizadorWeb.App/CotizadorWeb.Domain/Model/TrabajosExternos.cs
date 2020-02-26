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
    
    public partial class TrabajosExternos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrabajosExternos()
        {
            this.DetallePreFacturaInternaOT = new HashSet<DetallePreFacturaInternaOT>();
            this.DetallePreFacturaOT = new HashSet<DetallePreFacturaOT>();
        }
    
        public int IdTrabajoExterno { get; set; }
        public Nullable<int> IdServicio { get; set; }
        public Nullable<int> IdOrdenTrabajo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public string NoFactura { get; set; }
        public Nullable<System.DateTime> FechaFactura { get; set; }
        public string TipoPago { get; set; }
        public string NombreProveedor { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<decimal> FactorGanancia { get; set; }
        public string Moneda { get; set; }
        public Nullable<decimal> TasaCambio { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Cargado { get; set; }
        public Nullable<bool> Estatus { get; set; }
        public string ObservacionEliminar { get; set; }
        public Nullable<int> IdEmpElimina { get; set; }
        public Nullable<int> IdProveedor { get; set; }
    
        public virtual Proveedor Proveedor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePreFacturaInternaOT> DetallePreFacturaInternaOT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePreFacturaOT> DetallePreFacturaOT { get; set; }
        public virtual Mantenimiento Mantenimiento { get; set; }
        public virtual OrdenTrabajo OrdenTrabajo { get; set; }
    }
}
