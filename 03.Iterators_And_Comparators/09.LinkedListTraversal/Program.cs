using System;
using System.Linq;

class Program
{
    static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split().ToArray();
            if (command[0] == "Add")
            {
                list.Add(int.Parse(command[1]));
            }
            else//Remove
            {
                list.Remove(int.Parse(command[1]));
            }

        }
        Console.WriteLine(list.Count());
     
            Console.WriteLine(string.Join(" ", list));
        
    }
}

