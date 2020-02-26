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
    
    public partial class DetallePrefacturaV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetallePrefacturaV()
        {
            this.DetalleCombosProducto = new HashSet<DetalleCombosProducto>();
            this.DetalleProductosPrefacturaPV = new HashSet<DetalleProductosPrefacturaPV>();
        }
    
        public int IdDetallePrefacturaVenta { get; set; }
        public Nullable<int> IdPrefactura { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public Nullable<decimal> CostoUnitario { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> FactorDescuento { get; set; }
        public Nullable<decimal> FactorCantidad { get; set; }
        public Nullable<int> IdCombo { get; set; }
        public Nullable<int> IdServicio { get; set; }
        public Nullable<bool> Estatus { get; set; }
        public Nullable<decimal> IvaExcento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCombosProducto> DetalleCombosProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleProductosPrefacturaPV> DetalleProductosPrefacturaPV { get; set; }
        public virtual PrefacturaVenta PrefacturaVenta { get; set; }
        public virtual Producto Producto { get; set; }
    }
}