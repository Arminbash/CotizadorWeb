using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorWeb.Domain.Model;
using CotizadorWeb.Infrastructure;
using CotizadorWeb.Infrastructure.IBase;
using CotizadorWeb.Infrastructure.IServices;
using CotizadorWeb.Infrastructure.ViewModel;

namespace CotizadorWeb.Services.Services
{
    public class ProductosServices : IProdructoService
    {
        #region("Initialized")
        private readonly DBContextGlobal _dbContext = new DBContextGlobal();
        #endregion
        public IEnumerable<ProductoViewModel> getAll(int idSegmento,string moneda)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var _productos = myUnit.spDatosProductosXSegmentoRepository(idSegmento, moneda);
                    var _productosViewModel = new List<ProductoViewModel>();

                    foreach (spDatosProductosXSegmento_Result item in _productos)
                    {
                        ProductoViewModel _viewModel = new ProductoViewModel();

                        _viewModel.idProducto = item.IdProducto;
                        _viewModel.CodigoAlterno = item.CodigoAlterno;
                        _viewModel.CodigoOriginal = item.CodigoAlterno;
                        _viewModel.Nombre = item.Nombre;
                        _viewModel.Costo = (Decimal)item.Costo;
                        _viewModel.Marca = item.Marca;
                        _viewModel.Rubro = item.Rubro;
                        _viewModel.Linea = item.Linea;
                        _viewModel.Precio = (Decimal)item.Precio;
                        _viewModel.idSegmento = idSegmento;
                        _viewModel.Descuento = 0;
                        _viewModel.DescuentoMaximo = (Decimal)item.Descuento;
                        _viewModel.Iva = (Decimal)item.IVA;

                        _productosViewModel.Add(_viewModel);
                    }
                    return _productosViewModel;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return new List<ProductoViewModel>();
                }
            }
        }

        public ProductoViewModel getProductoXId(int idProducto, int idSegmento, string moneda)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var item = myUnit.spDatosProductosXSegmentoRepository(idSegmento,moneda).Where(x => x.IdProducto == idProducto).FirstOrDefault();
                    ProductoViewModel _Producto = new ProductoViewModel();

                    _Producto.idProducto = item.IdProducto;
                    _Producto.CodigoAlterno = item.CodigoAlterno;
                    _Producto.CodigoOriginal = item.CodigoAlterno;
                    _Producto.Nombre = item.Nombre;
                    _Producto.Costo = (Decimal)item.Costo;
                    _Producto.Marca = item.Marca;
                    _Producto.Rubro = item.Rubro;
                    _Producto.Linea = item.Linea;
                    _Producto.Precio = (Decimal)item.Precio;
                    _Producto.idSegmento = idSegmento;
                    _Producto.Descuento = 0;
                    _Producto.DescuentoMaximo =(Decimal) item.Descuento;
                    _Producto.Iva = (Decimal) item.IVA;
                    _Producto.Total = Math.Round( _Producto.Precio * (1 + (_Producto.Iva / 100)),2);

                    return _Producto;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return new ProductoViewModel();
                }
            }
        }

        public IEnumerable<ProductoViewModel> getProductosXFiltro(ProductoViewModel productoView, string moneda)
        {
            using (var myUnit = new UnitOfWork(new DBContextGlobal()))
            {
                try
                {
                    var _productos = myUnit.spDatosProductosXSegmentoRepository(productoView.idSegmento,moneda).
                        Where(x => x.CodigoAlterno.ToLower().Contains(productoView.CodigoAlterno.ToLower())
                        && x.CodigoOriginal.ToLower().Contains(productoView.CodigoOriginal.ToLower())
                        && x.Nombre.ToLower().Contains(productoView.Nombre.ToLower())
                        && x.Linea.ToLower().Contains(productoView.Linea.Trim().ToLower())
                        && x.Marca.ToLower().Contains(productoView.Marca.Trim().ToLower())
                        && x.Rubro.ToLower().Contains(productoView.Rubro.ToLower())
                        );
                    var _productosViewModel = new List<ProductoViewModel>();
                    foreach (spDatosProductosXSegmento_Result item in _productos)
                    {
                        ProductoViewModel _viewModel = new ProductoViewModel();

                        _viewModel.idProducto = item.IdProducto;
                        _viewModel.CodigoAlterno = item.CodigoAlterno;
                        _viewModel.CodigoOriginal = item.CodigoAlterno;
                        _viewModel.Nombre = item.Nombre;
                        _viewModel.Costo = (Decimal)item.Costo;
                        _viewModel.Marca = item.Marca;
                        _viewModel.Rubro = item.Rubro;
                        _viewModel.Linea = item.Linea;
                        _viewModel.Precio = (Decimal)item.Precio;
                        _viewModel.idSegmento = productoView.idSegmento;
                        _viewModel.Descuento = 0;
                        _viewModel.DescuentoMaximo = (Decimal)item.Descuento;
                        _viewModel.Iva = (Decimal)item.IVA;

                        _productosViewModel.Add(_viewModel);
                    }
                    return _productosViewModel;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return new List<ProductoViewModel>();
                }
            }
        }
    }
}
