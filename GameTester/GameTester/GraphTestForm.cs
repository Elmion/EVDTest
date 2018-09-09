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
            uc = new ucGraphNode();
           uc.Location = new Point(0, 0);
            uc.Parent = this;
            // DoubleBuffered = true;
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            // g = pb.CreateGraphics();
            SetStyle(
            System.Windows.Forms.ControlStyles.UserPaint |
            System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
            System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
            true);

            MouseMove += GraphTestForm_MouseMove;
        }

        private void GraphTestForm_MouseMove(object sender, MouseEventArgs e)
        {
           Invalidate();

        }

        private void GraphTestForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(20, 20), new Point(100, 100));
            e.Graphics.DrawBezier(new Pen(Brushes.Aqua, 3), new Point(20, 20), new Point(20, 0), new Point(100, 0), new Point(MousePosition.X, MousePosition.Y));
        }
        private void GraphTestForm_Load(object sender, EventArgs e)
        {


        }

        private void pb_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
