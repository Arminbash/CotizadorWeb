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
    
    public partial class PeticionCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PeticionCompra()
        {
            this.DetallePeticionCompra = new HashSet<DetallePeticionCompra>();
        }
    
        public int IdPeticionCompra { get; set; }
        public Nullable<int> IdAsignar { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual AsignarProductos AsignarProductos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePeticionCompra> DetallePeticionCompra { get; set; }
    }
}
