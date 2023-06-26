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


abstract class User
{
    public string Username { get; set; }

    public abstract void GetPrivileges();
    public string GetName()
    {
        return Username;
    }
}

class AdministrativeUser : User
{
    public override void GetPrivileges()
    {
        throw new NotImplementedException();
    }
}

class RegularUser : User
{
    public override void GetPrivileges()
    {
        throw new NotImplementedException();
    }
}