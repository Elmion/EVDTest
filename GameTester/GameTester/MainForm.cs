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
            Image i = Image.FromFile(@"E:\Buffer\Heart.png");
            Image d = Image.FromFile(@"E:\Buffer\icons8-Muscle Filled-50.png");
            //BaseCard.Instance.ImageBase.AddImage(i, "Heart", "Nhfkfkf");
            //BaseCard.Instance.ImageBase.AddImage(d, "hand", "asdadasdasd");
            //BaseCard.Instance.ImageBase.SaveLibrary();
            //pbTest.BackgroundImage = BaseCard.Instance.ImageBase.GetImage(Guid.Parse("df57a62e-f1f3-4cda-8310-e340728ac727"));

        }
    }
}
