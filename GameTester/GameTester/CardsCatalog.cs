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
    public partial class CardsCatalog : Form
    {
        FullCard c;
        CardCreator cardCreator;
        public CardsCatalog()
        {
            InitializeComponent();
            CardBase.Instance.Cards.ForEach(x => lbCards.Items.Add(x.Header));
        }
        private void lbCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c != null) { c.Close(); c.Dispose(); }
            c = new FullCard(CardBase.Instance.Cards.Find(x => x.Header == (string)lbCards.SelectedItem));
            c.Show(this);
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            using (CardCreator cc = new CardCreator())
            {
                ;
                if(cc.ShowDialog() == DialogResult.OK)                {
                    CardBase.Instance.AddNewCardToBase(cc.EditedCard);
                    lbCards.Items.Clear();
                    CardBase.Instance.Cards.ForEach(x => lbCards.Items.Add(x.Header));
                    cc.Close();
                }
            }
        }
        private void bEdit_Click(object sender, EventArgs e)
        {
            using (CardCreator cc = new CardCreator())
            {
                cc.LoadThisCard(CardBase.Instance.Cards.Find(x => x.Header == (string)lbCards.SelectedItem));
                
                if (cc.ShowDialog() == DialogResult.OK)
                {
                    int index = CardBase.Instance.Cards.FindIndex(x => x.Header == (string)lbCards.SelectedItem);
                    CardBase.Instance.Cards[index] = cc.EditedCard;
                    cc.Close();
                }
            }
        }
        private void bDelete_Click(object sender, EventArgs e)
        {
            CardBase.Instance.Cards.Remove(CardBase.Instance.Cards.Find(x => x.Header == (string)lbCards.SelectedItem));
            lbCards.Items.Clear();
            CardBase.Instance.Cards.ForEach(x => lbCards.Items.Add(x.Header));
        }

        private void CardsCatalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            CardBase.Instance.SaveLibrary();
        }
    }
}
