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
    
    public partial class spDatosTrasladoParaReporte_Result
    {
        public string Consecutivo { get; set; }
        public string TipoTraslado { get; set; }
        public string CodBodegaOrigen { get; set; }
        public string BodegaOrigen { get; set; }
        public string CodBodegaDestino { get; set; }
        public string BodegaDestino { get; set; }
        public string Empleado { get; set; }
        public string CodigoEmpleado { get; set; }
        public Nullable<System.DateTime> FechaAprobado { get; set; }
        public Nullable<System.DateTime> FechaEnviado { get; set; }
        public string ObservacionEnvio { get; set; }
    }
}
