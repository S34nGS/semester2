class PlayingCard
{
    public string Suit;
    public string Rank;

    public PlayingCard(string suit, string rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public string GetDescription() => $"The {Rank} of {Suit}";
}
