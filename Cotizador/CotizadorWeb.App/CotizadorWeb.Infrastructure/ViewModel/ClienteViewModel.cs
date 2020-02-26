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
    [Validator(typeof(ClienteViewModelValidation))]
    public class ClienteViewModel
    {
        public int idCliente { get;set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public string TipoCliente { get; set; }
        public int idSegmento { get; set; }
        public string Segmento { get; set; }
    }
}
