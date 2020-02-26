using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.ViewModel
{
    public class ListProductoViewModel : BaseModelo
    {
        public List<ProductoViewModel> productoViewModels { get; set; }
    }
}
