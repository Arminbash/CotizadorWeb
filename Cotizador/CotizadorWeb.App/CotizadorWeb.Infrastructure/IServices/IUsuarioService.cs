using CotizadorWeb.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.IServices
{
    public interface IUsuarioService
    {
         bool validarUsuario(UsuarioViewModel userVM);
         bool permisosUsuario(UsuarioViewModel userVM);
    }
}
