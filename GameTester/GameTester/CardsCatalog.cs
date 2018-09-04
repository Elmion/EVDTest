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
            if (c == null || c.IsDisposed)
            { 
            Card findedCard = CardBase.Instance.Cards.Find(x => x.Header == (string)lbCards.SelectedItem);
                if(findedCard != null)
                 c = new FullCard(findedCard);
            }
            else
                c.LoadCard(CardBase.Instance.Cards.Find(x => x.Header == (string)lbCards.SelectedItem));
            if (c != null && !c.Visible)
            {
                c.Show(this);
                c.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            }
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            //Создаём окно креатора
            using (CardCreator cc = new CardCreator())
            {
                cc.StartPosition = FormStartPosition.Manual;
                cc.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                if (cc.ShowDialog() == DialogResult.OK)                {
                    CardBase.Instance.AddNewCardToBase(cc.EditedCard);
                    lbCards.Items.Clear();
                    CardBase.Instance.Cards.ForEach(x => lbCards.Items.Add(x.Header));
                    cc.Close();
                }
            }
        }
        private void Edit()
        {

            //Создаём окно креатора
            using (CardCreator cc = new CardCreator())
            {
                cc.StartPosition = FormStartPosition.Manual;
                cc.Location = new Point(this.Location.X + this.Width, this.Location.Y);

                cc.LoadThisCard(CardBase.Instance.Cards.Find(x => x.Header == (string)lbCards.SelectedItem));
                
                if (cc.ShowDialog() == DialogResult.OK)
                {
                    int index = CardBase.Instance.Cards.FindIndex(x => x.Header == (string)lbCards.SelectedItem);
                    CardBase.Instance.Cards[index] = cc.EditedCard;
                    cc.Close();
                    lbCards_SelectedIndexChanged(null, null);
                }
            }
        }
        private void bDelete_Click(object sender, EventArgs e)
        {   //закрываем обзорное окно
            //Создаём окно креатора
            CardBase.Instance.Cards.Remove(CardBase.Instance.Cards.Find(x => x.Header == (string)lbCards.SelectedItem));
            lbCards.Items.Clear();
            CardBase.Instance.Cards.ForEach(x => lbCards.Items.Add(x.Header));
        }

        private void CardsCatalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            CardBase.Instance.SaveLibrary();
        }
        private void lbCards_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbCards.SelectedIndex != -1)
                Edit();
        }
        private void CardsCatalog_Move(object sender, EventArgs e)
        {
            if (c != null && c.Visible)
                c.Location = new Point(this.Location.X + this.Width, this.Location.Y);
        }
        
        private void bSave_Click(object sender, EventArgs e)
        {
            CardBase.Instance.SaveLibrary();
        }
    }
}
