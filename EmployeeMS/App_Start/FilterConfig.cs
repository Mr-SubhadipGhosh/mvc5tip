using System.Web;
using System.Web.Mvc;
using Utility;

namespace EmployeeMS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomFilter());
        }
    }
}
