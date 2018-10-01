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
    public partial class UcParameterOutput : UserControl
    {
        public Action<object> ConnectorActivated;
        public int delta
            {
                get
                {
                    return (int)lNameType.CreateGraphics().MeasureString(lNameType.Text, lNameType.Font).Width+5;//5 - пустые места
                }
            }

        public Type TypeOUT
        {
            get
            {
              return parameterInfo == null ? null : parameterInfo.ParameterType;
            }
        }
        private ParameterInfo parameterInfo;
        public UcParameterOutput()
        {
            InitializeComponent();
            this.parameterInfo = null;
            lNameType.Text = "VoidExit";
            lNameType.Location = new Point(0, 5);
            int XNextControl = (int)lNameType.CreateGraphics().MeasureString(lNameType.Text, lNameType.Font).Width;
            this.Width = XNextControl + sc.Panel2.Width + 1;
        }
        public UcParameterOutput(ParameterInfo parameterInfo)
        {

            //TODO Высота элеметов
            InitializeComponent();
            this.parameterInfo = parameterInfo;
            lNameType.Text = parameterInfo.ParameterType.ToString().Split('.').Last();
            lNameType.Location = new Point(0, 5);
            int XNextControl = (int)lNameType.CreateGraphics().MeasureString(lNameType.Text, lNameType.Font).Width;

            this.Width = XNextControl + sc.Panel2.Width+1;
        }
        private void pbOut_MouseEnter(object sender, EventArgs e)
        {
            sc.Panel2.BackColor = Color.Lime;
        }
        private void pbOut_MouseLeave(object sender, EventArgs e)
        {
            sc.Panel2.BackColor = Color.DarkGreen;
        }
        private void sc_Panel2_Click(object sender, MouseEventArgs e)
        {
            ConnectorActivated(this);
        }
    }
}
