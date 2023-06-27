using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        String Chicken = "chicken";
        int Fish = 1;

        ArrayList Truck = new ArrayList
        {
            Chicken,
            Fish
        };
        string chick = (string)Truck[0];
        int fish = (int)Truck[1];

        Console.ReadKey();
    }
}