using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Box<int> box = new Box<int>(0);

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            box.Add(input);
        }
        int[] swapIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        box.Swap(swapIndexes[0], swapIndexes[1]);

        Console.Write(box.ToString());
    }
}

