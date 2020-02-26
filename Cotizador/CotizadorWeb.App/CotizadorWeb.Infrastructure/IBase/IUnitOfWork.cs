using CotizadorWeb.Domain.Model;
using CotizadorWeb.Domain;
using CotizadorWeb.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CotizadorWeb.Infrastructure.IBase
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Usuario> UsuarioRepository { get; }
        IRepository<TasaCambio> TasaCambioRepository { get; }
        IRepository<Empleado> EmpleadoRepository { get; }
        IRepository<ListaModulos> ListaModulosRepository { get; }
        IRepository<Permiso> PermisoRepository { get; }
        IRepository<Vendedor> VendedorRepository { get; }
        IRepository<Cliente> ClienteRepository { get; }
        IRepository<ClienteSeguimiento> ClienteSeguimientoRepository { get; }
        IRepository<Segmento> SegmentoRepository { get; }
        IRepository<Producto> ProductoRepository { get; }
        IRepository<PrecioProducto> PrecioProductoRepository { get; }
        void SaveChanges();
    }
}
