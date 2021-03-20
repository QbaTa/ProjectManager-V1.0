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
    public partial class LoginControl : UserControl,IContentControl
    {
        public LoginControl()
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

        /// <summary>
        /// Method to change property when Text box  click
        /// </summary>
        private void tbUserName_MouseDown(object sender, MouseEventArgs e)
        {
            TextBoxAttachedProperty.ChangePropertyClickTextBox(tbUserName, tbPassword);
        }

        /// <summary>
        /// Method to change property when Text box  click
        /// </summary>
        private void tbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TextBoxAttachedProperty.ChangePropertyClickPasswordBox(tbUserName, tbPassword);
        }

        private void LoginControl_Resize(object sender, EventArgs e)
        {
            label1.Location = new Point((panel1.Width - label1.Width) / 2, label1.Height + 20);
            tbUserName.Location = new Point((panel1.Width - tbUserName.Width) / 2, (panel1.Height - tbUserName.Height) / 2);
            tbPassword.Location = new Point((panel1.Width - tbPassword.Width) / 2, (panel1.Height - tbPassword.Height) / 2 + 50);
            tbPassword.Location = new Point((panel1.Width - tbPassword.Width) / 2, (panel1.Height - tbPassword.Height) / 2 + 50);
            btnNext.Location = new Point((panel1.Width - btnNext.Width) / 2, (panel1.Height - btnNext.Height) / 2 + 120);
            panel1.Location = new Point((this.Width - panel1.Width) / 2, (this.Height - panel1.Height)/2);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ContentManager.Show(PagesList.MainPage);
            Ukryj();
        }
    }
}
