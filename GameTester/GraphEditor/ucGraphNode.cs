using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace GraphEditor
{
    public partial class ucGraphNode : UserControl
    {
        const int DELTA_TOP = 100;
        const int HEAD = 100;
        const int CONNECTOR = 30;

        private List<Control> ucControls = new List<Control>();
        public event Action<object> InitConnect;
        public event Action<object, Point> Moving;
        public event Action<List<Control>> MethodChanging;
        public event Action<object> Delete;
        private bool Drag = false;
        private Point mouseDelta; //смещение мыши при перемещении
        public ucGraphNode()
        {
           
            InitializeComponent();
            cbMethod.SelectedIndexChanged += CbMethod_SelectedIndexChanged;
            cbMethod.DisplayMember = "Name";
            pMovePanel.MouseDown += DragStart;
            pMovePanel.MouseMove += DragContinue;
            pMovePanel.MouseUp += DragStop;
            Rebuild();
        }
        public ucGraphNode(Type t)
        {
            InitializeComponent();
            cbMethod.SelectedIndexChanged += CbMethod_SelectedIndexChanged;
            cbMethod.DisplayMember = "Name";
            FillControl(t);
            pMovePanel.MouseDown += DragStart;
            pMovePanel.MouseMove += DragContinue;
            pMovePanel.MouseUp += DragStop;
            Rebuild();
        }

        private void DragStart(object sender, MouseEventArgs e)
        {
            Drag = true;
            mouseDelta = PointToClient(MousePosition);
        } 
        private void DragStop(object sender, MouseEventArgs e)
        {
            Drag = false;
        }
        private void DragContinue(object sender, MouseEventArgs e)
        {
            if (Drag)
                Moving(this, mouseDelta);
        }
        private void CbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            MethodChanging(ucControls);
            ucControls.ForEach(x => x.Dispose());
            ucControls.Clear();
            Rebuild();
        }
        private void DeleteLink(object obj)
        {
            MethodChanging(new List<Control>() { (Control)obj });
        }
        private void Rebuild()
        {
            if(cbMethod.SelectedIndex == -1)
            {
                SetupMinimalBodySize();
               this.Size = Body.Size;
            }
            else
            { 
              
            MethodInfo method = (MethodInfo)cbMethod.SelectedItem;
            List<ParameterInfo> parameters = new List<ParameterInfo>(method.GetParameters());
            List<int> widths = new List<int>();
            int position = 0;
            foreach (ParameterInfo p in parameters)
            {
                if (!p.IsOut)
                {
                    UcРarameterInput input = new UcРarameterInput(p);
                    input.ConnectorActivated += InitConnect;
                    input.ConnectorDelete += DeleteLink;
                    widths.Add(input.Size.Width);
                    input.Parent = this;
                    input.BringToFront();
                    ucControls.Add(input);
                }
                else
                {
                   UcParameterOutput output = new UcParameterOutput(p);
                    output.ConnectorActivated += InitConnect;
                    widths.Add(output.Size.Width);
                    output.Parent = this;
                    output.BringToFront();
                    ucControls.Add(output);
                }
                position++;
            }

                if (method.ReturnType.Name != "Void")
            {
                UcParameterOutput output = new UcParameterOutput(method.ReturnParameter);
                output.ConnectorActivated += InitConnect;
 
                output.Location = new Point(Body.Location.X + Body.Size.Width - output.delta, DELTA_TOP + position * CONNECTOR);
                widths.Add(output.Size.Width);
                output.Parent = this;
                output.BringToFront();
                ucControls.Add(output);
            }
               // Добавляем пустые сцеки

                    UcРarameterInput enter = new UcРarameterInput();
                    enter.ConnectorActivated += InitConnect;
                    enter.ConnectorDelete += DeleteLink;
                    widths.Add(enter.Size.Width);
                    enter.Parent = this;
                    enter.BringToFront();
                    ucControls.Add(enter);

                    UcParameterOutput exit = new UcParameterOutput();
                    exit.ConnectorActivated += InitConnect;
                    widths.Add(exit.Size.Width);
                    exit.Parent = this;
                    exit.BringToFront();
                    ucControls.Add(exit);

                //--------------------



                int MaxWidth = widths.Count>0? widths.Max() + 20:20;

            SetupMinimalBodySize();

            Body.Size = new Size(MaxWidth <= Body.Size.Width? Body.Size.Width: MaxWidth, 
                                 HEAD + CONNECTOR * (parameters.Count + (method.ReturnType.Name != "Void" ? 1 : 0)+1));//+1 - место под void контроли

            int LeftPading = 25;
            int Rightpading = 26;
            //if (method.ReturnType.Name != "Void"|| parameters.Find(x => x.IsOut) != null ) //Если есть контроли выходные
            //{
            //    Rightpading = 26;
            //}
            //if (parameters.Find(x => (!x.IsOut)) != null)
            //{
            //    LeftPading = 25;
            //}

            Body.Location = new Point(LeftPading, 0);
            this.Size = new Size(Body.Size.Width + LeftPading + Rightpading , Body.Size.Height);

            position = 0;
            foreach (UserControl ctrl in ucControls)
                {
                    if(ctrl is UcParameterOutput)
                    {
                       if(position == ucControls.Count-1)
                        {
                            //последний OUT контрол поднимаем на сточку вверх
                            ctrl.Location = new Point(Body.Location.X + Body.Size.Width - ((UcParameterOutput)ctrl).delta, DELTA_TOP + (position-1) * CONNECTOR);
                        }
                       else
                        {
                            ctrl.Location = new Point(Body.Location.X + Body.Size.Width - ((UcParameterOutput)ctrl).delta, DELTA_TOP + position * CONNECTOR);
                        }
                    }
                    if(ctrl is UcРarameterInput)
                    {
                        ctrl.Location = new Point(Body.Location.X - ((UcРarameterInput)ctrl).delta, DELTA_TOP + position * CONNECTOR);
                    }
                    position++;
                }
            }
        }
        public void  FillControl(Type t,string method = "")
        {
            List<MethodInfo>  Methods = new List<MethodInfo>(t.GetMethods());
            cbMethod.Items.Clear();
            Methods.ForEach(x => cbMethod.Items.Add(x));
            var buff = Methods.FindIndex(x => x.Name == method);
            if (method != "" && buff != -1)
            {
                cbMethod.SelectedIndex = buff;
                cbMethod.Select();
            }
        }
        private void SetupMinimalBodySize()
        {
            int widthBody = cbMethod.Width + 10; //10 - отсупы слева справа
            SizeF DescriptionSize = lDescription.CreateGraphics().MeasureString(lDescription.Text, lDescription.Font);
            if (DescriptionSize.Width > widthBody)
                widthBody = (int)DescriptionSize.Width;
            Body.Location = new Point(0, 0);
            Body.Size = new Size(widthBody, lDescription.Location.Y + (int)DescriptionSize.Height);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pDelete_Click(object sender, EventArgs e)
        {
            Delete(this);
        }
    }
}
