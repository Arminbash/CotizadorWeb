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
    
    public partial class UbicacionEmpleado
    {
        public int IdUbicacionEmpleado { get; set; }
        public Nullable<int> IdSucursalDepartamento { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual SucursalDepartamento SucursalDepartamento { get; set; }
    }
}