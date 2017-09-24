using System;
using System.Collections.Generic;

abstract class Inhabitant
{
    protected Inhabitant(string name)
    {
        this.Name = name;
    }

    public abstract string Name { get; set; }
}

interface IAge
{
    int Age { get; set; }
}

interface IId
{
    string Id { get; set; }
}

interface IBirthDate
{
    DateTime BirthDate { get; set; }
}

class Citizen : Inhabitant, IAge, IId, IBirthDate
{

    public Citizen(string name, string id, int age, DateTime birthDate) : base(name)
    {
        this.Id = id;
        this.Age = age;
        this.BirthDate = birthDate;
    }
    public override string Name { get; set; }
    public string Id { get; set; }
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
}

class Robot : Inhabitant, IId
{
    public Robot(string name, string id) : base(name)
    {
        this.Id = id;
    }

    public override string Name { get; set; }
    public string Id { get; set; }
}

class Pet : Inhabitant, IBirthDate
{
    public Pet(string name, DateTime birthDate) : base(name)
    {
        this.BirthDate = birthDate;
    }
    public override string Name { get; set; }
    public DateTime BirthDate { get; set; }
}

class Program
{
    static void Main()
    {
        List<IBirthDate> birthDates = new List<IBirthDate>();

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] data = input.Split();

            switch (data[0])
            {
                case "Citizen":
                    if (data.Length == 5)
                    {
                        DateTime date = DateTime.ParseExact(data[4], "dd/MM/yyyy", null);
                        birthDates.Add(new Citizen(data[1], data[3], int.Parse(data[2]), date));
                    }
                    break;
                case "Pet":
                    if (data.Length == 3)
                    {   
                        DateTime date1 = DateTime.ParseExact(data[2], "dd/MM/yyyy", null);
                        birthDates.Add(new Pet(data[1], date1));
                    }
                    break;
            }
            input = Console.ReadLine();
        }
        string year = Console.ReadLine();

        foreach (var birthDate in birthDates)
        {
            if (birthDate.BirthDate.Year == int.Parse(year))
            {
                Console.WriteLine(birthDate.BirthDate.Date.ToString("dd/MM/yyyy"));
            }
        }
    }
}
