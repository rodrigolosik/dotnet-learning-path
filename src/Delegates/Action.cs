namespace Delegates.Action;

/// <summary>
/// An Action is defined that it has no return value. There are multiple overloads that correspond to the number of parameters an action can have.
/// </summary>
public class Action
{
    Action<string> printConsole = text => Console.WriteLine(text);

    //// Use Action
    void Print(Action<string> printAction) => printAction("Hello World");

    //// Use Delegate
    delegate void PrintAction(string text);
    void Print(PrintAction printAction) => printAction("Hello World");

    Action<string> printToConsole = PrintToConsole;
    Action<string> anotherAction = PrintToConsole;

    public static void PrintToConsole(string s) { }
}

/// <summary>
/// One thing one has to be aware is that Action does not go well with async and await. The reason is simple, an Action can't return anything so it behaves like a void function. Technically you would do async void. So no chance to await the task
/// </summary>
public class ActionAsync
{
    public async Task Action()
    {
        //Action doWait = async () => await Task.Delay(2000);

        //// async void - fire and forget
        //// We will not wait 2 seconds we just go right through
        //doWait();

        // Compiler error: Type 'void' is not awaitable
        //await doWait();
    }
}