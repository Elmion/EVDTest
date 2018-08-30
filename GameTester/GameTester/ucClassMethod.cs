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
using System.Collections;

namespace GameTester
{
    public partial class ucClassMethod : UserControl
    {
        List<Control> DopControlsInForm;
        Type typeControl;
        public ucClassMethod()
        {
            InitializeComponent();
            DopControlsInForm = new List<Control>();
        }
        public void Init(Type type)
        {
            typeControl = type;
            List<string>  methodsName = new List<MethodInfo> (type.GetMethods(BindingFlags.Public|BindingFlags.Instance|BindingFlags.DeclaredOnly)).Select(x => x.Name).ToList();
            methodsName.ForEach(x => cbMethods.Items.Add(x));
            cbMethods.SelectedIndexChanged += CbMethods_SelectedIndexChanged;
        }

        private void CbMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            MethodInfo selectedMethod = new List<MethodInfo>(typeControl.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))[cbMethods.SelectedIndex];
            ParameterInfo[] pInfo = selectedMethod.GetParameters();

            DopControlsInForm.ForEach(x => x.Dispose());
            DopControlsInForm.Clear();

            for (int i = 0; i < pInfo.Length; i++)
            {
                Label l = new Label();
                l.Name = "l" + pInfo[i].Name;
                l.Text = pInfo[i].Name;
                l.Parent = gbParameters;
                l.Location = new Point(10 , (i+1) * 30);
               

                TextBox tb = new TextBox();
                tb.Name = "tb"+pInfo[i].Name;
                tb.Parent = gbParameters;
                tb.Location = new Point(10 + pInfo[i].Name.Length * 8, (1 + i) *30 );

                l.SendToBack();

                DopControlsInForm.Add(l);
                DopControlsInForm.Add(tb);
            }
        }
        public ParametredAction GetAction()
        {
            ArrayList ReadyParams = new ArrayList();
            for (int i = 0; i < DopControlsInForm.Count; i++)
            {
                if(DopControlsInForm[i].Name.Contains("tb"))
                {
                    ReadyParams.Add(DopControlsInForm[i].Text);
                }
            }
            return new ParametredAction(typeControl.GetMethod(cbMethods.Text), ReadyParams.ToArray(), typeControl);
        }
    }
}
