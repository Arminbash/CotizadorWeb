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
    
    public partial class SPCARGARNOTADEBITO_PROVEEDOR_NOTACREDITO_Result
    {
        public int IDDETALLENOTASCREDITOPROVEEDOR { get; set; }
        public Nullable<int> IDNOTADEBITO { get; set; }
        public Nullable<System.DateTime> FECHAINGRESO { get; set; }
        public string CONSECUTIVO { get; set; }
        public string NONOTADEBITO { get; set; }
        public string MONEDA { get; set; }
        public Nullable<decimal> MONTONOTADEBITO { get; set; }
        public Nullable<decimal> TOTALABONO { get; set; }
        public Nullable<decimal> TOTALNOTACREDITOAPLICADA { get; set; }
        public Nullable<decimal> MONTOPENDIENTE { get; set; }
        public Nullable<decimal> MONTONOTA { get; set; }
    }
}