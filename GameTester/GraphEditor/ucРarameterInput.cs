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
    public partial class UcРarameterInput : UserControl
    {
        public event Action<object> ConnectorActivated;
        public event Action<object> ConnectorDelete;
        public int delta
        {
            get
            {
                return sc.Panel1.Width;
            }
        }
        public Type TypeIN
        {
            get
            {
                return parameterInfo.ParameterType;
            }
        }
        Control control = null;
        ParameterInfo parameterInfo = null;
        public UcРarameterInput()
        {
            InitializeComponent();
        }
        public UcРarameterInput(ParameterInfo parameterInfo)
        {
            //TODO Высота элеметов
            InitializeComponent();
            this.parameterInfo = parameterInfo;
            lName.Text = parameterInfo.Name +"("+ parameterInfo.ParameterType.ToString().Split('.').Last()+")";
            lName.Location = new Point(0, 4);
            int XNextControl = (int)lName.CreateGraphics().MeasureString(lName.Text, lName.Font).Width;
            control = GetControl(parameterInfo.ParameterType, XNextControl);
            control.Parent = sc.Panel2;
            control.Location = new Point( XNextControl, 1);
            control.BringToFront();
        }
        public object GetValue()
        {
            if (parameterInfo.ParameterType == typeof(string))
            {
                return control.Text;
            }
            if (parameterInfo.ParameterType == typeof(int))
            {
                return int.Parse(control.Text);
            }
            if (parameterInfo.ParameterType.IsEnum)
            {
                return Enum.Parse(parameterInfo.ParameterType, control.Text);
            }
            if (parameterInfo.ParameterType == typeof(bool))
            {
                return ((CheckBox)control).CheckState == CheckState.Checked ? true:false;
            }
            return null;
        }
        private Control GetControl(Type t,int delta)
        {
            Control ctrl = null;
            if (t == typeof(string) || t == typeof(int))
            {
                ctrl = new TextBox();
                ctrl.Size = new Size(60, sc.Panel2.Height);
                this.Size = new Size(delta + 90, sc.Panel2.Height);

            }
            if (t.IsEnum)
            {
                ctrl = new ComboBox();
                int MaxLength  = new List<string>(Enum.GetNames(t)).Max(x => x.Length);
                string MeasuredString = new List<string>(Enum.GetNames(t)).First(x => x.Length == MaxLength);
                new List<string>(Enum.GetNames(t)).ForEach(x => ((ComboBox)ctrl).Items.Add(x));
                int cbLen = (int)Math.Ceiling(ctrl.CreateGraphics().MeasureString(MeasuredString, ctrl.Font).Width);
                ctrl.Size = new Size(cbLen+20, sc.Panel2.Height);
                this.Size = new Size(delta + ctrl.Size.Width+28, sc.Panel2.Height+1);
            }
            if (t == typeof(bool))
            {
                ctrl = new CheckBox();
                ctrl.Size = new Size(20, sc.Panel2.Height);
                this.Size = new Size(delta + 45, sc.Panel2.Height);
            }
            return ctrl;
        }
        private void pbConnectorIn_MouseEnter(object sender, EventArgs e)
        {
            pbConnectorIn.BackColor = Color.LightSalmon;
        }
        private void pbConnectorIn_MouseLeave(object sender, EventArgs e)
        {
            pbConnectorIn.BackColor = Color.DarkRed;
        }
        private void pbConnectorIn_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    ConnectorActivated(this);
                    break;
                case MouseButtons.Right:
                    ConnectorDelete(this);
                    break;
            }

        }
    }
}
