using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Lake<int> lake =new Lake<int>();
        int[] input= Console.ReadLine().Split(new[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        foreach (var e in input)
        {
            lake.Add(e);
        }
        Console.WriteLine(string.Join(", ",lake));
    }
}

