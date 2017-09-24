using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] command = Console.ReadLine().Split(' ').Skip(1).ToArray();
        ListyIterator<string> listyIterator = new ListyIterator<string>(command);
        command = Console.ReadLine().Split(' ').ToArray();

        while (command[0] != "END")
        {
            switch (command[0])
            {
                case "Move":
                    Console.WriteLine(listyIterator.Move());

                    break;
                case "Print":
                    listyIterator.Print();
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());

                    break;

            }
            command = Console.ReadLine().Split(' ').ToArray();
        }
    }
}

