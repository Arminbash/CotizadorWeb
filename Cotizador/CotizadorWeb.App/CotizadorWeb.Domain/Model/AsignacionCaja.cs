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
    
    public partial class AsignacionCaja
    {
        public int IdAsignacionCaja { get; set; }
        public string NombreEquipo { get; set; }
        public string Mac { get; set; }
        public Nullable<int> AsignadoPor { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<int> IdCaja { get; set; }
        public Nullable<int> LiberadoPor { get; set; }
    
        public virtual Caja Caja { get; set; }
    }
}
