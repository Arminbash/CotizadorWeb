using System;
using System.Collections.Generic;
using CotizadorWeb.Domain;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace CotizadorWeb.Infrastructure.IRepositories
{
    public partial class Repository<T> : IRepository<T> where T : class
    {
        #region("Variables Globales")
        internal DbContext _context;
        internal DbSet<T> _dbset;
        #endregion
        #region("Constructor")
        public Repository(DbContext dbContext)
        {
            _context = dbContext;
            _dbset = dbContext.Set<T>();
        }
        #endregion
        #region("Implementacion Interfaz")
        public void AddOrUpdateEntity(T entity)
        {
            _dbset.AddOrUpdate(entity);
        }

        public void DeleteEntity(int? id)
        {
            var entity = _dbset.Find(id);
            _dbset.Remove(entity);
        }

        public T FindBy(int? id)
        {
            return _dbset.Find(id);
        }

        public IEnumerable<T> GetEntities()
        {
            return _dbset;
        }     
        #endregion
    }
}
