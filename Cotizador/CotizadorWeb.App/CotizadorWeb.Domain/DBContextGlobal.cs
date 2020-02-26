namespace CotizadorWeb.Domain.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public partial class DBContextGlobal : ERP_MSCORPEntities
    {
        public virtual DbSet<getTasaOficial> getTasaOficial { get; set; }
        public virtual DbSet<getTasaParalela> getTasaParalela { get; set; }

    }
    public partial class getTasaOficial 
    {
        public decimal Tasa { get; set; }
    }
    public partial class getTasaParalela
    {
        public decimal Tasa { get; set; }
    }
}
