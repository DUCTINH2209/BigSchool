using System.Web;
using System.Web.Mvc;

namespace _2011068542_NguyenDucTinh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
