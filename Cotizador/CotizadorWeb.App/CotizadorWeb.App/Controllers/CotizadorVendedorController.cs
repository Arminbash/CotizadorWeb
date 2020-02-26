using CotizadorWeb.Services.Services;
using System;
using System.Linq;
using System.Web.Mvc;
using CotizadorWeb.Infrastructure.ViewModel;
using CotizadorWeb.App.Tools;

namespace CotizadorWeb.App.Controllers
{
    [Authorize]
    public class CotizadorVendedorController : Controller
    {
        private readonly UsuarioServices _userService = new UsuarioServices();
        private readonly TasaCambioServices _tasaService = new TasaCambioServices()  ;
        private readonly ClienteServices _clienteServices = new ClienteServices();
        private readonly ProductosServices _productoService = new ProductosServices();

        // GET: CotizadorVendedor
        public ActionResult Index()
        {
            int _idUsuario = SessionHelper.GetUser();

            VendedorViewModel vendedor = _userService.obtenerVendedor(_idUsuario);

            var tasaOficial = _tasaService.obtenerTasaOficial(vendedor.idEmpresa, DateTime.Now);
            var tasaParalela = _tasaService.obtenerTasaParalela(vendedor.idEmpresa, DateTime.Now);
            ViewBag.TasaOficial = tasaOficial;
            ViewBag.TasaParalela = tasaParalela;
            ViewData["vendedor"] = vendedor;
            return View();
        }
        public ActionResult CerrarSesion()
        {
            try
            {
                SessionHelper.DestroyUserSession();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpGet]
        public PartialViewResult ModalClientes(int pagina)
        {
            int _idUsuario = SessionHelper.GetUser();
            VendedorViewModel vendedor = _userService.obtenerVendedor(_idUsuario);

            int pag = pagina;
            var cantidadRegistroPorPagina = 5;
            var ListaClientes = _clienteServices.getAll(vendedor.idEmpresa, vendedor.idUsuario);
            var clientes = ListaClientes
                .OrderByDescending(r => r.idCliente)
                .Skip((pagina - 1) * cantidadRegistroPorPagina)
                .Take(cantidadRegistroPorPagina).ToList();

            var totalDeRegistro = ListaClientes.Count();

            var modelo = new ListUsuarioViewModel();
            modelo.TipoPaginador = "Clientes";
            modelo.clienteViewModels = clientes;
            modelo.PaginaActual = pagina;
            modelo.TotalDeRegistros = totalDeRegistro;
            modelo.RegistroPorPagina = cantidadRegistroPorPagina;


            return PartialView("~/Views/Shared/Modals/_ModalClientes.cshtml", modelo);
        }

        [HttpGet]
        public PartialViewResult ModalProductos(int pagina,int idSegmento, string codAlterno, string codOriginal, string nombre,
                                                                  string marca, string linea, string rubro)
        {
            ProductoViewModel productoView = new ProductoViewModel();
            productoView.idSegmento = idSegmento;
            productoView.CodigoAlterno = codAlterno;
            productoView.CodigoOriginal = codOriginal;
            productoView.Nombre = nombre;
            productoView.Marca = marca;
            productoView.Linea = linea;
            productoView.Rubro = rubro;

            int pag = pagina;
            var cantidadRegistroPorPagina = 5;
            var modelo = new ListProductoViewModel();
            if (productoView != null)
            {
                var ListaProductos = _productoService.getProductosXFiltro(productoView,"Dólar");
                var productos = ListaProductos
                    .OrderByDescending(r => r.idProducto)
                    .Skip((pag - 1) * cantidadRegistroPorPagina)
                    .Take(cantidadRegistroPorPagina).ToList();

                var totalDeRegistro = ListaProductos.Count();

                modelo.TipoPaginador = "Productos";
                modelo.productoViewModels = productos;
                modelo.PaginaActual = pag;
                modelo.TotalDeRegistros = totalDeRegistro;
                modelo.RegistroPorPagina = cantidadRegistroPorPagina;
            }
            return PartialView("~/Views/Shared/Modals/_ModalProductos.cshtml", modelo);
        }


        public JsonResult ObtenerProducto(int idProducto,int idSegmento,string moneda)
        {
            return Json(_productoService.getProductoXId(idProducto,idSegmento,moneda), JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public PartialViewResult ModalClientesBuscar(int pagina, string buscar)
        {
            if (buscar == null) buscar = "";
            int pag = pagina;
            var cantidadRegistroPorPagina = 5;

            int _idUsuario = SessionHelper.GetUser();
            VendedorViewModel vendedor = _userService.obtenerVendedor(_idUsuario);
            if (buscar.Trim() == "")
            {

                var ListaClientes = _clienteServices.getAll(vendedor.idEmpresa, vendedor.idUsuario);
                var clientes = ListaClientes
                    .OrderByDescending(r => r.idCliente)
                    .Skip((pagina - 1) * cantidadRegistroPorPagina)
                    .Take(cantidadRegistroPorPagina).ToList();

                var totalDeRegistro = ListaClientes.Count();

                var modelo = new ListUsuarioViewModel();
                modelo.TipoPaginador = "Clientes";
                modelo.clienteViewModels = clientes;
                modelo.PaginaActual = pagina;
                modelo.TotalDeRegistros = totalDeRegistro;
                modelo.RegistroPorPagina = cantidadRegistroPorPagina;


                return PartialView("~/Views/Shared/Modals/_ModalClientes.cshtml", modelo);
            }
            else
            {
                var ListaClientes = _clienteServices.getXString(vendedor.idEmpresa, vendedor.idUsuario, buscar);
                var clientes = ListaClientes
                    .OrderByDescending(r => r.idCliente)
                    .Skip((pagina - 1) * cantidadRegistroPorPagina)
                    .Take(cantidadRegistroPorPagina).ToList();

                var totalDeRegistro = ListaClientes.Count();

                var modelo = new ListUsuarioViewModel();
                modelo.TipoPaginador = "Clientes";
                modelo.clienteViewModels = clientes;
                modelo.PaginaActual = pagina;
                modelo.TotalDeRegistros = totalDeRegistro;
                modelo.RegistroPorPagina = cantidadRegistroPorPagina;


                return PartialView("~/Views/Shared/Modals/_ModalClientes.cshtml", modelo);
            }
        }

        [HttpGet]
        public JsonResult ObtenerClienteXId(int idCliente)
        {
            if (idCliente != 0)
            {
                int _idUsuario = SessionHelper.GetUser();
                var cliente = _clienteServices.getClienteXId(idCliente, _idUsuario);
                return Json(cliente, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new ClienteViewModel(), JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Chat()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult ChargeTabs()
        {
            return PartialView("~/Views/Shared/_CreationTabs.cshtml");
        }
    }
}