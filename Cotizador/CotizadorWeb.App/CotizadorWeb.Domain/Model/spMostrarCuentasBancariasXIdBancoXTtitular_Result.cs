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
    
    public partial class spMostrarCuentasBancariasXIdBancoXTtitular_Result
    {
        public Nullable<int> IdCuentaBancaria { get; set; }
        public string Sucursal { get; set; }
        public string TipoTitular { get; set; }
        public string TitularCuenta { get; set; }
        public string Banco { get; set; }
        public string NoCuenta { get; set; }
        public string TipoMoneda { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<System.DateTime> FechaElaboracion { get; set; }
    }
}
