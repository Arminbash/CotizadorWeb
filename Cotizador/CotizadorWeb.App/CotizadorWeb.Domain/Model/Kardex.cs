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
    using System.Collections.Generic;
    
    public partial class Kardex
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kardex()
        {
            this.CosteoPEPS = new HashSet<CosteoPEPS>();
            this.CosteoPromedio = new HashSet<CosteoPromedio>();
            this.CosteoPromedioPonderado = new HashSet<CosteoPromedioPonderado>();
            this.KardexIdentificadorProducto = new HashSet<KardexIdentificadorProducto>();
            this.KardexLote = new HashSet<KardexLote>();
            this.KardexOT = new HashSet<KardexOT>();
        }
    
        public long IdKardex { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<decimal> CantidadEntrada { get; set; }
        public Nullable<decimal> CantidadSalida { get; set; }
        public Nullable<decimal> StockActualizado { get; set; }
        public Nullable<int> IdEmpresa { get; set; }
        public string Documento { get; set; }
        public Nullable<int> IdDocumento { get; set; }
    
        public virtual Bodega Bodega { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CosteoPEPS> CosteoPEPS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CosteoPromedio> CosteoPromedio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CosteoPromedioPonderado> CosteoPromedioPonderado { get; set; }
        public virtual Producto Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KardexIdentificadorProducto> KardexIdentificadorProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KardexLote> KardexLote { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KardexOT> KardexOT { get; set; }
    }
}
