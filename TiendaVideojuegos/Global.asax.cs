using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TiendaVideojuegos.Comun;
using TiendaVideojuegos.Persistencia;

namespace TiendaVideojuegos
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Util.RellenarDictionarySentencias();
        }

        protected void Application_End()
        {
            Util.EscribirDictionarySentenciasFichero();
            ConexionJDBC.CerrarConexion();
        }
    }
}
