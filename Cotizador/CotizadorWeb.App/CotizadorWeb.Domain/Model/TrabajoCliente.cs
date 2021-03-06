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
    
    public partial class TrabajoCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrabajoCliente()
        {
            this.ConfirmarCita = new HashSet<ConfirmarCita>();
            this.DetalleTrabajoCliente = new HashSet<DetalleTrabajoCliente>();
        }
    
        public int IdTrabajoCliente { get; set; }
        public Nullable<int> IdFlotaCliente { get; set; }
        public Nullable<int> IdAsesor { get; set; }
        public string Estado { get; set; }
        public Nullable<int> PametroAvisoHora { get; set; }
        public Nullable<int> HorometroActual { get; set; }
        public Nullable<int> HorometroFinal { get; set; }
        public Nullable<int> ParametroAvisoFecha { get; set; }
        public Nullable<System.DateTime> FechaFinal { get; set; }
        public Nullable<System.DateTime> FechaActual { get; set; }
        public Nullable<int> ParametroAvisoKilometraje { get; set; }
        public Nullable<int> KilometrajeActual { get; set; }
        public Nullable<int> KilometrajeFinal { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfirmarCita> ConfirmarCita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleTrabajoCliente> DetalleTrabajoCliente { get; set; }
        public virtual FlotaCliente FlotaCliente { get; set; }
    }
}
