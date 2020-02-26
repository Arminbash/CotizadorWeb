using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorWeb.Domain.Model;
using CotizadorWeb.Infrastructure.IBase;
using CotizadorWeb.Infrastructure.IServices;
using CotizadorWeb.Infrastructure.ViewModel;

namespace CotizadorWeb.Services.Services
{
    public class TasaCambioServices : ITasaCambioService
    {
        #region("Initialized")
        private readonly DBContextGlobal _dbContext = new DBContextGlobal();
        #endregion
        public decimal obtenerTasaOficial(int idEmpresa, DateTime fecha)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    decimal tasa = myUnit.getTasaOficialRepository(idEmpresa, fecha);

                    return tasa;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.ToString());
                    return 0;
                }
            }
        }
        public decimal obtenerTasaParalela(int idEmpresa, DateTime fecha)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var tasa = myUnit.getTasaParalelaRepository(idEmpresa, fecha);

                    return tasa;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.ToString());
                    return 0;
                }
            }
        }
    }
}
