using System.Web;
using System.Web.Mvc;

namespace MVC5_Unity_NLog
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
