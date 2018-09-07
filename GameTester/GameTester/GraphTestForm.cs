using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphEditor;

namespace GameTester
{
    public partial class GraphTestForm : Form
    {
        ucGraphNode uc;
        Timer t = new Timer();
        Graphics g ;
        int i = 0;
        public GraphTestForm()
        {
            InitializeComponent();
            //uc = new ucGraphNode();
            //uc.Location = new Point(0, 0);
            //uc.Parent = this;
            this.DoubleBuffered = true;
            g = this.CreateGraphics();
            Invalidate();
        }
        


        private void GraphTestForm_Paint(object sender, PaintEventArgs e)
        {
            g.DrawLine(new Pen(Brushes.Black), new Point(20, 20), new Point(100, 100));
            g.DrawBezier(new Pen(Brushes.Aqua), new Point(0, 0), new Point(0, 10), new Point(30, 30), new Point(10, 30));
            
        }
    }
}
