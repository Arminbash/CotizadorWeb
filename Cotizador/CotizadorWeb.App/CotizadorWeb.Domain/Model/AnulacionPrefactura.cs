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
    
    public partial class AnulacionPrefactura
    {
        public int IdAnulacionPrefactura { get; set; }
        public string Consecutivo { get; set; }
        public Nullable<int> IdSerie { get; set; }
        public string SerieConsecutivo { get; set; }
        public string Tipo { get; set; }
        public string Procedencia { get; set; }
        public Nullable<int> Identificador { get; set; }
        public string Motivo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> IdEncargadoAnulacion { get; set; }
    }
}