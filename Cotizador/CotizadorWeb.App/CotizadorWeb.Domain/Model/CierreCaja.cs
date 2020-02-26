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
    
    public partial class CierreCaja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CierreCaja()
        {
            this.ArqueoCaja = new HashSet<ArqueoCaja>();
        }
    
        public int IdCierreCaja { get; set; }
        public Nullable<System.DateTime> FechaCierre { get; set; }
        public Nullable<int> IdEncargadoCierre { get; set; }
        public Nullable<decimal> MontoCordoba { get; set; }
        public Nullable<decimal> MontoDolar { get; set; }
        public Nullable<decimal> MontoTarjetaCordoba { get; set; }
        public Nullable<decimal> MontoTarjetaDolar { get; set; }
        public Nullable<int> IdAperturaCaja { get; set; }
        public Nullable<int> IdCaja { get; set; }
        public string Observacion { get; set; }
    
        public virtual AperturaCaja AperturaCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArqueoCaja> ArqueoCaja { get; set; }
        public virtual Caja Caja { get; set; }
    }
}
