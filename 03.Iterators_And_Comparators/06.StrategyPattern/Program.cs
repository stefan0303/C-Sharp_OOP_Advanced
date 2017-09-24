using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedSet<Person> personsByName = new SortedSet<Person>(new CompareNames());
        SortedSet<Person> personsByAge = new SortedSet<Person>(new CompareAge());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Person person = new Person(input[0], int.Parse(input[1]));
            personsByName.Add(person);
            personsByAge.Add(person);
        }
        foreach (var p in personsByName)
        {
            Console.WriteLine(p.ToString());
        }
        foreach (var p in personsByAge)
        {
            Console.WriteLine(p.ToString());
        }
    }
}

