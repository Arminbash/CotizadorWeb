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
    
    public partial class SpGetRecibosCajaChicaElaboradosXIdEmpleado_Result
    {
        public int IdReciboCajaChica { get; set; }
        public string Consecutivo { get; set; }
        public string NombreConcepto { get; set; }
        public string TipoPersona { get; set; }
        public string NombreBeneficiario { get; set; }
        public string NombreSucursal { get; set; }
        public string NombreDepartamento { get; set; }
        public Nullable<System.DateTime> AplicaDe { get; set; }
        public Nullable<System.DateTime> Hasta { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> RetencionIMI { get; set; }
        public Nullable<decimal> RetencionIR { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}
