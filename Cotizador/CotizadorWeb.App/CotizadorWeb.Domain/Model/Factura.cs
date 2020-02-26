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
    
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.AnulacionFactura = new HashSet<AnulacionFactura>();
            this.DespachoFactura = new HashSet<DespachoFactura>();
            this.DetalleDescuentoXProntoPAgo = new HashSet<DetalleDescuentoXProntoPAgo>();
            this.DetalleFactura = new HashSet<DetalleFactura>();
            this.DetallePago = new HashSet<DetallePago>();
            this.DetalleReciboCajaGeneral = new HashSet<DetalleReciboCajaGeneral>();
            this.DetalleReciboRetencion = new HashSet<DetalleReciboRetencion>();
            this.DevolucionFactura = new HashSet<DevolucionFactura>();
            this.FacturaRetencion = new HashSet<FacturaRetencion>();
        }
    
        public int IdFactura { get; set; }
        public string Consecutivo { get; set; }
        public Nullable<int> IdSerie { get; set; }
        public Nullable<int> IdCaja { get; set; }
        public Nullable<int> IdAperturaCaja { get; set; }
        public Nullable<int> IdSegmento { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public string Plazo { get; set; }
        public Nullable<int> IdVendedor { get; set; }
        public string Estado { get; set; }
        public string TipoMoneda { get; set; }
        public Nullable<decimal> TasaParalela { get; set; }
        public Nullable<int> IdCajero { get; set; }
        public string SerieConsecutivo { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnulacionFactura> AnulacionFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DespachoFactura> DespachoFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleDescuentoXProntoPAgo> DetalleDescuentoXProntoPAgo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePago> DetallePago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleReciboCajaGeneral> DetalleReciboCajaGeneral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleReciboRetencion> DetalleReciboRetencion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevolucionFactura> DevolucionFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaRetencion> FacturaRetencion { get; set; }
    }
}