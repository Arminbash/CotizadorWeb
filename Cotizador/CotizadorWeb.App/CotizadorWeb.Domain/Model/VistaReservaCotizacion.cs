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
    
    public partial class VistaReservaCotizacion
    {
        public int IdReserva { get; set; }
        public int IdCotizacion { get; set; }
        public string Cotizacion { get; set; }
        public string NombreSerie { get; set; }
        public string NombreBodega { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> FechaValidez { get; set; }
        public string Vendedor { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
    }
}