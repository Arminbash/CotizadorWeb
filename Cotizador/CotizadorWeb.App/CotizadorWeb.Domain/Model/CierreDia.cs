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
    
    public partial class CierreDia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CierreDia()
        {
            this.MinutaDeposito = new HashSet<MinutaDeposito>();
        }
    
        public int IdCierreDia { get; set; }
        public Nullable<System.DateTime> FechaCierre { get; set; }
        public Nullable<int> IdEncargadoCierre { get; set; }
        public Nullable<int> IdAperturaDia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MinutaDeposito> MinutaDeposito { get; set; }
        public virtual AperturaDia AperturaDia { get; set; }
    }
}
