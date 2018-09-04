using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTester
{
    public partial class ucListActions<T> : UserControl
    {
        public List<ParametredAction> Actions
        {
            get
            {
                return lbAddedEffect.Items.Cast<ParametredAction>().ToList();
            }
            set
            {
                lbAddedEffect.Items.Clear();
                value.ForEach(x => lbAddedEffect.Items.Add(x));
            }
        }
        public ucListActions()
        {
            InitializeComponent();
            ucCM.Init(typeof(T));
            lbAddedEffect.SelectedIndexChanged += LbAddedEffect_SelectedIndexChanged;
            lbAddedEffect.DisplayMember = "Name";
        }
        private void LbAddedEffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAddedEffect.SelectedIndex != -1)
                ucCM.LoadEffect((ParametredAction)lbAddedEffect.SelectedItem);
        }
        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            if (lbAddedEffect.SelectedIndex != -1)
            {
                lbAddedEffect.Items.Remove(lbAddedEffect.SelectedItem);
            }
        }
        private void AddToList_Click(object sender, EventArgs e)
        {
            ParametredAction pa = ucCM.GetAction();
            if (pa == null) return;
            if (lbAddedEffect.SelectedIndex != -1 && ((ParametredAction)lbAddedEffect.SelectedItem).Name == pa.Name)
            {
                lbAddedEffect.Items[lbAddedEffect.Items.IndexOf(lbAddedEffect.SelectedItem)] = pa;
            }
            else
            {
                lbAddedEffect.Items.Add(pa);
            }
        }
    }
}
