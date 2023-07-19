using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersAndAttributes.WebApi.Attributes;

public class CustomAuthorizeAttribute : Attribute, IAuthorizationFilter
{
    public CustomAuthorizeAttribute()
    {
        Console.WriteLine("CustomAuthorizeAttribute Initialized");
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        if (!context.HttpContext.Request.Headers.ContainsKey("X-Custom-Auth"))
        {
            context.Result = new UnauthorizedResult();
        }

        Console.WriteLine("Attribute OnAuthorization Called");
    }
}
