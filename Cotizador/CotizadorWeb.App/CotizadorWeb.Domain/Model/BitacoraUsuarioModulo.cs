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
    
    public partial class BitacoraUsuarioModulo
    {
        public int IdBitacoraUsuarioModulo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string NombreModulo { get; set; }
        public string TipoGestion { get; set; }
        public Nullable<int> RegistroAfectado { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public string NombreTabla { get; set; }
        public string Sistema { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}