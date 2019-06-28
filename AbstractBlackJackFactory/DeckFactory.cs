using System;
using System.Collections.Generic;
using System.Text;
using AbstractBlackJackFactory.CardProducts;

namespace AbstractBlackJackFactory
{
    public abstract class DeckFactory
    {
        public abstract Card CreateDeck();

    }
}
