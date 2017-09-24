using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Box<string> box = new Box<string>("");
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            box.Add(input);

        }
        int[] swapIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        box.Swap(swapIndexes[0], swapIndexes[1]);

        Console.Write(box.ToString());
    }
}

