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
    
    public partial class SpDetallePedido_Result
    {
        public int IdDetallePedido { get; set; }
        public int IdPedido { get; set; }
        public int IdCalendarioAlimento { get; set; }
        public string TipoAlimento { get; set; }
        public System.DateTime Fecha { get; set; }
        public byte[] Imagen { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public string Estado { get; set; }
    }
}
