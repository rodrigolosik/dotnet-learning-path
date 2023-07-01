using Microsoft.Extensions.Logging;

namespace Delegates.AnonymousFunction;

internal class AnonymousFunction
{
    private readonly ILogger<AnonymousFunction> _logger;

    public AnonymousFunction(ILogger<AnonymousFunction> logger)
    {
        _logger = logger;
    }


    DoMath addTwo = delegate (int number)
    {
        return number + 2;
    };

    WriteInConsole writeInConsole = delegate (string text)
    {
        text.ToString();
    };

    void Act()
    {
        int result = addTwo(10);
    }

    delegate int DoMath(int number);
    delegate void WriteInConsole(string text);
}
