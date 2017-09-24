using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        List<Person> persons = new List<Person>();
        while (input[0] != "END")
        {
            Person person = new Person(input[0], int.Parse(input[1]), input[1]);
            persons.Add(person);

            input = Console.ReadLine().Split(' ').ToArray();
        }
        int indexOfPerson = int.Parse(Console.ReadLine());
        if (persons.Count - 1 < indexOfPerson)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            var personToCompare = persons[indexOfPerson];

            int numEqualPeople = 0;
            int numNotEqualPeople = 0;
            foreach (var p in persons)
            {
                if (p.CompareTo(personToCompare) == 0)
                {
                    numEqualPeople += 1;
                }
                else
                {
                    numNotEqualPeople += 1;
                }
            }
            Console.WriteLine(numEqualPeople + " " + numNotEqualPeople + " " + persons.Count);
        }
    }
}

