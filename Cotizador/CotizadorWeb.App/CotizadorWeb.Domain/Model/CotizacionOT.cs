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
    
    public partial class CotizacionOT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CotizacionOT()
        {
            this.DetalleCotizacionInsumo = new HashSet<DetalleCotizacionInsumo>();
            this.DetalleProductosCotizacionOT = new HashSet<DetalleProductosCotizacionOT>();
            this.DetalleServicioCotizacionOT = new HashSet<DetalleServicioCotizacionOT>();
        }
    
        public int IdCotizacion { get; set; }
        public Nullable<int> IdSerie { get; set; }
        public string Consecutivo { get; set; }
        public Nullable<int> IdFlota { get; set; }
        public Nullable<int> IdOrdenTrabajo { get; set; }
        public Nullable<int> IdAsesor { get; set; }
        public Nullable<System.DateTime> FechaElaboracion { get; set; }
        public Nullable<decimal> TasaParalela { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Estatus { get; set; }
        public Nullable<int> IdSegmento { get; set; }
        public string Moneda { get; set; }
        public string SerieConsecutivo { get; set; }
    
        public virtual FlotaVehicular FlotaVehicular { get; set; }
        public virtual OrdenTrabajo OrdenTrabajo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCotizacionInsumo> DetalleCotizacionInsumo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleProductosCotizacionOT> DetalleProductosCotizacionOT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleServicioCotizacionOT> DetalleServicioCotizacionOT { get; set; }
    }
}
