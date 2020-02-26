using CotizadorWeb.Infrastructure.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.Configuration
{
    public class ClienteViewModelValidation : AbstractValidator<ClienteViewModel>
    {
        public ClienteViewModelValidation()
        {
            RuleFor(model => model.idCliente)
                .NotNull().WithMessage("La información del cliente no es valida.");
            RuleFor(model => model.Nombre)
                .NotNull().WithMessage("La información del cliente no es valida.");
            RuleFor(model => model.Ruc)
                .NotNull().WithMessage("La información del cliente no es valida.");
            RuleFor(model => model.TipoCliente)
                .NotNull().WithMessage("La información del cliente no es valida.");
        }
    }
}
