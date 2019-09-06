using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc2.Introduction.Filters
{
    public class CustomFilter : Attribute, IActionFilter
    {
        //aksiyon önünde çalışacak kod bloğu
        public void OnActionExecuting(ActionExecutingContext context)
        {
            int i = 10;
        }

        //aksiyon sonunda çalışacak kod bloğu
        public void OnActionExecuted(ActionExecutedContext context)
        {
            int i = 20;
        }
    }
}
