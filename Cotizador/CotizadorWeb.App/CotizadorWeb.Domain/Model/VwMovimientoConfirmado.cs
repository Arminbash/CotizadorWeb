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
    
    public partial class VwMovimientoConfirmado
    {
        public int IdEmpleadoPuesto { get; set; }
        public int IdEmpleado { get; set; }
        public int IdPuesto { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Puesto { get; set; }
        public Nullable<decimal> SalarioMensual { get; set; }
        public string TipoMoneda { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Observacion { get; set; }
        public string MovimientoEstado { get; set; }
    }
}
