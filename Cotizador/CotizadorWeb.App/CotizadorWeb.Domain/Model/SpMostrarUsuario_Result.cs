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
    
    public partial class SpMostrarUsuario_Result
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public Nullable<int> IdTipoCuenta { get; set; }
        public int IdEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cuenta { get; set; }
        public string Descripcion { get; set; }
        public string Cedula { get; set; }
        public string Codigo { get; set; }
        public byte[] Foto { get; set; }
        public Nullable<bool> Estatus { get; set; }
        public string Contaseña { get; set; }
    }
}
