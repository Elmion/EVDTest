using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace GraphEditor
{
    public partial class fEditor : Form
    {
        
        public fEditor()
        {
            Random rnd = new Random();
            InitializeComponent();
            this.Resize += FEditor_Resize;
            ucCanvas1.Resize();
            //Грузим отмеченные IsEffectClass
            Type[] AssemblyTypes = Assembly.GetEntryAssembly().GetTypes();
            foreach (Type type in AssemblyTypes)
            {
                if(type.IsClass)
                {
                    var attr = type.GetCustomAttribute<IsEffectClassAttribute>();
                    if(attr != null)
                    {
                        ListViewItem lvi = new ListViewItem(type.Name, rnd.Next(3)); //<- пока через рандом.
                        lvi.Tag = type;
                        lComponents.Items.Add(lvi);
                    }
                }
            }
        }
        private void FEditor_Resize(object sender, EventArgs e)
        {
             ucCanvas1.Resize();
        }
        private void lComponents_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item as ListViewItem, DragDropEffects.Move);
        }
    }
}
