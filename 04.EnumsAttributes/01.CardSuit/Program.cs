using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Card Suits:");
        foreach (Card card in Enum.GetValues(typeof(Card)))
        {
            Console.WriteLine($"Ordinal value: {card.GetHashCode()}; Name value: {card}");
        }
    }
}

