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
    
    public partial class Permiso
    {
        public int IdPermiso { get; set; }
        public Nullable<bool> Ver { get; set; }
        public Nullable<bool> Guardar { get; set; }
        public Nullable<bool> Modificar { get; set; }
        public Nullable<bool> Eliminar { get; set; }
        public Nullable<int> IdListaModulos { get; set; }
        public Nullable<int> IdTipoCuenta { get; set; }
    
        public virtual ListaModulos ListaModulos { get; set; }
        public virtual TipoCuenta TipoCuenta { get; set; }
    }
}
