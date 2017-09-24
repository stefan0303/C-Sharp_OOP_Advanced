using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Card Ranks:");
        foreach (CardRanks card in Enum.GetValues(typeof(CardRanks)))
        {
            Console.WriteLine($"Ordinal value: {card.GetHashCode()}; Name value: {card}");
        }

    }
}

