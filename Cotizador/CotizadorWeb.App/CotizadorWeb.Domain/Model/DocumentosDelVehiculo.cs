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
    
    public partial class DocumentosDelVehiculo
    {
        public int IdDocumentosDelVehiculo { get; set; }
        public Nullable<int> IdFlotaSucursal { get; set; }
        public Nullable<int> IdSucursalDepartamento { get; set; }
        public string TipoDocumento { get; set; }
        public string NoCalcomania { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual FlotaSucursal FlotaSucursal { get; set; }
    }
}