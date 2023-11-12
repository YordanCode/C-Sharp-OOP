using System;

namespace Cards
{
    public class Card
    {
        private const string playingCardFaces = "2345678910JQKA";
        private const string playingCardSuits = "SHDC";
        private string face;
        private string suit;
        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face
        {
            get => face;
            set
            {
                if (playingCardFaces.Contains(value))
                    face = value;
                else
                    throw new ArgumentException("Invalid card!");
            }
        }
        public string Suit
        {
            get => suit;
            set
            {
                if (playingCardSuits.Contains(value))
                    suit = value;
                else
                    throw new ArgumentException("Invalid card!");
            }
        }

        public override string ToString()
        {
            GetSuitSymbol();
            return $"[{Face}{Suit}]";
        }
        private void GetSuitSymbol()
        {
            if (Suit == "S")
                suit = "\u2660";
            else if (Suit == "H")
                suit = "\u2665";
            else if (Suit == "D")
                suit = "\u2666";
            else if (Suit == "C")
                suit = "\u2663";
        }
    }
}


