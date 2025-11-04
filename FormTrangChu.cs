using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FormTrangChu : Form
    {
        private FormMain formMain;
        public FormTrangChu()
        {
            InitializeComponent();
        }
        public FormTrangChu(FormMain formMain)
        {
            this.formMain = formMain;
            InitializeComponent();
        }
    }
}
