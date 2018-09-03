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
    //TODO Выравнивание колонок в форме
    //TODO Контроль заполнения формы

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
            ParameterInfo[] info = typeControl.GetMethod(cbMethods.Text).GetParameters();
            try
            {
                ArrayList ReadyParams = new ArrayList();
                List<Control> temp = DopControlsInForm.Where<Control>(x => x.Name.Contains("tb")).ToList();
                for (int i = 0; i < temp.Count; i++)
                {
                    ReadyParams.Add(Convert.ChangeType(temp[i].Text,info[i].ParameterType));
                }
                return new ParametredAction(typeControl.GetMethod(cbMethods.Text), ReadyParams.ToArray(), typeControl);
            }
            catch
            {
                return null;
            }
        }
        public void LoadEffect(ParametredAction pa)
        {
            cbMethods.SelectedIndex = cbMethods.Items.IndexOf(pa.Name);
            CbMethods_SelectedIndexChanged(null, null);
            ParameterInfo[] info = pa.link.GetParameters();
            for (int i = 0; i < info.Length; i++)
            {
                MethodInfo ToString = info[i].ParameterType.GetMethod("ToString", new Type[] { });
                Control ctrl =  DopControlsInForm.Find(x => x.Name == "tb" + info[i].Name);
                if(ctrl != null) ctrl.Text = (string)ToString.Invoke(pa.Params[i], null);
            }
        }
    }
}
