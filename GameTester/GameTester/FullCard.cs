using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTester
{
    public partial class FullCard : Form
    {
        Card card;
        public FullCard(Card card)
        {
            InitializeComponent();
            this.card = card;
            tbDescription.Text = card.Description;
            lHeader.Text = card.Header;
            pImage.BackgroundImage = CardManager.ImagesStorage[card.ImageRef];
        }
    }
}
