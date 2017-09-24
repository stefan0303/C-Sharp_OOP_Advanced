using System;
using System.Linq;

class Program
{
    static void Main()
    {
        CustomList<string> customList =new CustomList<string>();
        Sorter<string> sorter =new Sorter<string>();
        string[] input = Console.ReadLine().Split().ToArray();
        while (input[0] != "END")
        {
            switch (input[0])
            {
                case "Add":
                    customList.Add(input[1]);
                    break;
                case "Remove":
                    customList.Remove(int.Parse(input[1]));
                   
                    break;
                case "Contains":
                    Console.WriteLine(customList.Contains(input[1]));
                    break;
                case "Swap":
                    customList.Swap(int.Parse(input[1]),int.Parse(input[2]));
                    break;
                case "Greater":
                    Console.WriteLine(customList.CountGreaterThan(input[1]));
                    break;
                case "Max":
                    Console.WriteLine(customList.Max());
                    break;
                case "Min":
                    Console.WriteLine(customList.Min());
                    break;
                case "Print":
                    foreach (var e in customList)
                    {
                        Console.WriteLine(e);
                    }
                    break;
                case "Sort":
                   sorter.Sort(customList);
                    break;
            }
            input = Console.ReadLine().Split().ToArray();
        }
    }
}

