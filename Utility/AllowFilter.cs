using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Utility
{
    public class AllowFilter : ActionFilterAttribute
    {
        public bool guest { get; set; }
        public string errorRedirect { get; set; }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (!guest)
            {
                bool check = filterContext.Controller.ViewData.ContainsKey("allow");
                if (!(check && !(bool)filterContext.Controller.ViewBag.allow))
                {
                    filterContext.Result = new RedirectResult(errorRedirect);
                }
            }

            base.OnActionExecuted(filterContext);
        }
    }
}
