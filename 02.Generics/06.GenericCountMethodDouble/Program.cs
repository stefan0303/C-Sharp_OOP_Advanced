using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Box<double> box = new Box<double>(0);
        for (int i = 0; i < n; i++)
        {
            double input = double.Parse(Console.ReadLine());
            box.Add(input);
           
        } 

        double itemToCompare = double.Parse(Console.ReadLine());
        Console.Write(box.CompareTo(itemToCompare));
        Console.WriteLine();
    }
}

