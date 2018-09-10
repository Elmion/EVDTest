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
        public Action<object> InitConnect;

        public ucGraphNode()
        {
           
            InitializeComponent();
            cbMethod.SelectedIndexChanged += CbMethod_SelectedIndexChanged;
            cbMethod.DisplayMember = "Name";
            Rebuild();
        }
        public ucGraphNode(Type t)
        {
            InitializeComponent();
            cbMethod.SelectedIndexChanged += CbMethod_SelectedIndexChanged;
            cbMethod.DisplayMember = "Name";
            FillControl(t);
            CbMethod_SelectedIndexChanged(null, null);
        }
        private void CbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucControls.ForEach(x => x.Dispose());
            ucControls.Clear();
            Rebuild();
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
            int MaxWidth = widths.Count>0? widths.Max() + 20:20;

            SetupMinimalBodySize();

            Body.Size = new Size(MaxWidth <= Body.Size.Width? Body.Size.Width: MaxWidth, 
                                 HEAD + CONNECTOR * (parameters.Count + (method.ReturnType.Name != "Void" ? 1 : 0)));

            int LeftPading = 0;
            int Rightpading = 0;
            if (method.ReturnType.Name != "Void"|| parameters.Find(x => x.IsOut) != null ) //Если есть контроли выходные
            {
                Rightpading = 26;
            }
            if (parameters.Find(x => (!x.IsOut)) != null)
            {
                LeftPading = 25;
            }

            Body.Location = new Point(LeftPading, 0);
            this.Size = new Size(Body.Size.Width + LeftPading + Rightpading , Body.Size.Height);

            position = 0;
            foreach (UserControl ctrl in ucControls)
                {
                    if(ctrl is UcParameterOutput)
                    {
                       ctrl.Location = new Point(Body.Location.X + Body.Size.Width - ((UcParameterOutput)ctrl).delta, DELTA_TOP + position * CONNECTOR);
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
    }
}
