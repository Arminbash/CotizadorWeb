using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorWeb.Infrastructure.ViewModel
{
    public class DetalleCotizacionViewModel 
    {
        //Base
        public int IdDetalle { get; protected set; }
        public decimal Cantidad { get; protected set; }
        public decimal PrecioUnitario { get; protected set; }
        public decimal FactorCantidad { get; protected set; }
        public decimal CostoUnitario { get; protected set; }
        public decimal FactorDescuento { get; protected set; }
        public decimal IVA { get; protected set; }

        //Products
        public int IdProducto { get; protected set; }
        public string CodigoAlterno { get; protected set; }
        public string CodigoOriginal { get; protected set; }
        public string Nombre { get; protected set; }

        //combos
        public int IdCombo { get; protected set; }

        //Services
        public int IdServicio { get; protected set; }

        public static DetalleCotizacionViewModel CreateNew(int idDetalle, decimal cantidad, decimal precioUnitario, decimal factorCantidad, decimal costoUnitario,
                                                    decimal factorDescuento, decimal iva, int idProducto, string codigoAlterno, string codigoOriginal,
                                                    string nombre, int idCombo, int idServicio)
        {
            Validate.SmallerThan(cantidad, 1, "DetalleCotizacionViewModel.cantidad must be greater than 0");
            Validate.SmallerThan(factorCantidad, 1, "DetalleCotizacionViewModel.factorCantidad must be greater than 0");
            Validate.SmallerThan(costoUnitario, 1, "DetalleCotizacionViewModel.costoUnitario must be greater than 0");
            Validate.SmallerThan(precioUnitario, 1, "DetalleCotizacionViewModel.precioUnitario must be greater than 0");
            Validate.NotNull(codigoAlterno, "DetalleCotizacionViewModel.codigoAlterno is required");
            Validate.NotNull(nombre, "DetalleCotizacionViewModel.nombre is required");
            return new DetalleCotizacionViewModel()
            {
                IdDetalle = idDetalle,
                Cantidad = cantidad,
                PrecioUnitario = precioUnitario,
                FactorCantidad = factorCantidad,
                CostoUnitario = costoUnitario,
                FactorDescuento = factorDescuento,
                IVA = iva,
                IdProducto = idProducto,
                CodigoAlterno = codigoAlterno,
                CodigoOriginal = codigoOriginal,
                Nombre = nombre,
                IdCombo = idCombo,
                IdServicio = idServicio
            };
        }
    }
}
