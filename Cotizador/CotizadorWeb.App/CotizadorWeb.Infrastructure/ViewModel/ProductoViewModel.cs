using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.ViewModel
{
    public class ProductoViewModel
    {
        public int idProducto { get; set; }
        public int idSegmento { get; set; }
        public string Nombre { get; set; }
        public string CodigoAlterno { get; set; }
        public string CodigoOriginal { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Rubro { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }

        public decimal Total { get; set; }

        public decimal Iva { get; set; }

        public decimal Descuento { get; set; }
        public decimal DescuentoMaximo { get; set; }

    }
}