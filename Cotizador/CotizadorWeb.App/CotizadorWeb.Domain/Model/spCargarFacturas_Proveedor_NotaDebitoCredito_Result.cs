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
    
    public partial class spCargarFacturas_Proveedor_NotaDebitoCredito_Result
    {
        public int IdDetalleNotasCreditoProveedor { get; set; }
        public Nullable<int> IDCOMPRA { get; set; }
        public string CONSECUTIVOCOMPRA { get; set; }
        public string NOFACTURA { get; set; }
        public string PROCEDENCIA { get; set; }
        public Nullable<System.DateTime> FECHACOMPRA { get; set; }
        public string MONEDA { get; set; }
        public Nullable<decimal> TOTALFACTURA { get; set; }
        public Nullable<decimal> TOTALDEVOLUCION { get; set; }
        public Nullable<decimal> TOTALABONO { get; set; }
        public Nullable<decimal> TOTALNOTACREDITOAPLICADA { get; set; }
        public Nullable<decimal> MONTOPENDIENTE { get; set; }
        public Nullable<decimal> MontoNota { get; set; }
    }
}
