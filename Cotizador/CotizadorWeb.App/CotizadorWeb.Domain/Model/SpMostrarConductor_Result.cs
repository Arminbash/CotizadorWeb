//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CotizadorWeb.Domain.Model
{
    using System;
    
    public partial class SpMostrarConductor_Result
    {
        public int IdConductor { get; set; }
        public Nullable<bool> EstadoConductor { get; set; }
        public int IdEmpleado { get; set; }
        public string Codigo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public string Nacionalidad { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public byte[] Foto { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string TipoSangre { get; set; }
        public Nullable<System.DateTime> LicenciaVence { get; set; }
        public string CategoriaLicencia { get; set; }
        public string LicenciaNumero { get; set; }
        public string PolizaLicencia { get; set; }
        public Nullable<System.DateTime> PolizaVence { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public bool Estado { get; set; }
        public string Inss { get; set; }
        public Nullable<decimal> SalarioMensual { get; set; }
        public string TipoMoneda { get; set; }
        public string Celular1 { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<int> IdEmpleadoSuperior { get; set; }
        public Nullable<int> SemanasCotizadas { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public string NombreSucursal { get; set; }
        public string NombreDepartamento { get; set; }
    }
}
