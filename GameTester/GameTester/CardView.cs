using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTester
{
    public partial class CardView : UserControl
    {
        FullCard fullform;
        public readonly Card card;
        Form owner;
        public CardView(Card card, Form owner)
        {
            InitializeComponent();
            this.card = card;
            lHeader.Text = card.Header;
            this.owner = owner;
            tbCardDescription.Text = card.Description;
            picCard.BackgroundImage = CardBase.Instance.GetImage(card.ImageRef);
            this.MouseDown += CardView_MouseDown;
            this.MouseUp += CardView_MouseUp;
        }

        private void CardView_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                fullform = new FullCard(card);
                fullform.StartPosition = FormStartPosition.Manual;
                fullform.Location = new Point(owner.Location.X + owner.Size.Width, owner.Location.Y);
                fullform.Show();
            }
        }

        private void CardView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if(fullform != null)
                {
                    fullform.Hide();
                    fullform.Dispose();
                }
                 
            }
        }
    }
}
