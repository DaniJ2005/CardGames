public class Card
{
    public Suit Suit { get; }
    public Rank Rank { get; }

    public Card(Suit suit, Rank rank)
    {
        Suit = suit;
        Rank = rank;
    }

    public void Print()
    {
        string icon = Suit switch
        {
            Suit.Hearts => "♥",
            Suit.Diamonds => "♦",
            Suit.Clubs => "♣",
            Suit.Spades => "♠",
            _ => "?"
        };

        bool isRed = Suit == Suit.Hearts || Suit == Suit.Diamonds;

        if (isRed)
            Console.ForegroundColor = ConsoleColor.Red;

        Console.Write(icon);

        Console.ResetColor();
        Console.Write($" {Rank} of {Suit} ");

        if (isRed)
            Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine(icon);
        Console.ResetColor();
    }

}
