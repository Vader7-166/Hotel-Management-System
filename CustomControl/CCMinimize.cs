using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.CustomControl
{
    public partial class CCMinimize : UserControl
    {
        public CCMinimize()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

        private void CCMinimize_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            parentForm.WindowState = FormWindowState.Minimized;
        }
    }
}
