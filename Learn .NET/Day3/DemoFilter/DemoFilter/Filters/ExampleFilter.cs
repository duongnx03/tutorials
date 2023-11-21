using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DemoFilter.Filters
{
    public class ExampleFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("___" + context.ActionDescriptor.DisplayName + "is run");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("___" + context.ActionDescriptor.DisplayName + "is running");
        }
    }
}

