using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class ListProjectItemControl : UserControl
    {
        public ListProjectItemControl(TaskModel _task)
        {
            InitializeComponent();

            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, lblIcon.Width, lblIcon.Height);
            lblIcon.Region = new Region(gp);
            lblIcon.Invalidate();

            lblProjectName.Text = _task.Title;
            lblProjectDesc.Text = _task.Description;
            lblIcon.Text = _task.Icon;
        }

        private void ListProjectItemControl_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Testowy messaagebox");
        }

        private void ListProjectItemControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(103, 106, 108);
        }

        private void ListProjectItemControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(51, 56, 60);
        }
    }
}
