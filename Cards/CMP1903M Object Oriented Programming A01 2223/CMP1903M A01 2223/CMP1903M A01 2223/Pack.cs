using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        private Card[] pack;
        private int currentCard;
        private const int numOfCards = 52;
        private Random randNum;


        public Pack()
        {
            //Initialise the card pack here
            string[] Value = { "ACE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "JACK", "QUEEN", "KING" };
            string[] Suit = { "HEARTS", "CLUBS", "DIAMONDS", "SPADES" };
            pack = new Card[numOfCards];
            currentCard = 0;
            randNum = new Random();
            for (int i = 0; i < pack.Length - 1; i++)
                pack[i] = new Card(Value[i % Value.Length], Suit[i / Value.Length]);
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {  
            //Shuffles the pack based on the type of shuffle
            randNum = new Random();
            switch (typeOfShuffle)
            {
                //FisherYatesShuffle
                case 0:
                    for (int i = pack.Length - 1; i >= 1; i--)
                    {
                        int j = randNum.Next(i + 1);
                        Card temp = pack[j];
                        pack[j] = pack[i];
                        pack[i] = temp;
                    }
                    return true;
                //Riffle Shuffle
                case 1:
                    for (int i = pack.Length - 1; i > 0; i--)
                    {
                        int j = randNum.Next(i + 1);
                        Card temp = pack[i];
                        pack[i] = pack[j];
                        pack[j] = temp;
                    }
                    return true;
                //No Shuffle
                case 2:
                    return true;

                default:
                    return false;
            }

        }

        public Card Deal()
        {
            //Returns one card
            Card card = pack[0];
            pack = pack.Skip(1).ToArray();
            return card;
        }
        public List<Card> DealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                cards.Add(Deal());
            }
            return cards;
        }
    }
}
 
