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
    
    public partial class ConfiguracionFIN
    {
        public int IdConfiguracion { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public Nullable<decimal> TasaDeInteresPorUso { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual Bancos Bancos { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
