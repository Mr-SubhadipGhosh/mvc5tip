using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Utility
{
    public class CustomFilter : ActionFilterAttribute
    {
       
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            if(!filterContext.Controller.ViewData.ContainsKey("allow")){
                filterContext.Controller.ViewData["allow"]=false;
            }

            base.OnActionExecuting(filterContext);
        }


    }
}
