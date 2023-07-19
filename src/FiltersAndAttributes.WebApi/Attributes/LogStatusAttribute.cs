using System.Web.Mvc;

namespace FiltersAndAttributes.WebApi.Attributes;

[AttributeUsage(AttributeTargets.All, Inherited = false)]
public class LogStatusAttribute : Attribute, IActionFilter
{
    private readonly string _prefix;

    public LogStatusAttribute(string prefix = "")
    {
        _prefix = prefix;
        Console.WriteLine("Attribute Initialized");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine(_prefix + "OnActionExecuted");
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine(_prefix + "OnActionExecuting");
    }
}
