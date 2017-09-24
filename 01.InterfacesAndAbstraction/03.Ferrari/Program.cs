using System;

class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        Ferrari ferrari = new Ferrari("Ferrari", "488-Spider", name);

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }

        Console.WriteLine(ferrari.ToString());

    }
}

