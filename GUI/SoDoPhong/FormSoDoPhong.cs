using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System.GUI.SoDoPhong
{
    public partial class FormSoDoPhong : Form
    {
        private FormMain formMain;

        public FormSoDoPhong(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }
    }
}
