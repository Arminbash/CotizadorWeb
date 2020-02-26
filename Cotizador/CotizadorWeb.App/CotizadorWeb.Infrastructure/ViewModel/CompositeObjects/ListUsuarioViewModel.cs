using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.ViewModel
{
    public class ListUsuarioViewModel : BaseModelo
    {
        public List<ClienteViewModel> clienteViewModels  { get; set; }

    }
}
