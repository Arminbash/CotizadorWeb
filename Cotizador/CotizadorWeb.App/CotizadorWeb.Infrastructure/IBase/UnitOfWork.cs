using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorWeb.Domain;
using CotizadorWeb.Domain.Model;
using CotizadorWeb.Infrastructure.IRepositories;

namespace CotizadorWeb.Infrastructure.IBase
{
    public partial class UnitOfWork : IUnitOfWork
    {
        private Repository<Usuario> _usuario; private Repository<Empleado> _empleado; private Repository<ListaModulos> _listaModulos; private Repository<Permiso> _permiso;
        private Repository<Vendedor> _vendedor; private Repository<TasaCambio> _tasaCambio; private Repository<Cliente> _cliente;private Repository<Segmento> _segmento ;
        private Repository<ClienteSeguimiento> _clienteSeguimiento; private Repository<Producto> _producto; private Repository<PrecioProducto> _precioProducto;

        private readonly DbContext dbContext;
        #region("Constructor")
        public UnitOfWork(DbContext context)
        {
            dbContext = context;
        }
        #endregion
        #region("Implementacion Interfaz")
        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        private bool disposed = false;

        public IRepository<Usuario> UsuarioRepository
        {
            get { return _usuario ?? (_usuario = new Repository<Usuario>(dbContext)); }
        }

        public IRepository<TasaCambio> TasaCambioRepository
        {
            get { return _tasaCambio ?? (_tasaCambio = new Repository<TasaCambio>(dbContext)); }
        }
        public IRepository<Empleado> EmpleadoRepository
        {
            get { return _empleado ?? (_empleado = new Repository<Empleado>(dbContext)); }
        }
        public IRepository<ListaModulos> ListaModulosRepository
        {
            get { return _listaModulos ?? (_listaModulos = new Repository<ListaModulos>(dbContext)); }
        }
        public IRepository<Permiso> PermisoRepository
        {
            get { return _permiso ?? (_permiso = new Repository<Permiso>(dbContext)); }
        }

        public IRepository<Vendedor> VendedorRepository
        {
            get { return _vendedor ?? (_vendedor = new Repository<Vendedor>(dbContext)); }
        }

        public IRepository<Cliente> ClienteRepository {
            get { return _cliente ?? (_cliente = new Repository<Cliente>(dbContext)); }
        }

        public IRepository<ClienteSeguimiento> ClienteSeguimientoRepository { 
            get { return _clienteSeguimiento ?? (_clienteSeguimiento = new Repository<ClienteSeguimiento>(dbContext)); }
        }

        public IRepository<Segmento> SegmentoRepository
        {
            get { return _segmento ?? (_segmento = new Repository<Segmento>(dbContext)); }
        }

        public IRepository<Producto> ProductoRepository
        {
            get { return _producto ?? (_producto = new Repository<Producto>(dbContext)); }
        }

        public IRepository<PrecioProducto> PrecioProductoRepository
        {
            get { return _precioProducto ?? (_precioProducto = new Repository<PrecioProducto>(dbContext)); }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
