using CotizadorWeb.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using CotizadorWeb.Domain.Model;

namespace CotizadorWeb.Infrastructure
{
    public class ServiceInjector : IServiceInjector
    {
        private IKernel _kernel;
        private List<Type> _types;


        /// <summary>
        /// Constructor, initialize IOC
        /// </summary>
        public ServiceInjector()
        {
            _kernel = new StandardKernel();
            _types = new List<Type>();


            //bind infrastructure services
            _kernel.Bind<IServiceInjector>().ToConstant(this);
            _kernel.Bind<DbContext>().To<DBContextGlobal>();
            _kernel.Bind<IServiceBus>().To<ServiceBus>();


            //bind command services
            //_kernel.Bind<IProductoCommandService>().To<ProductoCommandService>();
            //_types.Add(typeof(IProductoCommandService));

        }

        /// <summary>
        /// Resolve dependency by type
        /// </summary>
        public object Get(Type type)
        {
            return _kernel.Get(type);
        }


        /// <summary>
        /// Resolve dependency by generic
        /// </summary>
        public T Get<T>()
        {
            return _kernel.Get<T>();
        }


        /// <summary>
        /// Get list of registered types
        /// </summary>
        public List<Type> GetTypes()
        {
            return _types;
        }


        /// <summary>
        /// Use this method to instruct IOC about a new binding-association
        /// </summary>
        public void Bind<Intfc, Implm>() where Implm : Intfc
        {
            _kernel.Bind<Intfc>().To<Implm>();
        }

    }
}
