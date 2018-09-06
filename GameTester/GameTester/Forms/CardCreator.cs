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
        bool PicChanged = false; //флаг что картинка была изменена
        public Card EditedCard = null;
        ucListActions<Effect> ucEffects;
        ucListActions<Access> ucAccess;
        public CardCreator()
        {
            InitializeComponent();
            ucEffects = new ucListActions<Effect>();
            ucAccess = new ucListActions<Access>();
            ucEffects.Parent = groopEffect;
            ucAccess.Parent = groupCondition;
            ucEffects.Location = new Point(0, 20);
            ucAccess.Location = new Point(0, 20);
        }

        public void LoadThisCard(Card card)
        {
            tbHeader.Text = card.Header;
            tbDiscription.Text = card.Description;
            picCard.BackgroundImage = CardBase.Instance.GetImage(card.ImageRef);
            ucEffects.Actions = card.effects;
            ucAccess.Actions = card.accesses;
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
                    EditedCard.ImageRef  = CardBase.Instance.ImageBase.AddImage (picCard.BackgroundImage, tbHeader.Text, tbDiscription.Text).uid;
                }
            }
            else
            {
                //Новая карта
                EditedCard = new Card()
                {
                    ImageRef = picCard.BackgroundImage != null ? CardBase.Instance.ImageBase.AddImage(picCard.BackgroundImage, tbHeader.Text, tbDiscription.Text).uid : new Guid()
                };
            }
            EditedCard.Header = tbHeader.Text;
            EditedCard.Description = tbDiscription.Text;
            EditedCard.effects = ucEffects.Actions;
            EditedCard.accesses = ucAccess.Actions;
            return EditedCard;
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
