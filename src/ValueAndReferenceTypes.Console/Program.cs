internal class Program
{
    /// <summary>
    /// Value types 
    /// Value species lives on STACK
    /// - bool
    /// - byte
    /// - char
    /// - decimal
    /// - double
    /// - enum
    /// - float
    /// - int
    /// - long
    /// - sbyte
    /// - short
    /// - struct
    /// - uint
    /// - ulong
    /// - ushort
    /// 
    /// Reference Types
    /// Reference species lives on the HEAP
    /// - String
    /// - Arrays
    /// - Class
    /// - Delegates
    /// 
    /// </summary>

    private static void Main(string[] args)
    {
        //int i = 100;
        //Console.WriteLine(i);

        //ChangeValue(i);
        //Console.WriteLine(i);

        //Student std1 = new Student();
        //std1.StudentName = "Bill";
        //ChangeReferenceType(std1);
        //Console.WriteLine(std1.StudentName);

        String stringOne = "StringOne";
        string stringTwo = "StringTwo";

        Console.WriteLine("Before: {0}, {1}", stringOne, stringTwo);

        ChangeStringValues(stringOne, stringTwo);

        Console.WriteLine("After: {0}, {1}", stringOne, stringTwo);

    }

    static void ChangeStringValues(String stringOne, string stringTwo)
    {
        stringOne = "NewStringOne";
        stringTwo = "NewStringTwo";
    }

    static void ChangeValue(int x)
    {
        x = 200;
        Console.WriteLine(x);
    }

    static void ChangeReferenceType(Student std2)
    {
        std2.StudentName = "Steve";
    }
}

internal class Student
{
    public string StudentName { get; set; }
}