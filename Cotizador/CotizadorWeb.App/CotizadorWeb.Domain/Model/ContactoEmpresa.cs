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
    
    public partial class ContactoEmpresa
    {
        public int IdContactoEmpresa { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public string NombreRep { get; set; }
        public string CargoRep { get; set; }
        public string CelularRep { get; set; }
        public string ExtensionRep { get; set; }
        public string CorreoRep { get; set; }
        public string RedSocialRep { get; set; }
    
        public virtual Empresa Empresa { get; set; }
    }
}
