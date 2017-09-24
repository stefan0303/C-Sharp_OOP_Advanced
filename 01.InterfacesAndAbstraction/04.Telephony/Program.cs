using System;

class Program
{
    static void Main()
    {
        Smartphone smartphone = new Smartphone();
        string callingNumbers = Console.ReadLine();
        Console.Write(smartphone.Call(callingNumbers));

        string browsingSites = Console.ReadLine();
        Console.Write(smartphone.Browsing(browsingSites));
    }
}

