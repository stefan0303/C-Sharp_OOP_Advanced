using System;

class Card:IComparable
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
    public int Power => (int) this.Rank + (int) this.Suit;

    public override string ToString()
    {
        power = (int) this.Rank + (int) this.Suit;
        return $"Card name: {this.Rank} of {this.Suit}; Card power: {power}";
    }

    public int CompareTo(object obj)
    {
        return Power;
    }

    public int CompareTo(Card other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var rankComparison = rank.CompareTo(other.rank);
        if (rankComparison != 0) return rankComparison;
        var suitComparison = suit.CompareTo(other.suit);
        if (suitComparison != 0) return suitComparison;
        var powerComparison = power.CompareTo(other.power);
        if (powerComparison != 0) return powerComparison;
        var rankComparison1 = Rank.CompareTo(other.Rank);
        if (rankComparison1 != 0) return rankComparison1;
        return Suit.CompareTo(other.Suit);
    }
}

