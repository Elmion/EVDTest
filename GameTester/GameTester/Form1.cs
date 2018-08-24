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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CardManager.LoadCards("CardDescription.xml");
            bCardActivator.Text = CardManager.Decka[0].Header;
            tbCardDescription.Text = CardManager.Decka[0].Description;
            bCardActivator.Click += BCardActivator_Click;
        }

        private void BCardActivator_Click(object sender, EventArgs e)
        {
            CardManager.Decka[0].Click();
        }
    }
}
