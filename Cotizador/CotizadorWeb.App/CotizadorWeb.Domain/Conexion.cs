using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
namespace CotizadorWeb.Domain
{
    public class Conexion
    {
        private static EntityConnectionStringBuilder conn;
        public static EntityConnectionStringBuilder GetConnection()
        {
            if (conn == null)
            {
                conn = new EntityConnectionStringBuilder();
                conn.Provider = "System.Data.SqlClient";
                //conn.ProviderConnectionString = "'data source=192.168.10.7;initial catalog=ERP_MSCORP;user id=APP_USER;password=MSCORP2019;MultipleActiveResultSets=True;App=EntityFramework'";
                conn.ProviderConnectionString = "Server=192.168.10.7;Database=ERP_MSCORP;User Id=APP_USER;Password=MSCORP2019;";
                //conn.ProviderConnectionString = "Data Source=.;Initial Catalog=ERP_MSCORP;Integrated Security=True";
                conn.Metadata = "res://*/Model.EF_ERP_MSCORP.csdl|res://*/Model.EF_ERP_MSCORP.ssdl|res://*/Model.EF_ERP_MSCORP.msl";
            }
            return conn;
        }
    }
}
