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
    
    public partial class DetalleActivacionFlota
    {
        public int IdDetalleActivacionFlota { get; set; }
        public Nullable<int> IdActivacionFlota { get; set; }
        public Nullable<int> IdFlotaSucursal { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Estado { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual ActivacionFlota ActivacionFlota { get; set; }
        public virtual FlotaSucursal FlotaSucursal { get; set; }
    }
}
