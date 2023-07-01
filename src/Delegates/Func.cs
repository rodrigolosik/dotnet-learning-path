namespace Delegates.Func;

/// <summary>
/// The only difference is that a Func has to return a value.And the return type is always the last defined generic parameter
/// </summary>
internal class Func
{
    Func<int, int> MultiplyByTwo = n => n * 2;
    Func<string, string, int> CountLengthofBothStrings = (stringOne, stringTwo) => stringOne.Length + stringTwo.Length;
    Func<int, int, double> MultiplyTwoNumbers = (numberOne, numberTwo) => numberOne * numberTwo;

    void Act()
    {
        int number = MultiplyByTwo(10);
        int length = CountLengthofBothStrings("Hello", "World");
        double converted = MultiplyTwoNumbers(100, 200);
    }
}
