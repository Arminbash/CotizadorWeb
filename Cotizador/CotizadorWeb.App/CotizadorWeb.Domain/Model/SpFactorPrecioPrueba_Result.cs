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
    
    public partial class SpFactorPrecioPrueba_Result
    {
        public int IdProducto { get; set; }
        public int IdPrecioProducto { get; set; }
        public Nullable<int> IdSegmento { get; set; }
        public string CodigoAlterno { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> Factor { get; set; }
        public Nullable<decimal> FactorMinimo { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> PV { get; set; }
        public Nullable<decimal> PVMin { get; set; }
        public Nullable<decimal> DescuentoMax { get; set; }
        public Nullable<decimal> Margen { get; set; }
        public Nullable<decimal> MargenMin { get; set; }
        public string Rubro { get; set; }
        public string Linea { get; set; }
        public string Categoria { get; set; }
    }
}
