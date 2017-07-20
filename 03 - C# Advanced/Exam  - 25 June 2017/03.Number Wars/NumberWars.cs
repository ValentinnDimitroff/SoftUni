using System;
using System.Collections.Generic;
using System.Linq;

public class NumberWars
{
    public static void Main()
    {
        var firstPlayerDeck = new Queue<string>(Console.ReadLine().Split(' '));
        var secondPlayerDeck = new Queue<string>(Console.ReadLine().Split(' '));
        var gameTurn = 0;

        while (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count > 0 && gameTurn < 1_000_000)
        {
            gameTurn++;
            var firstPCard = firstPlayerDeck.Dequeue();
            var secondPCard = secondPlayerDeck.Dequeue();
            var firstNum = int.Parse(firstPCard.Substring(0, firstPCard.Length - 1));
            var secondNum = int.Parse(secondPCard.Substring(0, secondPCard.Length - 1));

            if (firstNum > secondNum)
            {
                firstPlayerDeck.Enqueue(firstPCard);
                firstPlayerDeck.Enqueue(secondPCard);
            }
            else if (secondNum > firstNum)
            {
                secondPlayerDeck.Enqueue(secondPCard);
                secondPlayerDeck.Enqueue(firstPCard);
            }
            else
            {
                var oldCards = new List<string>() { firstPCard, secondPCard };
                int i = 2;
                while (true)
                {
                    int firstSum = 0, secondSum = 0;
                    while (firstPlayerDeck.Count > 0 && oldCards.Count < i + 3)
                    {
                        var currentCard = firstPlayerDeck.Dequeue();
                        firstSum += currentCard[currentCard.Length - 1];
                        oldCards.Add(currentCard);
                    }

                    while (secondPlayerDeck.Count > 0 && oldCards.Count < i + 6)
                    {
                        var currentCard = secondPlayerDeck.Dequeue();
                        secondSum += currentCard[currentCard.Length - 1];
                        oldCards.Add(currentCard);
                    }

                    if (oldCards.Count < i + 6)
                        break;

                    if (firstSum > secondSum)
                        PutCardsInDeck(firstPlayerDeck, oldCards.ToArray());
                    else if (firstSum < secondSum)
                        PutCardsInDeck(secondPlayerDeck, oldCards.ToArray());

                    if (firstSum != secondSum)
                        break;
                    i = oldCards.Count;
                }
            }
        }

        if (firstPlayerDeck.Count > secondPlayerDeck.Count)
            Console.WriteLine($"First player wins after {gameTurn} turns");
        else if (firstPlayerDeck.Count < secondPlayerDeck.Count)
            Console.WriteLine($"Second player wins after {gameTurn} turns");
        else Console.WriteLine($"Draw after {gameTurn} turns");
    }

    private static void PutCardsInDeck(Queue<string> cardsDeck, string[] cards)
    {
        foreach (var card in cards.OrderByDescending(x => int.Parse(x.Substring(0, x.Length - 1)))
            .ThenByDescending(x => x[x.Length - 1]))
        {
            cardsDeck.Enqueue(card);
        }
    }
}