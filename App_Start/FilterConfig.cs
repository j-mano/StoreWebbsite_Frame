using System.Web;
using System.Web.Mvc;

namespace StoreWebbsite_Frame
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
