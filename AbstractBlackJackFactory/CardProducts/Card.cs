using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractBlackJackFactory.CardProducts
{
    public enum Suit
    {
        Heart,
        Diamond,
        Club,
        Spade
    }

    public enum Name
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack = 10,
        Queen = 10,
        King = 10,
    }
    public class Card
    {
        public Suit Suit { get; set; }
        public Name Name { get; set; }
    }
}
