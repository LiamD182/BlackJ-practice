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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             for(int i = 0;i <4; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    deck[i * 13 * j] = new CCard(i + 1, j + 1);
                }
            }
        }
    }
}

