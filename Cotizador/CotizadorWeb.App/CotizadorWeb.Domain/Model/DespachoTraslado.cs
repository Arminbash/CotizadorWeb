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
    
    public partial class DespachoTraslado
    {
        public int IdDespachoTraslado { get; set; }
        public Nullable<int> IdDespachador { get; set; }
        public Nullable<int> IdRepartidor { get; set; }
        public Nullable<System.DateTime> FechaEnviado { get; set; }
        public Nullable<int> IdTraslado { get; set; }
        public string ObservacionEnvio { get; set; }
        public string Estado { get; set; }
        public Nullable<int> IdEncargadoRecibir { get; set; }
        public Nullable<System.DateTime> FechaRecibido { get; set; }
        public string ObservacionRecibido { get; set; }
    
        public virtual Traslado Traslado { get; set; }
    }
}
