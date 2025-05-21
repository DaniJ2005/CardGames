using System.Reflection.Metadata.Ecma335;

public class Deck
{
    public Stack<Card> Cards { get; private set; }

    public Deck()
    {
        List<Card> deckList = GenerateRandomDeck();
        Cards = new Stack<Card>(deckList);
    }

    public List<Card> GenerateRandomDeck()
    {
        List<Card> deck = new();

        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                deck.Add(new Card(suit, rank));
            }
        }

        Shuffle(deck);

        return deck;
    }

    private void Shuffle(List<Card> deck)
    {
        // Fisher-Yates shuffle
        Random rng = new Random();

        for (int i = deck.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (deck[i], deck[j]) = (deck[j], deck[i]);
        }
    }

    public Card? Draw() => Cards.Count > 0 ? Cards.Pop() : null;

    public List<Card> Draw(int amount)
    {
        List<Card> cards = new();

        for (int i = 0; i < amount; i++)
        {
            if (Cards.Count == 0) break;
            cards.Add(Cards.Pop());
        }

        return cards;
    }

}