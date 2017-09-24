using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string playerOne = Console.ReadLine();
        string playerTwo = Console.ReadLine();

        List<Card> cardsPlayerOne = new List<Card>();
        List<Card> cardsPlayerTwo = new List<Card>();

        while (cardsPlayerOne.Count != 5)
        {

            string[] inputCard = Console.ReadLine().Split(' ').ToArray();
            string rank = inputCard[0];
            string suit = inputCard[2];

            try
            {
                Rank r = (Rank)Enum.Parse(typeof(Rank), rank);
                Suits suits = (Suits)Enum.Parse(typeof(Suits), suit);
                Card card = new Card(r, suits);
                if (cardsPlayerOne.Any(c => c.Rank == card.Rank && c.Suit == card.Suit))
                {
                    Console.WriteLine("Card is not in the deck.");
                }
                else
                {
                    cardsPlayerOne.Add(card);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No such card exists.");
            }

        }
        while (cardsPlayerTwo.Count != 5)
        {
            string[] inputCard = Console.ReadLine().Split(' ').ToArray();
            string rank = inputCard[0];
            string suit = inputCard[2];
            try
            {
                Rank r = (Rank)Enum.Parse(typeof(Rank), rank);
                Suits suits = (Suits)Enum.Parse(typeof(Suits), suit);
                Card card = new Card(r, suits);

                if (cardsPlayerOne.Any(c => c.Rank == card.Rank && c.Suit == card.Suit) || cardsPlayerTwo.Any(c => c.Rank == card.Rank && c.Suit == card.Suit))
                {
                    Console.WriteLine("Card is not in the deck.");
                }
                else
                {
                    cardsPlayerTwo.Add(card);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No such card exists.");
            }

        }
        Card bigestCardPlayerOne = cardsPlayerOne.OrderByDescending(c => c.power).FirstOrDefault();
        Card biggestCardPlayerTwo = cardsPlayerTwo.OrderByDescending(c => c.power).FirstOrDefault();

        if (bigestCardPlayerOne.power > biggestCardPlayerTwo.power)
        {
            Console.WriteLine(playerOne + " wins with " + bigestCardPlayerOne.Rank + " of " + bigestCardPlayerOne.Suit + ".");
        }
        else
        {
            Console.WriteLine(playerTwo + " wins with " + biggestCardPlayerTwo.Rank + " of " + biggestCardPlayerTwo.Suit + ".");
        }
    }
}


