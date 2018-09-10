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
    public partial class GameForm : Form
    {
        public static Form MainForm { get; private set; }
        public static readonly Random rnd = new Random();
        public List<CardView> View;
        public GameForm()
        {
            InitializeComponent();
            MainForm = this;
            View = new List<CardView>();
            LoadNewScreen();
        }
        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ((CardView)sender).card.Click();
                LoadNewScreen();
                UpdateScreen();
            }          
        }
        public void LoadNewScreen()
        {
            View.ForEach(x => x.Dispose());
            View.Clear();
            Point[] points = new Point[] { new Point(2,0),new Point(130,0), new Point(257,0),
                                           new Point(2,125),new Point(130,125), new Point(257,125),
                                           new Point(2,250),new Point(130,250), new Point(257,250)};
            View.Clear();
            Card[] cards = CardManager.CreateNewRandomCards(GameForm.rnd, 9);
            for (int i = 0; i < cards.Length; i++)
            {
                View.Add(new CardView(cards[i], this));
                View[i].Location = points[i];
                View[i].Parent = pBoard;
                View[i].MouseDown += Card_MouseDown;
            }
        }
        public void UpdateScreen()
        {
            tbAge.Text =  HeroTemp.Instance.time.NewBornAge.ToString();
            tbTime.Text = HeroTemp.Instance.time.CurentTimeToString();
            if (HeroTemp.Instance.Resurces.Find(x => x.Name == Resurces.Health).Value > 100)
                            HeroTemp.Instance.Resurces.Find(x => x.Name == Resurces.Health).Value = 100;
                pbHealth.Value = HeroTemp.Instance.Resurces.Find(x => x.Name == Resurces.Health).Value;
           lMoney.Text = HeroTemp.Instance.Resurces.Find(x => x.Name == Resurces.Money).Value.ToString();
        }
    }
}
