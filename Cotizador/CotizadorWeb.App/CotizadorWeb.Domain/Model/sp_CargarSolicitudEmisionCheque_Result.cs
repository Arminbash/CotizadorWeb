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
    
    public partial class sp_CargarSolicitudEmisionCheque_Result
    {
        public int IdSolicitudCheque { get; set; }
        public Nullable<System.DateTime> FechaSolicitud { get; set; }
        public string NombreDepartamento { get; set; }
        public string Solicitante { get; set; }
        public string AprobadoPor { get; set; }
        public string Beneficiario { get; set; }
        public Nullable<decimal> MontoCheque { get; set; }
        public string SiglasMoneda { get; set; }
        public string EnConceptoDe { get; set; }
    }
}
