
class Card
{
    private Rank rank;
    private Suits suit;
    private int power;
    public Card(Rank rank, Suits suit)
    {
        this.Rank = rank;
        this.Suit = suit;
    }

    public Rank Rank { get; set; }
    public Suits Suit { get; set; }

    public override string ToString()
    {
        power = (int) this.Rank + (int) this.Suit;
        return $"Card name: {this.Rank} of {this.Suit}; Card power: {power}";
    }
}

