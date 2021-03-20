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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ///<summary>
            /// Add control to controls
            ///</summary>
            Controls.Add((Control)ContentManager.AddNewPage(PagesList.LoginPage));
            Controls.Add((Control)ContentManager.AddNewPage(PagesList.MainPage));
            
            ((Control)ContentManager.GetPage(PagesList.MainPage)).Dock = DockStyle.Fill;
            ((Control)ContentManager.GetPage(PagesList.LoginPage)).Dock = DockStyle.Fill;

            ///<summary>
            /// Show Login Control
            ///</summary>
            ContentManager.Show(PagesList.LoginPage);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
