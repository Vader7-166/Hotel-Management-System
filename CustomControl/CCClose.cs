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
    [DefaultEvent(nameof(Click))]
    public partial class CCClose : UserControl
    {
        public CCClose()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;  
        }

        private void CCClose_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            parentForm.Close();
        }
    }
}
