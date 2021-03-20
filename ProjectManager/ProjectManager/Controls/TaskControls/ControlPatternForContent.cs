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
    public partial class ControlPatternForContent : UserControl, IContentControl
    {
        public ControlPatternForContent()
        {
            InitializeComponent();
            Controls.Add((Control)ContentManager.AddNewControl(TaskControlsList.CreateEditTaskControl));
        }

        public void Pokaz()
        {
            this.Visible = true;
        }

        public void Ukryj()
        {
            this.Visible = false;
        }

        private void ControlPatternForContent_Resize(object sender, EventArgs e)
        {
            Control Control = (Control)ContentManager.GetControl(ContentManager.CurrentControl);
            Control.Location = new Point((this.Width - Control.Width) / 2, (this.Height - Control.Height)/2);
        }
    }
}
