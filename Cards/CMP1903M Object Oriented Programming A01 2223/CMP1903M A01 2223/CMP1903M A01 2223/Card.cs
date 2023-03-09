using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903M_A01_2223
{
    class Card
    {
        private string vNum;
        private string sNum;

        public Card(string AvNum, string AsNum)
        {
            sNum = AsNum;
            vNum = AvNum;
        }


        //Base for the Card class.

        //The 'set' methods for these properties could have some validation
        //Value: numbers 1 - 13
        public string Value
        {
            get { return vNum; }
            set
            {
                if (value == "ACE" || value == "TWO" || value == "THREE" || value == "FOUR" || value == "FIVE" || value == "SIX" || value == "SEVEN" || value == "EIGHT" || value == "NINE" || value == "TEN" || value == "JACK" || value == "QUEEN" || value == "KING")
                {
                    vNum = value;
                }
            }
        }
        //Suit: numbers 1 - 4
        public string Suit
        { 
            get { return sNum; } 
            set
            {
                if (value == "HEARTS" || value == "CLUBS" || value == "DIAMONDS" || value == "SPADES")
                {
                    sNum = value;
                }
            }
        }
    }
}
