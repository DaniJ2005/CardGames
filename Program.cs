public class Program()
{
    public static void Main()
    {
        // List<Card> cards = new()
        // {
        //     new Card(Suit.Clubs, Rank.Ten),
        //     new Card(Suit.Clubs, Rank.Jack),
        //     new Card(Suit.Clubs, Rank.Queen),
        //     new Card(Suit.Clubs, Rank.King),
        //     new Card(Suit.Clubs, Rank.Ace),
        //     new Card(Suit.Hearts, Rank.Four),
        //     new Card(Suit.Diamonds, Rank.Four),
        // };
        // List<List<Card>> combinations = HandEvaluator.GetCombinations(cards);

        // HandEvaluator.PrintCombinations(combinations);

        ViewDeck();

    }

    private static void Poker()
    {
        Deck deck = new();
        Hand hand1 = new();
        Hand hand2 = new();

        hand1.Add(deck.Draw(2));
        hand2.Add(deck.Draw(2));

        Console.WriteLine(hand1);
        Console.WriteLine(hand2);
    }


    private static void ViewDeck()
    {
        Deck deck = new();

        while (deck.Cards.Count > 0)
        {
            Console.ReadKey(true);
            Card card = deck.Draw();
            card.Print();
        }
    }
}