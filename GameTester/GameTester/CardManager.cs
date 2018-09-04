using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Reflection;
using System.Collections;

namespace GameTester
{
    class CardManager
    {
        public static Card[] CreateNewRandomCards(Random rnd,int numCards)
        {
            Card[] cards = new Card[numCards];

            for (int i = 0; i < numCards; i++)
            {
                cards[i] = (Card)CardBase.Instance.Cards[rnd.Next(CardBase.Instance.Cards.Count)].Clone();
            }
            return cards;
        }
    }
}
