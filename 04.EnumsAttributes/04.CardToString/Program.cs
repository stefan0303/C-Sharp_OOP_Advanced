using System;

class Program
{
    static void Main()
    {
        string rankInput = Console.ReadLine();
        string suitInput = Console.ReadLine();

        if (rankInput != null&&suitInput!=null)
        {
            Rank rank = (Rank) Enum.Parse(typeof(Rank), rankInput);
            Suits suits = (Suits) Enum.Parse(typeof(Suits), suitInput);

           Card card =new Card(rank,suits);
         
            Console.WriteLine(card.ToString());
        }
    }
}

