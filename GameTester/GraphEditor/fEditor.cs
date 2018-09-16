using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphEditor
{
    public partial class fEditor : Form
    {
        ucCanvas canvas;
        public fEditor()
        {
            InitializeComponent();
            this.Resize += FEditor_Resize;
            ucCanvas1.Resize();
        }

        private void FEditor_Resize(object sender, EventArgs e)
        {
             ucCanvas1.Resize();
        }
    }
}
