public static class PokerGame
{
    public static void StartRound()
    {
        Deck deck = new();
        Hand hand = new();
        List<Card> tableCards;

        hand.Add(deck.Draw(2));

        tableCards = deck.Draw(5);
    }

}