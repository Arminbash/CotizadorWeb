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
    
    public partial class VwMostrarDepartamentos
    {
        public int IdDepartamento { get; set; }
        public string ExtensionEncargado { get; set; }
        public string NombreDepartamento { get; set; }
        public string NombreEncargado { get; set; }
        public string CargoEncargado { get; set; }
        public string CelularEncargado { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
    }
}
