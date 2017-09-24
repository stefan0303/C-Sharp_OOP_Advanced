using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] command = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Stack<int> stack = new Stack<int>();

        while (command[0] != "END")
        {
            if (command[0] == "Push")
            {
                for (int i = 1; i < command.Length; i++)
                {
                    int num = int.Parse(command[i]);
                    stack.Push(num);
                }
            }
            if (command[0] == "Pop")
            {
                stack.Pop();
            }

            command = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        foreach (var elementh in stack)
        {
            Console.WriteLine(elementh);
        }
        foreach (var elementh in stack)
        {
            Console.WriteLine(elementh);
        }
    }
}

