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
    
    public partial class sp_TrasladosDirectosSinDespacho_Result
    {
        public int IdTraslado { get; set; }
        public string Consecutivo { get; set; }
        public string TipoTraslado { get; set; }
        public string BodegaDestino { get; set; }
        public Nullable<int> CantidadItem { get; set; }
        public Nullable<decimal> CantidadAprobada { get; set; }
    }
}