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
    
    public partial class VwMostrarPuestos
    {
        public int IdPuesto { get; set; }
        public string Puesto { get; set; }
        public string Resumen { get; set; }
        public string Relaciones { get; set; }
        public string NivelAcademico { get; set; }
        public string ExperienciaPrevia { get; set; }
        public string Lugar { get; set; }
        public string Objetivos { get; set; }
        public decimal SalarioMinimo { get; set; }
        public decimal SalarioMaximo { get; set; }
        public string TipoMoneda { get; set; }
        public bool Estado { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public Nullable<int> IdPuestoSuperior { get; set; }
        public string NombreDepartamento { get; set; }
        public string NombreEncargado { get; set; }
    }
}
