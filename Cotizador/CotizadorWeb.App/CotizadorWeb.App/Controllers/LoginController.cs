using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CotizadorWeb.Infrastructure.ViewModel;
using CotizadorWeb.Services.Services;
using System.Security.Claims;
using CotizadorWeb.App.Tools;

namespace CotizadorWeb.App.Controllers
{
    [NoLoginAttribute]
    public class LoginController : Controller
    {
        private readonly UsuarioServices _userService = new UsuarioServices();

        [AllowAnonymous]
        public ActionResult Index()
        {
            return RedirectToAction("Vendedor");
        }

        [AllowAnonymous]
        public ActionResult Vendedor()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Vendedor(UsuarioViewModel x)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.MensajeError = "El usuario ó la contraseña no pueden ser vacios.";
                x.Password = null;
                return View("Vendedor", x);
            }
            if (_userService.validarUsuario(x) == false)
            {
                ViewBag.MensajeError = "El usuario ó contraseña son incorrectos.";
                x.Password = null;
                return View("Vendedor", x);
            }
            if (_userService.permisosUsuario(x) == false)
            {
                ViewBag.MensajeError = "El usuario no cuenta con permisos necesarios para el acceso.";
                x.Password = null;
                return View("Vendedor", x);
            }

            int _idUsuario = _userService.obtenerIdUsuario(x);

            VendedorViewModel vendedor = _userService.obtenerVendedor(_idUsuario);
            if(vendedor == null)
            {
                ViewBag.MensajeError = "El usuario contiene información erronea, Contacte soporte.";
                x.Password = null;
                return View("Vendedor", x);
            }

            SessionHelper.AddUserToSession(vendedor.idUsuario.ToString());

            return RedirectToAction("Index", "CotizadorVendedor");
        }
    }
}