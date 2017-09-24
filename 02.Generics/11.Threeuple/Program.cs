using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] inputOne = Console.ReadLine().Split(' ').ToArray();
        Tuple<string, string, string> tuple = new Tuple<string, string, string>(inputOne[0] + " " + inputOne[1], inputOne[2], inputOne[3]);
        Console.WriteLine(tuple.ToString());

        inputOne = Console.ReadLine().Split(' ').ToArray();
        bool isDrunk = inputOne[2] == "drunk";
        Tuple<string, int, bool> tupleTwo = new Tuple<string, int, bool>(inputOne[0], int.Parse(inputOne[1]), isDrunk);
        Console.WriteLine(tupleTwo.ToString());

        inputOne = Console.ReadLine().Split(' ').ToArray();
        Tuple<string, double, string> tupleThree = new Tuple<string, double, string>(inputOne[0], double.Parse(inputOne[1]), inputOne[2]);
        Console.WriteLine(tupleThree.ToString());
    }
}

