using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.ViewModel
{
    public class BaseModelo
    {
        public string TipoPaginador { get; set; }
        public int PaginaActual { get; set; }
        public int TotalDeRegistros { get; set; }
        public int RegistroPorPagina { get; set; }
    }
}
