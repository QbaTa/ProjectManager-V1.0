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
    public partial class CreateAndEditTaskControl : UserControl, IContentControl
    {
        public CreateAndEditTaskControl()
        {
            InitializeComponent();
            Ukryj();
        }

        /// <summary>
        /// Metoda do pokazania kontrolki
        /// </summary>
        public void Pokaz()
        {
            Visible = true;
        }

        /// <summary>
        /// Metoda do Ukrycia kontrolki
        /// </summary>
        public void Ukryj()
        {
            Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TaskControlManager.AddNewControl(TaskManager.AddNewTask(tbName.Text, tbDescription.Text, cbIcon.SelectedItem.ToString()));
        }
    }
}
