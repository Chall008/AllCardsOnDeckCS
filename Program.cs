using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var suitesOfCards = new List<string>() { "Spades", "Clubs", "Hearts", "Diamonds" };
            var amountOfCards = new List<string>() { "Ace of ", "2 of ", "3 of ", "4 of ", "5 of ", "6 of ", "7 of ", "8 of ", "9 of ", "10 of ", "Jack of ", "Queen of ", "King of " };
            var DeckOfCards = new List<string>();
            foreach (var aCardValue in amountOfCards)
            {
                foreach (var aCardSuite in suitesOfCards)
                {
                    var card = aCardValue + aCardSuite;
                    DeckOfCards.Add(card);
                    Console.WriteLine(card);
                }
            }
            var DeckSize = DeckOfCards.Count;
            for (var endOfDeck = DeckSize - 1; endOfDeck >= 0; endOfDeck--)
            {
                var cardPicker = new Random().Next(0, endOfDeck);

                var randomCard = DeckOfCards[cardPicker];
                var lastCard = DeckOfCards[endOfDeck];
                DeckOfCards[endOfDeck] = randomCard;
                DeckOfCards[cardPicker] = lastCard;
            }
            Console.WriteLine(DeckOfCards[0]);
            Console.WriteLine(DeckOfCards[1]);


        }
    }
}
