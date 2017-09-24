using System;
using System.Linq;


class Program
{
    static void Main()
    {

        string[] inputOne = Console.ReadLine().Split(' ').ToArray();

        Tuple<string, string> tuple = new Tuple<string, string>(inputOne[0] + " " + inputOne[1], inputOne[2]);
        Console.WriteLine(tuple.ToString());

        inputOne = Console.ReadLine().Split(' ').ToArray();
        Tuple<string, int> tupleTwo = new Tuple<string, int>(inputOne[0], int.Parse(inputOne[1]));
        Console.WriteLine(tupleTwo.ToString());

        inputOne = Console.ReadLine().Split(' ').ToArray();
        Tuple<int, double> tupleThree = new Tuple<int, double>(int.Parse(inputOne[0]), double.Parse(inputOne[1]));

        Console.WriteLine(tupleThree.ToString());

    }
}

