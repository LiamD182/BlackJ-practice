using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJ_practice
{
   class CCard
    {
        private int suit;
        private int value;
        public CCard()
        {
            suit = 0;
            value = 0;
        }

        public CCard(int suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public int getSuit() { return suit; }
        public int getValue() { return value; }

        public void setSuit(int suit) { this.suit = suit; }
        public void setValue(int value) { this.value =value; }

    }
}
