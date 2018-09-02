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
    public partial class CardCreator : Form
    {
        Dictionary<string,ParametredAction> parametredActions;
        bool PicChanged = false; //флаг что картинка была изменена
        public Card EditedCard = null;
        public CardCreator()
        {
            InitializeComponent();
            ucCM.Init(typeof(Effect));
            parametredActions = new Dictionary<string, ParametredAction>();
            lbAddedEffect.SelectedIndexChanged += LbAddedEffect_SelectedIndexChanged;
        }

        public void LoadThisCard(Card card)
        {
            tbHeader.Text = card.Header;
            tbDiscription.Text = card.Description;
            picCard.BackgroundImage = CardBase.Instance.GetImage(card.ImageRef);

            parametredActions.Clear();
            lbAddedEffect.Items.Clear();
            parametredActions = card.effects.ToDictionary(x => x.Name);
            parametredActions.Keys.ToList().ForEach(x => lbAddedEffect.Items.Add(x));
            PicChanged = false;
            EditedCard = card;
        }
        public Card SaveCard()
        {
            if (EditedCard != null)
            {
                //Если редактируем
                if(PicChanged)
                {
                    //TODO Удаление старой картинки из базы или переформатироване базы
                    EditedCard.ImageRef  = CardBase.Instance.ImageBase.AddImage (picCard.BackgroundImage, tbHeader.Text, tbDiscription.Text).uid;
                }
                EditedCard.Header = tbHeader.Text;
                EditedCard.Description = tbDiscription.Text;
                EditedCard.effects = parametredActions.Values.ToList();
            }
            else
            {
                //Новая карта
                EditedCard = new Card()
                {
                    Header = tbHeader.Text,
                    Description = tbDiscription.Text,
                    effects = parametredActions.Values.ToList(),
                    ImageRef = CardBase.Instance.ImageBase.AddImage(picCard.BackgroundImage, tbHeader.Text, tbDiscription.Text).uid
                };
            }
            return EditedCard;
        }
        private void LbAddedEffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucCM.LoadEffect(parametredActions[(string)lbAddedEffect.SelectedItem]);
        }
        private void AddToList_Click(object sender, EventArgs e)
        {
            ParametredAction pa = ucCM.GetAction();
            if (pa == null ) return;
            if (lbAddedEffect.Items.Contains(pa.Name))
            {
                parametredActions[pa.Name] = pa;
            }
            else
            {
                parametredActions.Add(pa.Name, pa);
                lbAddedEffect.Items.Add(pa.Name);
            }
        }

        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            if(lbAddedEffect.SelectedIndex != -1)
            {
                parametredActions.Remove((string)lbAddedEffect.SelectedItem);
                lbAddedEffect.Items.Remove(lbAddedEffect.SelectedItem);
            }
        }

        private void bNewPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fo = new OpenFileDialog())
            {
                fo.Multiselect = false;
                fo.FileOk += (o,ev) => 
                {
                    picCard.BackgroundImage = Image.FromStream(fo.OpenFile());
                    PicChanged = true;
                };
                fo.ShowDialog(this);
            }
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            EditedCard = SaveCard();
            DialogResult = DialogResult.OK;
        }
    }
}
