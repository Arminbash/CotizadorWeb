using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorWeb.Domain.Model;
using CotizadorWeb.Infrastructure.IBase;
using CotizadorWeb.Infrastructure.IRepositories;
using CotizadorWeb.Infrastructure.IServices;
using CotizadorWeb.Infrastructure.ViewModel;


namespace CotizadorWeb.Infrastructure.IBase
{
    public partial class UnitOfWork : IUnitOfWork
    {
        public decimal getTasaOficialRepository(int idEmpresa, DateTime Fecha)
        {
            var _tasaOficial = new Repository<getTasaOficial>(dbContext, "select (dbo.getTasaOficial (@idEmpresa,@Fecha)) as Tasa",
                                                                new SqlParameter("idEmpresa", SqlDbType.Int) { Value = idEmpresa },
                                                                new SqlParameter("Fecha", SqlDbType.Date) { Value = Fecha.Date.ToString("yyyy/MM/dd") });
            return _tasaOficial.GetRequestQuery().First().Tasa;
        }

        public decimal getTasaParalelaRepository(int idEmpresa, DateTime Fecha)
        {
            var _tasaOficial = new Repository<getTasaParalela>(dbContext, "select (dbo.getTasaParalela (@idEmpresa,@Fecha)) as Tasa",
                                                                new SqlParameter("idEmpresa", SqlDbType.Int) { Value = idEmpresa },
                                                                new SqlParameter("Fecha", SqlDbType.Date) { Value = Fecha.Date.ToString("yyyy/MM/dd") });
            return _tasaOficial.GetRequestQuery().First().Tasa;
        }

        public SpGetPrecioProducto_Result SpGetPrecioProductoRepository(int IdProducto, int IdSegmento)
        {
            var _producto = new Repository<SpGetPrecioProducto_Result>(dbContext, "exec SpGetPrecioProducto @IdProducto, @IdSegmento",
                                                                        new SqlParameter("IdProducto", SqlDbType.Int) { Value = IdProducto },
                                                                        new SqlParameter("IdSegmento", SqlDbType.Int) { Value = IdSegmento });
            return _producto.GetRequestQuery().First();
        }

        public IEnumerable<SpFactorPrecio_Result> SpFactorPrecioRepository(int IdSegmento)
        {
            var _productos = new Repository<SpFactorPrecio_Result>(dbContext, "exec SpFactorPrecio @IdSegmento",
                                                                    new SqlParameter("IdSegmento", SqlDbType.Int) { Value = IdSegmento });
            return _productos.GetRequestQuery();
        }

        public IEnumerable<SpVistaStockXProducto_Result> SpVistaStockXProductoRepository(int IdEmpresa)
        {
            var _productos = new Repository<SpVistaStockXProducto_Result>(dbContext, "exec SpVistaStockXProducto @IdEmpresa",
                                                                            new SqlParameter("IdEmpresa", SqlDbType.Int) { Value = IdEmpresa });
            return _productos.GetRequestQuery();
        }

        public IEnumerable<spDatosProductosXSegmento_Result> spDatosProductosXSegmentoRepository(int IdSegmento,string moneda)
        {
            var _productos = new Repository<spDatosProductosXSegmento_Result>(dbContext, "exec spDatosProductosXSegmento @IdSegmento, @Moneda",
                                                                                new SqlParameter("IdSegmento", SqlDbType.Int) { Value = IdSegmento },
                                                                                new SqlParameter("Moneda", SqlDbType.VarChar, 15) { Value = moneda});
            return _productos.GetRequestQuery();
        }


    }
}
