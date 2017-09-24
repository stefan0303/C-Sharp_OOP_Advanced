using System;

class Program
{
    static void Main()
    {
        string rankInput = Console.ReadLine();
        string suitInput = Console.ReadLine();

        string rankInputTwo = Console.ReadLine();
        string suitInputTwo = Console.ReadLine();
        if (rankInput != null&&suitInput!=null)
        {
            Rank rank = (Rank) Enum.Parse(typeof(Rank), rankInput);
            Suits suits = (Suits) Enum.Parse(typeof(Suits), suitInput);

            Rank rankTwo = (Rank)Enum.Parse(typeof(Rank), rankInputTwo);
            Suits suitsTwo = (Suits)Enum.Parse(typeof(Suits), suitInputTwo);

            Card card =new Card(rank,suits);
            Card cardTwo = new Card(rankTwo, suitsTwo);

         int comapare=  card.CompareTo(cardTwo);

            if (comapare==1)
            {
                Console.WriteLine(card.ToString());
            }
            else
            {
                Console.WriteLine(cardTwo.ToString());
            }
            
        }
    }
}

