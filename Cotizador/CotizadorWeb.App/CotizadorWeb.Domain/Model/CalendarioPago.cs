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
    
    public partial class CalendarioPago
    {
        public int IdCalendarioPago { get; set; }
        public Nullable<int> IdAdelanto { get; set; }
        public string Periodo { get; set; }
        public Nullable<decimal> Cuota { get; set; }
        public string Estado { get; set; }
    
        public virtual Adelanto Adelanto { get; set; }
    }
}
