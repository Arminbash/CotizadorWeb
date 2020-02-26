using System.Web;
using System.Web.Optimization;

namespace CotizadorWeb.App
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/bundles/Material").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/MDB/mdb.min.js"));

            bundles.Add(new StyleBundle("~/Content/css/Material").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/MDB/mdb.min.css",
                "~/Content/SiteVendedor.css"
                ));

            bundles.Add(new StyleBundle("~/Content/materialize").Include(
                "~/Content/materialize/css/materialize.min.css",
                "~/Content/SiteVendedor.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/materialize").Include(
                       "~/Scripts/materialize/materialize.min.js"));
        }
    }
}
