using System.Web;
using System.Web.Mvc;

namespace PaganaSoft.MVCSec2Lec1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
