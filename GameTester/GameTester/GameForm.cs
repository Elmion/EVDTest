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

            CardManager.LoadCards("CardDescription.xml");
            LoadNewScreen();

        }
        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ((CardView)sender).card.Click();
            }          
        }
        public void LoadNewScreen()
        {
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
    }
}
