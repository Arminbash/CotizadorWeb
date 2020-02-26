using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.IServices
{
    public interface ITasaCambioService
    {
        decimal obtenerTasaOficial(int idEmpresa, DateTime fecha);
        decimal obtenerTasaParalela(int idEmpresa, DateTime fecha);

    }
}
