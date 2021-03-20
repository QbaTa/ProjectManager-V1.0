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
    public partial class ListProjectControl : UserControl,IContentControl
    {
        public ListProjectControl()
        {
            InitializeComponent();
        }

        public void Pokaz()
        {
            this.Visible = true;
        }

        public void Ukryj()
        {
            this.Visible = false;
        }
    }
}
