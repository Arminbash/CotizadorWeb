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
    
    public partial class MecanicosVehiculoProceso
    {
        public int IdMecanicosVehiculoProceso { get; set; }
        public Nullable<int> IdVehiculoProcesoEstaciones { get; set; }
        public Nullable<int> IdMecanico { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual Mecanicos Mecanicos { get; set; }
        public virtual VehiculoProcesoEstaciones VehiculoProcesoEstaciones { get; set; }
    }
}
