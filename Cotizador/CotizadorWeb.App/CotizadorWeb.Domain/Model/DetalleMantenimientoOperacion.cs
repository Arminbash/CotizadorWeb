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
    
    public partial class DetalleMantenimientoOperacion
    {
        public int IdDetalleMantenimientoOperacion { get; set; }
        public Nullable<int> IdMantenimientoOperacion { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Estatus { get; set; }
        public Nullable<bool> servicio { get; set; }
        public Nullable<bool> producto { get; set; }
    
        public virtual MantenimientoOperacion MantenimientoOperacion { get; set; }
    }
}
