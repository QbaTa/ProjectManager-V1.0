using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class SideBarControl : UserControl
    {
        public SideBarControl()
        {
            InitializeComponent();
            Control control = (Control)ContentManager.AddNewControl(TaskControlsList.SideBarList);
            Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContentManager.Show(TaskControlsList.CreateEditTaskControl);
        }
    }
}
