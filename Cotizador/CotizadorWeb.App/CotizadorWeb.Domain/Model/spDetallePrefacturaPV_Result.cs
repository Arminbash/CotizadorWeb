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
    
    public partial class spDetallePrefacturaPV_Result
    {
        public string Tipo { get; set; }
        public int Identificador { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> PrecioTotal { get; set; }
    }
}
