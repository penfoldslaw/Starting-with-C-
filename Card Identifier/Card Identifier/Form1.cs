using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Card_Identifier : Form
    {
        public Card_Identifier()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureboxace_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Ace of Spades";
        }

        private void pictureBoxtwo_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "Two of Clubs";
        }
        private void pictureBox_Eight_Click(object sender, EventArgs e)
        {
                labelOutput.Text = "Eight of Diamonds";
        }

        private void pictureBox_king_Click(object sender, EventArgs e)
        {
                labelOutput.Text = "King of Spades";
        }

        private void pictureBox_Joker_Click(object sender, EventArgs e)
        {
                labelOutput.Text = "Joker";
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            labelOutput.Text = String.Empty;
        }

        private void Card_Identifier_Load(object sender, EventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
