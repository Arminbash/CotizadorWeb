using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorWeb.Domain;
using CotizadorWeb.Domain.Model;
using CotizadorWeb.Infrastructure.IBase;
using CotizadorWeb.Infrastructure.IServices;
using CotizadorWeb.Infrastructure.ViewModel;
namespace CotizadorWeb.Services.Services
{
    public class UsuarioServices : IUsuarioService
    {
        #region("Initialized")
        private readonly DBContextGlobal _dbContext = new DBContextGlobal();
        #endregion

        public bool validarUsuario(UsuarioViewModel userVM)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var _usuario = myUnit.UsuarioRepository.GetEntities().Where(x => x.Usuario1 == userVM.Usuario && x.Contaseña == userVM.Password && x.Estatus == true).FirstOrDefault();
                    if (_usuario != null)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
        }

        public bool permisosUsuario(UsuarioViewModel userVM)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var _usuario = myUnit.UsuarioRepository.GetEntities().Where(x => x.Usuario1 == userVM.Usuario && x.Contaseña == userVM.Password && x.Estatus == true).FirstOrDefault();
                    int idModulo = myUnit.ListaModulosRepository.GetEntities().Where(x => x.NombreForm == "Cotización de Venta").FirstOrDefault().IdListaModulos;

                    var _permiso = myUnit.PermisoRepository.GetEntities().Where(x => x.IdTipoCuenta == _usuario.IdTipoCuenta && x.IdListaModulos == idModulo).FirstOrDefault();

                    if (_permiso != null)
                    {
                        if (_permiso.Ver == true)
                        {
                            var _vendedor = myUnit.VendedorRepository.GetEntities().Where(x => x.IdEmpleado == _usuario.IdEmpleado && x.Estado == true).FirstOrDefault();
                            if (_vendedor != null)
                            {
                                return true;
                            }
                        }
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
        }

        public int obtenerIdUsuario(UsuarioViewModel userVM)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var _usuario = myUnit.UsuarioRepository.GetEntities().Where(x => x.Usuario1 == userVM.Usuario && x.Contaseña == userVM.Password && x.Estatus == true).FirstOrDefault();
                    return _usuario.IdUsuario;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return 0;
                }
            }
        }

        public VendedorViewModel obtenerVendedor(int idUsuario)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var _usuario = myUnit.UsuarioRepository.GetEntities().Where(x => x.IdUsuario == idUsuario && x.Estatus == true).FirstOrDefault();
                    if (_usuario != null)
                    {
                        VendedorViewModel vendedor = new VendedorViewModel();
                        var _vendedor = myUnit.VendedorRepository.GetEntities().Where(x => x.IdEmpleado == _usuario.IdEmpleado).FirstOrDefault();
                        var _Empleado = myUnit.EmpleadoRepository.GetEntities().Where(x => x.IdEmpleado == _usuario.IdEmpleado).FirstOrDefault();
                        var _segmentoVendedor = myUnit.SegmentoRepository.FindBy(_vendedor.IdSegmento);

                        vendedor.idVendedor = _vendedor.IdVendedor;
                        vendedor.idUsuario = _usuario.IdUsuario;
                        vendedor.Usuario = _usuario.Usuario1;
                        vendedor.idEmpleado = _Empleado.IdEmpleado;
                        vendedor.nombreVendedor = _Empleado.Nombres + " " + _Empleado.Apellidos;
                        vendedor.idSegmento = _segmentoVendedor.IdSegmento;
                        vendedor.segmento = _segmentoVendedor.NombreSegmento;
                        vendedor.idEmpresa = (int)_Empleado.IdEmpresa;

                        return vendedor;
                    }
                    return new VendedorViewModel();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return new VendedorViewModel();
                }
            }
        }

    }
}
