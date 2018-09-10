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
        ucGraphNode uc2;
        Timer t = new Timer();
        Graphics g ;
        int i = 0;

        Control StartLinkNode;

        public GraphTestForm()
        {
            InitializeComponent();
            uc = new ucGraphNode(typeof(GraphEditor.TestClass));
            uc.Location = new Point(0, 0);
            uc.Parent = this;
            uc.InitConnect += Test;

            uc2 = new ucGraphNode(typeof(GraphEditor.TestClass));
            uc2.Location = new Point(200, 0);
            uc2.Parent = this;
            uc2.InitConnect += Test;

            uc2.FillControl(typeof(GraphEditor.TestClass), "Method1");
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
        public void Test(object obj)
        {
            if(StartLinkNode == null)
            {
                StartLinkNode = (Control)obj;
            }
        }
        private void GraphTestForm_MouseMove(object sender, MouseEventArgs e)
        {
           Invalidate();

        }
        private void GraphTestForm_Paint(object sender, PaintEventArgs e)
        {
            if (StartLinkNode != null)
            {
                Point p = StartLinkNode.FindForm().PointToClient(
                        StartLinkNode.Parent.PointToScreen(
                            new Point(
                                StartLinkNode.Location.X+ StartLinkNode.Width,
                                StartLinkNode.Location.Y + StartLinkNode.Height/2
                                    )));
                Point mousePoint = this.PointToClient(MousePosition);
                e.Graphics.DrawBezier(new Pen(Brushes.Aqua, 3),
                    p,
                    new Point(p.X + 50, p.Y),
                    new Point(mousePoint.X-50, mousePoint.Y),
                    mousePoint);
            }
            e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(20, 20), new Point(100, 100));

        }
        private void GraphTestForm_Load(object sender, EventArgs e)
        {


        }
        private void pb_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
