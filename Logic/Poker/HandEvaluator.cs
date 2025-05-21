using System.Net;

public static class HandEvaluator
{
    public static void Evaluate(List<Card> tableCards, List<Card> playerCards)
    {
        List<Card> cards = tableCards.Concat(playerCards).ToList();

        List<List<Card>> combinations = GetCombinations(cards);

        foreach (List<Card> combination in combinations)
        {

        }

    }

    public static List<List<Card>> GetCombinations(List<Card> cards)
    {
        List<List<Card>> result = new();
        GenerateCombinations(cards, 0, new List<Card>(), result);
        return result;

    }

    public static void PrintCombinations(List<List<Card>> combinations)
    {
        foreach (var combo in combinations)
        {
            Console.WriteLine("[" + string.Join(", ", combo) + "]\n");
        }
    }

    private static void GenerateCombinations(List<Card> cards, int startIndex, List<Card> current, List<List<Card>> result)
    {   
        if (current.Count == 5)
        {
            result.Add(new List<Card>(current)); // Store a copy of the current combination
            return;
        }

        for (int i = startIndex; i < cards.Count; i++)
        {
            current.Add(cards[i]);                         // Choose this number
            GenerateCombinations(cards, i + 1, current, result); // Recurse to fill the rest
            current.RemoveAt(current.Count - 1);          // Backtrack (undo the last choice)
        }
    }
}