using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.ViewModel
{
    public class VendedorViewModel
    {
        public int idVendedor { get; set; }
        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public int idEmpleado { get; set; }
        public string nombreVendedor { get; set; }
        public int idSegmento { get; set; }
        public string segmento { get; set; }
        public int idEmpresa { get; set; }

    }
}
