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
    
    public partial class spCargarDatosPagoRealizadoTesoreria_MovimientoBancarioXCuenta_Result
    {
        public Nullable<int> IdPagoRealizadoTesoreria { get; set; }
        public Nullable<int> IdCuentaBanco { get; set; }
        public string PersonaRealiza { get; set; }
        public string Banco { get; set; }
        public string CuentaBanco { get; set; }
        public string Consecutivo { get; set; }
        public string TipoPago { get; set; }
        public Nullable<decimal> MontoTotalPago { get; set; }
        public string BancoBeneficiario { get; set; }
        public string CuentaBancoBeneficiario { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    }
}
