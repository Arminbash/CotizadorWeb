using CotizadorWeb.Domain.Model;
using CotizadorWeb.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.IServices
{
    public interface IClienteService
    {
        IEnumerable<ClienteViewModel> getAll(int idEmpresa,int idUsuario);
    }
}
