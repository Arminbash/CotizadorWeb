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
    
    public partial class DetalleNotaCreditoProveedor
    {
        public int IdDetalleNotasCreditoProveedor { get; set; }
        public Nullable<int> IdNotaCreditoProveedor { get; set; }
        public Nullable<int> IdCompra { get; set; }
        public Nullable<int> IdCuentaContable { get; set; }
        public Nullable<decimal> MontoNota { get; set; }
        public Nullable<bool> Estado { get; set; }
        public string TipoDocumento { get; set; }
    
        public virtual NotaCreditoProveedor NotaCreditoProveedor { get; set; }
    }
}
