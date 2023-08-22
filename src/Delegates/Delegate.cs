namespace Delegates;

internal class Delegate
{
    delegate void PrintText(string s);

    void PrintTextMethod()
    {
        DoMath addTwo = new DoMath(AddTwo);
        DoMath multiplyByTwo = new DoMath(MultiplyByTwo);

        Console.Write(addTwo(10));
        Console.Write(multiplyByTwo(10));
    }

    int AddTwo(int number) => number + 2;
    int MultiplyByTwo(int number) => number * 2;

    delegate int DoMath(int number);

}