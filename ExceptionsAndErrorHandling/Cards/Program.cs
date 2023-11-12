using System;
using System.Collections.Generic;

namespace Cards
{
    class Program
    {
        static void Main()
        {
            List<Card> cards = new List<Card>();
            string[] cardsArgs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < cardsArgs.Length; i++)
            {
                string[] cardFaceAndSuit = cardsArgs[i].Split(" ");
                string cardFace = cardFaceAndSuit[0];
                string cardSuit = cardFaceAndSuit[1];
                try
                {
                    Card card = new Card(cardFace, cardSuit);
                    card.Suit = "L";
                    cards.Add(card);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            foreach (var card in cards)
            {
                Console.Write(card.ToString() + " ");
            }     
        }
    }
}
