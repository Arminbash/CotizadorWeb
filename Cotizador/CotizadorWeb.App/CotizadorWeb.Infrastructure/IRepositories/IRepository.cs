using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.IRepositories
{
    public interface IRepository<T> where T : class
    {
        void AddOrUpdateEntity(T entity);
        void DeleteEntity(int? id);
        T FindBy(int? id);
        IEnumerable<T> GetEntities();
        IEnumerable<T> GetRequestQuery();
    }
}
