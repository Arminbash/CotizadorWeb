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
    
    public partial class DetalleAsignacionTecnicoServicio
    {
        public int IdDetalleAsignacionTecnicoServicio { get; set; }
        public Nullable<int> IdAsignacionTecnicoServicio { get; set; }
        public Nullable<int> IdServicio { get; set; }
        public Nullable<int> IdMecanico { get; set; }
    
        public virtual AsignacionTecnicoServicio AsignacionTecnicoServicio { get; set; }
    }
}
