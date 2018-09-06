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
            MethodInfo selectedMethod = typeControl.GetMethod((String)cbMethods.SelectedItem);
            ParameterInfo[] pInfo = selectedMethod.GetParameters();
            int index = pInfo.ToList().Max(y => GetLableName(y).Length);
            index = pInfo.ToList().FindIndex(x => GetLableName(x).Length == index);

            DopControlsInForm.ForEach(x => x.Dispose());
            DopControlsInForm.Clear();

            for (int i = 0; i < pInfo.Length; i++)
            {
                Label l = new Label();
                l.Name = "l" + pInfo[i].Name;
                l.Text = GetLableName(pInfo[i]);
                l.Parent = gbParameters;
                l.Location = new Point(10, (i + 1) * 30);

                if (pInfo[i].ParameterType.IsEnum)
                {
                    ComboBox cb = new ComboBox();
                    (pInfo[i].ParameterType).GetEnumNames().ToList().ForEach(x => cb.Items.Add(x)) ;
                    cb.Name = "cb" + pInfo[i].Name;
                    cb.Parent = gbParameters;
                    cb.Location = new Point(10 + (int)l.CreateGraphics().MeasureString(GetLableName(pInfo[index]), l.Font).Width, (1 + i) * 30);
                    DopControlsInForm.Add(cb);
                }
                else
                {
                    TextBox tb = new TextBox();
                    tb.Name = "tb" + pInfo[i].Name;
                    tb.Parent = gbParameters;
                    tb.Location = new Point(10 + (int)l.CreateGraphics().MeasureString(GetLableName(pInfo[index]), l.Font).Width, (1 + i) * 30);
                    DopControlsInForm.Add(tb);
                }
                l.SendToBack();
                DopControlsInForm.Add(l);
            }

        }
        private string GetLableName(ParameterInfo p)
        {
            if (p.ParameterType == typeof(string)) return p.Name + "(str)";
            if (p.ParameterType == typeof(int)) return p.Name + "(int)";
            if (p.ParameterType == typeof(bool)) return p.Name + "(flt)";
            if (p.ParameterType == typeof(float)) return p.Name + "(b)";
            return p.Name;
        }
        public ParametredAction GetAction()
        {
            try
            {
                ParameterInfo[] info = typeControl.GetMethod(cbMethods.Text).GetParameters();
                ArrayList ReadyParams = new ArrayList();
                List<Control> temp = DopControlsInForm.Where<Control>(x => x.Name.StartsWith("tb")|| x.Name.StartsWith("cb")).ToList();
                for (int i = 0; i < temp.Count; i++)
                {
                    if (!info[i].ParameterType.IsEnum)
                        ReadyParams.Add(Convert.ChangeType(temp[i].Text, info[i].ParameterType));
                    else
                        ReadyParams.Add(Enum.Parse(info[i].ParameterType, temp[i].Text));
                }
                ParametredAction pa = new ParametredAction(typeControl.GetMethod(cbMethods.Text), ReadyParams.ToArray(), typeControl);
                pa.Name = tbName.Text;
                return pa; 
            }
            catch
            {
                return null;
            }
        }
        public void LoadEffect(ParametredAction pa)
        {
            cbMethods.SelectedIndex = cbMethods.Items.IndexOf(pa.link.Name);
            CbMethods_SelectedIndexChanged(null, null);
            tbName.Text = pa.Name;
            ParameterInfo[] info = pa.link.GetParameters();
            for (int i = 0; i < info.Length; i++)
            {
                MethodInfo ToString = info[i].ParameterType.GetMethod("ToString", new Type[] { });
                Control ctrl;
                if (info[i].ParameterType.IsEnum)
                {
                    ctrl = DopControlsInForm.Find(x => x.Name == "cb" + info[i].Name);
                }
                else
                {
                    ctrl = DopControlsInForm.Find(x => x.Name == "tb" + info[i].Name);
                }
                if (ctrl != null) ctrl.Text = (string)ToString.Invoke(pa.Params[i], null);
            }
        }
    }
}
