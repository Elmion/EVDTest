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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Effect ef = new Effect("ChangeResurce", new List<object>() { "adasd", "11" });
            // Card c = new Card() { access = new Access(), Description = "kzkzczxcz", effects = new List<Effect>() { ef }, Header = "Тест" };
            //b.AddNewCardToBase(c, Image.FromFile(@"E:\Buffer\Heart.png"));
            //b.SaveLibrary();
            //BaseCard.Instance.ImageBase.AddImage(i, "Heart", "Nhfkfkf");
            //BaseCard.Instance.ImageBase.AddImage(d, "hand", "asdadasdasd");
            //BaseCard.Instance.ImageBase.SaveLibrary();
            //pbTest.BackgroundImage = BaseCard.Instance.ImageBase.GetImage(Guid.Parse("df57a62e-f1f3-4cda-8310-e340728ac727"));
        }
        private void bChangeDesk_Click(object sender, EventArgs e)
        {
            using (CardsCatalog cc = new CardsCatalog())
            {
                cc.ShowDialog();
            }
        }
        private void bGameStart_Click(object sender, EventArgs e)
        {
            using (GameForm cc = new GameForm())
            {
                cc.ShowDialog();
            }
        }
        private void bTests_Click(object sender, EventArgs e)
        {
            using (GraphTestForm cc = new GraphTestForm())
            {
                cc.ShowDialog();
            }
        }
    }
}
