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
    
    public partial class SpVistaTrabajosExternosXEmpresa_Result
    {
        public int IdTrabajoExterno { get; set; }
        public string NoFactura { get; set; }
        public string NoOrdenTrabajo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public string NombreProveedor { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string TipoPago { get; set; }
        public string Moneda { get; set; }
        public Nullable<decimal> Monto { get; set; }
        public Nullable<decimal> TasaCambio { get; set; }
    }
}
