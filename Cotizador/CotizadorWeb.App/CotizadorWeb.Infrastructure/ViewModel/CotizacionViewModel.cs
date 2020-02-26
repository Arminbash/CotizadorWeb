using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CotizadorWeb.Infrastructure.ViewModel
{
    public class CotizacionViewModel 
    {
        //Base
        public int IdSerie { get; protected set; }
        public String Consecutivo { get; protected set; }
        public DateTime Fecha { get; protected set; }
        public decimal TasaParalela { get; protected set; }
        public int Plazo { get; protected set; }
        public string Moneda { get; protected set; }

        //Segment
        public int IdSegmento { get; protected set; }
        public String Segmento { get; protected set; }

        //seller
        public int IdVendedor { get; protected set; }
        public String NombreVendedor { get; protected set; }

        //Client
        public int IdCliente { get; protected set; }
        public String NombreCliente { get; protected set; }


        public static CotizacionViewModel CreateNew(int idSerie, string consecutivo, DateTime fecha, decimal tasaParalela, int plazo, string moneda,
            int idSegmento, string segmento, int idVendedor, string nombreVendedor, int idCliente, string nombreCliente)
        {
            Validate.NotNull(consecutivo, "CotizacionViewModel.Consecutivo is required");
            Validate.NotNull(moneda, "CotizacionViewModel.moneda is required");
            Validate.NotNull(segmento, "CotizacionViewModel.segmento is required");
            Validate.NotNull(nombreVendedor, "CotizacionViewModel.nombreVendedor is required");
            Validate.NotNull(nombreCliente, "CotizacionViewModel.nombreCliente is required");
            return new CotizacionViewModel()
            {
                IdSerie = idSerie,
                Consecutivo = consecutivo,
                Fecha = fecha,
                TasaParalela = tasaParalela,
                Plazo = plazo,
                Moneda = moneda,
                IdSegmento = idSegmento,
                Segmento = segmento,
                IdVendedor = idVendedor,
                NombreVendedor = nombreVendedor,
                IdCliente = idCliente,
                NombreCliente = nombreCliente 
            };
        }

    }
}
