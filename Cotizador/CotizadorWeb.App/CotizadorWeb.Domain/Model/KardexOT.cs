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
    
    public partial class KardexOT
    {
        public int IdKardexOT { get; set; }
        public Nullable<long> IdKardex { get; set; }
        public int IdOrdenTrabajo { get; set; }
    
        public virtual Kardex Kardex { get; set; }
    }
}
