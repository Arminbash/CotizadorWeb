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
    
    public partial class ProveedorContacto
    {
        public int IdProveedorContacto { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdContacto { get; set; }
    
        public virtual Contacto Contacto { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
