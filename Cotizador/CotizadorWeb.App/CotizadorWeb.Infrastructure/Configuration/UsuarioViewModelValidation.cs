using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorWeb.Infrastructure.ViewModel;
using FluentValidation;

namespace CotizadorWeb.Infrastructure.Configuration
{
    public class UsuarioViewModelValidation : AbstractValidator<UsuarioViewModel>
    {
        public UsuarioViewModelValidation()
        {
            RuleFor(model => model.Usuario)
                .NotNull().WithMessage("Usuario y Contraseña es requerida.");
            RuleFor(model => model.Password)
                .NotNull().WithMessage("Usuario y Contraseña es requerida.");
        }
    }
}
