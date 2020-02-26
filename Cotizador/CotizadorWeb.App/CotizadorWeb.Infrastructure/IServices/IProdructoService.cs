using CotizadorWeb.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.IServices
{
    public interface IProdructoService
    {
        IEnumerable<ProductoViewModel> getAll(int idSegmento,string moneda);
        ProductoViewModel getProductoXId(int idProducto, int idSegmento, string moneda);
        IEnumerable<ProductoViewModel> getProductosXFiltro(ProductoViewModel productoView, string moneda);
    }
}
