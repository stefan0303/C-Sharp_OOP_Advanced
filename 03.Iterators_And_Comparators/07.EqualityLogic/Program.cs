using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedSet<Person> personsByName = new SortedSet<Person>(new CompareNames());
        HashSet<Person> personsHashSet = new HashSet<Person>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Person person = new Person(input[0], int.Parse(input[1]));
            personsByName.Add(person);
            personsHashSet.Add(person);
        }

        Console.WriteLine(personsHashSet.Count);
        Console.WriteLine(personsHashSet.Count);
    }
}

