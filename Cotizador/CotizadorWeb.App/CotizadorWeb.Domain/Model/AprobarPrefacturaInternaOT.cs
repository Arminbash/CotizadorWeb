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
    
    public partial class AprobarPrefacturaInternaOT
    {
        public int IdAprobarPrefacturaInternaOT { get; set; }
        public Nullable<int> IdPreFacturaInternaOT { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual PreFacturaInternaOT PreFacturaInternaOT { get; set; }
    }
}
