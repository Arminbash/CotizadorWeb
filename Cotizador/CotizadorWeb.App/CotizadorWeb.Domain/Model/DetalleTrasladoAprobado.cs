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
    
    public partial class DetalleTrasladoAprobado
    {
        public int IdDetalleTrasladoAprobado { get; set; }
        public Nullable<int> IdDetalleTrasladoSolicitado { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public string Observacion { get; set; }
    
        public virtual DetalleTrasladoSolicitado DetalleTrasladoSolicitado { get; set; }
        public virtual Producto Producto { get; set; }
    }
}