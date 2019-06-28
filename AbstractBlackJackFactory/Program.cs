using System;
using System.Collections.Generic;
using AbstractBlackJackFactory.CardProducts;

namespace AbstractBlackJackFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new List<Card>();

            foreach(var type in typeof(Suit).GetEnumValues())
            {
                var card = new Card();
                card.Suit = type;
            }
            

            Console.WriteLine("Hello World!");
        }
    }
}
