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
    
    public partial class sp_DatosDocumentoServicio_Result
    {
        public string Empleado { get; set; }
        public string Bodega { get; set; }
        public int IdKardex { get; set; }
        public int IdBodega { get; set; }
        public Nullable<int> IdDocumento { get; set; }
        public string Documento { get; set; }
        public string NombreSerie { get; set; }
        public string Consecutivo { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> RealizadoPor { get; set; }
    }
}
