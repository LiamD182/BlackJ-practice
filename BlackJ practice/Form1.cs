using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJ_practice
{
    public partial class Form1 : Form
    {
        CCard[] deck = new CCard[52];
        CCard[] hand = new CCard[5];

        int deckPointer = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck[i * 13 + j] = new CCard(i + 1, j + 1);
                }
            }

            //shuffle the deck 
            Random rnd = new Random();
            for (int i = 0; i < deck.Length; i++)
            {
                int tempCardID = rnd.Next(deck.Length - 1);

                CCard tempCard = deck[i];
                deck[i] = deck[tempCardID];
                deck[tempCardID] = tempCard;
            }

            displayDeck();
        }

        void displayDeck()
        {
            textBox1.Clear();
            for (int i = 0; i < deck.Length; i++)
            {
                textBox1.AppendText(deck[i].getSuit().ToString() + ", " + deck[i].getValue().ToString() + "\r\n");
            }
        }
    }
}

