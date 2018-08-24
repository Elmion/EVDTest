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
        public CardView(Card card)
        {
            InitializeComponent();
            lHeader.Text = card.Header;
            tbCardDescription.Text = card.Description;
        }
    }
}
