using System;

namespace GameTester
{
    class CardManager
    {
        public static Card[] CreateNewRandomCards(Random rnd,int numCards)
        {
            Card[] cards = new Card[numCards];

            int countInHand = 0;
            while(countInHand <9)
            { 
                Card erlyCard = (Card)CardBase.Instance.Cards[rnd.Next(CardBase.Instance.Cards.Count)].Clone();
                if (erlyCard.Check())
                {
                    cards[countInHand] = erlyCard;
                    countInHand++;
                }
            }
            return cards;
        }
    }
}
