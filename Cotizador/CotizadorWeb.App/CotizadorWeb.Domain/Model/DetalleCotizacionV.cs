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
    
    public partial class DetalleCotizacionV
    {
        public int IdDetalleCotizacionV { get; set; }
        public Nullable<int> IdCotizacion { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public Nullable<decimal> FactorCantidad { get; set; }
        public Nullable<decimal> CostoUnitario { get; set; }
        public Nullable<decimal> FactorDescuento { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<int> IdServicio { get; set; }
        public Nullable<int> IdCombo { get; set; }
        public Nullable<bool> Estatus { get; set; }
        public Nullable<decimal> CantidadAux { get; set; }
    
        public virtual ComboProducto ComboProducto { get; set; }
        public virtual CotizacionVenta CotizacionVenta { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Servicio Servicio { get; set; }
    }
}
