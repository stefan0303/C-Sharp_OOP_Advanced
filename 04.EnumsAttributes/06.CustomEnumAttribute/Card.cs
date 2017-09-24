﻿using System;

public class Card : IComparable<Card>
{
    private Rank rank;
    private Suits suit;
    private int power;

    public Card(Rank rank, Suits suit)
    {
        this.Rank = rank;
        this.Suit = suit;
        this.power = (int)this.rank + (int)this.suit;
    }
   
    public Rank Rank
    {
        get { return this.rank; }
        private set { this.rank = value; }
    }
    public Suits Suit
    {
        get { return this.suit; }
        private set { this.suit = value; }
    }

    public int CompareTo(Card other)
    {
        return this.power - other.power;
    }

    public override string ToString()
    {
        return $"Card name: {this.rank} of {this.suit}; Card power: {this.power}";
    }
}