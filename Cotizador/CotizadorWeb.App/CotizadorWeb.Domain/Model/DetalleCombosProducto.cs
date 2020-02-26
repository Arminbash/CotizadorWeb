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
    
    public partial class DetalleCombosProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetalleCombosProducto()
        {
            this.IdentificadorEnCombos = new HashSet<IdentificadorEnCombos>();
        }
    
        public int IdDetalleProductoCombos { get; set; }
        public Nullable<int> IdDetallePrefacturaVenta { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual DetallePrefacturaV DetallePrefacturaV { get; set; }
        public virtual Producto Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IdentificadorEnCombos> IdentificadorEnCombos { get; set; }
    }
}