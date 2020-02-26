using CotizadorWeb.Domain.Model;
using CotizadorWeb.Infrastructure.IBase;
using CotizadorWeb.Infrastructure.IServices;
using CotizadorWeb.Infrastructure.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Services.Services
{
    public class ClienteServices : IClienteService
    {
        #region("Initialized")
        private readonly DBContextGlobal _dbContext = new DBContextGlobal();
        #endregion
        public IEnumerable<ClienteViewModel> getAll(int idEmpresa, int idUsuario)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var _usuario = myUnit.UsuarioRepository.FindBy(idUsuario);
                    var _vendedor = myUnit.VendedorRepository.GetEntities().Where(x => x.IdEmpleado == _usuario.IdEmpleado).FirstOrDefault();
                    var _segmentoVendedor = myUnit.SegmentoRepository.FindBy(_vendedor.IdSegmento);

                    var _clientes = myUnit.ClienteRepository.GetEntities().Where(x => x.IdEmpresa == idEmpresa).ToList();
                    if (_clientes != null)
                    {
                        List<ClienteViewModel> listClienteRequest = new List<ClienteViewModel>();
                        foreach (Cliente item in _clientes)
                        {
                            ClienteViewModel clienteItem = new ClienteViewModel();
                            clienteItem.idCliente = item.IdCliente;
                            clienteItem.Nombre = item.Nombre;
                            clienteItem.Ruc = item.Cedula;

                            var _clienteSeguimiento = myUnit.ClienteSeguimientoRepository.GetEntities().Where(x => x.IdCliente == item.IdCliente).FirstOrDefault();

                            if (_clienteSeguimiento != null)
                            {
                                clienteItem.TipoCliente = _clienteSeguimiento.CondicionPago;

                                var _segmento = myUnit.SegmentoRepository.FindBy(_clienteSeguimiento.IdSegmento);

                                if (_segmento != null)
                                {
                                    clienteItem.idSegmento = (int)_clienteSeguimiento.IdSegmento;
                                    clienteItem.Segmento = _segmento.NombreSegmento;
                                }
                                else
                                {
                                    clienteItem.idSegmento = _segmentoVendedor.IdSegmento;
                                    clienteItem.Segmento = _segmentoVendedor.NombreSegmento;
                                }
                            }
                            else
                            {
                                clienteItem.TipoCliente = "Contado";
                                clienteItem.idSegmento = _segmentoVendedor.IdSegmento;
                                clienteItem.Segmento = _segmentoVendedor.NombreSegmento;
                            }

                            listClienteRequest.Add(clienteItem);
                        }

                        return listClienteRequest;
                    }
                    return new List<ClienteViewModel>();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.ToString());
                    return new List<ClienteViewModel>();
                }
            }
        }
        public IEnumerable<ClienteViewModel> getXString(int idEmpresa, int idUsuario, string buscar)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var _usuario = myUnit.UsuarioRepository.FindBy(idUsuario);
                    var _vendedor = myUnit.VendedorRepository.GetEntities().Where(x => x.IdEmpleado == _usuario.IdEmpleado).FirstOrDefault();
                    var _segmentoVendedor = myUnit.SegmentoRepository.FindBy(_vendedor.IdSegmento);

                    var _clientes = myUnit.ClienteRepository.GetEntities().Where(x => x.IdEmpresa == idEmpresa && (x.Nombre.ToLower().Contains(buscar.Trim().ToLower()) || x.Cedula.ToLower().Contains(buscar.Trim().ToLower()))).ToList();
                    if (_clientes != null)
                    {
                        List<ClienteViewModel> listClienteRequest = new List<ClienteViewModel>();
                        foreach (Cliente item in _clientes)
                        {
                            ClienteViewModel clienteItem = new ClienteViewModel();
                            clienteItem.idCliente = item.IdCliente;
                            clienteItem.Nombre = item.Nombre;
                            clienteItem.Ruc = item.Cedula;

                            var _clienteSeguimiento = myUnit.ClienteSeguimientoRepository.GetEntities().Where(x => x.IdCliente == item.IdCliente).FirstOrDefault();

                            if (_clienteSeguimiento != null)
                            {
                                clienteItem.TipoCliente = _clienteSeguimiento.CondicionPago;

                                var _segmento = myUnit.SegmentoRepository.FindBy(_clienteSeguimiento.IdSegmento);

                                if (_segmento != null)
                                {
                                    clienteItem.idSegmento = (int)_clienteSeguimiento.IdSegmento;
                                    clienteItem.Segmento = _segmento.NombreSegmento;
                                }
                                else
                                {
                                    clienteItem.idSegmento = _segmentoVendedor.IdSegmento;
                                    clienteItem.Segmento = _segmentoVendedor.NombreSegmento;
                                }
                            }
                            else
                            {
                                clienteItem.TipoCliente = "Contado";
                                clienteItem.idSegmento = _segmentoVendedor.IdSegmento;
                                clienteItem.Segmento = _segmentoVendedor.NombreSegmento;
                            }

                            listClienteRequest.Add(clienteItem);
                        }

                        return listClienteRequest;
                    }
                    return new List<ClienteViewModel>();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.ToString());
                    return new List<ClienteViewModel>();
                }
            }
        }
        public ClienteViewModel getClienteXId(int idCliente, int idUsuario)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var _usuario = myUnit.UsuarioRepository.FindBy(idUsuario);
                    var _vendedor = myUnit.VendedorRepository.GetEntities().Where(x => x.IdEmpleado == _usuario.IdEmpleado).FirstOrDefault();
                    var _segmentoVendedor = myUnit.SegmentoRepository.FindBy(_vendedor.IdSegmento);

                    var _cliente = myUnit.ClienteRepository.GetEntities().Where(x => x.IdCliente == idCliente).FirstOrDefault();

                    if (_cliente != null)
                    {
                        ClienteViewModel clienteItem = new ClienteViewModel();
                        clienteItem.idCliente = _cliente.IdCliente;
                        clienteItem.Nombre = _cliente.Nombre;
                        clienteItem.Ruc = _cliente.Cedula;

                        var _clienteSeguimiento = myUnit.ClienteSeguimientoRepository.GetEntities().Where(x => x.IdCliente == _cliente.IdCliente).FirstOrDefault();

                        if (_clienteSeguimiento != null)
                        {
                            clienteItem.TipoCliente = _clienteSeguimiento.CondicionPago;

                            var _segmento = myUnit.SegmentoRepository.FindBy(_clienteSeguimiento.IdSegmento);

                            if (_segmento != null)
                            {
                                clienteItem.idSegmento = (int)_clienteSeguimiento.IdSegmento;
                                clienteItem.Segmento = _segmento.NombreSegmento;
                            }
                            else
                            {
                                clienteItem.idSegmento = _segmentoVendedor.IdSegmento;
                                clienteItem.Segmento = _segmentoVendedor.NombreSegmento;
                            }
                        }
                        else
                        {
                            clienteItem.TipoCliente = "Contado";
                            clienteItem.idSegmento = _segmentoVendedor.IdSegmento;
                            clienteItem.Segmento = _segmentoVendedor.NombreSegmento;
                        }

                        return clienteItem;
                    }
                    else
                    {
                        return new ClienteViewModel();
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.ToString());
                    return new ClienteViewModel();
                }
            }
        }
    }
}
