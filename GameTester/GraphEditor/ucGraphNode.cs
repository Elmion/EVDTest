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

        public ucGraphNode()
        {
           
            InitializeComponent();
            List<MethodInfo>  Methods = new List<MethodInfo>(typeof(TestClass).GetMethods());
            Methods.ForEach(x => cbMethod.Items.Add(x));
            cbMethod.DisplayMember = "Name";
            cbMethod.SelectedIndexChanged += CbMethod_SelectedIndexChanged;
        }

        private void CbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucControls.ForEach(x => x.Dispose());
            ucControls.Clear();
            Rebuild();
        }
        private void Rebuild()
        {
            MethodInfo method = (MethodInfo)cbMethod.SelectedItem;
            List<ParameterInfo> parameters = new List<ParameterInfo>(method.GetParameters());
            List<int> widths = new List<int>();
            List<UserControl> RebuildControls = new List<UserControl>();
            int position = 0;
            foreach (ParameterInfo p in parameters)
            {
                if (!p.IsOut)
                {
                    UcРarameterInput input = new UcРarameterInput(p);
                    widths.Add(input.Size.Width);
                    input.Location = new Point(Body.Location.X - input.delta, DELTA_TOP + position * CONNECTOR);
                    input.Parent = this;
                    input.BringToFront();
                    ucControls.Add(input);
                }
                else
                {
                    UcParameterOutput output = new UcParameterOutput(p);
                    output.Location = new Point(Body.Location.X + Body.Size.Width - output.delta, DELTA_TOP + position * CONNECTOR);
                    widths.Add(output.Size.Width);
                    RebuildControls.Add(output);
                    output.Parent = this;
                    output.BringToFront();
                    ucControls.Add(output);
                }
                position++;
            }
            if (method.ReturnType.Name != "Void")
            {
                UcParameterOutput output = new UcParameterOutput(method.ReturnParameter);
                output.Location = new Point(Body.Location.X + Body.Size.Width - output.delta, DELTA_TOP + position * CONNECTOR);
                widths.Add(output.Size.Width);
                RebuildControls.Add(output);
                output.Parent = this;
                output.BringToFront();
                ucControls.Add(output);
            }
            int MaxWidth = widths.Max() + 20;
            Body.Size = new Size(MaxWidth, HEAD + CONNECTOR * (parameters.Count + (method.ReturnType.Name != "Void" ? 1 : 0)));
            foreach (UserControl ctrl in RebuildControls)
                ctrl.Location = new Point(Body.Location.X + Body.Size.Width - ((UcParameterOutput)ctrl).delta, ctrl.Location.Y);
        }
    }
}
