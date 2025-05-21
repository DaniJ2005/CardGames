public class Hand
{
    public List<Card> Cards { get; set; }

    public Hand()
    {
        Cards = new();
    }


    public void Add(Card card)
    {
        Cards.Add(card);
    }

    public void Add(List<Card> cards)
    {
        foreach (var card in cards)
        {
            Cards.Add(card);
        }
    }

    public void Clear()
    {
        Cards.Clear();
    }

    public override string ToString()
    {
        string hand = "Hand:\n   ";

        foreach (var card in Cards)
        {
            hand += $"{card}, ";
        }
        hand += "\n";

        return hand;
    }

}