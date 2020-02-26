using CotizadorWeb.Infrastructure.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.Configuration
{
    public class CotizacionViewModelValidation : AbstractValidator<CotizacionViewModel>
    {
        public CotizacionViewModelValidation()
        {
            RuleFor(model => model.IdSerie)
                .NotNull().WithMessage("El número de nombre es requerida");
            RuleFor(model => model.Fecha)
                .NotNull().WithMessage("Debe proporcionar una fecha válida.");
        }
    }
}
