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
    
    public partial class DocumentoDesvinculacion
    {
        public int IdDocDesvinculacion { get; set; }
        public Nullable<int> IdDocSoporte { get; set; }
        public Nullable<int> IdDesvinculacion { get; set; }
    
        public virtual DesvinculacionPersonal DesvinculacionPersonal { get; set; }
        public virtual DocumentoSoporte DocumentoSoporte { get; set; }
    }
}