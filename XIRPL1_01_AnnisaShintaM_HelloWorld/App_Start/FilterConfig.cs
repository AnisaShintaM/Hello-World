using System.Web;
using System.Web.Mvc;

namespace XIRPL1_01_AnnisaShintaM_HelloWorld
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}