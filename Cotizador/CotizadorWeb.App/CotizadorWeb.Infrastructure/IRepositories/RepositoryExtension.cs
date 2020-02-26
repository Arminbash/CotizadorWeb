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
        internal IEnumerable<T> _ListT;
        public Repository(DbContext dbContext, string query, params object[] parameters)
        {
            _context = dbContext;
            _ListT = dbContext.Database.SqlQuery<T>(query, parameters).ToList();
        }
        public IEnumerable<T> GetRequestQuery()
        {
            return _ListT;
        }
    }
}
