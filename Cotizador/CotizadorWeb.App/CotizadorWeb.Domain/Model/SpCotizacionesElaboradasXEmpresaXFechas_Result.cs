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
    
    public partial class SpCotizacionesElaboradasXEmpresaXFechas_Result
    {
        public Nullable<int> IdCotizacion { get; set; }
        public string NoCotizacion { get; set; }
        public Nullable<System.DateTime> FechaElaboracion { get; set; }
        public string Cliente { get; set; }
        public string Asesor { get; set; }
        public string TipoMoneda { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}