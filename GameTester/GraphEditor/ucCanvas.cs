using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphEditor
{
    public partial class ucCanvas : UserControl
    {
        List<ConnectionLine> Lines;
        List<ucGraphNode> Nodes;
        Control StartLinkNode;


        public ucCanvas()
        {
            InitializeComponent();
            Lines = new List<ConnectionLine>();
            Nodes = new List<ucGraphNode>();

           // Nodes.Add(CreateNode(0, 0));
           // Nodes.Add(CreateNode(200, 0));

            SetStyle(
            System.Windows.Forms.ControlStyles.UserPaint |
            System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
            System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
            true);
            MouseMove += OnMouseMove;
        }

        public ucGraphNode CreateNode(int x,int y,Type t)
        {
            ucGraphNode uc = new ucGraphNode(t);
            uc.Location = new Point(x, y);
            uc.Parent = this;
            uc.InitConnect += NodeInitConnect;
            uc.Moving += NodeMoving;
            uc.MethodChanging += NodeChangeMethod;
            uc.Delete += DeleteNode;
            return uc;
        }

        private void ucCanvas_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            if (item.Tag is Type)
            {
                Point buff = PointToClient(new Point(e.X, e.Y));
                Nodes.Add(CreateNode(buff.X, buff.Y, (Type)item.Tag));
            }
        }

        private void ucCanvas_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void DeleteNode(object obj)
        {
            ucGraphNode o = (ucGraphNode)obj;
            Lines.RemoveAll(x => x.start.Parent == o || x.end.Parent == o); //контрол это узлы куда мы привязываем нам нужен сама вся нода
            Nodes.Remove(o);
            o.Dispose();
        }
        private void NodeInitConnect(object obj)
        {
            if (StartLinkNode == null && obj is UcParameterOutput)
            {
                //ставим флаг для начала откисовки соеденияющей линии
                StartLinkNode = (Control)obj;
            }
            else
            {
                if (obj is UcРarameterInput && StartLinkNode != null) // соеденяем только с входами
                {
                    UcРarameterInput bufIn = (UcРarameterInput)obj;
                    UcParameterOutput bufOut = (UcParameterOutput)StartLinkNode;
                    if ( bufIn.TypeIN == null && bufOut.TypeOUT == null)
                        Lines.Add(new ConnectionLine { start = StartLinkNode, end = (Control)obj, TypeLine = TypesConnection.NextProcess });
                    else if ((bufIn.TypeIN != null && bufOut.TypeOUT != null)&&(bufIn.TypeIN == bufOut.TypeOUT //Это прямые типы
                               || bufOut.TypeOUT.ToString().StartsWith((bufIn.TypeIN.ToString()))) ) //Это сравнение для out типы в конце добавляют &
                           Lines.Add(new ConnectionLine { start = StartLinkNode, end = (Control)obj, TypeLine = TypesConnection.DeliverData});
                }
                //скидываем флаг
                StartLinkNode = null;
            }
        }
        public void NodeChangeMethod(List<Control> controls)
        {
            foreach (Control ctrl in controls)
            {
                DeleteLinks(ctrl);
            }
        }
        public  void DeleteLinks(Control DeleteControl)
        {
            ConnectionLine line = Lines.Find(x => (x.end == DeleteControl)||(x.start == DeleteControl));
            Lines.Remove(line);
        }
        private void NodeMoving(object obj,Point innrerPoint)
        {
            ucGraphNode node = obj as ucGraphNode;
            Point needPosition = node.Parent.PointToClient(MousePosition);
            node.Location = new Point(needPosition.X - innrerPoint.X, needPosition.Y - innrerPoint.Y);
            if (node.Location.X < 0)
                node.Location = new Point(0, node.Location.Y);
            if( node.Location.Y < 0)
                node.Location = new Point(node.Location.X, 0);
            if(node.Bounds.Right + 80 > this.Width)
                 {
                        this.Width = node.Bounds.Right + 80;
                 }
            if (node.Bounds.Bottom + 80 > this.Height)
            {
                this.Height = node.Bounds.Bottom + 80;
            }
            Invalidate();
        }
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            Invalidate();
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            //соеденяющая линия в процессе
            if (StartLinkNode != null)
            {
                //Начальная точка конечная относительно холста
                Point p = new Point(
                               StartLinkNode.Parent.Location.X + StartLinkNode.Location.X + StartLinkNode.Width,
                               StartLinkNode.Parent.Location.Y + StartLinkNode.Location.Y + StartLinkNode.Height / 2
                                    );
                //Конечная точка бизье относительно холста
                Point mousePoint = this.PointToClient(MousePosition);

                e.Graphics.DrawBezier(new Pen(Brushes.Aqua, 3),
                    p,
                    new Point(p.X + 50, p.Y),
                    new Point(mousePoint.X - 50, mousePoint.Y),
                    mousePoint);
            }
            //уже соединеные линии
            foreach (ConnectionLine line in Lines)
            {
                line.Draw(e.Graphics);
            }
        }

        public new  void  Resize()
        {
            if (this.Width <  this.Parent.Width )
            {
                this.Width = this.Parent.Width;
            }
            if (this.Height < this.Parent.Height)
            {
                this.Height = this.Parent.Height;
            }
        }

    }
    public struct ConnectionLine
    {
       public Control start;
       public Control end;
       public TypesConnection TypeLine;
       public void Draw(Graphics g)
       {
            //наши котролы это конечные точки.. поэтому вычиляем координаты для панели
            Point ps = new Point(
                                   start.Parent.Location.X + start.Location.X + start.Width,
                                   start.Parent.Location.Y + start.Location.Y + start.Height / 2
                                );
            Point pe = new Point(
                                   end.Parent.Location.X + end.Location.X,
                                   end.Parent.Location.Y + end.Location.Y + end.Height / 2
                                );
            switch(TypeLine)
            {
                case TypesConnection.DeliverData:
                    {
                        Pen p = new Pen(Color.MediumSeaGreen, 3);
                        p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        g.DrawBezier(p,
                        ps,
                        new Point(ps.X + 80, ps.Y),//80 - выступ линии
                        new Point(pe.X - 80, pe.Y),
                        pe);
                    }
                    break;
                case TypesConnection.NextProcess:
                    {
                        Pen p = new Pen(Color.Black, 3);
                        p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        g.DrawBezier(p,
                        ps,
                        new Point(ps.X + 80, ps.Y),//80 - выступ линии
                        new Point(pe.X - 80, pe.Y),
                        pe);
                    }
                    break;
            }
       }
    }
    public enum TypesConnection
    {
        DeliverData,
        NextProcess
    }
}
