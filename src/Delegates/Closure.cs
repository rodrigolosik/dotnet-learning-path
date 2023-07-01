namespace Delegates.Closure;

/// <summary>
/// Closures means that you bind a variable from outside scope of the function to the inside scope.
/// </summary>
internal class Closure
{
    void Act()
    {
        var someNumber = 100;

        Func<int, int> addSomeNumber = n => n + someNumber;
        someNumber = 101;

        Console.WriteLine(addSomeNumber(2));
    }
}
