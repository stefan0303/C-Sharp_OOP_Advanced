
class Card
{
    private Rank rank;
    private Suits suit;

    public Card(Rank rank, Suits suit)
    {
        this.Rank = rank;
        this.Suit = suit;
    }

    public Rank Rank { get; set; }
    public Suits Suit { get; set; }
}

