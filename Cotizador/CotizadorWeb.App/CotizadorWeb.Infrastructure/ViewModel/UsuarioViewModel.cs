using CotizadorWeb.Infrastructure.Configuration;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.ViewModel
{
    [Validator(typeof(UsuarioViewModelValidation))]
    public class UsuarioViewModel 
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
